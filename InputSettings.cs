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
        private string FILE = "e:/test.xml";
        private System.Collections.Generic.Dictionary<string, string> keybinds = new Dictionary<string, string>();
        private System.Collections.Generic.Dictionary<string, string> controllerbinds = new Dictionary<string, string>();
        public InputSettings()
        {
            readFile();
        }

        public System.Collections.Generic.Dictionary<string, string> getKeybinds()
        {
            return keybinds;
        }
        public System.Collections.Generic.Dictionary<string, string> getControllerbinds()
        {
            return controllerbinds;
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
                    if (xmlNode.Attributes["xboxpad"].Value != null)
                    {
                        string button = xmlNode.Attributes["xboxpad"].Value;
                        //if (button != null)
                        Console.WriteLine("in: " + button);
                            controllerbinds.Add(name, button);
                    }
                    
                }
                catch (Exception e)
                {
                    //Console.WriteLine(e.Message);
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
                    if (temp.Contains("xi"))
                    {
                         action.Attribute("xboxpad").Value = temp;
                    }
                    else
                        action.Attribute("keyboard").Value = temp;
                }
                if (controllerbinds.TryGetValue(action.Attribute("name").Value, out temp))
                {
                    Console.WriteLine("out: " + temp);
                    if (temp.Contains("xi"))
                    {
                        if (action.Attribute("xboxpad") == null)
                        {
                            XAttribute xboxattr = new XAttribute("xboxpad", temp);
                            action.Add(xboxattr);
                        }
                        else
                            action.Attribute("xboxpad").Value = temp;
                    }
                }
                
            }

            xmlFile.Save("e:/test.xml");
        }
    }
}
