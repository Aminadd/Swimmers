using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak_ispit1_plivaci
{
    public partial class Form1 : Form
    {
        //Ove prosledjujemo u Form2
        public static string ime1;
        public static string ime2;
        public static string ime3;
        public static string ime4;

        public static int brzina1;
        public static int brzina2;
        public static int brzina3;
        public static int brzina4;

        public static int b1;
        public static int b2;
        public static int b3;
        public static int b4;

        public static int Sice = 0;

        //Ove koristimo samo u ovoj formi
        public int boja { get; set; }
        public int sts { get; set; }
       
        public Form1()
        {
            InitializeComponent();
            boja = 5;
            sts = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (sts)
            {
                case 1:
                    if (textBox1.TextLength != 0 && textBox2.TextLength != 0 && boja != 5)
                    {
                        b1 = boja;
                        ime1 = textBox1.Text;
                        brzina1 = int.Parse(textBox2.Text.ToString());
                        sts++;                 
                    }
                    break;
                case 2:
                    if (textBox1.TextLength != 0 && textBox2.TextLength != 0 && boja != 5)
                    {
                        b2 = boja;
                        ime2 = textBox1.Text;
                        brzina2 = int.Parse(textBox2.Text.ToString());
                        sts++;
                    }
                    break;
                case 3:
                    if (textBox1.TextLength != 0 && textBox2.TextLength != 0 && boja != 5)
                    {
                        b3 = boja;
                        ime3 = textBox1.Text;
                        brzina3 = int.Parse(textBox2.Text.ToString());
                        sts++;
                    }
                    break;
                case 4:
                    if (textBox1.TextLength != 0 && textBox2.TextLength != 0 && boja != 5)
                    {
                        b4 = boja;
                        ime4 = textBox1.Text;
                        brzina4 = int.Parse(textBox2.Text.ToString());
                        sts++;
                    }
                    break;
                default:
                    break;
            }
            if(sts == 5)
            {

               Form2 frm2 = new Form2();
               frm2.ShowDialog();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            boja = 4; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            boja = 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            boja = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            boja = 1;
        }
    }
}
