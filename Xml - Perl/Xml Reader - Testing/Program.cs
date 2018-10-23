using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Xml_Reader___Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Ivandrofly-LK\Documents\Visual Studio 2012\Projects\C# - Tutorials\C# - DotNetPerls Examples\Xml - Perl\FamilyNames.xml";

            //Note: this is a abstract class we can't create the instance of it
            XmlReader xmlFile = XmlReader.Create(path);

            while (xmlFile.Read())
            {
                if (xmlFile.HasAttributes)
                {
                    Console.WriteLine("Name = " + xmlFile[0]);

                    if (xmlFile.HasValue)
                    {
                        Console.WriteLine("Value = {0}", xmlFile.Value);
                    }
                    else
                    {
                        Console.WriteLine("There is no value for {0}", xmlFile[xmlFile.AttributeCount - 1]);
                    }
                }
            };

            Console.ReadLine();
        }
    }
}
/*
<?xml version="1.0" encoding="utf-8" ?>
<perls>
  <article name="backgroundworker">
    Example text.
  </article>
  <article name="threadpool">
    More text.
  </article>
  <article></article>
  <article>Final text.</article>
</perls>
*/