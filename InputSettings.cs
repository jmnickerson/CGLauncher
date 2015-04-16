using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace CGLauncher
{
    class InputSettings
    {
        private string FILE = "e:/defaultprofile.xml";
        private System.Collections.Generic.Dictionary<string, string> keybinds;

        public InputSettings()
        {
            keybinds = new Dictionary<string, string>();
            readFile();
        }

        public System.Collections.Generic.Dictionary<string, string> getKeybinds()
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

        public void outputFile()
        {

            XDocument xmlFile = XDocument.Load(FILE);

            var query = from c in xmlFile.Elements("profile").Elements("actionmap").Elements("action")
                        //where(c => (string)c.Attribute("myattribute") == "some value")
                        select c;

            foreach (XElement action in query)
            {
                string temp;
                if(keybinds.TryGetValue(action.Attribute("name").Value,out temp))
                {
                    action.Attribute("keyboard").Value = temp;
                }
                
            }

            xmlFile.Save("e:/test.xml");
        }
    }
}
