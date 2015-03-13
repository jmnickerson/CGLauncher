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
        private string FILE = "../autoexec2.cfg";
        private bool fullScreen;
        private bool VSync;
        private bool motionBlur;
        private bool invertMouse;
        private bool SSAO;

        private int resx;
        private int resy;
        private int videoQuality;
        private int shadowQuality;
        private double bloom;

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
        public double getBloom() { return bloom; }
        public void setBloom(double bl) { bloom = bl; }

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
                if (line.Contains("r_HDRBloomRatio = "))
                {
                    Match m = Regex.Match(line, @"[0-9]+(?:\.[0-9]+)?");
                    bloom = Convert.ToDouble(m.Value);
                }
            }
        }

        public void output()
        {

            ArrayList lines = new ArrayList();

            lines.Add("r_displayinfo 0");
            lines.Add("r_TexturesStreaming=0");
            lines.Add("sv_timeofdayenable 0");
            lines.Add("sv_servername = svname");
            lines.Add("sv_cheatprotection = 1 ");
            lines.Add("sv_maxplayers = 32");
            lines.Add("net_pb_sv_enable true ");
            lines.Add("g_timelimit = 30 ");
            lines.Add("g_minteamlimit = 0 ");
            lines.Add("g_revivetime = 20");
            lines.Add("g_autoteambalance = 0 ");
            lines.Add("g_tk_punish = 0 ");
            lines.Add("ai_EnableWarningsErrors = 0");
            lines.Add("designer_warning_enabled = 0");

            int fs = 

            lines.Add("r_width = " + resx);
            lines.Add("r_height = " + resy);
            lines.Add("r_fullscreen = " + (fullScreen ? 1 : 0).ToString() );
            lines.Add("r_VSync = " + (fullScreen ? 1 : 0).ToString() );

            lines.Add("sys_spec = " + videoQuality);
            lines.Add("e_ShadowsMaxTexRes = " + shadowQuality);
            //lines.Add("cl_fov = " + fov);
            lines.Add("r_MotionBlur = " + 2);
            if (motionBlur)
                lines.Add("r_MotionBlurShutterSpeed = " + 0.001);
            else
                lines.Add("r_MotionBlurShutterSpeed = " + 0);
            lines.Add("r_MotionBlurMaxViewDist = " + 0);
            lines.Add("r_SSAO = " + (SSAO ? 1 : 0).ToString());
            lines.Add("cl_invertmouse = " + (invertMouse ? 1 : 0).ToString());


            lines.Add("r_HDRBloomRatio = " + bloom);
   
            lines.Add("p_GEB_max_cells 4096");


            String[] linearr = (String[])lines.ToArray(typeof (string));

            System.IO.File.WriteAllLines(FILE, linearr);

        }
    }
}
