using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpellCorrector
{
    public partial class Form1 : Form
    {
        private string[] lines;
        private Levenshtein check = new Levenshtein();
        private List<KeyValuePair<int, string>> word;
        public bool autocorrect = false;
        public Form1()
        {
            InitializeComponent();
            lines = File.ReadAllLines(@"C:\Users\Sattar\Downloads\Stuff\words");
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 32)
            {
                var tokens = textBox1.Text.Split();

                if ((tokens.Last() == " " || tokens.Last() == "") && (textBox1.SelectionStart == textBox1.Text.Length))
                {
                    return;
                }

                if (autocorrect == false)
                {
                    string last = tokens.Last();
                    word = check.CalculationDistance(lines, last);
                    word = word.OrderBy(d => d.Key).ToList();
                    tokens[tokens.Length - 1] = word[0].Value;
                    comboBox1.Items.Clear();
                    for (int i = 0; i < 10; i++)
                    {
                        comboBox1.Items.Add(word[i].Value);
                    }
                }
                if (autocorrect == true)
                {
                    int pos = textBox1.SelectionStart-1;
                    string all = textBox1.Text;
                    string wword = " ";
                    int lastpos = 0;
                    for (int i=pos; i>=0; i--)
                    {
                        if (all[i]==' ')
                        {
                            lastpos = i+1;
                            break;
                        }
                        else
                        {
                            wword += all[i];
                        }
                    }
                    char[] temp = wword.ToCharArray();
                    Array.Reverse(temp);
                    wword = new string(temp);
                    word = check.CalculationDistance(lines, wword);
                    Debug.WriteLine(wword);
                    word = word.OrderBy(d => d.Key).ToList();
                    Debug.WriteLine(word[0].Value);
                    all = all.Remove(lastpos, pos - lastpos + 1);
                    Debug.WriteLine(lastpos + " " + pos);
                    all = all.Insert(lastpos, word[0].Value + ' ');
                    textBox1.Clear();
                    textBox1.Text = all;
                    textBox1.SelectionStart = textBox1.Text.Length;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void autocorrect_btn_Click(object sender, EventArgs e)
        {
            if (autocorrect == false)
            {
                autocorrect = true;
                button3.BackColor = Color.Green;
            }
            else
            {
                autocorrect = false;
                button3.BackColor = Color.Red;
            }
        }

        private void change_btn_Click(object sender, EventArgs e)
        {
            string[] tokens = textBox1.Text.Split();
            tokens[tokens.Length-2] = comboBox1.SelectedItem.ToString();

            textBox1.Clear();
            textBox1.AppendText(String.Join(" ", tokens));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
