using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pinball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Alien");
            comboBox1.Items.Add("Batman '66");
            comboBox1.Items.Add("Congo");
            comboBox1.Items.Add("Dr Who");
            comboBox1.Items.Add("The Walking Dead");

            start1.BringToFront();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Alien")
            {
                alien1.BringToFront();
            }
            else if (comboBox1.Text == "Batman '66")
            {
                batman661.BringToFront();
            }
            else if (comboBox1.Text == "Congo"){
                
                congo1.BringToFront();
            }

            else if(comboBox1.Text == "Dr Who")
            {
                drwho1.BringToFront();
            }


            else if(comboBox1.Text =="The Walking Dead")
            {
                twd1.BringToFront();
                
            }
            else 


                start1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             start1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            about1.BringToFront();
        }
    }
}
