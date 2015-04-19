using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Globalization;


namespace CGLauncher
{
    class VideoSettings
    {
        private string FILE = "e:/autoexec2.cfg";
        private bool fullScreen;
        private bool VSync;
        private bool motionBlur;
        private bool invertMouse;
        private bool SSAO;

        private int resx;
        private int resy;
        private int videoQuality;
        private int shadowQuality;
        

        public bool getFullscreen() { return fullScreen; }
        public void setFullscreen(bool fs) { fullScreen = fs; }
        public bool getVSync() { return VSync; }
        public void setVSync(bool vs) { VSync = vs; }
        public bool getMotionBlur() { return motionBlur; }
        public void setMotionBlur(bool mb) { motionBlur = mb; }
        public bool getInvertMouse() { return invertMouse; }
        public void setInvertMouse(bool im) { invertMouse = im; }
        public bool getSSAO() { return SSAO; }
        public void setSSAO(bool ssao) { SSAO = ssao; }

        public int getResx() { return resx; }
        public void setResx(int rs) { resx = rs; }
        public int getResy() { return resy; }
        public void setResy(int ry) { resy = ry; }
        public int getVideoQuality() { return videoQuality; }
        public void setVideoQuality(int vq) { videoQuality =vq; }
        public int getShadowQuality() { return shadowQuality; }
        public void setShadowQuality(int sq) { shadowQuality = sq; }
        

        private ArrayList shadows;

        public VideoSettings()
        {

            shadows = new ArrayList();
            shadows.Add(256);
            shadows.Add(512);
            shadows.Add(1024);

        }

        public void readFile()
        {
            string[] lines = System.IO.File.ReadAllLines(FILE);

            foreach (string line in lines)
            {
                if (line.Contains("r_fullscreen"))
                {
                    if (line.Contains("1"))
                        fullScreen = true;
                    else
                        fullScreen = false;
                }
                if (line.Contains("r_VSync = "))
                {
                    if (line.Contains("1"))
                        VSync = true;
                    else
                        VSync = false;
                }
                if (line.Contains("r_MotionBlurShutterSpeed = "))
                {
                    if (line.Contains("0.001"))
                        motionBlur = true;
                    else
                        motionBlur = false;
                }
                if (line.Contains("cl_invertmouse = "))
                {
                    if (line.Contains("1"))
                        invertMouse = true;
                    else
                        invertMouse = false;
                }
                if (line.Contains("r_SSAO = "))
                {
                    if (line.Contains("1"))
                        SSAO = true;
                    else
                        SSAO = false;
                }
                if (line.Contains("r_width = "))
                {
                    resx = int.Parse(Regex.Match(line, @"\d+").Value, NumberFormatInfo.InvariantInfo);
                }
                if (line.Contains("r_height = "))
                {
                    resy = int.Parse(Regex.Match(line, @"\d+").Value, NumberFormatInfo.InvariantInfo);
                }
                if (line.Contains("sys_spec = "))
                {
                    videoQuality = int.Parse(Regex.Match(line, @"\d+").Value, NumberFormatInfo.InvariantInfo);
                }
                if (line.Contains("e_ShadowsMaxTexRes = "))
                {
                    shadowQuality = int.Parse(Regex.Match(line, @"\d+").Value, NumberFormatInfo.InvariantInfo);
                }

            }
        }

        public void output()
        {
            string[] lines = System.IO.File.ReadAllLines(FILE);
            List<string> lineslist = new List<string>(lines);

            for (int i = 0; i < lineslist.Count; i++)
            {
                if (lineslist[i].Contains("r_fullscreen"))
                {
                    lineslist[i] =("r_fullscreen = " + (fullScreen ? 1 : 0).ToString());
                }
                if (lineslist[i].Contains("r_VSync = "))
                {
                    lineslist[i] = ("r_VSync = " + (fullScreen ? 1 : 0).ToString());
                }
                if (lineslist[i].Contains("r_MotionBlurShutterSpeed = "))
                {
                    if (motionBlur)
                        lineslist[i] =("r_MotionBlurShutterSpeed = " + 0.001);
                    else
                        lineslist[i] =("r_MotionBlurShutterSpeed = " + 0);
                }

                if (lineslist[i].Contains("cl_invertmouse = "))
                {
                    lineslist[i] =("cl_invertmouse = " + (invertMouse ? 1 : 0).ToString());
                }
                if (lineslist[i].Contains("r_SSAO = "))
                {
                    lineslist[i] =("r_SSAO = " + (SSAO ? 1 : 0).ToString());
                }
                if (lineslist[i].Contains("r_width = "))
                {
                    lineslist[i] = ("r_width = " + resx);
                }
                if (lineslist[i].Contains("r_height = "))
                {
                    lineslist[i] =("r_height = " + resy);
                }
                if (lineslist[i].Contains("sys_spec = "))
                {
                    lineslist[i] =("sys_spec = " + videoQuality);
                }
                if (lineslist[i].Contains("e_ShadowsMaxTexRes = "))
                {
                    lineslist[i] =("e_ShadowsMaxTexRes = " + shadowQuality);
                }

            }

            System.IO.File.WriteAllLines(FILE, lineslist.ToArray());

        }
    }
}
