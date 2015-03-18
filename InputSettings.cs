using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
namespace CGLauncher
{
    class InputSettings
    {
        private string FILE = "c:/defaultProfile.xml";
        private System.Collections.Generic.SortedDictionary<string, string> keybinds;
        public InputSettings()
        {
            keybinds = new SortedDictionary<string, string>();
            readFile();
        }

        public System.Collections.Generic.SortedDictionary<string, string> getKeybinds()
        {
            return keybinds;
        }

        private void readFile()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(FILE);
            XmlElement root = xmlDoc.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("//actionmap/action");

            foreach (XmlNode xmlNode in nodes)
            {
                try
                {
                    string name = xmlNode.Attributes["name"].Value;
                    string key = xmlNode.Attributes["keyboard"].Value;
                    //Console.WriteLine("Name: " + name + " Keyboard: " + key);
                    keybinds.Add(name, key);
                }
                catch (Exception e)
                {

                }
            }
        }
    }
}
