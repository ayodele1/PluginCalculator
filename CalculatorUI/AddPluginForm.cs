using ApplicationHelpers;
using Microsoft.Build.Evaluation;
using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace CalculatorUI
{
    public partial class AddPluginForm : Form
    {
        public AddPluginForm()
        {
            InitializeComponent();
        }

        public string CompilationSourceFile
        {
            get;
            private set;
        }

        public string CompilationSourceFileName
        {
            get;
            private set;
        }

        private void onLoad(object sender, EventArgs e)
        {
            _operatorTypeComboBox.SelectedItem = _operatorTypeComboBox.Items[0];
        }

        private void DisplayPluginSignature(string operatorType, string pluginName)
        {
            _pluginWebBrowser.Navigate("about:blank");
            string htmlText = string.Format(@"
                <html>
                    <body style=""background-color:#404040;font-size:11.5;color:white"">
                        <code>
                        <p><span style=""color:#006699"">using</span> System;<br />
                        <span style=""color:#006699"">using</span> DomainObjects;</p>
                        <p style=""color:white;margin:0""><span style=""color:#006699"">namespace </span>PluginLibrary</p>
                        <p style=""color:white;margin:0"">{0}</p>
                            <P style=""margin:0"">&nbsp;&nbsp;[<span style=""color:#00e673"">PluginAttribute</span>(""<span style=""color:#e69900"">CalculatorPlugin</span>"")]</p>
                           <p style=""margin:0"">&nbsp;&nbsp;<span style= ""color:#006699"">public class</span> <span style=""color:#00e673"">{3}</span> : {2}</p>
                            <p style=""color:white;margin:0"">&nbsp;&nbsp;{0}</p>
                            <p style=""color:white"">&nbsp;&nbsp;{1}</p>
                        <p style=""color:white"">{1}</p>
                    </body>
                </html
                </code>", "{", "}", operatorType, pluginName);
            _pluginWebBrowser.Document.OpenNew(false).Write(htmlText);
            _pluginWebBrowser.Refresh();
        }

        private void onCancel(object sender, EventArgs e)
        {
            this.Close();
        }

        private void onOpenVisualStudio(object sender, EventArgs e)
        {
            CompilationSourceFileName = string.Concat(_pluginNameTbox.Text, ".cs");
            var compilationDirectory = DirectoryHelper.PluginComplationDirectory;
            var compilationProject = new Project(Path.Combine(compilationDirectory, "PluginLibrary.csproj"));

            CompilationSourceFile = Path.Combine(compilationDirectory, CompilationSourceFileName);

            if (!File.Exists(CompilationSourceFile))
                File.Create(CompilationSourceFile).Close();

            compilationProject.AddItem("Compile", CompilationSourceFile);
            compilationProject.Save();


            _pluginNameTbox.Enabled = false;
            Process.Start(compilationProject.FullPath);
        }

        private void onTextChanged(object sender, EventArgs e)
        {
            _vsLinkBtn.Enabled = string.IsNullOrEmpty(_pluginNameTbox.Text) ? false : true;
            onComboSelected(sender, e);
        }

        private void onCreatePlugin(object sender, EventArgs e)
        {
            //Update the CalculatorManagerUI


            //Compile the Plugin to DLL
            string codeToCompile = File.ReadAllText(CompilationSourceFile);
            var dllFile = Path.Combine(DirectoryHelper.PluginDLLsDirectory, string.Concat(_pluginNameTbox.Text, ".dll"));
            if (!CompilePluginToDLL(codeToCompile, dllFile))
                MessageBox.Show("There were Compilation Errors. Please check your code");

        }

        private void onComboSelected(object sender, EventArgs e)
        {
            string operatorType = _operatorTypeComboBox.SelectedItem == _operatorTypeComboBox.Items[0] ? "IUnaryOperator" : "IBinaryOperator";
            string pluginName = string.IsNullOrEmpty(_pluginNameTbox.Text) ? "[Plugin Name]" : _pluginNameTbox.Text;
            DisplayPluginSignature(operatorType, pluginName);
        }

        private bool CompilePluginToDLL(string codeToCompile, string dllFileName)
        {
            CSharpCodeProvider provider = new CSharpCodeProvider();
            CompilerParameters parameters = new CompilerParameters()
            {
                GenerateInMemory = false,
                GenerateExecutable = false,
                OutputAssembly = dllFileName
            };
            parameters.ReferencedAssemblies.Add("DomainObjects.dll");

            CompilerResults results = provider.CompileAssemblyFromSource(parameters, codeToCompile);
            if (results.Errors.Count != 0)
                return false;
            return true;
        }
    }
}
