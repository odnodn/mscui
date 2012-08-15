// <copyright file="RestyledPatientBanner.aspx.cs" company="Microsoft Corporation and Crown copyright 2007 - 2010.">
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
// <date>10-Jan-2008</date>
// <summary>Patientbanner styling sample page</summary>

using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

/// <summary>
/// Re-styled patient Banner
/// </summary>
public partial class SamplesPatientBannerRestyledPatientBanner : System.Web.UI.Page
{
    /// <summary>
    /// Default Page Load
    /// </summary>
    /// <param name="sender">Sender of the event.</param>
    /// <param name="e">Event Argument.</param>
    protected void Page_Load(object sender, EventArgs e)
    {
        // set the radio button change event handler
        this.monoChrome.CheckedChanged += new EventHandler(this.ToggleCssRadioCheckedChanged);
        this.blueBar.CheckedChanged += new EventHandler(this.ToggleCssRadioCheckedChanged);
        this.pureAndSimple.CheckedChanged += new EventHandler(this.ToggleCssRadioCheckedChanged);
        this.steel.CheckedChanged += new EventHandler(this.ToggleCssRadioCheckedChanged);
        this.blueReverse.CheckedChanged += new EventHandler(this.ToggleCssRadioCheckedChanged);
        this.blueDoubleBar.CheckedChanged += new EventHandler(this.ToggleCssRadioCheckedChanged);
        this.SetStyles();
    }

    /// <summary>
    /// Called on Radio button changes
    /// </summary>
    /// <param name="sender">Sender of the event.</param>
    /// <param name="e">Event Argument.</param>
    protected void ToggleCssRadioCheckedChanged(object sender, EventArgs e)
    {
        this.SetStyles();
    }

    /// <summary>
    /// Event handler for View all addresses link
    /// </summary>
    /// <param name="sender">Sender of the event.</param>
    /// <param name="e">event args</param>
    protected void PatientBanner_ViewAllAddressesClick(object sender, NhsCui.Toolkit.PatientBannerEventArgs e)
    {
        ScriptManager.RegisterClientScriptBlock(this, GetType(), "ViewAllAddressesClick", "this.msg='View all addresses clicked';", true);
    }

    /// <summary>
    /// Event handler for View all contact details link
    /// </summary>
    /// <param name="sender">Sender of the event.</param>
    /// <param name="e">event args</param>    
    protected void PatientBanner_ViewAllContactDetailsClick(object sender, NhsCui.Toolkit.PatientBannerEventArgs e)
    {
        ScriptManager.RegisterClientScriptBlock(this, GetType(), "ViewAllContactDetailsClick", "this.msg='View all contact details clicked';", true);
    }

    /// <summary>
    /// Event handler for Gender value click
    /// </summary>
    /// <param name="sender">Sender of the event.</param>
    /// <param name="e">event args</param>  
    protected void PatientBanner_GenderValueClick(object sender, NhsCui.Toolkit.PatientBannerEventArgs e)
    {
        ScriptManager.RegisterClientScriptBlock(this, GetType(), "GenderValueClick", "this.msg='Gender value clicked';", true);
    }

    /// <summary>
    /// Event handler for Identifier click
    /// </summary>
    /// <param name="sender">Sender of the event.</param>
    /// <param name="e">event args</param>    
    protected void PatientBanner_IdentifierClick(object sender, NhsCui.Toolkit.PatientBannerEventArgs e)
    {
        ScriptManager.RegisterClientScriptBlock(this, GetType(), "IdentifierClick", "this.msg='Nhs number clicked';", true);
    }

    /// <summary>
    /// Set styles based on the selection
    /// </summary>
    private void SetStyles()
    {
        // monoChrome is selected
        if (this.monoChrome.Checked)
        {
            this.patientBanner.ZoneOneStyle = "monoChrome_Zone1";
            this.patientBanner.ZoneTwoTitleStyle = "monoChrome_zone2_title";
            this.patientBanner.ZoneTwoDataStyle = "monoChrome_zone2_data";
            this.patientBanner.ZoneTwoHoverStyle = "monoChrome_zone2_title_hover";
        }

        // double bar is selected
        if (this.blueDoubleBar.Checked)
        {
            this.patientBanner.ZoneOneStyle = "blueDoubleBar_Zone1";
            this.patientBanner.ZoneTwoTitleStyle = "blueDoubleBar_zone2_title";
            this.patientBanner.ZoneTwoDataStyle = "blueDoubleBar_zone2_data";
            this.patientBanner.ZoneTwoHoverStyle = "blueDoubleBar_zone2_title_hover";
        }

        // blue reverse is selected
        if (this.blueReverse.Checked)
        {
            this.patientBanner.ZoneOneStyle = "blueReverse_Zone1";
            this.patientBanner.ZoneTwoTitleStyle = "blueReverse_zone2_title";
            this.patientBanner.ZoneTwoDataStyle = "blueReverse_zone2_data";
            this.patientBanner.ZoneTwoHoverStyle = "blueReverse_zone2_title_hover";
        }

        // Steel is selected
        if (this.steel.Checked)
        {
            this.patientBanner.ZoneOneStyle = "steel_Zone1";
            this.patientBanner.ZoneTwoTitleStyle = "steel_zone2_title";
            this.patientBanner.ZoneTwoDataStyle = "steel_zone2_data";
            this.patientBanner.ZoneTwoHoverStyle = "steel_zone2_title_hover";
        }

        // Pure & Simple is selected
        if (this.pureAndSimple.Checked)
        {
            this.patientBanner.ZoneOneStyle = "pureSimple_Zone1";
            this.patientBanner.ZoneTwoTitleStyle = "pureSimple_zone2_title";
            this.patientBanner.ZoneTwoDataStyle = "pureSimple_zone2_data";
        }

        // Blue Bar is selected
        if (this.blueBar.Checked)
        {
            this.patientBanner.ZoneOneStyle = "blueBar_Zone1";
            this.patientBanner.ZoneTwoTitleStyle = "blueBar_zone2_title";
            this.patientBanner.ZoneTwoDataStyle = "blueBar_zone2_data";
            this.patientBanner.ZoneTwoHoverStyle = "blueBar_zone2_title_hover";
        }
    }
}
