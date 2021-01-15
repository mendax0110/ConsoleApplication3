using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = "\t";

            XmlWriter writer = XmlWriter.Create(@"E:/filme.xml", settings);
                // Write XML data.
               writer.WriteStartDocument();//Header
                    writer.WriteStartElement("filme"); //<filme>
                        writer.WriteStartElement("film"); //<film>
                            writer.WriteElementString("title", "Guardians of the galaxy 2");  
                            writer.WriteStartElement("preis");
                                writer.WriteAttributeString("währung", "EUR");
                                writer.WriteString("16,9");
                            writer.WriteEndElement();
                        writer.WriteEndElement();//</film>
                                                                               
            writer.WriteStartElement("film"); //<film>
                            writer.WriteElementString("title", "got out");
                            writer.WriteStartElement("preis");
                                 writer.WriteAttributeString("währung", "CHF");
                                 writer.WriteString("8,7");
                        writer.WriteEndElement();//</film>
            writer.WriteEndElement();//</film>
                writer.WriteEndElement();//</filme>
             writer.WriteEndDocument();
                writer.Close();
            

            
        }
    }
}
