using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CryLaunch
{
    class VideoSettings
    {
 
        private string fullScreen;
        private string VSync;
        private string motionBlur;
        private string invertMouse;
        private string SSAO;
        private string resolution;
        private string videoQuality;
        private string shadowQuality;
        private string bloom;

        //public string fullScreen { get; set; }


        public VideoSettings()
        {
            string[] lines = System.IO.File.ReadAllLines(@"/autoexec.cfg");

        }

        
    }
}
