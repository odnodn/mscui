//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1434
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NhsCui.Toolkit.WinForms.GenderLabelControl {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("NhsCui.Toolkit.WinForms.GenderLabelControl.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Control used to show the gender.
        /// </summary>
        internal static string AccessibleDescription {
            get {
                return ResourceManager.GetString("AccessibleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nhs gender label.
        /// </summary>
        internal static string AccessibleName {
            get {
                return ResourceManager.GetString("AccessibleName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Female.
        /// </summary>
        internal static string Female {
            get {
                return ResourceManager.GetString("Female", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Male.
        /// </summary>
        internal static string Male {
            get {
                return ResourceManager.GetString("Male", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not Known.
        /// </summary>
        internal static string NotKnown {
            get {
                return ResourceManager.GetString("NotKnown", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not Specified.
        /// </summary>
        internal static string NotSpecified {
            get {
                return ResourceManager.GetString("NotSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Value must be one of: Male, Female, NotSpecified or NotKnown..
        /// </summary>
        internal static string PatientGenderArgumentOutOfRangeException {
            get {
                return ResourceManager.GetString("PatientGenderArgumentOutOfRangeException", resourceCulture);
            }
        }
    }
}
