using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiteMap.Builder
{
    public interface ISiteMapBuilder
    {
        /// <summary>
        /// Builds the header.
        /// </summary>
        void BuildHeader();

        /// <summary>
        /// Builds the footer.
        /// </summary>
        void BuildFooter();

        /// <summary>
        /// Builds the page.
        /// </summary>
        /// <param name="url">The URL.</param>
        void BuildPage(Uri url);

        /// <summary>
        /// Gets the site map.
        /// </summary>
        /// <returns></returns>
        String GetSiteMap();
    }
}
