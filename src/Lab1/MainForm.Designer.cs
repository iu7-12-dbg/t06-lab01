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
            this.lblInputWordInfo = new System.Windows.Forms.Label();
            this.lbClosestWords = new System.Windows.Forms.ListBox();
            this.lblLbClosestWordsInfo = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectDictionaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWordsCount = new System.Windows.Forms.Label();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.lblActiveDictionary = new System.Windows.Forms.Label();
            this.txtBxActiveDictionary = new System.Windows.Forms.TextBox();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInputWord
            // 
            this.txtInputWord.Location = new System.Drawing.Point(12, 48);
            this.txtInputWord.Name = "txtInputWord";
            this.txtInputWord.Size = new System.Drawing.Size(171, 20);
            this.txtInputWord.TabIndex = 0;
            // 
            // btnFindClosestWords
            // 
            this.btnFindClosestWords.Location = new System.Drawing.Point(12, 74);
            this.btnFindClosestWords.Name = "btnFindClosestWords";
            this.btnFindClosestWords.Size = new System.Drawing.Size(171, 23);
            this.btnFindClosestWords.TabIndex = 1;
            this.btnFindClosestWords.Text = "Поиск";
            this.btnFindClosestWords.UseVisualStyleBackColor = true;
            this.btnFindClosestWords.Click += new System.EventHandler(this.btnFindClosestWords_Click);
            // 
            // lblInputWordInfo
            // 
            this.lblInputWordInfo.AutoSize = true;
            this.lblInputWordInfo.Location = new System.Drawing.Point(9, 32);
            this.lblInputWordInfo.Name = "lblInputWordInfo";
            this.lblInputWordInfo.Size = new System.Drawing.Size(101, 13);
            this.lblInputWordInfo.TabIndex = 2;
            this.lblInputWordInfo.Text = "Слово для поиска:";
            // 
            // lbClosestWords
            // 
            this.lbClosestWords.FormattingEnabled = true;
            this.lbClosestWords.Location = new System.Drawing.Point(249, 48);
            this.lbClosestWords.Name = "lbClosestWords";
            this.lbClosestWords.ScrollAlwaysVisible = true;
            this.lbClosestWords.Size = new System.Drawing.Size(272, 264);
            this.lbClosestWords.TabIndex = 3;
            // 
            // lblLbClosestWordsInfo
            // 
            this.lblLbClosestWordsInfo.AutoSize = true;
            this.lblLbClosestWordsInfo.Location = new System.Drawing.Point(246, 32);
            this.lblLbClosestWordsInfo.Name = "lblLbClosestWordsInfo";
            this.lblLbClosestWordsInfo.Size = new System.Drawing.Size(142, 13);
            this.lblLbClosestWordsInfo.TabIndex = 4;
            this.lblLbClosestWordsInfo.Text = "Похожие слова в словаре:";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 361);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(533, 22);
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(533, 24);
            this.menuStrip.TabIndex = 6;
            this.menuStrip.Text = "menuStrip";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectDictionaryToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.FileToolStripMenuItem.Text = "Файл";
            // 
            // SelectDictionaryToolStripMenuItem
            // 
            this.SelectDictionaryToolStripMenuItem.Name = "SelectDictionaryToolStripMenuItem";
            this.SelectDictionaryToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.SelectDictionaryToolStripMenuItem.Text = "Выбрать словарь";
            this.SelectDictionaryToolStripMenuItem.Click += new System.EventHandler(this.SelectDictionaryToolStripMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.HelpToolStripMenuItem.Text = "Справка";
            this.HelpToolStripMenuItem.Click += new System.EventHandler(this.HelpToolStripMenuItem_Click);
            // 
            // lblWordsCount
            // 
            this.lblWordsCount.AutoSize = true;
            this.lblWordsCount.Location = new System.Drawing.Point(246, 315);
            this.lblWordsCount.Name = "lblWordsCount";
            this.lblWordsCount.Size = new System.Drawing.Size(76, 13);
            this.lblWordsCount.TabIndex = 7;
            this.lblWordsCount.Text = "lblWordsCount";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // lblActiveDictionary
            // 
            this.lblActiveDictionary.AutoSize = true;
            this.lblActiveDictionary.Location = new System.Drawing.Point(9, 338);
            this.lblActiveDictionary.Name = "lblActiveDictionary";
            this.lblActiveDictionary.Size = new System.Drawing.Size(105, 13);
            this.lblActiveDictionary.TabIndex = 9;
            this.lblActiveDictionary.Text = "Активный словарь:";
            // 
            // txtBxActiveDictionary
            // 
            this.txtBxActiveDictionary.Location = new System.Drawing.Point(120, 335);
            this.txtBxActiveDictionary.Name = "txtBxActiveDictionary";
            this.txtBxActiveDictionary.ReadOnly = true;
            this.txtBxActiveDictionary.Size = new System.Drawing.Size(113, 20);
            this.txtBxActiveDictionary.TabIndex = 10;
            this.txtBxActiveDictionary.Text = "Отсутствует";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 383);
            this.Controls.Add(this.txtBxActiveDictionary);
            this.Controls.Add(this.lblActiveDictionary);
            this.Controls.Add(this.lblWordsCount);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.lblLbClosestWordsInfo);
            this.Controls.Add(this.lbClosestWords);
            this.Controls.Add(this.lblInputWordInfo);
            this.Controls.Add(this.btnFindClosestWords);
            this.Controls.Add(this.txtInputWord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Лабораторная 1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputWord;
        private System.Windows.Forms.Button btnFindClosestWords;
        private System.Windows.Forms.Label lblInputWordInfo;
        private System.Windows.Forms.ListBox lbClosestWords;
        private System.Windows.Forms.Label lblLbClosestWordsInfo;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectDictionaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.Label lblWordsCount;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Label lblActiveDictionary;
        private System.Windows.Forms.TextBox txtBxActiveDictionary;
    }
}

