namespace PizzaForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.listBox_Pizzak = new System.Windows.Forms.ListBox();
            this.button_Atlagar = new System.Windows.Forms.Button();
            this.groupBox_Fizetes = new System.Windows.Forms.GroupBox();
            this.radioButton_Bankkartya = new System.Windows.Forms.RadioButton();
            this.radioButton_Keszpenz = new System.Windows.Forms.RadioButton();
            this.checkBox_Szamla = new System.Windows.Forms.CheckBox();
            this.textBox_Rendeles = new System.Windows.Forms.TextBox();
            this.numericUpDown_Mennyiseg = new System.Windows.Forms.NumericUpDown();
            this.button_hozzad = new System.Windows.Forms.Button();
            this.listBox_Kosar = new System.Windows.Forms.ListBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button_fizetes = new System.Windows.Forms.Button();
            this.textBox_osszeg = new System.Windows.Forms.TextBox();
            this.groupBox_Fizetes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Mennyiseg)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // listBox_Pizzak
            // 
            this.listBox_Pizzak.FormattingEnabled = true;
            this.listBox_Pizzak.ItemHeight = 16;
            this.listBox_Pizzak.Location = new System.Drawing.Point(16, 15);
            this.listBox_Pizzak.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_Pizzak.Name = "listBox_Pizzak";
            this.listBox_Pizzak.Size = new System.Drawing.Size(204, 212);
            this.listBox_Pizzak.TabIndex = 0;
            this.listBox_Pizzak.SelectedIndexChanged += new System.EventHandler(this.listBox_Pizzak_SelectedIndexChanged);
            // 
            // button_Atlagar
            // 
            this.button_Atlagar.Location = new System.Drawing.Point(16, 255);
            this.button_Atlagar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Atlagar.Name = "button_Atlagar";
            this.button_Atlagar.Size = new System.Drawing.Size(204, 28);
            this.button_Atlagar.TabIndex = 1;
            this.button_Atlagar.Text = "Pizzák átlagára";
            this.button_Atlagar.UseVisualStyleBackColor = true;
            this.button_Atlagar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox_Fizetes
            // 
            this.groupBox_Fizetes.Controls.Add(this.radioButton_Bankkartya);
            this.groupBox_Fizetes.Controls.Add(this.radioButton_Keszpenz);
            this.groupBox_Fizetes.Location = new System.Drawing.Point(331, 39);
            this.groupBox_Fizetes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Fizetes.Name = "groupBox_Fizetes";
            this.groupBox_Fizetes.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox_Fizetes.Size = new System.Drawing.Size(267, 123);
            this.groupBox_Fizetes.TabIndex = 2;
            this.groupBox_Fizetes.TabStop = false;
            this.groupBox_Fizetes.Text = "Fizetési lehetőségek";
            // 
            // radioButton_Bankkartya
            // 
            this.radioButton_Bankkartya.AutoSize = true;
            this.radioButton_Bankkartya.Location = new System.Drawing.Point(24, 53);
            this.radioButton_Bankkartya.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Bankkartya.Name = "radioButton_Bankkartya";
            this.radioButton_Bankkartya.Size = new System.Drawing.Size(96, 20);
            this.radioButton_Bankkartya.TabIndex = 0;
            this.radioButton_Bankkartya.TabStop = true;
            this.radioButton_Bankkartya.Text = "Bankkártya";
            this.radioButton_Bankkartya.UseVisualStyleBackColor = true;
            // 
            // radioButton_Keszpenz
            // 
            this.radioButton_Keszpenz.AutoSize = true;
            this.radioButton_Keszpenz.Location = new System.Drawing.Point(23, 25);
            this.radioButton_Keszpenz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_Keszpenz.Name = "radioButton_Keszpenz";
            this.radioButton_Keszpenz.Size = new System.Drawing.Size(86, 20);
            this.radioButton_Keszpenz.TabIndex = 0;
            this.radioButton_Keszpenz.TabStop = true;
            this.radioButton_Keszpenz.Text = "Készpénz";
            this.radioButton_Keszpenz.UseVisualStyleBackColor = true;
            // 
            // checkBox_Szamla
            // 
            this.checkBox_Szamla.AutoSize = true;
            this.checkBox_Szamla.Location = new System.Drawing.Point(353, 196);
            this.checkBox_Szamla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_Szamla.Name = "checkBox_Szamla";
            this.checkBox_Szamla.Size = new System.Drawing.Size(106, 20);
            this.checkBox_Szamla.TabIndex = 3;
            this.checkBox_Szamla.Text = "Számlát kér?";
            this.checkBox_Szamla.UseVisualStyleBackColor = true;
            // 
            // textBox_Rendeles
            // 
            this.textBox_Rendeles.Location = new System.Drawing.Point(605, 39);
            this.textBox_Rendeles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Rendeles.Name = "textBox_Rendeles";
            this.textBox_Rendeles.Size = new System.Drawing.Size(195, 22);
            this.textBox_Rendeles.TabIndex = 5;
            this.textBox_Rendeles.TextChanged += new System.EventHandler(this.textBox_Rendeles_TextChanged);
            // 
            // numericUpDown_Mennyiseg
            // 
            this.numericUpDown_Mennyiseg.Location = new System.Drawing.Point(797, 39);
            this.numericUpDown_Mennyiseg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.numericUpDown_Mennyiseg.Name = "numericUpDown_Mennyiseg";
            this.numericUpDown_Mennyiseg.Size = new System.Drawing.Size(51, 22);
            this.numericUpDown_Mennyiseg.TabIndex = 6;
            // 
            // button_hozzad
            // 
            this.button_hozzad.Location = new System.Drawing.Point(624, 71);
            this.button_hozzad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_hozzad.Name = "button_hozzad";
            this.button_hozzad.Size = new System.Drawing.Size(209, 28);
            this.button_hozzad.TabIndex = 7;
            this.button_hozzad.Text = "Hozzáadás";
            this.button_hozzad.UseVisualStyleBackColor = true;
            this.button_hozzad.Click += new System.EventHandler(this.button_hozzad_Click);
            // 
            // listBox_Kosar
            // 
            this.listBox_Kosar.FormattingEnabled = true;
            this.listBox_Kosar.ItemHeight = 16;
            this.listBox_Kosar.Location = new System.Drawing.Point(761, 183);
            this.listBox_Kosar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox_Kosar.Name = "listBox_Kosar";
            this.listBox_Kosar.Size = new System.Drawing.Size(343, 212);
            this.listBox_Kosar.TabIndex = 8;
            // 
            // button_fizetes
            // 
            this.button_fizetes.Location = new System.Drawing.Point(264, 510);
            this.button_fizetes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_fizetes.Name = "button_fizetes";
            this.button_fizetes.Size = new System.Drawing.Size(393, 117);
            this.button_fizetes.TabIndex = 9;
            this.button_fizetes.Text = "Fizetés";
            this.button_fizetes.UseVisualStyleBackColor = true;
            this.button_fizetes.Click += new System.EventHandler(this.button_fizetes_Click);
            // 
            // textBox_osszeg
            // 
            this.textBox_osszeg.Location = new System.Drawing.Point(856, 38);
            this.textBox_osszeg.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_osszeg.Name = "textBox_osszeg";
            this.textBox_osszeg.Size = new System.Drawing.Size(82, 22);
            this.textBox_osszeg.TabIndex = 5;
            this.textBox_osszeg.TextChanged += new System.EventHandler(this.textBox_Rendeles_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 814);
            this.Controls.Add(this.button_fizetes);
            this.Controls.Add(this.listBox_Kosar);
            this.Controls.Add(this.button_hozzad);
            this.Controls.Add(this.numericUpDown_Mennyiseg);
            this.Controls.Add(this.textBox_osszeg);
            this.Controls.Add(this.textBox_Rendeles);
            this.Controls.Add(this.checkBox_Szamla);
            this.Controls.Add(this.groupBox_Fizetes);
            this.Controls.Add(this.button_Atlagar);
            this.Controls.Add(this.listBox_Pizzak);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Fizetes.ResumeLayout(false);
            this.groupBox_Fizetes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Mennyiseg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox_Pizzak;
        private System.Windows.Forms.Button button_Atlagar;
        private System.Windows.Forms.GroupBox groupBox_Fizetes;
        private System.Windows.Forms.RadioButton radioButton_Bankkartya;
        private System.Windows.Forms.RadioButton radioButton_Keszpenz;
        private System.Windows.Forms.CheckBox checkBox_Szamla;
        private System.Windows.Forms.TextBox textBox_Rendeles;
        private System.Windows.Forms.NumericUpDown numericUpDown_Mennyiseg;
        private System.Windows.Forms.Button button_hozzad;
        private System.Windows.Forms.ListBox listBox_Kosar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button_fizetes;
        private System.Windows.Forms.TextBox textBox_osszeg;
    }
}

