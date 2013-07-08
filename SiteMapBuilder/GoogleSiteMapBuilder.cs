using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiteMap.Builder
{
    public class GoogleSiteMapBuilder : ISiteMapBuilder
    {
        private string header;
        private string footer;
        private List<Uri> urls;

        /// <summary>
        /// Builds the header.
        /// </summary>
        public void BuildHeader()
        {
            header = string.Concat("<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n",
                     "<urlset xmlns=\"http://www.sitemaps.org/schemas/sitemap/0.9\">\n");
        }

        /// <summary>
        /// Builds the footer.
        /// </summary>
        public void BuildFooter()
        {
            footer = "</urlset>\n</xml>\n";
        }

        /// <summary>
        /// Builds the page.
        /// </summary>
        /// <param name="url">The URL.</param>
        public void BuildPage(Uri url)
        {
            if (urls == null)
            {
                urls = new List<Uri>();
            }
            urls.Add(url);
        }

        /// <summary>
        /// Gets the site map.
        /// </summary>
        /// <returns></returns>
        public String GetSiteMap()
        {
            StringBuilder body = new StringBuilder();
            foreach (var url in urls)
            {
                body.Append("<url>\n<loc>");
                body.Append(url);
                body.Append("</loc>\n</url>");
            }
            return string.Concat(header, body, footer);
        }
    }
}
