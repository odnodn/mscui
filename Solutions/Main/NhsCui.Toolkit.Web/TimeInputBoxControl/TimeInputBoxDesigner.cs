//-----------------------------------------------------------------------
// <copyright file="TimeInputBoxDesigner.cs" company="Microsoft Corporation and Crown copyright 2007 - 2010.">
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
// <date>16-Jan-2007</date>
// <summary>Designer for TimeInputBox.</summary>
//-----------------------------------------------------------------------

//Although the control currently support both 24 hour and 12 hour clock the use of 12 hour clock is NOT supported 
//for safety critical environments, and the ISV has a responsibility to use the controls in a manner appropriate to 
//the clinical context.

namespace NhsCui.Toolkit.Web
{
    using System;
    using System.Web.UI.Design.WebControls;
    using System.ComponentModel;
    using NhsCui.Toolkit.DateAndTime;

    /// <summary>
    /// Designer for TimeInputBox. AON: Ask dev.
    /// </summary>
    internal class TimeInputBoxDesigner : CompositeControlDesigner
    {
        /// <summary>
        /// Called when the associated control changes.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="ce">A ComponentChangedEventArgs that contains the event data. </param>
        public override void OnComponentChanged(object sender, System.ComponentModel.Design.ComponentChangedEventArgs ce)
        {
            if (ce == null)
            {
                throw new ArgumentNullException("ce");
            }

            base.OnComponentChanged(sender, ce);

            if (ce.Member.Name == "Value")
            {
                // user has edited Value property make sure the designer knows that
                // this means other properties need serializing
                TimeInputBox control = (TimeInputBox)this.Component;

                this.RaiseComponentChanged("TimeType", control.TimeType);

                switch (control.Value.TimeType)
                {
                    case TimeType.Exact:
                    case TimeType.Approximate:
                        this.RaiseComponentChanged("TimeValue", control.TimeValue);
                        break;                    

                    case TimeType.NullIndex:
                        this.RaiseComponentChanged("NullIndex", control.NullIndex);
                        break;
                }
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
