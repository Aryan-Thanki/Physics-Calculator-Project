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
        // Gravity Constant
        public const double GRAVITY = 9.81;
        //Creates a list for drawing the buttons using the CalcButton class
        List<CalcButton> buttonList = new List<CalcButton>();
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Method for what appears on the form when it loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //Creates a steamreader object so that user can get data from csv file
            StreamReader reader;
            //creates a string for the lines in the txt file
            string line = "";
            //Creates an array for the text file
            //When the data in the textfile is read is is transferred into this string array
            string[] csvArray;
            //Open file dialog variable that allows me the read text file from outside my program
            OpenFileDialog dialog1 = new OpenFileDialog();
            // X coordinate
            int x = 20;
            // Y coordinate
            int y = 450;
            //Creates a integer called count for the number of rows in the txt file
            int count = 1;

            // Code for making a textbox 
            //Creates the textbox screen withe background color of light green
            screen.BackColor = Color.GreenYellow;
            //Gives the textbox screen a name
            screen.Name = "Calculator screen";
            //Font for the screen
            screen.Font = new Font("Segoe UI", 20);
            //Aligns the text to the right like a traditional calculator
            screen.TextAlign = HorizontalAlignment.Right;
            //Screen location
            screen.Location = new Point(x, 30);
            //screen WIdth
            screen.Width = 290;
            //screen height
            screen.Height = 150;
            //Make the screen bigger by having multple lines
            screen.Multiline = true;
            //Makes the screen readonly so the user can't type into it
            screen.ReadOnly = true;
            //Adds the screen to the form dynamically
            Controls.Add(screen);

            //Opens a file dialog
            //If the user clicks on the buttons csv .txt file and presses okay
            //the following code is run
            if(dialog1.ShowDialog() == DialogResult.OK)
            {
                //reads the data inside the opened text file
                reader = File.OpenText(dialog1.FileName);
                //Creates a loop that continues until the end of the data in the file
                while(!reader.EndOfStream)
                {
                    //Readers the data in each line
                    line = reader.ReadLine();
                    //Adds the data in each line and splits it based on the comma (example,example)
                    csvArray = line.Split(',');
                    //Adds the data inside the array  to the buttons list.
                    //Uses the x and y coordiates created at the top of the form load method
                    //Uses the same width and height for every button created
                    //Uses the csv data from the array to write the text inside the buttons and the names of the buttons
                    //Uses the left column of the data in the txt file for the names and set at postion 0 of the array
                    //Uses the right column of the data in the txt file for the text and set at postion 1 of the array
                    buttonList.Add(new CalcButton(x, y, 50, 50, csvArray[1], csvArray[0]));
                    //If count variable is divisible by 5 and gives a remainder of 0 then change the following x and y coordinates
                    if ((count) % 5 == 0)
                    {
                        x = 20;
                        y += -60;
                    }
                    //else increase x by 60 pixels
                    else
                    {
                        x += 60;
                    }
                    //increases count by one every time the loop runs
                    count++;
                }
                //closes the reader
                reader.Close();
            }   
        }


        /// <summary>
        /// Draws the buttons based on the buttons list using data from the txt file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //for loop that creates buttons in the grephics(the form), and draws them one by one_
            for(int i = 0; i < buttonList.Count; i++)
            {
                buttonList[i].DrawButton(e.Graphics);
            }
        }


        /// <summary>
        /// Method that checks if the user clicks on a button. If so perform the op method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            string op = "";
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

        /// <summary>
        /// Does the code for every button when clicked
        /// </summary>
        /// <param name="op"></param>
        private void DoOperation(string op)
        {
            //Produces a number in the text box as long as it is between 0 and 9 when clicked
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
            //Produces a Decimal Point on the text box when clicked
            else if (op == ".")
            {
                screen.Text = screen.Text + ".";
            }
            // Produces a π symbol that represents pi on the textbox when clicked
            else if (op == "π")
            {
                screen.Text = screen.Text + π;
            }
            // Squares the current number
            else if (op == "[]^2")
            {
                screen.Text = Convert.ToString(Convert.ToInt32(screen.Text) * Convert.ToInt32(screen.Text));
            }
            // Produces a Addition Symbol in the textbox when pressed
            else if (op == "+")
            {
                firstNumber = Convert.ToDouble(screen.Text);
                screen.Text = "0";
                Operation = "+";
            }
            // Produces a Subtraction Symbol in the textbox when pressed 
            else if (op == "-")
            {
                firstNumber = Convert.ToDouble(screen.Text);
                screen.Text = "0";
                Operation = "-";
            }
            // Produces a Multiplication Symbol in the textbox when pressed
            else if (op == "x")
            {
                firstNumber = Convert.ToDouble(screen.Text);
                screen.Text = "0";
                Operation = "*";
            }
            // Produces a Division Symbol in the textbox when pressed
            else if (op == "/")
            {
                firstNumber = Convert.ToDouble(screen.Text);
                screen.Text = "0";
                Operation = "/";
            }
            // Backspaces a single character on the textbox when clicked 
            else if (op == "Del")
            {
                screen.Text = screen.Text.Remove(screen.Text.Length - 1, 1);
            }
            // Clears the textbox
            else if (op == "CE")
            {
                screen.Clear();
            }
            // Adds the number for speed of light automaticlly into the textbox
            else if (op == "c")
            {
                //Creates a variable called c and gives it the value of 10 raised to the power of 8
                double c = Math.Pow(10, 8);
                //Adds the variable c multipled by 3 to the screen when the button c is pressed to represent speed of light
                screen.Text = screen.Text + 3 * c;
            }
            // Adds the value for earths gravity to the form when the button g is pressed
            else if (op == "g")
            {
                //Adds the constant for Earths gravity to the screen when clicked
                screen.Text = screen.Text + GRAVITY;
            }
            // Adds the value for charge of an electron when the button eC is clicked
            else if (op == "eC")
            {
                //Creates a variable called eC and gives it the value of 10 raised to the power of -19
                double eC = Math.Pow(10, -19);
                //Adds the variable eC multipled by -1.6 to the screen when the button eC is pressed to represent charge of an electron
                screen.Text = screen.Text + -1.6 * eC;
            }
            // Adds the value for Plancks Constant to the form when the button h is clicked
            else if (op == "h")
            {
                //Creates a variable called h and gives it the value of 10 raised to the power of -34
                double h = Math.Pow(10, -34);
                //Adds the variable eC multipled by 6.63 to the screen when the button h is pressed to represent plancks constant
                screen.Text = screen.Text + 6.63 * h;
            }
            else if (op == "G")
            {
                //Creates a variable called G and gives it the value of 10 raised to the power of -11
                double G = Math.Pow(10, -11);
                //Ads\ds the variable G multiplied by 6.67 to the screen when the button G is clicked
                screen.Text = screen.Text + 6.67 * G;
            }
            // Makes the numbers be calculated depending on the operation used
            else if (op == "=")
            {
                //Try catch method for getting errors and keeping program open 
                try
                {
                    //Calls the operation calculation class to calculate the first and second number in the textbox
                    OperationCalculation Calculate = new OperationCalculation();
                    secondNumber = Convert.ToDouble(screen.Text);
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
                        //ELSE run the code as usual
                        else 
                        {
                            result = Calculate.Division(firstNumber, secondNumber);
                            screen.Text = Convert.ToString(result);
                            firstNumber = result;
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a number");

                }
            }
        }


    }
}
