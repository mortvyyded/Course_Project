using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpGL;

namespace SharpGL_My_First_Model
{
    public partial class Form1 : Form
    {
        float rotation = 0.0f; // переменная, которая будет задавать угол поворота

        public Form1()
        {
            InitializeComponent();
        }

        private void openglControl1_Load(object sender, EventArgs e)
        {
            //  Возьмём OpenGL объект
            OpenGL gl = openglControl1.OpenGL;

            //  Очищаем буфер цвета и глубины
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            //  Загружаем единичную матрицу
            gl.LoadIdentity();

            //  Указываем оси вращения (x, y, z)
            gl.Rotate(rotation, 0.0f, 1.0f, 0.0f);

            // рисуем крышу
            gl.Begin(OpenGL.GL_TRIANGLES);

            gl.Color(1f, 0.2f, 0.0f); // здесь задаём цвет для каждой плоскости
            gl.Vertex(0.0f, 2.5f, 0.0f);
            gl.Vertex(2.0f, 1.5f, -2.0f);
            gl.Vertex(2.0f, 1.5f, 2.0f);

            gl.Color(1f, 0.3f, 0.0f);
            gl.Vertex(-2.0f, 1.5f, -2.0f);
            gl.Vertex(-2.0f, 1.5f, 2.0f);
            gl.Vertex(0.0f, 2.5f, 0.0f);

            gl.Color(1f, 0.4f, 0.0f);
            gl.Vertex(0.0f, 2.5f, 0.0f);
            gl.Vertex(2.0f, 1.5f, -2.0f);
            gl.Vertex(-2.0f, 1.5f, -2.0f);

            gl.Color(1f, 0.1f, 0.0f);
            gl.Vertex(0.0f, 2.5f, 0.0f);
            gl.Vertex(-2.0f, 1.5f, 2.0f);
            gl.Vertex(2.0f, 1.5f, 2.0f);

            gl.End();

            // передняя часть дома
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(1f, 1f, 0f);
            gl.Vertex(2f, 1.5f, -2f);
            gl.Vertex(2f, 0f, -2f);
            gl.Vertex(-2f, 0f, -2f);
            gl.Vertex(-2f, 1.5f, -2f);

            gl.End();

            // правая часть дома
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(1f, 0.8f, 0f);
            gl.Vertex(2f, 0f, -2f);
            gl.Vertex(2f, 0f, 2f);
            gl.Vertex(2f, 1.5f, 2f);
            gl.Vertex(2f, 1.5f, -2f);
            gl.End();

            // задняя часть дома
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(1f, 0.7f, 0f);
            gl.Vertex(2f, 0f, 2f);
            gl.Vertex(-2f, 0f, 2f);
            gl.Vertex(-2f, 1.5f, 2f);
            gl.Vertex(2f, 1.5f, 2f);
            gl.End();

            // левая часть дома
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(1f, 0.9f, 0f);
            gl.Vertex(-2f, 0f, -2f);
            gl.Vertex(-2f, 0f, 2f);
            gl.Vertex(-2f, 1.5f, 2f);
            gl.Vertex(-2f, 1.5f, -2f);
            gl.End();

            // дверь (передняя стена)
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(1f, 0.5f, 0f);
            gl.Vertex(0.3f, 0f, -2.01f);
            gl.Vertex(-0.3f, 0f, -2.01f);
            gl.Vertex(-0.3f, 1.2f, -2.01f);
            gl.Vertex(0.3f, 1.2f, -2.01f);
            gl.End();

            // рисуем землю            
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0f, 1f, 0f);
            gl.Vertex(-10f, 0f, -10f);
            gl.Vertex(10f, 0f, -10f);
            gl.Vertex(10f, 0f, 10f);
            gl.Vertex(-10f, 0f, 10f);
            gl.End();

            rotation += 1.5f; // угол разворота за 1 кадр
        }

        // Эту функцию используем для задания некоторых значений по умолчанию
        private void openGLControl_OpenGLInitialized(object sender, EventArgs e)
        {
            //  Возьмём OpenGL объект
            OpenGL gl = openglControl1.OpenGL;

            //  Фоновый цвет по умолчанию (в данном случае цвет голубой)
            gl.ClearColor(0.1f, 0.5f, 1.0f, 0);
        }

        // Данная функция используется для преобразования изображения 
        // в объёмный вид с перспективой
        private void openGLControl_Resized(object sender, EventArgs e)
        {
            //  Возьмём OpenGL объект
            OpenGL gl = openglControl1.OpenGL;

            //  Зададим матрицу проекции
            gl.MatrixMode(OpenGL.GL_PROJECTION);

            //  Единичная матрица для последующих преобразований
            gl.LoadIdentity();

            //  Преобразование
            gl.Perspective(60.0f, (double)Width / (double)Height, 0.01, 100.0);

            //  Данная функция позволяет установить камеру и её положение
            gl.LookAt(-5, 3, -6,    // Позиция самой камеры (x, y, z)
                        0, 1, 0,     // Направление, куда мы смотрим
                        0, 2, 0);    // Верх камеры

            //  Зададим модель отображения
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
        }
    }
}
