using EvidencijaNezaposlenih.Servisi.Interfejsi;
using EvidencijaNezaposlenih.Servisi.Servisi;
using System;
using System.ComponentModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Web;
using System.Web.Optimization;
using System.Web.Routing;
using Unity;

namespace EvidencijaNezaposlenih.Interfejs
{
    public class Global : HttpApplication
    {
        void Application_Start(object sender, EventArgs e)
        {
            // Create Unity container builder
            var containerBuilder = new UnityContainerBuilders();


            // Register dependencies
            var container = containerBuilder.RegisterDependencies().Build();

            // Store the container in a static property or application state
            Application["NezaposleniDbContext"] = container;

            // Other application startup configurations
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}