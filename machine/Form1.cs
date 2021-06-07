using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using MachineML.Model;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace machine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.ShowDialog();
            if (open.FileName != null)
            {
                pictureBox1.ImageLocation = open.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        { 

            // Add input data
            var input = new ModelInput();
            input.ImageSource = pictureBox1.ImageLocation;

            // Load model and predict output of sample data
            ModelOutput result = ConsumeModel.Predict(input);

            MessageBox.Show("Selected image is " + result.Prediction);

        }
    }
}
