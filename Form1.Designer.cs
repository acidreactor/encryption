namespace ShifrB
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromTextBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caesarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fromTextBoxToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encryptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromFileToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.fromTextBoxToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.fromFileToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.fromTextBoxToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Исходный текст:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 57);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(323, 360);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(341, 57);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(323, 360);
            this.textBox2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(341, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Исходный текст:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.encodingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(672, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.fileToolStripMenuItem.Text = "Меню";
            // 
            // encodingToolStripMenuItem
            // 
            this.encodingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xORToolStripMenuItem,
            this.caesarToolStripMenuItem,
            this.dESToolStripMenuItem});
            this.encodingToolStripMenuItem.Name = "encodingToolStripMenuItem";
            this.encodingToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.encodingToolStripMenuItem.Text = "Шифрование";
            // 
            // xORToolStripMenuItem
            // 
            this.xORToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromFileToolStripMenuItem,
            this.fromTextBoxToolStripMenuItem});
            this.xORToolStripMenuItem.Name = "xORToolStripMenuItem";
            this.xORToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.xORToolStripMenuItem.Text = "XOR";
            // 
            // fromFileToolStripMenuItem
            // 
            this.fromFileToolStripMenuItem.Name = "fromFileToolStripMenuItem";
            this.fromFileToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fromFileToolStripMenuItem.Text = "Из файла";
            this.fromFileToolStripMenuItem.Click += new System.EventHandler(this.fromFileToolStripMenuItem_Click);
            // 
            // fromTextBoxToolStripMenuItem
            // 
            this.fromTextBoxToolStripMenuItem.Name = "fromTextBoxToolStripMenuItem";
            this.fromTextBoxToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fromTextBoxToolStripMenuItem.Text = "Из TextBox";
            this.fromTextBoxToolStripMenuItem.Click += new System.EventHandler(this.fromTextBoxToolStripMenuItem_Click);
            // 
            // caesarToolStripMenuItem
            // 
            this.caesarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromFileToolStripMenuItem1,
            this.fromTextBoxToolStripMenuItem1});
            this.caesarToolStripMenuItem.Name = "caesarToolStripMenuItem";
            this.caesarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.caesarToolStripMenuItem.Text = "Цезарь";
            // 
            // fromFileToolStripMenuItem1
            // 
            this.fromFileToolStripMenuItem1.Name = "fromFileToolStripMenuItem1";
            this.fromFileToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.fromFileToolStripMenuItem1.Text = "Из файла";
            this.fromFileToolStripMenuItem1.Click += new System.EventHandler(this.fromFileToolStripMenuItem1_Click);
            // 
            // fromTextBoxToolStripMenuItem1
            // 
            this.fromTextBoxToolStripMenuItem1.Name = "fromTextBoxToolStripMenuItem1";
            this.fromTextBoxToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.fromTextBoxToolStripMenuItem1.Text = "Из TextBox";
            this.fromTextBoxToolStripMenuItem1.Click += new System.EventHandler(this.fromTextBoxToolStripMenuItem1_Click);
            // 
            // dESToolStripMenuItem
            // 
            this.dESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encryptToolStripMenuItem,
            this.decriptToolStripMenuItem});
            this.dESToolStripMenuItem.Name = "dESToolStripMenuItem";
            this.dESToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dESToolStripMenuItem.Text = "DES";
            // 
            // encryptToolStripMenuItem
            // 
            this.encryptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromFileToolStripMenuItem3,
            this.fromTextBoxToolStripMenuItem3});
            this.encryptToolStripMenuItem.Name = "encryptToolStripMenuItem";
            this.encryptToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.encryptToolStripMenuItem.Text = "Шифрование";
            // 
            // decriptToolStripMenuItem
            // 
            this.decriptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fromFileToolStripMenuItem4,
            this.fromTextBoxToolStripMenuItem4});
            this.decriptToolStripMenuItem.Name = "decriptToolStripMenuItem";
            this.decriptToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.decriptToolStripMenuItem.Text = "Дешифрование";
            // 
            // fromFileToolStripMenuItem3
            // 
            this.fromFileToolStripMenuItem3.Name = "fromFileToolStripMenuItem3";
            this.fromFileToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.fromFileToolStripMenuItem3.Text = "Из файла";
            this.fromFileToolStripMenuItem3.Click += new System.EventHandler(this.fromFileToolStripMenuItem3_Click);
            // 
            // fromTextBoxToolStripMenuItem3
            // 
            this.fromTextBoxToolStripMenuItem3.Name = "fromTextBoxToolStripMenuItem3";
            this.fromTextBoxToolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.fromTextBoxToolStripMenuItem3.Text = "Из TextBox";
            this.fromTextBoxToolStripMenuItem3.Click += new System.EventHandler(this.fromTextBoxToolStripMenuItem3_Click);
            // 
            // fromFileToolStripMenuItem4
            // 
            this.fromFileToolStripMenuItem4.Name = "fromFileToolStripMenuItem4";
            this.fromFileToolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.fromFileToolStripMenuItem4.Text = "Из файла";
            this.fromFileToolStripMenuItem4.Click += new System.EventHandler(this.fromFileToolStripMenuItem4_Click);
            // 
            // fromTextBoxToolStripMenuItem4
            // 
            this.fromTextBoxToolStripMenuItem4.Name = "fromTextBoxToolStripMenuItem4";
            this.fromTextBoxToolStripMenuItem4.Size = new System.Drawing.Size(152, 22);
            this.fromTextBoxToolStripMenuItem4.Text = "Из TextBox";
            this.fromTextBoxToolStripMenuItem4.Click += new System.EventHandler(this.fromTextBoxToolStripMenuItem4_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Текстовый файл (*.txt) | *.txt";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Выход";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 429);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Шифрование текста";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encodingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromTextBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caesarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromFileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fromTextBoxToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encryptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromFileToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem fromTextBoxToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem decriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromFileToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem fromTextBoxToolStripMenuItem4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

