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

        public void LoadFile()
        {
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        getcode[i] = line;
                        values.Items.Add(getcode[i]);
                        i++;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("llulululul wrong file dude");
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

        private void lateralFarSlider_Scroll(object sender, EventArgs e)
        {
            SliderValues("3rdPersonCameraLateralFar=", 8, lateralFarSlider,FarLabel);

        }
    }
   
}
