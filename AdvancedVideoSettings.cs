using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;

namespace CGLauncher
{
    class AdvancedVideoSettings
    {
        private double bloom;
        private string INPUTFILE = "e:/autoexec2.cfg";
        public double getBloom() { return bloom; }
        public void setBloom(double bl) { bloom = bl; }

        public void readFile()
        {
            string[] file = System.IO.File.ReadAllLines(INPUTFILE);

            foreach (string line in file)
            {
                if (line.Contains("r_HDRBloomRatio = "))
                {
                    Match m = Regex.Match(line, @"[0-9]+(?:\.[0-9]+)?");
                    bloom = Convert.ToDouble(m.Value);
                }
            }
        }


        public void output()
        {

            string[] lines = System.IO.File.ReadAllLines(INPUTFILE);
            List<string> lineslist = new List<string>(lines);
            
            bool foundinfile = false;
            
            string bloomString  = ("r_HDRBloomRatio = " + bloom);

            for(int i = 0;i < lineslist.Count;i++)
            {
                if (lineslist[i].Contains("r_HDRBloomRatio = "))
                {
                    lineslist[i] = bloomString;
                    foundinfile = true;
                }
            }

            if (!foundinfile)
            {
                lineslist.Add(bloomString);
            }
            System.IO.File.WriteAllLines(INPUTFILE, lineslist.ToArray());

        }
    }
}
