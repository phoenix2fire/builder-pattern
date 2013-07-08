using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SiteMap.Builder;
using System.Configuration;

namespace SiteMap
{
    public class SiteMapFactory
    {
        /// <summary>
        /// Gets the sitemap builder.
        /// </summary>
        /// <param name="builderId">The builder id.</param>
        /// <returns></returns>
        public static ISiteMapBuilder GetBuilder()
        {
            ISiteMapBuilder builder;
            string builderName = ConfigurationManager.AppSettings["SiteMapBuilder"];
            switch (builderName)
            {
                case "GoogleSiteMapBuilder":
                    builder = new GoogleSiteMapBuilder();
                    break;
                case "HTMLSiteMapBuilder":
                    builder = new HTMLSiteMapBuilder();
                    break;
                default:
                    builder = new GoogleSiteMapBuilder();
                    break;
            }
            return builder;
        }
    }
}
