﻿
namespace SharpGL_My_First_Model
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openglControl1 = new SharpGL.OpenGLControl();
            ((System.ComponentModel.ISupportInitialize)(this.openglControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // openglControl1
            // 
            this.openglControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openglControl1.DrawFPS = false;
            this.openglControl1.Location = new System.Drawing.Point(13, 12);
            this.openglControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.openglControl1.Name = "openglControl1";
            this.openglControl1.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openglControl1.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openglControl1.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openglControl1.Size = new System.Drawing.Size(774, 426);
            this.openglControl1.TabIndex = 0;
            this.openglControl1.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openglControl1.Resized += new System.EventHandler(this.openGLControl_Resized);
            this.openglControl1.Load += new System.EventHandler(this.openglControl1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.openglControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.openglControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private SharpGL.OpenGLControl openglControl1;
    }
}

