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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.buttonDeleteLine = new System.Windows.Forms.Button();
            this.buttonCreateLine = new System.Windows.Forms.Button();
            this.panelGraphics = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.buttonDeleteLine);
            this.groupBox1.Controls.Add(this.buttonCreateLine);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // buttonDeleteLine
            // 
            this.buttonDeleteLine.Location = new System.Drawing.Point(7, 50);
            this.buttonDeleteLine.Name = "buttonDeleteLine";
            this.buttonDeleteLine.Size = new System.Drawing.Size(193, 23);
            this.buttonDeleteLine.TabIndex = 1;
            this.buttonDeleteLine.Text = "Удалить выбранную линию";
            this.buttonDeleteLine.UseVisualStyleBackColor = true;
            // 
            // buttonCreateLine
            // 
            this.buttonCreateLine.Location = new System.Drawing.Point(7, 20);
            this.buttonCreateLine.Name = "buttonCreateLine";
            this.buttonCreateLine.Size = new System.Drawing.Size(193, 23);
            this.buttonCreateLine.TabIndex = 0;
            this.buttonCreateLine.Text = "Создать линию";
            this.buttonCreateLine.UseVisualStyleBackColor = true;
            this.buttonCreateLine.Click += new System.EventHandler(this.ButtonCreateLine_Click);
            // 
            // panelGraphics
            // 
            this.panelGraphics.BackColor = System.Drawing.SystemColors.Window;
            this.panelGraphics.Location = new System.Drawing.Point(224, 12);
            this.panelGraphics.Name = "panelGraphics";
            this.panelGraphics.Size = new System.Drawing.Size(568, 426);
            this.panelGraphics.TabIndex = 1;
            this.panelGraphics.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelGraphics_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelGraphics);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Graphics Editor";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCreateLine;
        private System.Windows.Forms.Button buttonDeleteLine;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Panel panelGraphics;
    }
}

