using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bmiApp
{
    public partial class Form1 : Form
    {

        //Variables
        int height, weight;

        public Form1()
        {
            InitializeComponent();
            calculateButton.Enabled = false;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Do something
            height = Convert.ToInt32(heightText.Text);
            height = int.Parse(heightText.Text);
            weight = Convert.ToInt32(weightText.Text);
            weight = int.Parse(weightText.Text);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void weightText_TextChanged(object sender, EventArgs e)
        {
      
        }
    }
}
