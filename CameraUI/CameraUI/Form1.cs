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
        string path,path2, filename = "";
        static string file; // for temp file
        bool firstwrite = true;
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
                    writer.Flush();
                    writer.Close();
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
                    writer.Flush();
                    writer.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("load file first" + ex.Message);
            }
        }
        public void LoadFile(string file1)
        {
            
            string[] getcode = new string[99];
            int i = 0 ;
            try
            {
                if (!File.Exists(file))
                {
                   file = CreateTmpFile();
                }
                if (file1 == file)
                {
                    path = file;
                    values.Items.Clear();
                }
                    using (StreamReader sr = new StreamReader(path))
                    {
                        string line;
                        string[] val;
                        while ((line = sr.ReadLine()) != null)
                        {
                            getcode[i] = line;
                            values.Items.Add(getcode[i]);
                        if(firstwrite)
                            UpdateTmpFile(file, getcode[i]);
                            if (getcode[i] != "")
                            {
                                val = getcode[i].Split('=');
                                if (val[1] == "True" || val[1] == "true" || val[1] == "false" || val[1] == "False")
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
                                        case "fov":
                                            fovSlider.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                        fovLabel.Text = fovSlider.Value.ToString("0.0", CultureInfo.GetCultureInfo("en-US"));
                                            break;
                                        case "positionSmooth":
                                            posSmoothSlider.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                            posSmoothLabel.Text = posSmoothSlider.Value.ToString("0.0", CultureInfo.GetCultureInfo("en-US"));
                                        break;
                                        case "rotationSmooth":
                                            rotationSmoothSlider.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                            rotationSmoothLabel.Text = rotationSmoothSlider.Value.ToString("0.0", CultureInfo.GetCultureInfo("en-US"));
                                        break;
                                        case "3rdPersonCameraDistance":
                                            distanceSlider.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                        distanceLabel.Text = distanceSlider.Value.ToString("0.0", CultureInfo.GetCultureInfo("en-US"));
                                        break;
                                        case "3rdPersonCameraUpperHeight":
                                            upperHightSlider.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                        upperLabel.Text = upperHightSlider.Value.ToString("0.0", CultureInfo.GetCultureInfo("en-US"));
                                        break;
                                        case "3rdPersonCameraLowerHeight":
                                            lowerHeightSlider.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                        lowerLabel.Text = lowerHeightSlider.Value.ToString("0.0", CultureInfo.GetCultureInfo("en-US"));
                                        break;
                                        case "3rdPersonCameraLateralNear":
                                            lateralNearSlider.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                        nearLabel.Text = lateralNearSlider.Value.ToString("0.0", CultureInfo.GetCultureInfo("en-US"));
                                        break;
                                        case "3rdPersonCameraLateralFar":
                                            lateralFarSlider.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                        FarLabel.Text = lateralFarSlider.Value.ToString("0.0", CultureInfo.GetCultureInfo("en-US"));
                                        break;
                                        case "3rdPersonCameraForwardPrediction":
                                            fPredictionSlider.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                        forwardLabel.Text = fPredictionSlider.Value.ToString("0.0", CultureInfo.GetCultureInfo("en-US"));
                                        break;
                                        case "3rdPersonCameraSpeed":
                                            cSpeedSlider.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                        speedLabel.Text = cSpeedSlider.Value.ToString("0.0", CultureInfo.GetCultureInfo("en-US"));
                                        break;
                                        case "lookAtPosX":
                                            posXSlider.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                        lookXLabel.Text = posXSlider.Value.ToString("0.0", CultureInfo.GetCultureInfo("en-US"));
                                        break;
                                        case "lookAtPosY":
                                            trackBar2.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                        lookYLabel.Text = trackBar2.Value.ToString("0.0", CultureInfo.GetCultureInfo("en-US"));
                                        break;
                                        case "lookAtPosZ":
                                            posZSlider.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                        lookZLabel.Text = posZSlider.Value.ToString("0.0", CultureInfo.GetCultureInfo("en-US"));
                                        break;
                                        case "maxSway":
                                            maxSwaySlider.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                        maxSwayLabel.Text = maxSwaySlider.Value.ToString("0.0", CultureInfo.GetCultureInfo("en-US"));
                                        break;
                                        case "swaySpeed":
                                            swaySpeedSlider.Value = Convert.ToInt32(val[1].Split('.')[0]);
                                        swaySpeedLabel.Text = swaySpeedSlider.Value.ToString("0.0", CultureInfo.GetCultureInfo("en-US"));
                                        break;
                                    }
                                }
                                Console.WriteLine(val[1] + "\n");
                            }
                            // fovSlider.Value = 
                            //fovLabel.Text = val.ToString(); 
                            i++;
                        }
                    
                    sr.Close();
                    }
                firstwrite = false;
                path = path2;
            }
            catch (Exception e)
            {
                Console.WriteLine("something went wrong");
                Console.WriteLine(e.Message);
            }
        }
        /******************************************
         * CREATE TEMP FILE FOR DISCARD CHANGES 
         *****************************************/
        private static string CreateTmpFile()
        {
            string fileName = string.Empty;

            try
            {

                fileName = Path.GetTempFileName();
            
                FileInfo fileInfo = new FileInfo(fileName);

                fileInfo.Attributes = FileAttributes.Temporary;

                Console.WriteLine("TEMP file created at: " + fileName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to create TEMP file or set its attributes: " + ex.Message);
            }
            return fileName;
        }

        private static void UpdateTmpFile(string tmpFile,string text)
        {
            try
            {
                // Write to the temp file.
                StreamWriter streamWriter = File.AppendText(tmpFile);
                streamWriter.WriteLine(text);
                Console.WriteLine(text);
                streamWriter.Flush();
                streamWriter.Close();

                Console.WriteLine("TEMP file updated.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error writing to TEMP file: " + ex.Message);
            }
        }
        private static void DeleteTmpFile(string tmpFile)
        {
            try
            {
                // Delete the temp file (if it exists)
                if (File.Exists(tmpFile))
                {
                    File.Delete(tmpFile);
                    Console.WriteLine("TEMP file deleted.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error deleteing TEMP file: " + ex.Message);
            }
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
                path2 = path;
                filename = openFileDialog1.SafeFileName;
                   if(filename == "DynamicCamera.cfg")
                {
                    LoadFile(path);
                    loadBtn.Enabled = false;
                    btnDiscard.Visible = true;
                }
                else
                {
                    MessageBox.Show("Please select your DynamicCamera.cfg");
                }
                 
            }
        }

        private void btnDiscard_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to discard your changes ?", "Discard changes", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                LoadFile(file);
                CheckBoxValues("avoidWalls=", 15, wallsCB);
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Save your changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                LoadFile(file);
                CheckBoxValues("avoidWalls=", 15, wallsCB);
                File.Delete(file);
                Console.WriteLine("TEMP file deleted.");
            }
            if (result == DialogResult.Yes)
            {
                File.Delete(file);
                Console.WriteLine("TEMP file deleted.");
            }
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
   

