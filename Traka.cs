using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak_ispit1_plivaci
{
    class Traka
    {
        public void Draw(PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.Red, 10, 10, 340, 50);
            e.Graphics.FillRectangle(Brushes.Blue, 12, 12, 336, 46);

            e.Graphics.FillRectangle(Brushes.Red, 10, 70, 340, 50);
            e.Graphics.FillRectangle(Brushes.Blue, 12, 72, 336, 46);

            e.Graphics.FillRectangle(Brushes.Red, 10, 130, 340, 50);
            e.Graphics.FillRectangle(Brushes.Blue, 12, 132, 336, 46);

            e.Graphics.FillRectangle(Brushes.Red, 10, 190, 340, 50);
            e.Graphics.FillRectangle(Brushes.Blue, 12, 192, 336, 46);

        }
    }
}
