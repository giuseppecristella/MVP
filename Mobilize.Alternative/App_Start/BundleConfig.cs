using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Mobilize.Alternative.App_Start
{
  public class BundleConfig
  {

    public static void RegisterBundles(BundleCollection bundles)
    {

      bundles.Add(new ScriptBundle("~/bundles/jqm").Include(
        "~/Scripts/jquery-1.6.4.js",
        "~/Scripts/jquery.mobile-1.3.2.js",
        "~/Scripts/mobilesite.js"
        ));


    }
  
  }
}