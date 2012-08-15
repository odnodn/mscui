// <copyright file="LeafPage.Master.cs" company="Microsoft Corporation copyright 2008.">
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
// <date>10-Jan-2008</date>
// <summary>Leaf page master</summary>

namespace Microsoft.Cui.SampleWebsite
{
    using System;
    using System.Collections;
    using System.Web;
    using System.Web.UI;
    using System.Web.UI.WebControls;

    /// <summary>
    /// The master page for leaf pages within the Controls, Samples and Guidance areas
    /// </summary>
    public partial class LeafPage : System.Web.UI.MasterPage
    {
        /// <summary>
        /// Gets the CrossReferencesControl for a Leaf Page
        /// </summary>
        public CrossReferencesControl CrossReferencesTable
        {
            get
            {
                return this.crossReferencesTable;
            }
        }

        /// <summary>
        /// Page Load handler
        /// </summary>
        /// <param name="sender">Sender of the event.</param>
        /// <param name="e">Event Argument.</param>
        protected void Page_Load(object sender, EventArgs e)
        {
            this.RegisterScripts();
        }

        /// <summary>
        /// Init time processing
        /// </summary>
        /// <param name="e">Event Argument.</param>
        protected override void OnInit(EventArgs e)
        {
            this.CrossReferencesTable.SiteMapNodes = CrossReferencesControl.GetSiteMapNodesForCrossReferences(this.SiteMapDS);

            base.OnInit(e);
        }

        /// <summary>
        /// Async postback error handler
        /// </summary>
        /// <param name="sender">Sender of the event.</param>
        /// <param name="e">Event Argument.</param>
        protected void DefaultScriptManager_AsynchronousPostBackError(object sender, AsyncPostBackErrorEventArgs e)
        {
            if (e.Exception.Data["ExtraInfo"] != null)
            {
                this.DefaultScriptManager.AsyncPostBackErrorMessage =
                    e.Exception.Message +
                    e.Exception.Data["ExtraInfo"].ToString();
            }
            else
            {
                this.DefaultScriptManager.AsyncPostBackErrorMessage =
                    "An unspecified error occurred.";
            }
        }

        /// <summary>
        /// To register js scripts with the app.
        /// </summary>
        private void RegisterScripts()
        {
            string filePath = "~/JavaScript/common.js";
            this.Page.ClientScript.RegisterClientScriptInclude(GetType(), GetType().ToString(), Page.ResolveUrl(filePath));
        }
    }
}