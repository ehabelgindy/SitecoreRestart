using System;
using System.Web;
using Sitecore;
using Sitecore.Diagnostics;
using Sitecore.Install;
using Sitecore.Jobs.AsyncUI;
using Sitecore.Shell.Framework;
using Sitecore.Web.UI.HtmlControls;
using Sitecore.Web.UI.Sheer;
using Sitecore.Web.UI.XamlSharp.Xaml;
using Sitecore.Web.UI.Pages;

namespace SitecoreClientAddons.Restart
{
    public class RestartControl : DialogForm
    {
        protected Checkbox Restart;
        protected Checkbox RestartServer;
        //protected 

        protected override void OnLoad(EventArgs e)
        {

            base.OnLoad(e);
            if (!Context.ClientPage.IsEvent)
            {
                this.Restart.Checked = true;
                this.RestartServer.Checked = false;
            }
        }



        protected override void OnOK(object sender, EventArgs args)
        {
            DoRestart();
        }

        protected override void OnCancel(object sender, EventArgs args)
        {
            Windows.Close();
        }

        protected void DoRestart()
        {

            if (this.RestartServer.Checked)
                Installer.RestartServer();
            if (this.Restart.Checked)
                Context.ClientPage.ClientResponse.Broadcast(Context.ClientPage.ClientResponse.SetLocation(string.Empty), "Shell");
            
            Windows.Close();
        }
    }
}
