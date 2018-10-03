using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml;

namespace MusicTest
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument fretboard = XDocument.Load("C:\\Users\\Ashton\\source\\repos\\MusicTest\\MusicTestGUI\\Images\\Fretboard_Guitar.svg");

            XmlDocument fretboard2 = new XmlDocument();
            fretboard2.Load("C:\\Users\\Ashton\\source\\repos\\MusicTest\\MusicTestGUI\\Images\\Fretboard_Guitar.svg");

            foreach (XmlNode x in fretboard2.LastChild.LastChild)
            {
                Console.WriteLine(x.Attributes["note"].Value + 
                    " " + x.Attributes["style"].Value + " " + 
                    x.Attributes["style"].Value.Length + "\n");


                if (x.Attributes["note"].Value == "\"A#\"")
                {
                    x.Attributes["style"].InnerText = x.Attributes["style"].InnerText + ";opacity:1";
                }

            }

            foreach (XmlNode x in fretboard2.LastChild.LastChild)
            {
                Console.WriteLine("\n\n" + x.Attributes["note"].Value +
                    " " + x.Attributes["style"].Value + " " +
                    x.Attributes["style"].Value.Length + "\n");

            }


        }
    }
}
