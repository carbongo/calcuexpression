using DynamicExpresso;
using DynamicExpresso.Exceptions;
namespace CalcuExpression
{
    public partial class Form1 : Form
    {
        private TextBox lastActiveTextBox;
        public Form1()
        {
            InitializeComponent();
            // Initialize lastActiveTextBox to a default, e.g., textBox_Result
            lastActiveTextBox = textBox_Result;
        }
        public static double Factorial(int number)
        {
            if (number < 0) return double.NaN; // Error for negative numbers
            if (number == 0) return 1;
            double result = 1;
            for (int i = 1; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        // Class level variable to store defined variables
        private readonly Dictionary<string, object> definedVariables = new Dictionary<string, object>();

        private void textBox_Result_GotFocus(object sender, EventArgs e)
        {
            lastActiveTextBox = textBox_Result;
        }

        private void textBox_Definition_GotFocus(object sender, EventArgs e)
        {
            lastActiveTextBox = textBox_Definition;
        }

        private void operationEqual_Click(object sender, EventArgs e)
        {
            if (lastActiveTextBox == textBox_Definition)
            {
                lastActiveTextBox.Text += "=";
            }
            else if (lastActiveTextBox == textBox_Result)
            {
                try
                {
                    var interpreter = new Interpreter();
                    interpreter.Reference(typeof(Form1));
                    foreach (var variable in definedVariables)
                    {
                        interpreter.SetVariable(variable.Key, variable.Value);
                    }

                    var result = interpreter.Eval(textBox_Result.Text);
                    textBox_Result.Text = result.ToString();
                }
                catch (ParseException ex)
                {
                    textBox_Result.Text = "Parse Error: " + ex.Message;
                }
                catch (Exception ex)
                {
                    textBox_Result.Text = "Error: " + ex.Message;
                }
            }
        }

        private void operationClear_Click(object sender, EventArgs e)
        {
            lastActiveTextBox.Text = "";
        }

        private void operationDefine_Click(object sender, EventArgs e)
        {
            var parts = textBox_Definition.Text.Split('=');
            if (parts.Length == 2)
            {
                var variableName = parts[0].Trim();
                try
                {
                    var variableValue = new Interpreter().Eval(parts[1]);
                    definedVariables[variableName] = variableValue;
                    textBox_Definition.Text = $"{variableName} defined";
                }
                catch
                {
                    textBox_Definition.Text = "Invalid Definition";
                }
            }
            else
            {
                textBox_Definition.Text = "Invalid Definition";
            }
        }

        // Button click event handler
        private void button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            lastActiveTextBox.Text += button.Text;
        }

        private void buttonSin_Click(object sender, EventArgs e)
        {
            lastActiveTextBox.Text += "Math.Sin(";
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            lastActiveTextBox.Text += "Math.Cos(";
        }

        private void buttonLn_Click(object sender, EventArgs e)
        {
            lastActiveTextBox.Text += "Math.Log(";
        }
        private void buttonLog_Click(object sender, EventArgs e)
        {
            lastActiveTextBox.Text += "Math.Log(";
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            lastActiveTextBox.Text += "Math.Tan(";
        }

        private void buttonFactorial_Click(object sender, EventArgs e)
        {
            lastActiveTextBox.Text += "Factorial(";
        }

        private void buttonSqrt_Click(object sender, EventArgs e)
        {
            lastActiveTextBox.Text += "Math.Sqrt(";
        }

        private void buttonExp_Click(object sender, EventArgs e)
        {
            lastActiveTextBox.Text += "Math.Pow(";
        }

    }
}
