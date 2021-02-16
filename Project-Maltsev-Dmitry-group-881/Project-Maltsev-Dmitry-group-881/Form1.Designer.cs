namespace Project_Maltsev_Dmitry_group_881
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.разработчикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проектыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.калькуляторToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.инженерныйКалькуляторToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.разработчикToolStripMenuItem,
            this.проектыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1298, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // разработчикToolStripMenuItem
            // 
            this.разработчикToolStripMenuItem.Name = "разработчикToolStripMenuItem";
            this.разработчикToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.разработчикToolStripMenuItem.Text = "Разработчик";
            this.разработчикToolStripMenuItem.Click += new System.EventHandler(this.разработчикToolStripMenuItem_Click);
            // 
            // проектыToolStripMenuItem
            // 
            this.проектыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.калькуляторToolStripMenuItem1,
            this.инженерныйКалькуляторToolStripMenuItem});
            this.проектыToolStripMenuItem.Name = "проектыToolStripMenuItem";
            this.проектыToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.проектыToolStripMenuItem.Text = "Проекты";
            this.проектыToolStripMenuItem.Click += new System.EventHandler(this.проектыToolStripMenuItem_Click);
            // 
            // калькуляторToolStripMenuItem1
            // 
            this.калькуляторToolStripMenuItem1.Name = "калькуляторToolStripMenuItem1";
            this.калькуляторToolStripMenuItem1.Size = new System.Drawing.Size(220, 22);
            this.калькуляторToolStripMenuItem1.Text = "Калькулятор";
            this.калькуляторToolStripMenuItem1.Click += new System.EventHandler(this.калькуляторToolStripMenuItem1_Click);
            // 
            // инженерныйКалькуляторToolStripMenuItem
            // 
            this.инженерныйКалькуляторToolStripMenuItem.Name = "инженерныйКалькуляторToolStripMenuItem";
            this.инженерныйКалькуляторToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.инженерныйКалькуляторToolStripMenuItem.Text = "Инженерный калькулятор";
            this.инженерныйКалькуляторToolStripMenuItem.Click += new System.EventHandler(this.инженерныйКалькуляторToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1298, 139);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Меню";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem разработчикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проектыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem калькуляторToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem инженерныйКалькуляторToolStripMenuItem;
    }
}

