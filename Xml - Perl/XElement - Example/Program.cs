using System;
using System.Linq;
using System.Xml.Linq;

namespace XElement_
{
    class Program
    {
        static void Main()
        {
            // ... Download sitemap.
            XElement sitemap = XElement.Load("http://www.dotnetperls.com/sitemap.xml");

            // ... XNames.
            XName url = XName.Get("url", "http://www.sitemaps.org/schemas/sitemap/0.9");
            XName loc = XName.Get("loc", "http://www.sitemaps.org/schemas/sitemap/0.9");

            // ... Loop over url elements.
            // ... Then access each loc element.
            foreach (var urlElement in sitemap.Elements(url))
            {
                var locElement = urlElement.Element(loc);
                Console.WriteLine(locElement.Value);
            }

            // ... Display count.
            Console.WriteLine("Count: {0}", sitemap.Elements(url).Count());
        }
    } 
}

//End of sample XML file: sitemap.xml

//<url>
//<loc>http://www.dotnetperls.com/xor</loc>
//<image:image><image:loc>http://www.dotnetperls.com/xor.png</image:loc></image:image>
//</url>

//<url>
//<loc>http://www.dotnetperls.com/yield</loc>
//<image:image><image:loc>http://www.dotnetperls.com/yield.png</image:loc></image:image>
//</url>

//<url>
//<loc>http://www.dotnetperls.com/zip</loc>
//</url>
//</urlset>

//End of output

//http://www.dotnetperls.com/xor
//http://www.dotnetperls.com/yield
//http://www.dotnetperls.com/zip
//Count: 1247