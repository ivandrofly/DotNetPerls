using System;
using System.Drawing;
using System.Windows.Forms;

namespace RichTextBox_Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.Font = new Font("Consolas", 18f, FontStyle.Bold);
            richTextBox1.BackColor = Color.AliceBlue;
            string[] words = { "Dot", "Net", "Perls", "is", "a", "nice", "website." };
            Color[] colors = { Color.Aqua, Color.CadetBlue, Color.Cornsilk, Color.Gold, Color.HotPink, Color.Lavender, Color.Moccasin };
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];
                Color color = colors[i];
                {
                    richTextBox1.SelectionBackColor = color;
                    richTextBox1.AppendText(word);
                    richTextBox1.SelectionBackColor = Color.AliceBlue;
                    richTextBox1.AppendText(" ");
                }
            }
        }
    }
}

//Output of the example
//    Please see image at top.