using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace XmlDocument___Example
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("http://www.nikse.dk/se/Names_Etc.xml");

            XmlNode selectedNode = doc.SelectSingleNode("/ignore_list");
            //XmlNode singleNode = doc.DocumentElement.SelectSingleNode("/ignore_list");


            foreach (XmlNode node in selectedNode.ChildNodes)
            {
                Console.WriteLine("Name {0}", node.InnerText);
                Console.WriteLine("Change Name = {0}", node.InnerText.ToUpper());
            }

            //foreach (XmlNode node in singleNode.ChildNodes)
            //{
            //    Console.WriteLine("Name {0}", node.InnerText);
            //    Console.WriteLine("Change Name = {0}", node.InnerText.ToUpper());
            //}
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (XmlNode node in doc.DocumentElement.SelectNodes("name"))
            {
                Console.WriteLine("Name {0}", node.InnerText);
                Console.WriteLine("Change Name = {0}", node.InnerText.ToUpper());
            }

            Console.ReadLine();
        }
    }
}
