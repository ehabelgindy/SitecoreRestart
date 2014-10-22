using Sitecore;
using Sitecore.Diagnostics;
using Sitecore.Globalization;
using Sitecore.Shell.Applications.Dialogs.ProgressBoxes;
using Sitecore.Shell.Framework.Commands;

namespace SitecoreClientAddons.Restart
{
    public class RestartSitecoreCommand : Command
    {

        public override void Execute(CommandContext context)
        {
            Context.ClientPage.ClientResponse.ShowModalDialog(UIUtil.GetUri("control:RestartControl"), "400px", "150px");
        }
    }
}