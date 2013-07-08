using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiteMap.Data
{
    public class WebPage
    {
        #region CTOR
        /// <summary>
        /// Initializes a new instance of the <see cref="WebPage"/> class.
        /// </summary>
        /// <param name="title">The title.</param>
        /// <param name="url">The URL.</param>
        /// <param name="parent">The parent.</param>
        /// <param name="children">The children.</param>
        public WebPage(String title, String url, WebPage parent,
                List<WebPage> children)
        {
            this.Title = title;
            this.Url = url;
            this.Parent = parent;
            this.Children = children;
        }
        #endregion

        #region Public Members
        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public String Title { get; set; }
        /// <summary>
        /// Gets or sets the URL.
        /// </summary>
        /// <value>
        /// The URL.
        /// </value>
        public String Url { get; set; }
        /// <summary>
        /// Gets or sets the parent.
        /// </summary>
        /// <value>
        /// The parent.
        /// </value>
        public WebPage Parent { get; set; }
        /// <summary>
        /// Gets or sets the children.
        /// </summary>
        /// <value>
        /// The children.
        /// </value>
        public List<WebPage> Children { get; set; }
        #endregion

    }
}
