// <copyright file="Testimonials.aspx.cs" company="Microsoft Corporation copyright 2008.">
// (c) 2008 Microsoft Corporation. All rights reserved.
// This source is subject to the Microsoft Public License.
// See http://www.microsoft.com/opensource/licenses.mspx.
//
// This document and/or software (�this Content�) has been created in partnership
// with the National Health Service (NHS) in England.  Intellectual Property Rights
// to this Content are jointly owned by Microsoft and the NHS in England, although 
// both Microsoft and the NHS are entitled to independently exercise their rights
// of ownership.  Microsoft acknowledges the contribution of the NHS in England
// through their Common User Interface programme to this Content.  Readers are 
// referred to www.cui.nhs.uk for further information on the NHS CUI Programme.
// </copyright>
// <date>16-Mar-2008</date>
// <summary>Testimonials page</summary>

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
using System.Text;

/// <summary>
/// Design Guide
/// </summary>
public partial class ShowcaseTestimonials : System.Web.UI.Page
{   
     /// <summary>
    /// Gets the initparams value for silverlight plugin
    /// </summary>
    protected static string InitParameters
    {
        get
        {
            AppSettingsReader appsReader = new AppSettingsReader();

            StringBuilder initParams = new StringBuilder();
            initParams.Append("HostPageName=Testimonials");
            initParams.Append(",testimonials01=");
            initParams.Append(appsReader.GetValue("testimonials01", typeof(string)));
            initParams.Append(",testimonials02=");
            initParams.Append(appsReader.GetValue("testimonials02", typeof(string)));
            initParams.Append(",testimonials03=");
            initParams.Append(appsReader.GetValue("testimonials03", typeof(string)));
            initParams.Append(",testimonials04=");
            initParams.Append(appsReader.GetValue("testimonials04", typeof(string)));
            initParams.Append(",testimonials05=");
            initParams.Append(appsReader.GetValue("testimonials05", typeof(string)));
            initParams.Append(",testimonials06=");
            initParams.Append(appsReader.GetValue("testimonials06", typeof(string)));
            return initParams.ToString();
        }
    }

    /// <summary>
    /// Default Page Load Method
    /// </summary>
    /// <param name="sender">Sender of the event.</param>
    /// <param name="e">Event Argument.</param>
    protected void Page_Load(object sender, EventArgs e)
    {       
    }
}
