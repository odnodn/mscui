//-----------------------------------------------------------------------------------
// <copyright file="MetadataRegistrationBase.cs" company="Microsoft Corporation and Crown copyright 2007 - 2010.">
// (c) 2007 - 2010 Microsoft Corporation. 
// All rights reserved.
//
// CERTAIN PARTS OF THIS WORK CONTAIN SOFTWARE CODE THAT IS LICENSED 
// FOR USE UNDER THE MICROSOFT PUBLIC LICENSE. DISTRIBUTION, IN SOURCE CODE 
// OR OBJECT CODE FORM, OF THOSE PARTS MUST COMPLY WITH THE TERMS OF THE 
// PUBLIC LICENSE. SEE http://www.microsoft.com/opensource/licenses.mspx 
// FOR DETAILS.  
// IF YOU BRING A PATENT CLAIM AGAINST ANY CONTRIBUTOR OVER PATENTS THAT 
// YOU CLAIM ARE INFRINGED BY THE PUBLIC LICENSE SOFTWARE, YOUR PATENT 
// LICENSE FROM SUCH CONTRIBUTOR TO THE SOFTWARE ENDS AUTOMATICALLY.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY 
// KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A
// PARTICULAR PURPOSE.
// </copyright>
// <date>20-Apr-2009</date>
// <summary>Implements a framework for design time metadata registration.</summary>
//-----------------------------------------------------------------------------------

namespace Microsoft.Cui.Controls.Design.Common
{
#if SILVERLIGHT
    extern alias Silverlight;
    using SSW = Silverlight::System.Windows;
#else
    using SSW = System.Windows;
#endif

    using System;
    using System.ComponentModel;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Xml.Linq;
    using Microsoft.Windows.Design.Metadata;

    /// <summary>
    /// MetadataRegistrationBase class, for VS2008 and IRegisterMetadata.
    /// </summary>
    public class MetadataRegistrationBase
    {
        /// <summary>
        /// Gets or sets the case sensitive resource name of the embedded XML file.
        /// </summary>
        protected string XmlResourceName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the FullName of the corresponding run time assembly.
        /// </summary>
        protected string AssemblyFullName
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets a value indicating whether the metadata has been registered.
        /// </summary>
        protected bool Initialized
        {
            get;
            set;
        }

        /// <summary>
        /// Called by tools to register design time metadata.
        /// </summary>
        public virtual void Register()
        {
            if (!this.Initialized)
            {
                MetadataStore.AddAttributeTable(this.BuildAttributeTable());
                this.Initialized = true;
            }
        }

        /// <summary>
        /// Build design time metadata attribute table.
        /// </summary>
        /// <returns>Custom attribute table.</returns>
        protected virtual AttributeTable BuildAttributeTable()
        {
            AttributeTableBuilder builder = new AttributeTableBuilder();

            this.AddDescriptions(builder);
            this.AddAttributes(builder);
            AddTables(builder);

            return builder.CreateTable();
        }

        /// <summary>
        /// Provide a place to add custom attributes without creating an AttributeTableBuilder subclass.
        /// </summary>
        /// <param name="builder">The assembly attribute table builder.</param>
        protected virtual void AddAttributes(AttributeTableBuilder builder)
        {
        }

        /// <summary>
        /// Find all AttributeTableBuilder subclasses in the assembly 
        /// and add their attributes to the assembly attribute table.
        /// </summary>
        /// <param name="builder">The assembly attribute table builder.</param>
        [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "Design time dll should not fail.")]
        private static void AddTables(AttributeTableBuilder builder)
        {
            Debug.Assert(builder != null, "AddTables is called with null parameter!");

            Assembly asm = Assembly.GetExecutingAssembly();
            foreach (Type t in asm.GetTypes())
            {
                if (t.IsSubclassOf(typeof(AttributeTableBuilder)))
                {
                    try
                    {
                        AttributeTableBuilder atb = (AttributeTableBuilder)Activator.CreateInstance(t);
                        builder.AddTable(atb.CreateTable());
                    }
                    catch (Exception e)
                    {
                        Debug.Assert(false, string.Format(CultureInfo.InvariantCulture, "Exception in AddTables method: {0}", e));
                    }
                }
            }
        }

        /// <summary>
        /// Create description attribute from run time assembly xml file.
        /// </summary>
        /// <param name="builder">The assembly attribute table builder.</param>
        [SuppressMessage("Microsoft.Design", "CA1031:DoNotCatchGeneralExceptionTypes", Justification = "Design time dll should not fail.")]
        private void AddDescriptions(AttributeTableBuilder builder)
        {
            Debug.Assert(builder != null, "AddDescriptions is called with null parameter!");

            if (string.IsNullOrEmpty(this.XmlResourceName) ||
                string.IsNullOrEmpty(this.AssemblyFullName))
            {
                return;
            }

            XDocument xdoc = XDocument.Load(new StreamReader(
                Assembly.GetExecutingAssembly().GetManifestResourceStream(this.XmlResourceName)));
            if (xdoc == null)
            {
                return;
            }

            foreach (XElement member in xdoc.Descendants("member"))
            {
                try
                {
                    string name = (string)member.Attribute("name");
                    bool istype = name.StartsWith("T:", StringComparison.OrdinalIgnoreCase);
                    if (istype ||
                        name.StartsWith("P:", StringComparison.OrdinalIgnoreCase))
                    {
                        int lastDot = name.Length;
                        string typeName;
                        if (istype)
                        {
                            typeName = name.Substring(2); // skip leading "T:"
                        }
                        else
                        {
                            lastDot = name.LastIndexOf('.');
                            typeName = name.Substring(2, lastDot - 2);
                        }

                        typeName += this.AssemblyFullName;

                        Type t = Type.GetType(typeName);
                        if (t != null && t.IsPublic && t.IsClass && t.IsSubclassOf(typeof(SSW::FrameworkElement)))
                            {
                            string desc = member.Descendants("summary").FirstOrDefault().Value;
                            desc = desc.Trim();
                            desc = string.Join(" ", desc.Split(new char[] { ' ', '\t', '\n' }, StringSplitOptions.RemoveEmptyEntries));

                            if (istype)
                            {
                                builder.AddCallback(t, b => b.AddCustomAttributes(new DescriptionAttribute(desc)));
                            }
                            else
                            {
                                string propName = name.Substring(lastDot + 1);
                                PropertyInfo pi = t.GetProperty(propName, BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                                if (pi != null)
                                {
                                    builder.AddCallback(t, b => b.AddCustomAttributes(propName, new DescriptionAttribute(desc)));
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Debug.Assert(false, string.Format(CultureInfo.InvariantCulture, "Exception: {0}\n For member : {1}", e, member));
                }
            }
        }
    }
}