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
        float rotation = 0.0f;

        

        public Form1()
        {
            InitializeComponent();
        }

        private void openglControl1_OpenGLDraw(object sender, SharpGL.RenderEventArgs args)
        {
            OpenGL gl = openglControl1.OpenGL;
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
            gl.LoadIdentity();
            gl.Rotate(rotation, 0.0f, 1.0f, 0.0f);

            //ДНО 1
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.1, 0.1, 0.1);
            gl.Vertex(-2, 0 , -1.5);
            gl.Vertex(2, 0, -1.5);
            gl.Vertex(2, 0, 2.5);
            gl.Vertex(-2, 0, 2.5);
            gl.End();

            //ДНО 2
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.1, 0.1, 0.1);
            gl.Vertex(-1.5, 0, -4);
            gl.Vertex(1.5, 0, -4);
            gl.Vertex(1.5, 0, -1);
            gl.Vertex(-1.5, 0, -1);
            gl.End();

            //ДНО 3
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.1, 0.1, 0.1);
            gl.Vertex(-2, 0, -4);
            gl.Vertex(2, 0, -4);
            gl.Vertex(2, 0, -3);
            gl.Vertex(-2, 0, -3);
            gl.End();

            //ДНО 4
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.1, 0.1, 0.1);
            gl.Vertex(-1.5, 0, 4);
            gl.Vertex(1.5, 0, 4);
            gl.Vertex(1.5, 0, 1);
            gl.Vertex(-1.5, 0, 1);
            gl.End();

            //ДНО 5
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.1, 0.1, 0.1);
            gl.Vertex(-1, 0, 6);
            gl.Vertex(1, 0, 6);
            gl.Vertex(1, 0, 5);
            gl.Vertex(-1, 0, 5);
            gl.End();

            //БАМПЕР ПЕРЕД 1
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.5, 0.5, 0.5);
            gl.Vertex(-1, 0, 6);
            gl.Vertex(1, 0, 6);
            gl.Vertex(1, 1, 6);
            gl.Vertex(-1, 1, 6);
            gl.End();
            
            //БАМПЕР ЗАД 1
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.5, 0.5, 0.5);
            gl.Vertex(-2, 0, -4);
            gl.Vertex(2, 0, -4);
            gl.Vertex(2, 1, -4);
            gl.Vertex(-2, 1, -4);
            gl.End();


            //БАГАЖНИК 1 
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.5, 0.5, 0.5);
            gl.Vertex(-2, 1, -4);
            gl.Vertex(2, 1, -4);
            gl.Vertex(2, 1.3, -2.5);
            gl.Vertex(-2, 1.3, -2.5);
            gl.End();

            //КАПОТ 1
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.5, 0.5, 0.5);
            gl.Vertex(-1, 1, 6);
            gl.Vertex(1, 1, 6);
            gl.Vertex(2, 1.3, 2.5);
            gl.Vertex(-2, 1.3, 2.5);
            gl.End();

            //СТЕКО ПЕРЕД
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.5, 0.5, 0.5);
            gl.Vertex(-2, 1.3,2.5);
            gl.Vertex(2, 1.3, 2.5);
            gl.Vertex(2, 2.7, 2);
            gl.Vertex(-2, 2.7, 2);
            gl.End();

            //СТЕКО ЗАД
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.5, 0.5, 0.5);
            gl.Vertex(-2, 1.3, -2.5);
            gl.Vertex(2, 1.3, -2.5);
            gl.Vertex(2, 2.7, -2);
            gl.Vertex(-2, 2.7, -2);
            gl.End();

            //крыша
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.5, 0.5, 0.5);
            gl.Vertex(-2, 2.7, -2);
            gl.Vertex(2, 2.7, -2);
            gl.Vertex(2, 2.7, 2);
            gl.Vertex(-2, 2.7, 2);
            gl.End();

            //фары перед
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(3.1, 0.8, 0.1);
            gl.Vertex(1.8, 0.2, 5.01);
            gl.Vertex(1.6, 0.2, 5.01);
            gl.Vertex(1.6, 0.8, 5.01);
            gl.Vertex(1.8, 0.8, 5.01);
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(3.1, 0.8, 0.1);
            gl.Vertex(-1.8, 0.2, 5.01);
            gl.Vertex(-1.6, 0.2, 5.01);
            gl.Vertex(-1.6, 0.8, 5.01);
            gl.Vertex(-1.8, 0.8, 5.01);
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.5, 1, 1.5);
            gl.Vertex(1.6, 0.2, 5.01);
            gl.Vertex(1, 0.2, 5.01);
            gl.Vertex(1, 0.8, 5.01);
            gl.Vertex(1.6, 0.8, 5.01);
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.5, 1, 1.5);
            gl.Vertex(-1.6, 0.2, 5.01);
            gl.Vertex(-1, 0.2, 5.01);
            gl.Vertex(-1, 0.8, 5.01);
            gl.Vertex(-1.6, 0.8, 5.01);
            gl.End();

            //Радиатор
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.2, 0.2, 0.2);
            gl.Vertex(-0.5, 0.1, 6.01);
            gl.Vertex(0.5, 0.1, 6.01);
            gl.Vertex(0.5, 0.9, 6.01);
            gl.Vertex(-0.5, 0.9, 6.01);
            gl.End();

            //фары зад
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(3.1, 0.8, 0.1);
            gl.Vertex(1.8, 0.2, -4.01);
            gl.Vertex(1.6, 0.2, -4.01);
            gl.Vertex(1.6, 0.8, -4.01);
            gl.Vertex(1.8, 0.8, -4.01);
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(3.1, 0.8, 0.1);
            gl.Vertex(-1.8, 0.2, -4.01);
            gl.Vertex(-1.6, 0.2, -4.01);
            gl.Vertex(-1.6, 0.8, -4.01);
            gl.Vertex(-1.8, 0.8, -4.01);
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.6, 0.1, 0.1);
            gl.Vertex(1.6, 0.2, -4.01);
            gl.Vertex(1, 0.2, -4.01);
            gl.Vertex(1, 0.8, -4.01);
            gl.Vertex(1.6, 0.8, -4.01);
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.6, 0.1, 0.1);
            gl.Vertex(-1.6, 0.2, -4.01);
            gl.Vertex(-1, 0.2, -4.01);
            gl.Vertex(-1, 0.8, -4.01);
            gl.Vertex(-1.6, 0.8, -4.01);
            gl.End();

            //Колесо перед
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.5, 0.5, 0.5);
            gl.Vertex(-1, 0, 4);
            gl.Vertex(1, 0, 4);
            gl.Vertex(1, 0.7, 3.8);
            gl.Vertex(-1, 0.7, 3.8);
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.5, 0.5, 0.5);
            gl.Vertex(-1, 0, 2.5);
            gl.Vertex(1, 0, 2.5);
            gl.Vertex(1, 0.7, 2.9);
            gl.Vertex(-1, 0.7, 2.9);
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.5, 0.5, 0.5);
            gl.Vertex(-1, 0.7, 3.8);
            gl.Vertex(1, 0.7, 3.8);
            gl.Vertex(1, 0.7, 2.9);
            gl.Vertex(-1, 0.7, 2.9);
            gl.End();

            //Колесо зад
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.5, 0.5, 0.5);
            gl.Vertex(-2, 0, -3);
            gl.Vertex(2, 0, -3);
            gl.Vertex(2, 0.7, -2.7);
            gl.Vertex(-2, 0.7, -2.7);
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.5, 0.5, 0.5);
            gl.Vertex(-2, 0, -1.5);
            gl.Vertex(2, 0, -1.5);
            gl.Vertex(2, 0.7, -1.9);
            gl.Vertex(-2, 0.7, -1.9);
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.5, 0.5, 0.5);
            gl.Vertex(-2, 0.7, -2.7);
            gl.Vertex(2, 0.7, -2.7);
            gl.Vertex(2, 0.7, -1.9);
            gl.Vertex(-2, 0.7, -1.9);
            gl.End();

           
            //двери 1
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.5, 0.5, 0.5);
            gl.Vertex(-2, 0, -1.5);
            gl.Vertex(-2, 0, 2.5);
            gl.Vertex(-1, 1.2, 3.3);
            gl.Vertex(-1, 1.3, 2.5);
            gl.Vertex(-2, 2.7, 2);
            gl.Vertex(-2, 2.7, -2);
            gl.Vertex(-2, 1.3, -2.5);
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.5, 0.5, 0.5);
            gl.Vertex(-2, 0, -4);
            gl.Vertex(-2, 1, -4);
            gl.Vertex(-2, 1.3, -2.4);
            gl.Vertex(-2, 0, -3);            
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.5, 0.5, 0.5);
            gl.Vertex(-1, 0, 6);
            gl.Vertex(-1, 1, 6);
            gl.Vertex(-1, 1.2, 3.2);
            gl.Vertex(-1, 0, 4);
            gl.End();           

            gl.Begin(OpenGL.GL_TRIANGLES);
            gl.Color(0.5, 0.5, 0.5);
            gl.Vertex(-2, 0.7, -2);
            gl.Vertex(-2, 0.7, -2.8);
            gl.Vertex(-2, 1.3, -2.5);
            gl.End();

            //двери 2
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.5, 0.5, 0.5);
            gl.Vertex(2, 0, -1.5);
            gl.Vertex(2, 0, 2.5);
            gl.Vertex(1, 1.2, 3.3);
            gl.Vertex(1, 1.3, 2.5);
            gl.Vertex(2, 2.7, 2);
            gl.Vertex(2, 2.7, -2);
            gl.Vertex(2, 1.3, -2.5);
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.5, 0.5, 0.5);
            gl.Vertex(2, 0, -4);
            gl.Vertex(2, 1, -4);
            gl.Vertex(2, 1.3, -2.4);
            gl.Vertex(2, 0, -3);
            gl.End();

            gl.Begin(OpenGL.GL_TRIANGLES);
            gl.Color(0.5, 0.5, 0.5);
            gl.Vertex(2, 0.7, -2);
            gl.Vertex(2, 0.7, -2.8);
            gl.Vertex(2, 1.3, -2.5);
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.5, 0.5, 0.5);
            gl.Vertex(1, 0, 6);
            gl.Vertex(1, 1, 6);
            gl.Vertex(1, 1.2, 3.2);
            gl.Vertex(1, 0, 4);
            gl.End();

            //Стекло перед
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.9, 0.9, 0.9);
            gl.Vertex(-1.9, 1.4, 2.5);
            gl.Vertex(1.9, 1.4, 2.5);
            gl.Vertex(1.9, 2.6, 2.1);
            gl.Vertex(-1.9, 2.6, 2.1);
            gl.End();

            //СТЕКО ЗАД
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.9, 0.9, 0.9);
            gl.Vertex(-1.9, 1.4, -2.5);
            gl.Vertex(1.9, 1.4, -2.5);
            gl.Vertex(1.9, 2.6, -2.1);
            gl.Vertex(-1.9, 2.6, -2.1);
            gl.End();

            //Стекло дверь
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.9, 0.9, 0.9);
            gl.Vertex(2.01, 1.3, 0.3);
            gl.Vertex(2.01, 2.5, 0.3);
            gl.Vertex(2.01, 2.5, 2);
            gl.Vertex(2.01, 1.3, 2.4);
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.9, 0.9, 0.9);
            gl.Vertex(-2.01, 1.3, 0.3);
            gl.Vertex(-2.01, 2.5, 0.3);
            gl.Vertex(-2.01, 2.5, 2);
            gl.Vertex(-2.01, 1.3, 2.4);
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.9, 0.9, 0.9);
            gl.Vertex(2.01, 1.3, -0.3);
            gl.Vertex(2.01, 2.5, -0.3);
            gl.Vertex(2.01, 2.5, -2);
            gl.Vertex(2.01, 1.3, -2.4);
            gl.End();

            gl.Begin(OpenGL.GL_POLYGON);
            gl.Color(0.9, 0.9, 0.9);
            gl.Vertex(-2.01, 1.3, -0.3);
            gl.Vertex(-2.01, 2.5, -0.3);
            gl.Vertex(-2.01, 2.5, -2);
            gl.Vertex(-2.01, 1.3, -2.4);

           

            gl.End();

            rotation += 1.5f; 
        }

        private void openglControl1_OpenGLInitialized(object sender, EventArgs e)
        {
            OpenGL gl = openglControl1.OpenGL;
            gl.ClearColor(0.9f, 0.9f, 1.9f, 0);
        }

        private void openglControl1_Resized(object sender, EventArgs e)
        {
           
            OpenGL gl = openglControl1.OpenGL;
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.LoadIdentity();
            gl.Perspective(60.0f, (double)Width / (double)Height, 0.01, 100.0);
            gl.LookAt(-5,6, -8,    
                        0, 1, 0,     
                        0, 2, 0);    
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
        }
    }
}
