using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiteMap.Data
{
    public class WebSite
    {
        public static WebPage[] WebPages = {
            new WebPage("First", @"http://example.com/1", null, null),
            new WebPage("Second", @"http://example.com/2", null, null),
            new WebPage("Third", @"http://example.com/3", null, null),
            new WebPage("Fourth", @"http://example.com/4", null, null),
            new WebPage("Fifth", @"http://example.com/5", null, null),
            new WebPage("Sixth", @"http://example.com/6", null, null),
            new WebPage("Seventh", @"http://example.com/7", null, null) };
    }
}
