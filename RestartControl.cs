using System;
using System.Web;
using Sitecore.Diagnostics;
using Sitecore.Web.UI.HtmlControls;
using Sitecore.Web.UI.XamlSharp.Xaml;

namespace SitecoreClientAddons.Restart
{
    public class RestartControl : XamlMainControl
    {
        protected Literal ltlOut;

        protected override void OnLoad(EventArgs e)
        {
            Assert.ArgumentNotNull((object)e, "e");
            base.OnLoad(e);

            ltlOut.Text = string.Format("Querystring: {0}", HttpContext.Current.Request.Url.Query);
        }
    }
}
