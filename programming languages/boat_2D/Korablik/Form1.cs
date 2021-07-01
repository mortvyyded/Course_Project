using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Korablik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Объявляем объект "g" класса Graphics и предоставляем
            // ему возможность рисования на pictureBox1:
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.PaleTurquoise);
            // Создаем объекты-кисти для закрашивания фигур
            SolidBrush myCorp = new SolidBrush(Color.Black);
            SolidBrush myTrum = new SolidBrush(Color.White);
            SolidBrush myTrub = new SolidBrush(Color.Gold);
            SolidBrush myTrub1 = new SolidBrush(Color.DimGray);
            SolidBrush mySeа = new SolidBrush(Color.Turquoise);
            SolidBrush myWaterline = new SolidBrush(Color.Red);
            SolidBrush myStick = new SolidBrush(Color.DimGray);
            SolidBrush myStick1 = new SolidBrush(Color.DimGray);
            SolidBrush myColor = new SolidBrush(Color.White);
            SolidBrush myColor1 = new SolidBrush(Color.Blue);
            SolidBrush myColor2 = new SolidBrush(Color.Red);
            SolidBrush myColor3 = new SolidBrush(Color.Green);
            SolidBrush myColor4 = new SolidBrush(Color.White);
            SolidBrush myColor5 = new SolidBrush(Color.Red);
            //Выбираем перо myPen чёрного цвета цвета толщиной в 2 пикселя:
            Pen myWind = new Pen(Color.Black, 2);
            // Закрашиваем фигуры
            g.FillRectangle(myStick, 125, 250, 5, 50); // палка для российского флага
            g.FillRectangle(myColor, 125, 250, 40, 10); // белый цвет
            g.FillRectangle(myColor1, 125, 260, 40, 10); // синий цвет
            g.FillRectangle(myColor2, 125, 270, 40, 10); // красный цвет
            g.FillRectangle(myStick1, 635, 250, 5, 50); // палка для татарстанского флага
            g.FillRectangle(myColor3, 635, 250, 40, 10); // зеленый цвет
            g.FillRectangle(myColor4, 635, 260, 40, 3); // белый цвет
            g.FillRectangle(myColor5, 635, 263, 40, 10); // красный цвет
            g.FillRectangle(myTrub, 300, 125, 75, 75); // 1 труба (прямоугольник)
            g.FillRectangle(myTrub, 480, 125, 75, 75); // 2 труба (прямоугольник)
            g.FillRectangle(myTrub1, 310, 70, 55, 55); // 1 труба маленькая (прямоугольник)
            g.FillRectangle(myTrub1, 490, 70, 55, 55); // 2 труба маленькая (прямоугольник)
            g.FillPolygon(myCorp, new Point[]      // корпус (трапеция)
              {
    new Point(100,300),new Point(700,300),
    new Point(700,300),new Point(600,400),
    new Point(600,400),new Point(200,400),
    new Point(200,400),new Point(100,300)
              }
            );
            g.FillPolygon(myWaterline, new Point[]
{
    new Point(170,370),new Point(630,370),
    new Point(700,300),new Point(600,400),
    new Point(600,400),new Point(200,400),
    new Point(200,400),new Point(100,300)
}
);
            g.FillRectangle(myTrum, 250, 200, 350, 100); // палуба (прямоугольник)
                                                         // Море - 12 секторов-полуокружностей
            int x = 50;
            int Radius = 50;
            while (x <= pictureBox1.Width - Radius)
            {
                g.FillPie(mySeа, 0 + x, 375, 50, 50, 0, -180);
                x += 50;
            }
            // Иллюминаторы 
            for (int y = 300; y <= 550; y += 50)
            {
                g.DrawEllipse(myWind, y, 240, 20, 20); // 6 окружностей
            }
        }
    }
}
