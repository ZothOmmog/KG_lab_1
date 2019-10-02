namespace KG_lab_1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupMainMenu = new System.Windows.Forms.GroupBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonCreateLine = new System.Windows.Forms.Button();
            this.buttonDeleteLine = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTipCreate = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipDelete = new System.Windows.Forms.ToolTip(this.components);
            this.groupMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupMainMenu
            // 
            this.groupMainMenu.Controls.Add(this.buttonExit);
            this.groupMainMenu.Controls.Add(this.buttonCreateLine);
            this.groupMainMenu.Controls.Add(this.buttonDeleteLine);
            this.groupMainMenu.Location = new System.Drawing.Point(16, 15);
            this.groupMainMenu.Margin = new System.Windows.Forms.Padding(4);
            this.groupMainMenu.Name = "groupMainMenu";
            this.groupMainMenu.Padding = new System.Windows.Forms.Padding(4);
            this.groupMainMenu.Size = new System.Drawing.Size(275, 524);
            this.groupMainMenu.TabIndex = 0;
            this.groupMainMenu.TabStop = false;
            this.groupMainMenu.Text = "Меню";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(8, 489);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(257, 28);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Выход";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // buttonCreateLine
            // 
            this.buttonCreateLine.Location = new System.Drawing.Point(8, 23);
            this.buttonCreateLine.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCreateLine.Name = "buttonCreateLine";
            this.buttonCreateLine.Size = new System.Drawing.Size(259, 28);
            this.buttonCreateLine.TabIndex = 0;
            this.buttonCreateLine.Text = "Создать линию";
            this.buttonCreateLine.UseVisualStyleBackColor = true;
            this.buttonCreateLine.Click += new System.EventHandler(this.ButtonCreateLine_Click);
            // 
            // buttonDeleteLine
            // 
            this.buttonDeleteLine.Location = new System.Drawing.Point(8, 59);
            this.buttonDeleteLine.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDeleteLine.Name = "buttonDeleteLine";
            this.buttonDeleteLine.Size = new System.Drawing.Size(257, 28);
            this.buttonDeleteLine.TabIndex = 1;
            this.buttonDeleteLine.Text = "Удалить линию";
            this.buttonDeleteLine.UseVisualStyleBackColor = true;
            this.buttonDeleteLine.Click += new System.EventHandler(this.ButtonDeleteLine_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(300, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(751, 523);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupMainMenu);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Graphics Editor";
            this.groupMainMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupMainMenu;
        private System.Windows.Forms.Button buttonCreateLine;
        private System.Windows.Forms.Button buttonDeleteLine;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTipCreate;
        private System.Windows.Forms.ToolTip toolTipDelete;
        private System.Windows.Forms.Button buttonExit;
    }
}

