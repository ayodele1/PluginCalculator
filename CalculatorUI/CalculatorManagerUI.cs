using System;
using System.Windows.Forms;

namespace CalculatorUI
{
    public partial class CalculatorManagerUI : Form
    {
        public CalculatorManagerUI()
        {
            InitializeComponent();
        }

        private void onAddPlugin(object sender, EventArgs e)
        {
            AddPluginForm apf = new AddPluginForm();
            apf.ShowDialog();
        }
    }
}
