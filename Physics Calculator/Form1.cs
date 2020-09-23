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
            screen.BackColor = Color.LavenderBlush;
            screen.Name = "Calculator screen";
            screen.Font = new Font("Courier new", 16);
            screen.Location = new Point(x, 30);
            screen.Width = 290;
            screen.Height = 100;
            screen.Multiline = true;
            
            Controls.Add(screen);


            Button b1 = new Button();
            b1.Location = new Point(x, y);
            b1.Width = 50;
            b1.Height = 50;
            b1.Text = "1";
            b1.Name = "Button 1";
            b1.Click += new EventHandler(b1_Click);

            Controls.Add(b1);

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

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openFIleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
