using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace OhjJatkoDay2Teht2_2
{
     class Program
    {
        static void Main(string[] args)
        {
            //luodaan uusi XmlTextReader instanssi reader ja 
            //lisätään siihen haluttu XML-tiesodto
            string Books = @"C:\Users\Anne\source\repos\OhjJatkoDay2Teht2_2\Books.Xml";
             XmlTextReader reader = new XmlTextReader(Books);

            //luetaan XML-tiedosto läpi while-loopin ja reader-metodin avulla
            while (reader.Read())
            {
                switch (reader.NodeType)
                {   
                    case XmlNodeType.Element:
                        Console.Write("<" + reader.Name);
                        while (reader.MoveToNextAttribute())
                            Console.Write(" " + reader.Name + "='" + reader.Value + "'");
                      
                        Console.WriteLine(">");
                        break;

                    //esitetään joka elementissä teksti
                    case XmlNodeType.Text:
                        Console.WriteLine(reader.Value);
                        break;

                    //ilmoittaa elementin päättymisen
                    case XmlNodeType.EndElement:
                        Console.Write("</" + reader.Name);
                        Console.WriteLine(">");
                        break;
                    
                }
                Console.WriteLine(reader.Name);
            }
            Console.ReadLine();
        }
    }
}
