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
                }
            }
        }
        public static string StringToBinary(string data)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in data.ToCharArray())
            {
                sb.Append(Convert.ToString(c, 2).PadLeft(8, '0'));
            }
            return sb.ToString();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            string coodete = richTextBox1.Text;
            var lines = coodete.Split('\n');
            var specificLine = lines[0];
            bool DoRepeat = true;
            string spr;
            int i = 0;
            string java = "SuperNPC";
            string fina = "";
            while (DoRepeat == true)
            {

                specificLine = lines[i];
                if (specificLine.Contains("badosz"))
                {
                    spr = specificLine.Remove(0, 7);
                    fina += "badosz " + spr + "\n";
                }
                if (specificLine.Contains("java ="))
                {
                    java = specificLine.Remove(0, 6);
                    fina += specificLine;
                }
                if (specificLine == "java")
                {
                    fina += java + "\n";
                }
                i++;
                if (i == richTextBox1.Text.Split('\n').Length)
                {
                    DoRepeat = false;
                }
            }
            MessageBox.Show(StringToBinary(fina));
            File.WriteAllText(saveFileDialog1.FileName + ".jlexe", StringToBinary(fina));
        }
            public static string BinaryToString(string data)
            {
                List<Byte> byteList = new List<Byte>();

                for (int i = 0; i < data.Length; i += 8)
                {
                    byteList.Add(Convert.ToByte(data.Substring(i, 8), 2));
                }
                return Encoding.ASCII.GetString(byteList.ToArray());
            }
        private void Button3_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            string coodete = BinaryToString(File.ReadAllText(openFileDialog1.FileName));
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
                    spr = specificLine.Remove(0, 7);
                    deguug.richTextBox1.Text += spr + "\n";
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
                }
            }
        }
    }
}
