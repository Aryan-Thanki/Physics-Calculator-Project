using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;



namespace Physics_Calculator
{
    
    

    public partial class Form1 : Form
    {
        //Code for creating the screen that the user types their numbers in.
        TextBox screen = new TextBox();
        //Variable for the first number used in the calculation
        double firstNumber;
        //Variable for the second Number used in the calculation
        double secondNumber;
        //Variable for the result
        double result;
        //Variable for the four operations
        string Operation;
        // Pi Constant
        public const double π = Math.PI;
        public const double GRAVITY = 9.81;
        List<CalcButton> buttonList = new List<CalcButton>();

        //CalcButton butt1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Graphics paper = this.CreateGraphics();
            StreamReader reader;
            string line = "";
            string[] csvArray;
            OpenFileDialog dialog1 = new OpenFileDialog();
            // X coordinate
            int x = 20;
            // Y coordinate
            int y = 450;

            int count = 1;

            // Code for making a textbox 
            screen.BackColor = Color.GreenYellow;
            screen.Name = "Calculator screen";
            screen.Font = new Font("Segoe UI", 16);
            screen.TextAlign = HorizontalAlignment.Right;
            screen.Location = new Point(x, 30);
            screen.Width = 290;
            screen.Height = 100;
            screen.Multiline = true;
            screen.ReadOnly = true;
            Controls.Add(screen);

            //butt1 = new CalcButton(50, 200, 50, 50, "+", "Addition");
            //butt1.DrawButton(paper);
            string[] namesArray = new string[] { "Button Zero" , "Button Decimal Point" ,
                "Button Pi" , "Button Squared" ,  "Button Equals" , "Button One" , "Button Two" ,
                "Button Three" , "Button Plus" , "Button Minus" , "Button Four" , "Button Five" ,
                "Button Six" , "Button Multiply" , "Button Divide" , "Button Seven" , "Button Eight" ,
                "Button Nine" , "Button Delete" , "Button Clear" , "Button Speed of Light" ,
                "Button Earth's Gravity" , "Button electron Charge"};

            string[] textArray = new string[] { "0", "." , "π" , "[]^2" , "=" , "1" , "2" , "3" ,
                "+" , "-" , "4" , "5" , "6" , "x" , "/" , "7" , "8" , "9" , "Del" , "CE" , "c" ,
                "g" , "eC" };

            if(dialog1.ShowDialog() == DialogResult.OK)
            {
                reader = File.OpenText(dialog1.FileName);
                while(!reader.EndOfStream)
                {
                    line = reader.ReadLine();
                    csvArray = line.Split(',');
                    buttonList.Add(new CalcButton(x, y, 50, 50, csvArray[1], csvArray[0]));
                    if ((count) % 5 == 0)
                    {
                        x = 20;
                        y += -60;
                    }
                    else
                    {
                        x += 60;
                    }
                    count++;
                }
                reader.Close();
            }
            
            //for (int i = 0; i < namesArray.Length; i++)
            //{
            //    buttonList.Add(new CalcButton(x, y, 50, 50, textArray[i], namesArray[i]));
            //    if ((i + 1) % 5 == 0)
            //    {
            //        x = 20;
            //        y += -60;
            //    }
            //    else
            //    {
            //        x += 60;
            //    }
            //}

            //Code for the Button 0
            /*buttonList.Add(new CalcButton(x, y, 50, 50, "0", "Button Zero"));
            x += 60;
            buttonList.Add(new CalcButton(x, y, 50, 50, ".", "Button Decimal Point"));
            x += 60;
            buttonList.Add(new CalcButton(x, y, 50, 50, "π", "Button Pi"));
            x += 60;
            buttonList.Add(new CalcButton(x, y, 50, 50, "[]^2", "Button Squared"));
            x += 60;
            buttonList.Add(new CalcButton(x, y, 50, 50, "=", "Button Equals"));
            x = 20;
            y += -60;
            buttonList.Add(new CalcButton(x, y, 50, 50, "1", "Button One"));
            x += 60;
            buttonList.Add(new CalcButton(x, y, 50, 50, "2", "Button Two"));
            x += 60;
            buttonList.Add(new CalcButton(x, y, 50, 50, "3", "Button Three"));
            x += 60;
            buttonList.Add(new CalcButton(x, y, 50, 50, "+", "Button Plus"));
            x += 60;
            buttonList.Add(new CalcButton(x, y, 50, 50, "-", "Button Minus"));
            x = 20;
            y += -60;
            buttonList.Add(new CalcButton(x, y, 50, 50, "4", "Button Four"));
            x += 60;
            buttonList.Add(new CalcButton(x, y, 50, 50, "5", "Button Five"));
            x += 60;
            buttonList.Add(new CalcButton(x, y, 50, 50, "6", "Button Six"));
            x += 60;
            buttonList.Add(new CalcButton(x, y, 50, 50, "x", "Button Multiply"));
            x += 60;
            buttonList.Add(new CalcButton(x, y, 50, 50, "/", "Button Divide"));
            x = 20;
            y += -60;
            buttonList.Add(new CalcButton(x, y, 50, 50, "7", "Button Seven"));
            x += 60;
            buttonList.Add(new CalcButton(x, y, 50, 50, "8", "Button Eight"));
            x += 60;
            buttonList.Add(new CalcButton(x, y, 50, 50, "9", "Button Nine"));
            x += 60;
            buttonList.Add(new CalcButton(x, y, 50, 50, "Del", "Button Delete"));
            x += 60;
            buttonList.Add(new CalcButton(x, y, 50, 50, "CE", "Button Clear"));
            x = 20;
            y += -60;
            buttonList.Add(new CalcButton(x, y, 50, 50, "c", "Button Speed of Light"));
            x += 60;
            buttonList.Add(new CalcButton(x, y, 50, 50, "g", "Button Earth's Gravity"));
            x += 60;
            buttonList.Add(new CalcButton(x, y, 50, 50, "eC", "Button electron Charge"));
            */

            //Button b0 = new Button();
            //b0.Location = new Point(x, y);
            //b0.Width = 50;
            //b0.Height = 50;
            //b0.Text = "0";
            //b0.Name = "Button 0";

            //b0.Font = new Font("Segoe UI", 16);
            //b0.Click += new EventHandler(b0_Click);
            //Controls.Add(b0);

            //Code for the Decimal Point Button 
            /*Button bdecipoint = new Button();
            bdecipoint.Location = new Point(x += 60, y);
            bdecipoint.Width = 50;
            bdecipoint.Height = 50;
            bdecipoint.Text = ".";
            bdecipoint.Name = "Button Decimal Point";
            bdecipoint.Font = new Font("Segoe UI", 16);
            bdecipoint.Click += new EventHandler(bdecipoint_Click);
            Controls.Add(bdecipoint);

            //Code for the Pi Constant button
            Button bpi = new Button();
            bpi.Location = new Point(x += 60, y);
            bpi.Width = 50;
            bpi.Height = 50;
            bpi.Text = "π";
            bpi.Name = "Button Pi";
            bpi.Font = new Font("Segoe UI", 16);
            bpi.Click += new EventHandler(bpi_Click);
            Controls.Add(bpi);

            //Code for the Squared button
            Button bsquare = new Button();
            bsquare.Location = new Point(x += 60, y);
            bsquare.Width = 50;
            bsquare.Height = 50;
            bsquare.Text = "[]^2";
            bsquare.Name = "Button X^2";
            bsquare.Font = new Font("Segoe UI", 12);
            bsquare.Click += new EventHandler(bsquare_Click);
            Controls.Add(bsquare);

            //Code for the Equals Button
            Button bequals = new Button();
            bequals.Location = new Point(x += 60, y);
            bequals.Width = 50;
            bequals.Height = 50;
            bequals.Text = "=";
            bequals.Name = "Button Equals";
            bequals.Font = new Font("Segoe UI", 16);
            bequals.Click += new EventHandler(bequals_Click);
            Controls.Add(bequals);

            //Code for the Button One
            Button b1 = new Button();
            b1.Location = new Point(x = 20, y += -60);
            b1.Width = 50;
            b1.Height = 50;
            b1.Text = "1";
            b1.Name = "Button 1";
            b1.Font = new Font("Segoe UI", 16);
            b1.Click += new EventHandler(b1_Click);
            Controls.Add(b1);

            //Code for the Button Two
            Button b2 = new Button();
            b2.Location = new Point(x += 60, y);
            b2.Width = 50;
            b2.Height = 50;
            b2.Text = "2";
            b2.Name = "Button 2";
            b2.Font = new Font("Segoe UI", 16);
            b2.Click += new EventHandler(b2_Click);
            Controls.Add(b2);

            //Code for the Button Three
            Button b3 = new Button();
            b3.Location = new Point(x += 60, y);
            b3.Width = 50;
            b3.Height = 50;
            b3.Text = "3";
            b3.Name = "Button 3";
            b3.Font = new Font("Segoe UI", 16);
            b3.Click += new EventHandler(b3_Click);
            Controls.Add(b3);

            //Code for the Addition Buttom
            Button bplus = new Button();
            bplus.Location = new Point(x += 60, y);
            bplus.Width = 50;
            bplus.Height = 50;
            bplus.Text = "+";
            bplus.Name = "Button Plus";
            bplus.Font = new Font("Segoe UI", 16);
            bplus.Click += new EventHandler(bplus_Click);
            Controls.Add(bplus);

            //Code for the Subtraction Button
            Button bminus = new Button();
            bminus.Location = new Point(x += 60, y);
            bminus.Width = 50;
            bminus.Height = 50;
            bminus.Text = "-";
            bminus.Name = "Button Minus";
            bminus.Font = new Font("Segoe UI", 16);
            bminus.Click += new EventHandler(bminus_Click);
            Controls.Add(bminus);

            //Code for the Button Four
            Button b4 = new Button();
            b4.Location = new Point(x = 20, y += -60);
            b4.Width = 50;
            b4.Height = 50;
            b4.Text = "4";
            b4.Name = "Button 4";
            b4.Font = new Font("Segoe UI", 16);
            b4.Click += new EventHandler(b4_Click);
            Controls.Add(b4);

            //Code for the Button Five
            Button b5 = new Button();
            b5.Location = new Point(x += 60, y);
            b5.Width = 50;
            b5.Height = 50;
            b5.Text = "5";
            b5.Name = "Button 5";
            b5.Font = new Font("Segoe UI", 16);
            b5.Click += new EventHandler(b5_Click);
            Controls.Add(b5);

            //Code for the Button Six
            Button b6 = new Button();
            b6.Location = new Point(x += 60, y);
            b6.Width = 50;
            b6.Height = 50;
            b6.Text = "6";
            b6.Name = "Button 6";
            b6.Font = new Font("Segoe UI", 16);
            b6.Click += new EventHandler(b6_Click);
            Controls.Add(b6);

            //Code for the Multiply Button
            Button bmultiply = new Button();
            bmultiply.Location = new Point(x += 60, y);
            bmultiply.Width = 50;
            bmultiply.Height = 50;
            bmultiply.Text = "x";
            bmultiply.Name = "Button Multiply";
            bmultiply.Font = new Font("Segoe UI", 16);
            bmultiply.Click += new EventHandler(bmultiply_Click);
            Controls.Add(bmultiply);

            //Code for the Divide Button
            Button bdivide = new Button();
            bdivide.Location = new Point(x += 60, y);
            bdivide.Width = 50;
            bdivide.Height = 50;
            bdivide.Text = "/";
            bdivide.Name = "Button Divide";
            bdivide.Font = new Font("Segoe UI", 16);
            bdivide.Click += new EventHandler(bdivide_Click);
            Controls.Add(bdivide);

            //Code for the Button Seven
            Button b7 = new Button();
            b7.Location = new Point(x = 20, y += -60);
            b7.Width = 50;
            b7.Height = 50;
            b7.Text = "7";
            b7.Name = "Button 7";
            b7.Font = new Font("Segoe UI", 16);
            b7.Click += new EventHandler(b7_Click);
            Controls.Add(b7);

            //Code for the Button Eight
            Button b8 = new Button();
            b8.Location = new Point(x += 60, y);
            b8.Width = 50;
            b8.Height = 50;
            b8.Text = "8";
            b8.Name = "Button 8";
            b8.Font = new Font("Segoe UI", 16);
            b8.Click += new EventHandler(b8_Click);
            Controls.Add(b8);

            //Code for the Button Nine
            Button b9 = new Button();
            b9.Location = new Point(x += 60, y);
            b9.Width = 50;
            b9.Height = 50;
            b9.Text = "9";
            b9.Name = "Button 9";
            b9.Font = new Font("Segoe UI", 16);
            b9.Click += new EventHandler(b9_Click);
            Controls.Add(b9);

            //Code for the Delete Button
            Button bdel = new Button();
            bdel.Location = new Point(x += 60, y);
            bdel.Width = 50;
            bdel.Height = 50;
            bdel.Text = "DEL";
            bdel.Name = "Button Delete";
            bdel.Font = new Font("Segoe UI", 12);
            bdel.Click += new EventHandler(bdel_Click);
            Controls.Add(bdel);

            //Code for the Clear Button
            Button bclear = new Button();
            bclear.Location = new Point(x += 60, y);
            bclear.Width = 50;
            bclear.Height = 50;
            bclear.Text = "CE";
            bclear.Name = "Clear Button";
            bclear.Font = new Font("Segoe UI", 12);
            bclear.Click += new EventHandler(bclear_Click);
            Controls.Add(bclear);

            //Code for the speed of light constant button
            Button bc = new Button();
            bc.Location = new Point(x = 20, y += -60);
            bc.Width = 50;
            bc.Height = 50;
            bc.Text = "c";
            bc.Name = "Button Speed of Light";
            bc.Font = new Font("Segoe UI", 16);
            bc.Click += new EventHandler(bc_Click);
            Controls.Add(bc);

            //Code for the gravity button constant button
            Button bg = new Button();
            bg.Location = new Point(x += 60, y);
            bg.Width = 50;
            bg.Height = 50;
            bg.Text = "g";
            bg.Name = "Button Gravity";
            bg.Font = new Font("Segoe UI", 16);
            bg.Click += new EventHandler(bg_Click);
            Controls.Add(bg);

            //Code for the gravity button constant button
            Button beC = new Button();
            beC.Location = new Point(x += 60, y);
            beC.Width = 50;
            beC.Height = 50;
            beC.Text = "eC";
            beC.Name = "Button Electron Charge";
            beC.Font = new Font("Segoe UI", 16);
            beC.Click += new EventHandler(beC_Click);
            Controls.Add(beC);

            //Code for the Plancks Constant button
            //Button bh = new Button();
            //bh.Location = new Point(x += 60, y);
            //bh.Width = 50;
            //bh.Height = 50;
            //bh.Text = "eC";
            //bh.Name = "Button ";
            //bh.Font = new Font("Segoe UI", 16);
            //bh.Click += new EventHandler(bh_Click);
            //Controls.Add(bh);*/
        }
 

        /// <summary>
        /// Produces a Zero in the text box when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //private void b0_Click(object sender, EventArgs e)
        //{
        //    screen.Text = screen.Text + "0";
        //}


        /// <summary>
        /// Produces a Decimal Point on the text box when clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bdecipoint_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + ".";
        }


        /// <summary>
        /// Produces a π symbol that represents pi on the textbox when clicked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bpi_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text + π;
        }


        /// <summary>
        /// Backspaces a single character on the textbox when clicked 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bdel_Click(object sender, EventArgs e)
        {
            screen.Text = screen.Text.Remove(screen.Text.Length - 1, 1);
        }


        /// <summary>
        /// Clears the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bclear_Click(object sender, EventArgs e)
        {
            screen.Clear();
        }


        /// <summary>
        /// Squares the current number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bsquare_Click(object sender, EventArgs e)
        {
            screen.Text = Convert.ToString(Convert.ToInt32(screen.Text) * Convert.ToInt32(screen.Text));
        }


        /// <summary>
        /// Adds the number for speed of light automaticlly into the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bc_Click(object sender, EventArgs e)
        {
            //Creates a variable called c and gives it the value of 10 raised to the power of 8
            double c = Math.Pow(10, 8);
            //Adds the variable c multipled by 3 to the screen when the button c is pressed to represent speed of light
            screen.Text = screen.Text + 3 * c;
        }


        /// <summary>
        /// Adds the value for earths gravity to the form when the button g is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bg_Click(object sender, EventArgs e)
        {
            //Adds the constant for Earths gravity to the screen when clicked
            screen.Text = screen.Text + 9.81;
        }

        /// <summary>
        /// Adds the value for charge of an electron when the button eC is clicked
        /// Performs the calculation to create the small value for charge of an electron
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void beC_Click(object sender, EventArgs e)
        {
            //Creates a variable called eC and gives it the value of 10 raised to the power of -19
            double eC = Math.Pow(10, -19);
            //Adds the variable eC multipled by -1.6 to the screen when the button eC is pressed to represent charge of an electron
            screen.Text = screen.Text + -1.6 * eC;
        }


        private void bh_Click(object sender, EventArgs e)
        {
            //Creates a variable called h and gives it the value of 10 raised to the power of - 19
            double h = Math.Pow(10, -34);
            //Adds the variable eC multipled by -1.6 to the screen when the button eC is pressed to represent charge of an electron
            screen.Text = screen.Text + 6.63 * h;
        } 



        /// <summary>
        /// Produces a one in the textbox when clicked
        /// If a textbox is not clear, a one is added onto the end of the current number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// Produces a two in the textbox when clicked
        /// If a textbox is not clear, a two is added onto the end of the current number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// Produces a three in the textbox when clicked
        /// If a textbox is not clear, a three is added onto the end of the current number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// Produces a four in the textbox wnen clicked
        /// If a textbox is not clear, a four is added onto the end of the current number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// Produces a five in the textbox when clicked
        /// If a textbox is not clear, a five is added onto the end of the current number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// Produces a six in the textbox when clicked
        /// If a textbox is not clear, a six is added onto the end of the current number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// Produces a seven in the textbox when clicked
        /// If a textbox is not clear, a seven is added onto the end of the current number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// Produces a eight in the textbox when clicked
        /// If a textbox is not clear, a eight is added onto the end of the current number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// Produces a nine in the textbox when clicked
        /// If a textbox is not clear, a nine is added onto the end of the current number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// Produces a Addition Symbol in the textbox when pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bplus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(screen.Text);
            screen.Text = "0";
            Operation = "+";
        }


        /// <summary>
        /// Produces a Subtraction Symbol in the textbox when pressed 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bminus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(screen.Text);
            screen.Text = "0";
            Operation = "-";
        }


        /// <summary>
        /// Produces a Multiplication Symbol in the textbox when pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bmultiply_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(screen.Text);
            screen.Text = "0";
            Operation = "*";
        }


        /// <summary>
        /// Produces a Division Symbol in the textbox when pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bdivide_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(screen.Text);
            screen.Text = "0";
            Operation = "/";
        }


        /// <summary>
        /// Makes the numbers be calculates depending on the operation used
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bequals_Click(object sender, EventArgs e)
        {

            OperationCalculation Calculate = new OperationCalculation();
            secondNumber = Convert.ToDouble(screen.Text);

            //Try catch method for getting errors and keeping program open 
            try
            {
                //IF operation is addition, the first and second number will be added together to
                //form the result
                if (Operation == "+")
                {
                    result = Calculate.Addition(firstNumber, secondNumber);
                    screen.Text = Convert.ToString(result);
                    firstNumber = result;
                }
                //IF operation is subtraction, the first and second number will be minused from each other to
                //form the result
                if (Operation == "-")
                {
                    result = Calculate.Subtraction(firstNumber, secondNumber);
                    screen.Text = Convert.ToString(result);
                    firstNumber = result;
                }
                //IF operation is multiplication, the first and second number will be timesed together to
                //form the result
                if (Operation == "*")
                {
                    result = Calculate.Multiplication(firstNumber, secondNumber);
                    screen.Text = Convert.ToString(result);
                    firstNumber = result;
                }
                //IF operation is divison, the first and second number will be divided from each other to
                //form the result
                if (Operation == "/")
                {
                    //IF the second number is zero the screen will say cannot divide by zero
                    if (secondNumber == 0)
                    {
                        screen.Text = "Cannot divide by 0";
                    }
                    else
                    {
                        result = Calculate.Division(firstNumber, secondNumber);
                        screen.Text = Convert.ToString(result);
                        firstNumber = result;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for(int i= 0; i < buttonList.Count; i++)
            {
                buttonList[i].DrawButton(e.Graphics);
            }
            
        }

        private void DoOperation(string op)
        {
            if (op[0] >= '0' && op[0] <= '9')
            {
                if (screen.Text == "0" && screen.Text != null)
                {
                    screen.Text = op;
                }
                else
                {
                    screen.Text = screen.Text + op;
                }
            }
            //
            else if (op == ".")
            {
                screen.Text = screen.Text + ".";
            }
            else if (op == "π")
            {
                screen.Text = screen.Text + π;
            }
            else if (op == "[]^2")
            {
                screen.Text = Convert.ToString(Convert.ToInt32(screen.Text) * Convert.ToInt32(screen.Text));
            }
            else if (op == "=")
            {
                OperationCalculation Calculate = new OperationCalculation();
                secondNumber = Convert.ToDouble(screen.Text);

                //Try catch method for getting errors and keeping program open 
                try
                {
                    //IF operation is addition, the first and second number will be added together to
                    //form the result
                    if (Operation == "+")
                    {
                        result = Calculate.Addition(firstNumber, secondNumber);
                        screen.Text = Convert.ToString(result);
                        firstNumber = result;
                    }
                    //IF operation is subtraction, the first and second number will be minused from each other to
                    //form the result
                    if (Operation == "-")
                    {
                        result = Calculate.Subtraction(firstNumber, secondNumber);
                        screen.Text = Convert.ToString(result);
                        firstNumber = result;
                    }
                    //IF operation is multiplication, the first and second number will be timesed together to
                    //form the result
                    if (Operation == "*")
                    {
                        result = Calculate.Multiplication(firstNumber, secondNumber);
                        screen.Text = Convert.ToString(result);
                        firstNumber = result;
                    }
                    //IF operation is divison, the first and second number will be divided from each other to
                    //form the result
                    if (Operation == "/")
                    {
                        //IF the second number is zero the screen will say cannot divide by zero
                        if (secondNumber == 0)
                        {
                            screen.Text = "Cannot divide by 0";
                        }
                        else
                        {
                            result = Calculate.Division(firstNumber, secondNumber);
                            screen.Text = Convert.ToString(result);
                            firstNumber = result;
                        }

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else if (op == "+")
            {
                firstNumber = Convert.ToDouble(screen.Text);
                screen.Text = "0";
                Operation = "+";
            }
            else if (op == "-")
            {
                firstNumber = Convert.ToDouble(screen.Text);
                screen.Text = "0";
                Operation = "-";
            }
            else if (op == "x")
            {
                firstNumber = Convert.ToDouble(screen.Text);
                screen.Text = "0";
                Operation = "*";
            }
            else if (op == "/")
            {
                firstNumber = Convert.ToDouble(screen.Text);
                screen.Text = "0";
                Operation = "/";
            }
            else if (op == "Del")
            {
                screen.Text = screen.Text.Remove(screen.Text.Length - 1, 1);
            }
            else if (op == "CE")
            {
                screen.Clear();
            }
            else if (op == "c")
            {
                //Creates a variable called c and gives it the value of 10 raised to the power of 8
                double c = Math.Pow(10, 8);
                //Adds the variable c multipled by 3 to the screen when the button c is pressed to represent speed of light
                screen.Text = screen.Text + 3 * c;
            }
            else if (op == "g")
            {
                //Adds the constant for Earths gravity to the screen when clicked
                screen.Text = screen.Text + GRAVITY;
            }
            else if (op == "eC")
            {
                //Creates a variable called eC and gives it the value of 10 raised to the power of -19
                double eC = Math.Pow(10, -19);
                //Adds the variable eC multipled by -1.6 to the screen when the button eC is pressed to represent charge of an electron
                screen.Text = screen.Text + -1.6 * eC;
            }
            else if (op == "h")
            {
                //Creates a variable called h and gives it the value of 10 raised to the power of -34
                double h = Math.Pow(10, -34);
                //Adds the variable eC multipled by 6.63 to the screen when the button h is pressed to represent plancks constant
                screen.Text = screen.Text + 6.63 * h;
            }
            

        }


        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            string op = "";
            //if(butt1.CheckClick(e.X, e.Y) == true)
            //{
            //    MessageBox.Show("Clicked on");
            //}
            for(int i = 0; i < buttonList.Count; i++)
            {
                op = buttonList[i].CheckClick(e.X, e.Y);
                if (op != "none")
                {
                    DoOperation(op);
                    break;
                }
            }
        }
    }
}
