//-----------------------------------------------------------------------
// <copyright file="ContactLabelPage.xaml.cs" company="Microsoft Corporation and Crown copyright 2007 - 2010.">
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
// <date>19-May-2008</date>
// <summary>Sample page to host contact label control. </summary>
//-----------------------------------------------------------------------

namespace Microsoft.Cui.SamplePages
{
    #region Using
    using System;
    using System.Windows;
    using System.Windows.Controls;
    #endregion

    /// <summary>
    /// Sample page to host contact label control.
    /// </summary>
    public partial class ContactLabelPage : UserControl
    {
        /// <summary>
        /// Member variable to hold AllowResize.
        /// </summary>
        private bool allowResize = true;

        /// <summary>
        /// Initializes a new instance of contact label page.
        /// </summary>
        public ContactLabelPage()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(this.ContactLabelPage_Loaded);
        }

        /// <summary>
        /// Gets or sets a value indicating whether resizers can be shown on the page.
        /// </summary>
        /// <value>Boolean indicating whether resizers can be shown.</value>
        public bool AllowResize
        {
            get
            {
                return this.allowResize;
            }

            set
            {
                this.allowResize = value;
                this.ShowOrHideResizers();
            }
        }

        /// <summary>
        /// Shows or Hides the resizers based on AllowResize Property.
        /// </summary>
        private void ShowOrHideResizers()
        {
            if (this.TopResizer != null && this.BottomResizer != null && this.LeftResizer != null && this.RightResizer != null)
            {
                if (this.allowResize)
                {
                    this.TopResizer.Visibility = Visibility.Visible;
                    this.BottomResizer.Visibility = Visibility.Visible;
                    this.LeftResizer.Visibility = Visibility.Visible;
                    this.RightResizer.Visibility = Visibility.Visible;
                }
                else
                {
                    this.TopResizer.Visibility = Visibility.Collapsed;
                    this.BottomResizer.Visibility = Visibility.Collapsed;
                    this.LeftResizer.Visibility = Visibility.Collapsed;
                    this.RightResizer.Visibility = Visibility.Collapsed;
                }
            }
        }

        /// <summary>
        /// Handles the loaded event of the page.
        /// </summary>
        /// <param name="sender">Sender of the event.</param>
        /// <param name="e">Event args.</param>
        private void ContactLabelPage_Loaded(object sender, RoutedEventArgs e)
        {
            this.ShowOrHideResizers(); 
        }        
    }
}
