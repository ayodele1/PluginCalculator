using DomainObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace PluginCalculator
{
    public partial class CalculatorControl : UserControl
    {
        StringBuilder arithmeticExpression, numericExpression;
        string currentArithmeticExpression, currentNumericValue = string.Empty;
        int currentOperation = -1;
        string currentOperatorButtonName = string.Empty;
        string[] values = new string[2];//Store value1 and value2
        PluginManager pm;

        enum ArithmeticOperation { Add, Subtract, Divide, Multiply, PluginOperation }

        public CalculatorControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 1,2,3 e.t.c are considered numberic buttons
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onClickNumericButton(object sender, EventArgs e)
        {
            string keyboardEntry = (sender as Button).Text.ToString();
            BuildArithmeticExpression(keyboardEntry);
            BuildNumericExpression(keyboardEntry);
        }

        private void onClearScreen(object sender, EventArgs e)
        {
            _displayTbox.Clear();
            _displayLabel.ResetText();
        }
        private void clearArrayValues()
        {
            Array.Clear(values, 0, values.Length);
        }

        private void onSelectArithmeticOperator(object sender, EventArgs e)
        {
            var buttonClicked = (Button)sender;
            var buttonTag = buttonClicked.Tag;
            currentOperatorButtonName = buttonClicked.Name;
            Plugin p = null;
            if (buttonTag != null && buttonTag.GetType().BaseType == typeof(Plugin))
            {
                p = FindPluginByName(buttonClicked.Name);
            }
            string keyboardEntry = (sender as Button).Text.ToString();
            int operationToPerform = DetectOperationToPerform(keyboardEntry, p);
            string result = string.Empty;

            if (currentOperation < 0)
            {
                values[0] = currentNumericValue;
                currentOperation = operationToPerform;
                result = PerformCalculation(values[0], values[1], currentOperation, p);
            }
            else
            {
                values[1] = currentNumericValue;
                result = PerformCalculation(values[0], values[1], currentOperation, p);
                currentOperation = operationToPerform;
                BuildNumericExpression(result);
            }
            clearArrayValues();
            values[0] = result;
            BuildArithmeticExpression(keyboardEntry);
            _displayLabel.Text = currentArithmeticExpression;
            numericExpression.Clear();

        }

        private string PerformCalculation(string firstValue, string secondValue, int operationToPerform, Plugin plugin = null)
        {
            if (secondValue == null && operationToPerform != 4)//For Unary Operations
            {
                return firstValue;
            }

            double val1 = Double.Parse(firstValue);
            double val2 = Double.Parse(secondValue);
            double result = 0;



            switch (operationToPerform)
            {
                case 0:
                    result = val1 + val2;
                    break;
                case 1:
                    result = val1 - val2;
                    break;
                case 2:
                    result = val1 / val2;
                    break;
                case 3:
                    result = val1 * val2;
                    break;
                case 4:
                    if (plugin != null)
                        result = plugin.Calculate(firstValue, secondValue);
                    break;
                default:
                    result = 0;
                    break;

            }
            return result.ToString();
        }

        private int DetectOperationToPerform(string operation, object buttonTag)
        {
            if (buttonTag != null && buttonTag.GetType().BaseType == typeof(Plugin))
                return (int)ArithmeticOperation.PluginOperation;
            if (string.Compare(operation, "+") == 0)
                return (int)ArithmeticOperation.Add;
            if (string.Compare(operation, "-") == 0)
                return (int)ArithmeticOperation.Subtract;
            if (string.Compare(operation, "*") == 0)
                return (int)ArithmeticOperation.Multiply;
            if (string.Compare(operation, "/") == 0)
                return (int)ArithmeticOperation.Divide;

            return -1;
        }

        /// <summary>
        /// "=" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void onCalculateResult(object sender, EventArgs e)
        {
            string result = string.Empty;
            Plugin p = FindPluginByName(currentOperatorButtonName);
            if (currentOperation < 0 && currentNumericValue != string.Empty)
                result = currentNumericValue;
            if (currentOperation >= 0)
                result = PerformCalculation(values[0], values[1], currentOperation, p);
            numericExpression.Clear();
            arithmeticExpression.Clear();
            BuildNumericExpression(result);
            BuildArithmeticExpression(result);
            currentOperation = -1; 
        }

        /// <summary>
        /// Uses a StringBuilder to build arithmetic expression from keyboard Input
        /// Also sets the label text.
        /// </summary>
        private void BuildArithmeticExpression(string keyboardEntry)
        {
            arithmeticExpression.Append(keyboardEntry);
            currentArithmeticExpression = arithmeticExpression.ToString();
            _displayLabel.Text = currentArithmeticExpression;
        }


        /// <summary>
        /// Uses a StringBuilder to build arithmetic expression from keyboard Input
        /// Also sets the label text.
        /// </summary>
        /// <param name="keyboardEntry"></param>
        private void BuildNumericExpression(string keyboardEntry)
        {
            numericExpression.Append(keyboardEntry);
            currentNumericValue = numericExpression.ToString();
            _displayTbox.Text = currentNumericValue;
        }

        public void AddNewButtonControl(string buttonName, string buttonText, object buttonTag)
        {
            Button b = new Button()
            {
                Name = buttonName,
                Text = buttonText,
                Dock = DockStyle.Fill,
                Tag = buttonTag
            };
            _pluginButtonsTableLayoutPanel.Controls.Add(b, 0, 0);
            b.Click += onSelectArithmeticOperator;
        }

        private void onLoad(object sender, EventArgs e)
        {
            arithmeticExpression = new StringBuilder();
            numericExpression = new StringBuilder();
            pm = new PluginManager(); //automatically loads the plugins from dll
            LoadPluginsToView(pm.LoadedPlugins);
        }

        private void LoadPluginsToView(List<Plugin> plugins)
        {
            if (plugins != null)
            {
                foreach (Plugin p in plugins)
                {
                    AddNewButtonControl(p.Name, p.OperatorSymbol, p);
                }
            }
        }

        private Plugin FindPluginByName(string name)
        {
            return pm.LoadedPlugins.Find(plugin => plugin.Name.Equals(name));
        }
    }
}
