using Kentico.Activities.Web.Mvc;
using Kentico.CampaignLogging.Web.Mvc;
using Kentico.Content.Web.Mvc;
using Kentico.Content.Web.Mvc.Routing;
using Kentico.Newsletters.Web.Mvc;
using Kentico.OnlineMarketing.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.Web.Mvc;

namespace Kentico
{
    public class ApplicationConfig
    {
        public static void RegisterFeatures(IApplicationBuilder builder)
        {
            builder.UsePreview();
            builder.UsePageBuilder(new PageBuilderOptions
            {

                DefaultSectionIdentifier = "Section.General",
                RegisterDefaultSection = false
            });
            builder.UseDataAnnotationsLocalization();
            builder.UseCampaignLogger();
            builder.UseActivityTracking();
            builder.UseABTesting();
            builder.UseEmailTracking(new EmailTrackingOptions());
            builder.UsePageRouting(new PageRoutingOptions
            {
                EnableAlternativeUrls = true
            });
        }
    }
}