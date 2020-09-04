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
        

        public class drawButtons {
            public int[] drawingButton = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
        
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Graphics paper = this.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.CornflowerBlue);
            int x = 30;
            int y = 350;

            for (int i = 0; i <= 10; i++)
            {
                Rectangle rect = new Rectangle(x, y, 50, 50);
                paper.FillRectangle(brush, rect);
                

            }
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

         


        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
