using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SiteMap.Builder;
using System.IO;
using System.Diagnostics;

namespace SiteMap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Program generates SiteMap from the Data using Builder Pattern...");
            Console.Write("Please provide the filename to save the sitemap... ");
            string sitemapFilePath = Console.ReadLine();
            string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, sitemapFilePath);
            SaveSiteMapToDisk(fullPath);

            Process.Start(fullPath);
        }

        /// <summary>
        /// Saves the site map to disk.
        /// </summary>
        /// <param name="sitemapFilePath">The sitemap file path.</param>
        private static void SaveSiteMapToDisk(string sitemapFilePath)
        {
            SiteMapMaker sitemapMaker = new SiteMapMaker(SiteMapFactory.GetBuilder());
            sitemapMaker.SaveSiteMapToDisk(sitemapFilePath);
        }
    }
}
