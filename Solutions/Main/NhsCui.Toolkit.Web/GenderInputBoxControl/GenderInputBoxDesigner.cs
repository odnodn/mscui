//-----------------------------------------------------------------------
// <copyright file="GenderInputBoxDesigner.cs" company="Microsoft Corporation and Crown copyright 2007 - 2010.">
// Copyright (c) Microsoft Corporation and Crown copyright 2007 - 2010.
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
// <date>04-Sep-2007</date>
// <summary>GenderInputBox Designer class</summary>
//-----------------------------------------------------------------------

namespace NhsCui.Toolkit.Web
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using AjaxControlToolkit.Design;
    using System.ComponentModel;

    /// <summary>
    /// Designer for GenderInputBox control
    /// </summary>
    internal class GenderInputBoxDesigner : ExtenderControlBaseDesigner<GenderInputBoxExtender>
    {
        /// <summary>
        /// Called when the associated control changes.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="ce">A ComponentChangedEventArgs that contains the event data.</param>
        public override void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs ce)
        {
            base.OnComponentChanged(sender, ce);

            if (ce.Member.Name == "Value")
            {
                GenderInputBoxExtender control = (GenderInputBoxExtender)this.Component;
                this.RaiseComponentChanged("Value", control.Value);
            }
        }

        /// <summary>
        /// Raise property changed event
        /// </summary>
        /// <param name="propertyName">property name</param>
        /// <param name="value">property value</param>
        private void RaiseComponentChanged(string propertyName, object value)
        {
            PropertyDescriptor property = TypeDescriptor.GetProperties(this.Component)[propertyName];
            if (property != null)
            {
                this.RaiseComponentChanged(property, null, value);
            }
        }
    }
}
