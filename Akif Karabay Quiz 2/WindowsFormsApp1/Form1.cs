using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
      

        public Form1()
        {
            InitializeComponent();
            
           
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuild_Click(object sender, EventArgs e)
        {
            panel1.Visible= false;  
            label15.Text = TextboxRed.Text;
            label16.Text = TextboxOrange.Text;
            label18.Text = TextboxRed.Text;
            label20.Text=textboxYellow.Text;
            label17.Text=TextboxRed.Text;
            label19.Text=TextboxGreen.Text;
            label23.Text=TextboxOrange.Text;
            label22.Text=textboxYellow.Text;
            label21.Text = TextboxOrange.Text;
            label26.Text = TextboxGreen.Text;
            label25.Text = textboxYellow.Text;
            label24.Text = TextboxGreen.Text;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Throw50button_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int comp1 = 0;
            int comp2 = 0;
            for (int i = 0; i < 50; i++) { 
            int randomNumber = random.Next(100);
            if (randomNumber > 50)
            {
                comp1++;

            }
            else comp2++;
            }
            label28.Text = comp1 + " - " + comp2;
            //
            int comp11 = 0;
            int comp22 = 0;
            for (int i = 0; i < 50; i++)
            {
                int randomNumber1 = random.Next(100);
                if (randomNumber1 > 50)
                {
                    comp11++;

                }
                else comp22++;
            }
            label33.Text = comp11 + " - " + comp22;
            //

            int comp111 = 0;
            int comp222 = 0;
            for (int i = 0; i < 50; i++)
            {
                int randomNumber12 = random.Next(100);
                if (randomNumber12 > 50)
                {
                    comp111++;

                }
                else comp222++;
            }
            label32.Text = comp111 + " - " + comp222;
            //
            int comp1111 = 0;
            int comp2222 = 0;
            for (int i = 0; i < 50; i++)
            {
                int randomNumber123 = random.Next(100);
                if (randomNumber123 > 50)
                {
                    comp1111++;

                }
                else comp2222++;
            }
            label31.Text = comp1111 + " - " + comp2222;
            //
            int comp11111 = 0;
            int comp22222 = 0;
            for (int i = 0; i < 50; i++)
            {
                int randomNumber1234 = random.Next(100);
                if (randomNumber1234 > 50)
                {
                    comp11111++;

                }
                else comp22222++;
            }
            label30.Text = comp11111 + " - " + comp22222;
            //
            int comp111111 = 0;
            int comp222222 = 0;
            for (int i = 0; i < 50; i++)
            {
                int randomNumber12345 = random.Next(100);
                if (randomNumber12345 > 50)
                {
                    comp111111++;

                }
                else comp222222++;
            }
            label29.Text = comp111111 + " - " + comp222222;
            int totalscoreRed = comp1 + comp11 + comp111;
            int totalscoreOrange = comp2 + comp1111 + comp11111;
            int totalscoreYellow = comp22 + comp2222 + comp111111;
            int totalscoreGreen = comp222 + comp22222 + comp222222;

           int max1= Math.Max(Math.Max(Math.Max(totalscoreRed, totalscoreOrange),totalscoreGreen),totalscoreYellow);
            if (max1 == totalscoreYellow) { label34.Text = "WİNNER İS YELLOW "; label34.BackColor = Color.Yellow; }
            if (max1 == totalscoreGreen) { label34.Text = "WİNNER İS GREEN ";label34.BackColor = Color.Green; }
            if (max1 == totalscoreRed) { label34.Text = "WİNNER İS RED ";label34.BackColor = Color.Red; }
            if (max1 == totalscoreOrange) { label34.Text = "WİNNER İS ORANGE ";label34.BackColor = Color.Orange; }

        }

        private void buttonDisplayWinner_Click(object sender, EventArgs e)
        {
            panel2.Visible= false;
            
        }
    }
}
