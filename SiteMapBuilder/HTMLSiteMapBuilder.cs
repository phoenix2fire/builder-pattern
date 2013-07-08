using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiteMap.Builder
{
    public class HTMLSiteMapBuilder: ISiteMapBuilder
    {
        private string header;
        private string footer;
        private List<Uri> urls;

        /// <summary>
        /// Builds the header.
        /// </summary>
        public void BuildHeader()
        {
            header = "<ul class=\"sitemap\">\n";
        }

        /// <summary>
        /// Builds the footer.
        /// </summary>
        public void BuildFooter()
        {
            footer = "</ul>\n";
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
