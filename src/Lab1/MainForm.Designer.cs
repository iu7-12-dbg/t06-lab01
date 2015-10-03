namespace Lab1
{
    partial class MainForm
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
            this.txtInputWord = new System.Windows.Forms.TextBox();
            this.btnFindClosestWords = new System.Windows.Forms.Button();
            this.lblInputWord = new System.Windows.Forms.Label();
            this.lbClosestWords = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInputWord
            // 
            this.txtInputWord.Location = new System.Drawing.Point(12, 22);
            this.txtInputWord.Name = "txtInputWord";
            this.txtInputWord.Size = new System.Drawing.Size(138, 20);
            this.txtInputWord.TabIndex = 0;
            // 
            // btnFindClosestWords
            // 
            this.btnFindClosestWords.Location = new System.Drawing.Point(12, 48);
            this.btnFindClosestWords.Name = "btnFindClosestWords";
            this.btnFindClosestWords.Size = new System.Drawing.Size(138, 23);
            this.btnFindClosestWords.TabIndex = 1;
            this.btnFindClosestWords.Text = "Поиск";
            this.btnFindClosestWords.UseVisualStyleBackColor = true;
            this.btnFindClosestWords.Click += new System.EventHandler(this.btnFindClosestWords_Click);
            // 
            // lblInputWord
            // 
            this.lblInputWord.AutoSize = true;
            this.lblInputWord.Location = new System.Drawing.Point(9, 6);
            this.lblInputWord.Name = "lblInputWord";
            this.lblInputWord.Size = new System.Drawing.Size(101, 13);
            this.lblInputWord.TabIndex = 2;
            this.lblInputWord.Text = "Слово для поиска:";
            // 
            // lbClosestWords
            // 
            this.lbClosestWords.FormattingEnabled = true;
            this.lbClosestWords.Location = new System.Drawing.Point(206, 22);
            this.lbClosestWords.Name = "lbClosestWords";
            this.lbClosestWords.ScrollAlwaysVisible = true;
            this.lbClosestWords.Size = new System.Drawing.Size(208, 264);
            this.lbClosestWords.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Похожие слова в словаре:";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 291);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(426, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 313);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbClosestWords);
            this.Controls.Add(this.lblInputWord);
            this.Controls.Add(this.btnFindClosestWords);
            this.Controls.Add(this.txtInputWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Лабораторная 1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputWord;
        private System.Windows.Forms.Button btnFindClosestWords;
        private System.Windows.Forms.Label lblInputWord;
        private System.Windows.Forms.ListBox lbClosestWords;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}

