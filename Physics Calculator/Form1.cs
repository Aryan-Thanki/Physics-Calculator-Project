using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Physics_Calculator
{
    public partial class Form1 : Form
    {
        TextBox screen = new TextBox();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {





        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Graphics paper = this.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.CornflowerBlue);

            int x = 20;
            int y = 350;
            /*
            for (int i = 1; i <= 20; i++)
            {
                Rectangle rect = new Rectangle(x, y, 50, 50);
                paper.FillRectangle(brush, rect);
                x += 60;

                if (i % 5 == 0)
                {
                    x = 20;
                    y += -60;
                }
            }
            y = 350;
            */
            screen.BackColor = Color.GreenYellow;
            screen.Name = "Calculator screen";
            screen.Font = new Font("Courier new", 16);
            screen.Location = new Point(x, 30);
            screen.Width = 290;
            screen.Height = 100;
            screen.Multiline = true;
            screen.ReadOnly = true;
            Controls.Add(screen);

            Button b0 = new Button();
            b0.Location = new Point(x, y);
            b0.Width = 50;
            b0.Height = 50;
            b0.Text = "0";
            b0.Name = "Button 0";
            b0.Font = new Font("Comic Sans", 16);
            b0.Click += new EventHandler(b0_Click);
            Controls.Add(b0);

            Button b1 = new Button();
            b1.Location = new Point(x = 20, y += -60);
            b1.Width = 50;
            b1.Height = 50;
            b1.Text = "1";
            b1.Name = "Button 1";
            b1.Font = new Font("Comic Sans", 16);
            b1.Click += new EventHandler(b1_Click);
            Controls.Add(b1);

            Button b2 = new Button();
            b2.Location = new Point(x += 60, y);
            b2.Width = 50;
            b2.Height = 50;
            b2.Text = "2";
            b2.Name = "Button 2";
            b2.Font = new Font("Comic Sans", 16);
            b2.Click += new EventHandler(b2_Click);
            Controls.Add(b2);

            Button b3 = new Button();
            b3.Location = new Point(x += 60, y);
            b3.Width = 50;
            b3.Height = 50;
            b3.Text = "3";
            b3.Name = "Button 3";
            b3.Font = new Font("Comic Sans", 16);
            b3.Click += new EventHandler(b3_Click);
            Controls.Add(b3);

            Button b4 = new Button();
            b4.Location = new Point(x = 20, y += -60);
            b4.Width = 50;
            b4.Height = 50;
            b4.Text = "4";
            b4.Name = "Button 4";
            b4.Font = new Font("Comic Sans", 16);
            b4.Click += new EventHandler(b4_Click);
            Controls.Add(b4);

            Button b5 = new Button();
            b5.Location = new Point(x += 60, y);
            b5.Width = 50;
            b5.Height = 50;
            b5.Text = "5";
            b5.Name = "Button 5";
            b5.Font = new Font("Comic Sans", 16);
            b5.Click += new EventHandler(b5_Click);
            Controls.Add(b5);

            Button b6 = new Button();
            b6.Location = new Point(x += 60, y);
            b6.Width = 50;
            b6.Height = 50;
            b6.Text = "6";
            b6.Name = "Button 6";
            b6.Font = new Font("Comic Sans", 16);
            b6.Click += new EventHandler(b6_Click);
            Controls.Add(b6);

            Button b7 = new Button();
            b7.Location = new Point(x = 20, y += -60);
            b7.Width = 50;
            b7.Height = 50;
            b7.Text = "7";
            b7.Name = "Button 7";
            b7.Font = new Font("Comic Sans", 16);
            b7.Click += new EventHandler(b7_Click);
            Controls.Add(b7);

            Button b8 = new Button();
            b8.Location = new Point(x += 60, y);
            b8.Width = 50;
            b8.Height = 50;
            b8.Text = "8";
            b8.Name = "Button 8";
            b8.Font = new Font("Comic Sans", 16);
            b8.Click += new EventHandler(b8_Click);
            Controls.Add(b8);

            Button b9 = new Button();
            b9.Location = new Point(x += 60, y);
            b9.Width = 50;
            b9.Height = 50;
            b9.Text = "9";
            b9.Name = "Button 9";
            b9.Font = new Font("Comic Sans", 16);
            b9.Click += new EventHandler(b9_Click);
            Controls.Add(b9);
        }
        private void b0_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + "0";
        }
        private void b1_Click(object sender, EventArgs e)
        {
            
            if (screen.Text == "0" && screen.Text != null)
            {
                screen.Text = "1";
            }
            else
            {
                screen.Text = screen.Text + "1";
            }
        }
        private void b2_Click(object sender, EventArgs e)
        {

            if (screen.Text == "0" && screen.Text != null)
            {
                screen.Text = "2";
            }
            else
            {
                screen.Text = screen.Text + "2";
            }
        }
        private void b3_Click(object sender, EventArgs e)
        {

            if (screen.Text == "0" && screen.Text != null)
            {
                screen.Text = "3";
            }
            else
            {
                screen.Text = screen.Text + "3";
            }
        }
        private void b4_Click(object sender, EventArgs e)
        {

            if (screen.Text == "0" && screen.Text != null)
            {
                screen.Text = "4";
            }
            else
            {
                screen.Text = screen.Text + "4";
            }
        }
        private void b5_Click(object sender, EventArgs e)
        {

            if (screen.Text == "0" && screen.Text != null)
            {
                screen.Text = "5";
            }
            else
            {
                screen.Text = screen.Text + "5";
            }
        }
        private void b6_Click(object sender, EventArgs e)
        {

            if (screen.Text == "0" && screen.Text != null)
            {
                screen.Text = "6";
            }
            else
            {
                screen.Text = screen.Text + "6";
            }
        }
        private void b7_Click(object sender, EventArgs e)
        {

            if (screen.Text == "0" && screen.Text != null)
            {
                screen.Text = "7";
            }
            else
            {
                screen.Text = screen.Text + "7";
            }
        }
        private void b8_Click(object sender, EventArgs e)
        {

            if (screen.Text == "0" && screen.Text != null)
            {
                screen.Text = "8";
            }
            else
            {
                screen.Text = screen.Text + "8";
            }
        }
        private void b9_Click(object sender, EventArgs e)
        {

            if (screen.Text == "0" && screen.Text != null)
            {
                screen.Text = "9";
            }
            else
            {
                screen.Text = screen.Text + "9";
            }
        }
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openFIleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
