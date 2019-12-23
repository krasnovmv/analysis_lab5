namespace analysis_lab5
{
    partial class Form1
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.функцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьПапкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DirBtn = new System.Windows.Forms.Button();
            this.WriteBtnOpen = new System.Windows.Forms.Button();
            this.WriteBtnClose = new System.Windows.Forms.Button();
            this.ReadBtnOpen = new System.Windows.Forms.Button();
            this.ReadBtnLine = new System.Windows.Forms.Button();
            this.ReadBlock = new System.Windows.Forms.Button();
            this.WriteBtnLine = new System.Windows.Forms.Button();
            this.SearchInputLabel = new System.Windows.Forms.Label();
            this.SearchInput = new System.Windows.Forms.TextBox();
            this.PositionInputLabel = new System.Windows.Forms.Label();
            this.PositionInput = new System.Windows.Forms.TextBox();
            this.WriteBlock = new System.Windows.Forms.Button();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ReadBtnClose = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 245);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(340, 142);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.функцииToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(364, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.открытьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click_1);
            // 
            // функцииToolStripMenuItem
            // 
            this.функцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьПапкуToolStripMenuItem});
            this.функцииToolStripMenuItem.Name = "функцииToolStripMenuItem";
            this.функцииToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.функцииToolStripMenuItem.Text = "Функции";
            // 
            // создатьПапкуToolStripMenuItem
            // 
            this.создатьПапкуToolStripMenuItem.Name = "создатьПапкуToolStripMenuItem";
            this.создатьПапкуToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.создатьПапкуToolStripMenuItem.Text = "Создать папку";
            this.создатьПапкуToolStripMenuItem.Click += new System.EventHandler(this.создатьПапкуToolStripMenuItem_Click);
            // 
            // DirBtn
            // 
            this.DirBtn.Location = new System.Drawing.Point(12, 27);
            this.DirBtn.Name = "DirBtn";
            this.DirBtn.Size = new System.Drawing.Size(121, 23);
            this.DirBtn.TabIndex = 2;
            this.DirBtn.Text = "Папка";
            this.DirBtn.UseVisualStyleBackColor = true;
            this.DirBtn.Click += new System.EventHandler(this.DirBtn_Click);
            // 
            // WriteBtnOpen
            // 
            this.WriteBtnOpen.Location = new System.Drawing.Point(71, 56);
            this.WriteBtnOpen.Name = "WriteBtnOpen";
            this.WriteBtnOpen.Size = new System.Drawing.Size(121, 23);
            this.WriteBtnOpen.TabIndex = 3;
            this.WriteBtnOpen.Text = "Открыть для записи";
            this.WriteBtnOpen.UseVisualStyleBackColor = true;
            this.WriteBtnOpen.Click += new System.EventHandler(this.WriteBtnOpen_Click);
            // 
            // WriteBtnClose
            // 
            this.WriteBtnClose.Location = new System.Drawing.Point(71, 85);
            this.WriteBtnClose.Name = "WriteBtnClose";
            this.WriteBtnClose.Size = new System.Drawing.Size(121, 23);
            this.WriteBtnClose.TabIndex = 4;
            this.WriteBtnClose.Text = "Закрыть для записи";
            this.WriteBtnClose.UseVisualStyleBackColor = true;
            this.WriteBtnClose.Click += new System.EventHandler(this.WriteBtnClose_Click);
            // 
            // ReadBtnOpen
            // 
            this.ReadBtnOpen.Location = new System.Drawing.Point(231, 27);
            this.ReadBtnOpen.Name = "ReadBtnOpen";
            this.ReadBtnOpen.Size = new System.Drawing.Size(121, 23);
            this.ReadBtnOpen.TabIndex = 5;
            this.ReadBtnOpen.Text = "Открыть для чтения";
            this.ReadBtnOpen.UseVisualStyleBackColor = true;
            this.ReadBtnOpen.Click += new System.EventHandler(this.ReadBtnOpen_Click);
            // 
            // ReadBtnLine
            // 
            this.ReadBtnLine.Location = new System.Drawing.Point(231, 56);
            this.ReadBtnLine.Name = "ReadBtnLine";
            this.ReadBtnLine.Size = new System.Drawing.Size(121, 23);
            this.ReadBtnLine.TabIndex = 6;
            this.ReadBtnLine.Text = "Чтение строки";
            this.ReadBtnLine.UseVisualStyleBackColor = true;
            this.ReadBtnLine.Click += new System.EventHandler(this.ReadBtnLine_Click);
            // 
            // ReadBlock
            // 
            this.ReadBlock.Location = new System.Drawing.Point(71, 187);
            this.ReadBlock.Name = "ReadBlock";
            this.ReadBlock.Size = new System.Drawing.Size(121, 23);
            this.ReadBlock.TabIndex = 7;
            this.ReadBlock.Text = "Чтение блока";
            this.ReadBlock.UseVisualStyleBackColor = true;
            this.ReadBlock.Click += new System.EventHandler(this.ReadBlock_Click);
            // 
            // WriteBtnLine
            // 
            this.WriteBtnLine.Location = new System.Drawing.Point(231, 85);
            this.WriteBtnLine.Name = "WriteBtnLine";
            this.WriteBtnLine.Size = new System.Drawing.Size(121, 23);
            this.WriteBtnLine.TabIndex = 8;
            this.WriteBtnLine.Text = "Запись строки";
            this.WriteBtnLine.UseVisualStyleBackColor = true;
            this.WriteBtnLine.Click += new System.EventHandler(this.WriteBtnLine_Click);
            // 
            // SearchInputLabel
            // 
            this.SearchInputLabel.AutoSize = true;
            this.SearchInputLabel.Location = new System.Drawing.Point(68, 145);
            this.SearchInputLabel.Name = "SearchInputLabel";
            this.SearchInputLabel.Size = new System.Drawing.Size(63, 13);
            this.SearchInputLabel.TabIndex = 9;
            this.SearchInputLabel.Text = "Для файла";
            // 
            // SearchInput
            // 
            this.SearchInput.Location = new System.Drawing.Point(71, 161);
            this.SearchInput.Name = "SearchInput";
            this.SearchInput.Size = new System.Drawing.Size(121, 20);
            this.SearchInput.TabIndex = 10;
            // 
            // PositionInputLabel
            // 
            this.PositionInputLabel.AutoSize = true;
            this.PositionInputLabel.Location = new System.Drawing.Point(228, 145);
            this.PositionInputLabel.Name = "PositionInputLabel";
            this.PositionInputLabel.Size = new System.Drawing.Size(51, 13);
            this.PositionInputLabel.TabIndex = 11;
            this.PositionInputLabel.Text = "Позиция";
            // 
            // PositionInput
            // 
            this.PositionInput.Location = new System.Drawing.Point(231, 161);
            this.PositionInput.Name = "PositionInput";
            this.PositionInput.Size = new System.Drawing.Size(121, 20);
            this.PositionInput.TabIndex = 13;
            // 
            // WriteBlock
            // 
            this.WriteBlock.Location = new System.Drawing.Point(231, 187);
            this.WriteBlock.Name = "WriteBlock";
            this.WriteBlock.Size = new System.Drawing.Size(121, 23);
            this.WriteBlock.TabIndex = 14;
            this.WriteBlock.Text = "Запись блока";
            this.WriteBlock.UseVisualStyleBackColor = true;
            this.WriteBlock.Click += new System.EventHandler(this.WriteBlock_Click);
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(175, 216);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 15;
            this.SearchBtn.Text = "Найти";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ReadBtnClose
            // 
            this.ReadBtnClose.Location = new System.Drawing.Point(231, 114);
            this.ReadBtnClose.Name = "ReadBtnClose";
            this.ReadBtnClose.Size = new System.Drawing.Size(121, 23);
            this.ReadBtnClose.TabIndex = 16;
            this.ReadBtnClose.Text = "Закрыть для чтения";
            this.ReadBtnClose.UseVisualStyleBackColor = true;
            this.ReadBtnClose.Click += new System.EventHandler(this.ReadBtnClose_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 399);
            this.Controls.Add(this.ReadBtnClose);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.WriteBlock);
            this.Controls.Add(this.PositionInput);
            this.Controls.Add(this.PositionInputLabel);
            this.Controls.Add(this.SearchInput);
            this.Controls.Add(this.SearchInputLabel);
            this.Controls.Add(this.WriteBtnLine);
            this.Controls.Add(this.ReadBlock);
            this.Controls.Add(this.ReadBtnLine);
            this.Controls.Add(this.ReadBtnOpen);
            this.Controls.Add(this.WriteBtnClose);
            this.Controls.Add(this.WriteBtnOpen);
            this.Controls.Add(this.DirBtn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem функцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьПапкуToolStripMenuItem;
        private System.Windows.Forms.Button DirBtn;
        private System.Windows.Forms.Button WriteBtnOpen;
        private System.Windows.Forms.Button WriteBtnClose;
        private System.Windows.Forms.Button ReadBtnOpen;
        private System.Windows.Forms.Button ReadBtnLine;
        private System.Windows.Forms.Button ReadBlock;
        private System.Windows.Forms.Button WriteBtnLine;
        private System.Windows.Forms.Label SearchInputLabel;
        private System.Windows.Forms.TextBox SearchInput;
        private System.Windows.Forms.Label PositionInputLabel;
        private System.Windows.Forms.TextBox PositionInput;
        private System.Windows.Forms.Button WriteBlock;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button ReadBtnClose;
    }
}

