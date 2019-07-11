using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jubyLang
{
    public partial class Form1 : Form
    {
        string tempLater = File.ReadAllText("template.txt");
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string coodete = richTextBox1.Text;
            var lines = coodete.Split('\n');
            var specificLine = lines[0];
            bool DoRepeat = true;
            string spr;
            int i = 0;
            string java = "SuperNPC";
            deguug deguug = new deguug();
            deguug.Show();
            while (DoRepeat == true)
            {

                specificLine = lines[i];
                if (specificLine.Contains("badosz"))
                {
                    spr = specificLine.Remove(0,7);
                    deguug.richTextBox1.Text += spr + "\n";
                    tempLater += "Console.WriteLine(" + '"' + spr + '"' + ");";
                }
                if (specificLine.Contains("java ="))
                {
                    java = specificLine.Remove(0, 6);
                }
                if (specificLine == "java")
                {
                    deguug.richTextBox1.Text += java + "\n";
                }
                else if (specificLine == "nie banuj")
                {
                    deguug.richTextBox1.Text += "nie banuj pls" + "\n";
                }
                else if (specificLine == "microsoft/vscode")
                {
                    deguug.richTextBox1.Text += File.ReadAllText("issues.txt") + "\n";
                }
                i++;
                if (i == richTextBox1.Text.Split('\n').Length)
                {
                    DoRepeat = false;
                    tempLater += File.ReadAllText("templateend.txt");
                    CompileSCS();
                    //output uot = new output();
                    //uot.Show();
                    //uot.richTextBox1.Text = tempLater;
                }
            }
        }
        public void CompileSCS()
        {

            CSharpCodeProvider codeProvider = new CSharpCodeProvider();
            ICodeCompiler icc = codeProvider.CreateCompiler();
            string Output = "smiec.exe";
            deguug debyge = new deguug();
            System.CodeDom.Compiler.CompilerParameters parameters = new CompilerParameters
            {
                GenerateExecutable = true,
                OutputAssembly = Output
            };
            CompilerResults results = icc.CompileAssemblyFromSource(parameters, tempLater);
            if (results.Errors.Count > 0)
            {
                debyge.richTextBox1.ForeColor = Color.Red;
                foreach (CompilerError CompErr in results.Errors)
                {
                    debyge.richTextBox1.Text = debyge.richTextBox1.Text +
                                "Line number " + CompErr.Line +
                                ", Error Number: " + CompErr.ErrorNumber +
                                ", '" + CompErr.ErrorText + ";" +
                                Environment.NewLine + Environment.NewLine;
                }
            }
            else
            {
                //Successful Compile
                debyge.richTextBox1.ForeColor = Color.Blue;
                debyge.richTextBox1.Text = "Success!";

            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CompileSCS();
        }
    }
}
