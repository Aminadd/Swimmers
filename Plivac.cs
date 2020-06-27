using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Zadatak_ispit1_plivaci
{
    class Plivac
    {
        public string ime { get; set; }
        public int brzina { get; set; }
        public int boja { get; set; }
        public int b { get; set; }
        public int i { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int k { get; set; }
        public int x1 { get; set; }

        public int y1 { get; set; }
        public int brojac = 0;
        private int promenaSmera = 2;
        public static int PredajStafetu = 1;
        public const int MAXR = 320;


        public Plivac(int x, int y,  int brzina, int boja, string ime)
        {
            this.X = x;
            this.Y = y;
            this.boja = boja;
            this.brzina = brzina;
            this.ime = ime;
        }

        public void PlivacMove()
        {
            if(this.X >= 310)
            {
                k++;
                Form1.Sice = 1;
            }
            if(k == 0)
            {
                MoveRight();
            }
        }

        public void PlivacStafeta()
        {
            if (promenaSmera < 4)
            {
                if (promenaSmera % 2 == 0)
                {
                    if (this.X >= 300)
                    {
                        promenaSmera++;
                    }
                    MoveRight();
                }
                else
                {
                    if (this.X <= 45)
                    {
                        promenaSmera++;
                    }
                    MoveLeft();
                }
            }
            else
            {
                PredajStafetu++;
            }
        }

        public void Draw(PaintEventArgs e)
        {
            Font font = new Font("Courier New", 12, FontStyle.Bold);
            switch (boja)
            {
                case 1:
                    ime = ime.Substring(0,1);              

                    e.Graphics.FillEllipse(Brushes.Purple, this.X, this.Y, 20, 20);
                    e.Graphics.DrawString(ime, font, Brushes.White, this.X + 2, this.Y + 1);
                    break;
                case 2:
                    ime = ime.Substring(0, 1);

                    e.Graphics.FillEllipse(Brushes.Orange, this.X, this.Y, 20, 20);
                    e.Graphics.DrawString(ime, font, Brushes.White, this.X + 2, this.Y + 1);
                    break;
                case 3:
                    ime = ime.Substring(0, 1);

                    e.Graphics.FillEllipse(Brushes.Green, this.X, this.Y, 20, 20);
                    e.Graphics.DrawString(ime, font, Brushes.White, this.X + 2, this.Y + 1);
                    break;
                case 4:
                    ime = ime.Substring(0, 1);

                    e.Graphics.FillEllipse(Brushes.Black, this.X, this.Y, 20, 20);
                    e.Graphics.DrawString(ime, font, Brushes.White, this.X + 2, this.Y + 1);
                    break;
                default:
                    break;
            }
        }

        public void MoveRight()
        {
            this.X += this.brzina;
            if(this.X >= MAXR)
            {
                this.X = MAXR;
            }
        }
        public void MoveLeft()
        {
            this.X -= this.brzina;
        }
        public void Save()
        {
            if(brojac == 0)
            {
                x1 = this.X;
                y1 = this.Y;
                brojac++;
            }
        }

        public void Reset()
        {
            this.X = x1;
            this.Y = y1;
            k = 0;
            PredajStafetu = 1;
            promenaSmera = 2;
        }
    }
}
