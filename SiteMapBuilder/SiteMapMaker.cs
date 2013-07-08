using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SiteMap.Data;
using System.IO;

namespace SiteMap.Builder
{
    public class SiteMapMaker
    {
        private string siteMap;

        #region CTOR
        /// <summary>
        /// Initializes a new instance of the <see cref="SiteMapMaker"/> class.
        /// </summary>
        /// <param name="siteMapBuilder">The site map builder.</param>
        public SiteMapMaker(ISiteMapBuilder siteMapBuilder)
        {
            siteMapBuilder.BuildHeader();
            siteMapBuilder.BuildFooter();
            for (int i = 0; i < WebSite.WebPages.Length; i++)
            {
                siteMapBuilder.BuildPage(new Uri(WebSite.WebPages[i].Url));
            }
            siteMap = siteMapBuilder.GetSiteMap();
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// Saves the site map to disk.
        /// </summary>
        /// <param name="sitemapFilePath">The sitemap file path.</param>
        public void SaveSiteMapToDisk(string sitemapFilePath)
        {
            using (StreamWriter writer = new StreamWriter(sitemapFilePath, false))
            {
                writer.Write(siteMap);
            }
        }

        /// <summary>
        /// Gets the site map.
        /// </summary>
        /// <returns></returns>
        public string GetSiteMap()
        {
            return siteMap;
        }
        #endregion
    }
}
