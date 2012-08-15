//-----------------------------------------------------------------------
// <auto-generated/>
// <copyright file="NhsDateEditor.Designer.cs" company="Microsoft Corporation and Crown copyright 2007 - 2010.">
// Copyright (c) Microsoft Corporation.
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
// <summary>Property Editor for NhsDate type</summary>
//-----------------------------------------------------------------------

namespace NhsCui.Toolkit.DateAndTime
{
    /// <summary></summary>
    public partial class NhsDateEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>value label</summary>
        private System.Windows.Forms.Label valueLabel;

        /// <summary>value textbox</summary>
        private System.Windows.Forms.TextBox valueTextBox;

        /// <summary>approx checkbox</summary>
        private System.Windows.Forms.CheckBox approxCheckbox;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhsDateEditor));
            this.valueLabel = new System.Windows.Forms.Label();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.approxCheckbox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // valueLabel
            // 
            resources.ApplyResources(this.valueLabel, "valueLabel");
            this.valueLabel.Name = "valueLabel";
            // 
            // valueTextBox
            // 
            resources.ApplyResources(this.valueTextBox, "valueTextBox");
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Leave += new System.EventHandler(this.ValueTextBox_Leave);
            // 
            // approxCheckbox
            // 
            resources.ApplyResources(this.approxCheckbox, "approxCheckbox");
            this.approxCheckbox.Name = "approxCheckbox";
            this.approxCheckbox.UseVisualStyleBackColor = true;
            this.approxCheckbox.CheckedChanged += new System.EventHandler(this.ApproxCheckbox_CheckedChanged);
            // 
            // NhsDateEditor
            // 
            this.Controls.Add(this.approxCheckbox);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.valueLabel);
            this.Name = "NhsDateEditor";
            resources.ApplyResources(this, "$this");
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}