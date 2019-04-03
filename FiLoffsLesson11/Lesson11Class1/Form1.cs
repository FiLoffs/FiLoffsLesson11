using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson11Class1
{
    public partial class Form1 : Form
    {
        BoatShop boatShop;

        public Form1()
        {
            InitializeComponent();
            boatShop = new BoatShop();
            Array mas = VesselType.GetValues(typeof(VesselType));
            foreach (VesselType name in mas)
                comboBoxVesselType.Items.Add(name);

            Array mas2 = SpeedUnit.GetValues(typeof(SpeedUnit));
            foreach (SpeedUnit name in mas)
                comboBoxSpeedUnit.Items.Add(name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                boatShop.Photo = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(boatShop.Photo);
            }
            
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

        }

        private void trackBarDraught_ValueChanged(object sender, EventArgs e)
        {
            labelDraught.Text = (trackBarDraught.Value/10.0).ToString();
        }

        private void trackBarDraught_Scroll(object sender, EventArgs e)
        {

        }

        private void hScrollMaxSpeed_ValueChanged(object sender, EventArgs e)
        {
            labelSpeed.Text = hScrollMaxSpeed.Value.ToString();
        }

        private void comboBoxSpeedUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBoxSpeedUnit.Text);

        }
    }
}
