using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CameraUI
{
    public partial class Form1 : Form
    {
        string[] getcode = new string[99];
        int i;
        string path, filename = "";
        double value;
        public Form1()
        {
            InitializeComponent();
        }

        public void SliderValues(string name, int index, TrackBar tr, Label lblName)
        {
            String val;
            try
            {
                if (name != "fov=")
                {
                    value = tr.Value * 0.1;
                    val = value.ToString("0.0", CultureInfo.GetCultureInfo("en-US"));
                }
                else
                { value = tr.Value;
                    val = value.ToString("0.0", CultureInfo.GetCultureInfo("en-US"));
                }

                values.Items[index].Text = name + val;
                lblName.Text = val;
                using (var writer = new StreamWriter(path))
                {
                    foreach (ListViewItem item in values.Items)
                    {
                        writer.WriteLine(item.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("load file first" + ex.Message);
            }
        }

        public void CheckBoxValues(string name, int index, CheckBox cb)
        {
            String val;
            try
            {
                val = cb.Checked.ToString();
                values.Items[index].Text = name + val;
                using (var writer = new StreamWriter(path))
                {
                    foreach (ListViewItem item in values.Items)
                    {
                        writer.WriteLine(item.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("load file first" + ex.Message);
            }
        }
        public void LoadFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    string[] val ;
                    while ((line = sr.ReadLine()) != null)
                    {
                        getcode[i] = line;
                        values.Items.Add(getcode[i]);
                        
                        if (getcode[i] != "")
                        {
                            val = getcode[i].Split('=');
                            if(val[1] == "True" || val[1] == "true" || val[1] == "false" || val[1] == "False" )
                            {
                                if (val[0] == "thirdPerson")
                                    thirdPersonCB.Checked = Boolean.Parse(val[1]);
                                if (val[0] == "cameraPreview")
                                    igCameraCB.Checked = Boolean.Parse(val[1]);
                                if (val[0] == "avoidWalls")
                                    wallsCB.Checked = Boolean.Parse(val[1]);
                                if (val[0] == "useSway")
                                    SwayCB.Checked = Boolean.Parse(val[1]);
                            }
                            else
                            {
                                switch (val[0])
                                {
                                    case "fov": fovSlider.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                        break;
                                    case "positionSmooth": posSmoothSlider.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                        break;
                                    case "rotationSmooth":
                                        rotationSmoothSlider.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                        break;
                                    case "3rdPersonCameraDistance":
                                        distanceSlider.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                        break;
                                    case "3rdPersonCameraUpperHeight":
                                        upperHightSlider.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                        break;
                                    case "3rdPersonCameraLowerHeight":
                                        lowerHeightSlider.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                        break;
                                    case "3rdPersonCameraLateralNear":
                                        lateralNearSlider.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                        break;
                                    case "3rdPersonCameraLateralFar":
                                        lateralFarSlider.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                        break;
                                    case "3rdPersonCameraForwardPrediction":
                                        fPredictionSlider.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                        break;
                                    case "3rdPersonCameraSpeed":
                                        cSpeedSlider.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                        break;
                                    case "lookAtPosX":
                                        posXSlider.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                        break;
                                    case "lookAtPosY":
                                        trackBar2.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                        break;
                                    case "lookAtPosZ":
                                        posZSlider.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                        break;
                                    case "maxSway":
                                        maxSwaySlider.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                        break;
                                    case "swaySpeed":
                                        swaySpeedSlider.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                        break;
                                }
                            }
                            Console.WriteLine(val[1] + "\n");
                        }
                        // fovSlider.Value = 
                        //fovLabel.Text = val.ToString(); 
                        i++;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Wrong file, please select your DynamicCamera.cfg");
                Console.WriteLine(e.Message);
            }
          /*  int x = 0;
            String lastitem = values.Items[0].Text.Split('=').Last();
            Console.WriteLine(lastitem);
            // fovSlider.Value = Convert.ToInt32(lastitem); 
            */
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Path to your DynamicCarmera file";
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.Filter = "cfg files (*.cfg)|*.cfg";
            openFileDialog1.ShowHelp = true;
            openFileDialog1.FileName = "DynamicCamera.cfg";
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                filename = openFileDialog1.SafeFileName;
                   if(filename == "DynamicCamera.cfg")
                {
                    LoadFile();
                    loadBtn.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Please select your DynamicCamera.cfg");
                }
                 
            }
        }

        private void fovSlider_Scroll(object sender, EventArgs e)
        {
            SliderValues("fov=", 0, fovSlider, fovLabel);
        }

        private void distanceSlider_Scroll(object sender, EventArgs e)
        {
            SliderValues("3rdPersonCameraDistance=", 4, distanceSlider, distanceLabel);
        }

        private void upperHightSlider_Scroll(object sender, EventArgs e)
        {
            SliderValues("3rdPersonCameraUpperHeight=", 5, upperHightSlider, upperLabel);
        }

        private void lowerHeightSlider_Scroll(object sender, EventArgs e)
        {
            SliderValues("3rdPersonCameraLowerHeight=", 6, lowerHeightSlider, lowerLabel);
        }

        private void lateralNearSlider_Scroll(object sender, EventArgs e)
        {
            SliderValues("3rdPersonCameraLateralNear=", 7, lateralNearSlider, nearLabel);
        }

        private void wallsCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxValues("avoidWalls=", 15, wallsCB);
        }

        private void fPredictionSlider_Scroll(object sender, EventArgs e)
        {
            SliderValues("3rdPersonCameraForwardPrediction=", 9, fPredictionSlider, forwardLabel);

        }

        private void cSpeedSlider_Scroll(object sender, EventArgs e)
        {
            SliderValues("3rdPersonCameraSpeed=", 10, cSpeedSlider, speedLabel);

        }

        private void thirdPersonCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxValues("thirdPerson=", 3, thirdPersonCB);
        }

        private void igCameraCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxValues("cameraPreview=", 12, igCameraCB);
            CheckBoxValues("moveCameraInGame=", 13, igCameraCB);
        }

        private void SwayCB_CheckedChanged(object sender, EventArgs e)
        {
            CheckBoxValues("useSway=", 20, SwayCB);
        }

        private void posSmoothSlider_Scroll(object sender, EventArgs e)
        {
            SliderValues("positionSmooth=", 1, posSmoothSlider, posSmoothLabel);

        }

        private void rotationSmoothSlider_Scroll(object sender, EventArgs e)
        {
            SliderValues("rotationSmooth=", 2, rotationSmoothSlider, rotationSmoothLabel);

        }

        private void posXSlider_Scroll(object sender, EventArgs e)
        {
            SliderValues("lookAtPosX=", 16, posXSlider, lookXLabel);

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            SliderValues("lookAtPosY=", 17, trackBar2, lookYLabel);

        }

        private void posZSlider_Scroll(object sender, EventArgs e)
        {
            SliderValues("lookAtPosZ=", 18, posZSlider, lookZLabel);

        }

        private void maxSwaySlider_Scroll(object sender, EventArgs e)
        {
            SliderValues("maxSway=", 21, maxSwaySlider, maxSwayLabel);

        }

        private void swaySpeedSlider_Scroll(object sender, EventArgs e)
        {
            SliderValues("swaySpeed=", 22, swaySpeedSlider, swaySpeedLabel);

        }

        private void lateralFarSlider_Scroll(object sender, EventArgs e)
        {
            SliderValues("3rdPersonCameraLateralFar=", 8, lateralFarSlider,FarLabel);

        }
    }
   
}
