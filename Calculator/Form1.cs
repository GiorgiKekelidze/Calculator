using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button btn)
                {
                    btn.Font = new Font("Segoe UI", 10, FontStyle.Bold); // Change size & style here
                }
            }
        }
       
        private void AppendToEnd(string text){
            if (richTextBox1.Text != string.Empty){
                if(richTextBox1.Text[0] == '0' && richTextBox1.Text.Length == 1){ // If the first character is '0' and there are no more characters, replace it
                        richTextBox1.Text = string.Empty; // Clear if the first character is '0'
                        richTextBox1.SelectionStart = richTextBox1.Text.Length;
                        richTextBox1.SelectionLength = 0;
                        richTextBox1.AppendText(text);
                }
                else{
                    richTextBox1.SelectionStart = richTextBox1.Text.Length;
                    richTextBox1.SelectionLength = 0;
                    richTextBox1.AppendText(text);
                }
            }
            else
            {
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.SelectionLength = 0;
                richTextBox1.AppendText(text);
            }
        }
        private void AppendToEndOper(string text)
        {
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.SelectionLength = 0;
                richTextBox1.AppendText(text);
        }


        private void OneBtn_Click(object sender, EventArgs e)
        {
            AppendToEnd("1");
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            AppendToEnd("2");
        }
        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            AppendToEnd("3");
        }
        private void FourBtn_Click(object sender, EventArgs e)
        {
            AppendToEnd("4");
        }
        private void FiveBtn_Click(object sender, EventArgs e)
        {
            AppendToEnd("5");
        }
        private void SixBtn_Click(object sender, EventArgs e)
        {
            AppendToEnd("6");
        }
        private void NineBtn_Click(object sender, EventArgs e)
        {
            AppendToEnd("9");
        }
        private void EightBtn_Click(object sender, EventArgs e)
        {
            AppendToEnd("8");
        }
         private void ZeroBtn_Click(object sender, EventArgs e)
         {
            AppendToEnd("0");
         }
        private void SevenBtn_Click(object sender, EventArgs e)
        {
            AppendToEnd("7");
        }

        private void MultBtn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Last() == ',')
            {
                richTextBox1.Text = richTextBox1.Text.TrimEnd(',');
            }
            string[] parts = richTextBox1.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 3 && operations.ContainsKey(parts[1]))
            {
                double leftOperand = double.Parse(parts[0], new CultureInfo("fr-FR"));
                double rightOperand = double.Parse(parts[2], new CultureInfo("fr-FR"));
                string operation = parts[1];
                double result = operations[operation](leftOperand, rightOperand);
                richTextBox1.Text = result.ToString();
                AppendToEndOper(" X ");
            }
            else if (parts.Length == 2 && operations.ContainsKey(parts[1]))
            {
                // if second value is substraction do not append
            }
            else
            {
                AppendToEndOper(" X ");
            }
        }
        private Dictionary<string, Func<double, double, double>> operations = new Dictionary<string, Func<double, double, double>>
        {
            { "+", (a, b) => a + b },
            { "-", (a, b) => a - b },
            { "X", (a, b) => a * b },
            { "/", (a, b) => a / b },
            {"sqrt()",(a, b) => Math.Sqrt(a) } // Added square root operation
        };
        private void EqlBtn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Last() == ',')
            {
                richTextBox1.Text = richTextBox1.Text.TrimEnd(',');
            }
            string[] parts = richTextBox1.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string input = richTextBox1.Text;

            // Regular expression pattern: matches sqrt(...) with anything inside
            Regex sqrtPattern = new Regex(@"sqrt\([^\)]+\)");

            if (sqrtPattern.IsMatch(input))
            {
                if (input.StartsWith("sqrt(") && input.EndsWith(")"))
                {
                    // Input is already sqrt() form, extract inner number
                    string inside = input.Substring(5, input.Length - 6);

                    if (double.TryParse(inside, out double value))
                    {
                        if (value < 0)
                        {
                            MessageBox.Show("Cannot take square root of a negative number.");
                            return;
                        }

                        double result = Math.Sqrt(value);
                        richTextBox1.Text = $"{result}";
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Invalid number inside sqrt().");
                    }
                }
                else
                {
                    // Wrap current input in sqrt()
                    richTextBox1.Text = $"sqrt({input})";
                }
            }
            if (parts.Length == 3 && operations.ContainsKey(parts[1]))
            {

                double leftOperand = double.Parse(parts[0], new CultureInfo("fr-FR"));
                double rightOperand = double.Parse(parts[2], new CultureInfo("fr-FR"));
                if (parts[1] == "/" && rightOperand == 0)
                {
                    MessageBox.Show("Cannot divide by zero");
                    richTextBox1.Text = string.Empty; // Clear the text box
                    return;
                }
                string operation = parts[1];
                double result = operations[operation](leftOperand, rightOperand);
                richTextBox1.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input format. Please use: number operator number (e.g., 2 + 2).");
            }
        }

        private void SubsBtn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Last() == ',')
            {
                richTextBox1.Text = richTextBox1.Text.TrimEnd(',');
            }
            string[] parts = richTextBox1.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 3 && operations.ContainsKey(parts[1]))
            {
                double leftOperand = double.Parse(parts[0], new CultureInfo("fr-FR"));
                double rightOperand = double.Parse(parts[2], new CultureInfo("fr-FR"));
                string operation = parts[1];
                double result = operations[operation](leftOperand, rightOperand);
                richTextBox1.Text = result.ToString();
                AppendToEndOper(" - ");
            }
            else if (parts.Length == 2 && operations.ContainsKey(parts[1]))
            {
                // if second value is substraction do not append
            }
            else
            {
                AppendToEndOper(" - ");
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Last() == ',')
            {
                richTextBox1.Text = richTextBox1.Text.TrimEnd(',');
            }
            string[] parts = richTextBox1.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 3 && operations.ContainsKey(parts[1]))
            {
                double leftOperand = double.Parse(parts[0], new CultureInfo("fr-FR"));
                double rightOperand = double.Parse(parts[2], new CultureInfo("fr-FR"));
                string operation = parts[1];
                double result = operations[operation](leftOperand, rightOperand);
                richTextBox1.Text = result.ToString();
                AppendToEndOper(" + ");
            }
            else if (parts.Length == 2 && operations.ContainsKey(parts[1]))
            {
                // if second value is substraction do not append
            }
            else
            {
                AppendToEndOper(" + ");
            }
        }

        private void DivBtn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text.Last() ==',')
            {
                richTextBox1.Text = richTextBox1.Text.TrimEnd(',');
            }
            string[] parts = richTextBox1.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length == 3 && operations.ContainsKey(parts[1]))
            {
                double leftOperand = double.Parse(parts[0], new CultureInfo("fr-FR"));
                double rightOperand = double.Parse(parts[2], new CultureInfo("fr-FR"));
                if (rightOperand == 0)
                {
                    MessageBox.Show("Cannot divide by zero");
                    return;
                }
                string operation = parts[1];
                double result = operations[operation](leftOperand, rightOperand);
                richTextBox1.Text = result.ToString();
                AppendToEndOper(" / ");
            }
            else if (parts.Length == 2 && operations.ContainsKey(parts[1]))
            {
                // if second value is substraction do not append
            }
            else
            {
                AppendToEndOper(" / ");
            }
        }
        double i = 0;
        private void PointBtn_Click(object sender, EventArgs e)
        {
            string[] parts = richTextBox1.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length > 1)
            {
                if ((double.TryParse(richTextBox1.Text.Last().ToString(), out i) == true) && (parts[0].Contains(',') || (parts[1].Contains(',')))){

                }
            }
            else if (parts.Length <= 1) {
                if ((double.TryParse(richTextBox1.Text.Last().ToString(), out i) == true) && (parts[0].Contains(',')))
                {
                    // If the last character is a digit and the first or second part contains a decimal point, do nothing
                }
            }
            if (double.TryParse(richTextBox1.Text.Last().ToString(), out i) == true && richTextBox1.Text.Last() != ',')
            {
                // If the last character is a digit, append a decimal point
                AppendToEndOper(",");
                // Your logic here
            }
            else if (richTextBox1.Text.Last() == ',')
            {
                // If the last character is already a decimal point, do nothing
            }
        }

        private void ModulusBtn_Click(object sender, EventArgs e)
        {
            string input = richTextBox1.Text.Trim();

            if (string.IsNullOrEmpty(input))
                return;

            // Find the last number in the expression
            int lastOpIndex = Math.Max(
                input.LastIndexOf('+'),
                Math.Max(
                    input.LastIndexOf('-'),
                    Math.Max(
                        input.LastIndexOf('*'),
                        Math.Max(input.LastIndexOf('/', input.Length - 1), input.LastIndexOf('%'))
                    )
                )
            );

            // Get prefix and last number
            string prefix = input.Substring(0, lastOpIndex + 1);
            string lastNum = input.Substring(lastOpIndex + 1).Trim();

            // Toggle negation
            if (lastNum.StartsWith("-"))
                lastNum = lastNum.Substring(1); // remove -
            else
                lastNum = "-" + lastNum;

            // Update the text box
            richTextBox1.Text = prefix + lastNum;
        }

        private void SqrtBtn_Click(object sender, EventArgs e)
        {
            string input = richTextBox1.Text.Trim();

            // If input is empty or just "sqrt(", assume 0
            if (string.IsNullOrEmpty(input) || input == "sqrt(")
            {
                richTextBox1.Text = "sqrt(0)";
                return;
            }

            if (input.StartsWith("sqrt(") && input.EndsWith(")"))
            {
                // Input is already sqrt() form, extract inner number
                string inside = input.Substring(5, input.Length - 6);

                if (double.TryParse(inside, out double value))
                {
                    if (value < 0)
                    {
                        MessageBox.Show("Cannot take square root of a negative number.");
                        return;
                    }

                    double result = Math.Sqrt(value);
                    richTextBox1.Text = $"sqrt({result})";
                }
                else
                {
                    MessageBox.Show("Invalid number inside sqrt().");
                }
            }
            else
            {
                // Wrap current input in sqrt()
                richTextBox1.Text = $"sqrt({input})";
            }

        }

        private void SqrBtn_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Text = Math.Pow(double.Parse(richTextBox1.Text),2).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Format Exception text contains non numeric value");
            }   
            catch (ArgumentNullException ex)
            {
                MessageBox.Show($"An ArgumentNullException error occurred: {ex.Message}");
            }
            catch (OverflowException ex)
            {
                MessageBox.Show($"An OverflowException error occurred: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int maxLength = 15; // Adjust based on your requirements
            float defaultFontSize = 20f;
            float minFontSize = 16f;
            if (richTextBox1.Text.Length > 21)
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (!(ctrl is TextBox)) // Keep textBox1 active
                        if(ctrl is Button && ctrl.Name == "DltBtn")
                            ctrl.Enabled = true; // Enable delete button and richTextBox1
                        else
                            ctrl.Enabled = false;
                }

            }
            else if (richTextBox1.Text.Length < 21)
            {
                foreach (Control ctrl in this.Controls)
                {
                    if (!(ctrl is TextBox)) // Keep textBox1 active
                        ctrl.Enabled = true;
                }
            }
            if (richTextBox1.Text.Length > maxLength)
            {
                float newFontSize = defaultFontSize * maxLength / richTextBox1.Text.Length;
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, Math.Min(newFontSize, minFontSize), richTextBox1.Font.Style);
            }
            else
            {
                richTextBox1.Font = new Font(richTextBox1.Font.FontFamily, defaultFontSize, richTextBox1.Font.Style);
            }
        }

        private void DltBtn_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != string.Empty)
            {
                richTextBox1.Text = richTextBox1.Text.Substring(0, richTextBox1.Text.Length - 1);
            }
           
        }
        private void OneDivBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.Text.Contains(" "))
                {
                    string[] parts = richTextBox1.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    double rightOperand = double.Parse(parts[2], new CultureInfo("fr-FR"));
                    parts[2] = (1 / rightOperand).ToString();
                    richTextBox1.Text = parts[0] + " " + parts[1] + " " + parts[2];
                }
                else
                {
                    richTextBox1.Text = (1 / double.Parse(richTextBox1.Text)).ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void PerCentage_Click(object sender, EventArgs e)
        {
            try
            {
                if (richTextBox1.Text.Contains(" "))
                {
                    string[] parts = richTextBox1.Text.Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                    double rightOperand = double.Parse(parts[2], new CultureInfo("fr-FR"));
                    if (parts[1] == "+")
                    {
                        richTextBox1.Text = (double.Parse(parts[0]) + ((double.Parse(parts[0]) * double.Parse(parts[2])) / 100)).ToString();
                    }
                    else if (parts[1] == "-")
                    {
                        richTextBox1.Text = (double.Parse(parts[0]) - ((double.Parse(parts[0]) * double.Parse(parts[2])) / 100)).ToString();
                    }
                    else if (parts[1] == "X")
                    {
                        richTextBox1.Text = (double.Parse(parts[0]) * ((double.Parse(parts[0]) * double.Parse(parts[2])) / 100)).ToString();
                    }
                    else if (parts[1] == "/")
                    {
                        richTextBox1.Text = (double.Parse(parts[0]) / ((double.Parse(parts[0]) * double.Parse(parts[2])) / 100)).ToString();
                    }
                }
                else if (richTextBox1.Text.Contains(" ") == false)
                {
                    richTextBox1.Text = "0";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CEBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
        }

        private void CBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
        }
    }
}
