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
    public partial class Form2 : Form
    {
        public bool kreni { get; private set; }
        public bool stafeta { get; private set; }
        public bool standardna { get; private set; }
        public bool reset { get; private set; }
        public static int max;
        Keys key;

        public Form2()
        {   
            InitializeComponent();
        }
        
   
        Plivac plivac1 = new Plivac(20, 20, Form1.brzina1, Form1.b1, Form1.ime1);
        Plivac plivac2 = new Plivac(20, 80, Form1.brzina2, Form1.b2, Form1.ime2);
        Plivac plivac3 = new Plivac(20, 140, Form1.brzina3, Form1.b3, Form1.ime3);
        Plivac plivac4 = new Plivac(20, 200, Form1.brzina4, Form1.b4, Form1.ime4);
        Traka traka = new Traka();

        public void Winner()
        {
            int flag_pobednik;

            max = Form1.brzina1;
            flag_pobednik = 1;

            if (max < Form1.brzina2)
            {
                max = Form1.brzina2;
                flag_pobednik = 2;
            }

            if (max < Form1.brzina3)
            {
                max = Form1.brzina3;
                flag_pobednik = 3;
            }

            if (max < Form1.brzina4)
            {
                max = Form1.brzina4;
                flag_pobednik = 4;
            }

            switch (flag_pobednik)
            {
                case 1:
                    MessageBox.Show("Pobednik je" + Form1.ime1);
                    break;
                case 2:
                    MessageBox.Show("Pobednik je" + Form1.ime2);
                    break;
                case 3:
                    MessageBox.Show("Pobednik je" + Form1.ime3);
                    break;
                case 4:
                    MessageBox.Show("Pobednik je" + Form1.ime4);
                    break;
                default:
                    break;
            }
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            
            plivac1.Save();
            plivac2.Save();
            plivac3.Save();
            plivac4.Save();

           Gametimer1.Start();

            traka.Draw(e);
            plivac1.Draw(e);
            plivac2.Draw(e);
            plivac3.Draw(e);
            plivac4.Draw(e);

            if (reset == true)
            {
                plivac1.Reset();
                plivac2.Reset();
                plivac3.Reset();
                plivac4.Reset();
                reset = false;
            }

            if (kreni == true && (standardna || stafeta ))
            {
                if(standardna == true)
                {
                    plivac1.PlivacMove();
                    plivac2.PlivacMove();
                    plivac3.PlivacMove();
                    plivac4.PlivacMove();

                    //Winner();
                }

                if (stafeta == true)
                {
                    if (Plivac.PredajStafetu == 1)
                    {
                        plivac1.PlivacStafeta();
                    }

                    if (Plivac.PredajStafetu == 2)
                    {
                        plivac2.PlivacStafeta();
                    }

                    if (Plivac.PredajStafetu == 3)
                    {
                        plivac3.PlivacStafeta();
                    }

                    if (Plivac.PredajStafetu == 4)
                    {
                        plivac4.PlivacStafeta();
                    }
                }                
            }   
        }
        private void Gametimer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reset = false;
            kreni = true;          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kreni = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           kreni = false;
           reset = true;
        }
        
        private void button5_Click(object sender, EventArgs e)
        {
            plivac1.Reset();
            plivac2.Reset();
            plivac3.Reset();
            plivac4.Reset();
            stafeta = false;
            standardna = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            plivac1.Reset();
            plivac2.Reset();
            plivac3.Reset();
            plivac4.Reset();
            stafeta = true;
            standardna = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            plivac1.Reset();
            plivac2.Reset();
            plivac3.Reset();
            plivac4.Reset();
            stafeta = false;
            standardna = false;
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            key = e.KeyCode;
        }
    }
}
