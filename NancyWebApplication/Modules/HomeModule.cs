namespace NancyWebApplication.Modules
{
    using Nancy;
    using System.Configuration;

    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ =>
            {
                dynamic viewBag = new DynamicDictionary();
                viewBag.OurWebLink = ConfigurationManager.AppSettings["OurWebLink"];
                return View["Home", viewBag];
            };
        }
    }
}