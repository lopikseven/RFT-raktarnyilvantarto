namespace funkspec
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.szerkesztes_button = new System.Windows.Forms.Button();
            this.osszes_radio = new System.Windows.Forms.RadioButton();
            this.rendelendo_radio = new System.Windows.Forms.RadioButton();
            this.rak_allapot_button = new System.Windows.Forms.Button();
            this.rendelendo_button = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bejovo_rendeles_button = new System.Windows.Forms.Button();
            this.uj_termek_button = new System.Windows.Forms.Button();
            this.uj_beszallito_button = new System.Windows.Forms.Button();
            this.kereses_textbox = new System.Windows.Forms.TextBox();
            this.kereses_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.beszallito_radio = new System.Windows.Forms.RadioButton();
            this.azon_radio = new System.Windows.Forms.RadioButton();
            this.mennyiseg_radio = new System.Windows.Forms.RadioButton();
            this.ar_radio = new System.Windows.Forms.RadioButton();
            this.rendelesek_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(14, 203);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(708, 340);
            this.listBox1.TabIndex = 0;
            // 
            // szerkesztes_button
            // 
            this.szerkesztes_button.Location = new System.Drawing.Point(14, 61);
            this.szerkesztes_button.Name = "szerkesztes_button";
            this.szerkesztes_button.Size = new System.Drawing.Size(188, 43);
            this.szerkesztes_button.TabIndex = 1;
            this.szerkesztes_button.Text = "Szerkesztés";
            this.szerkesztes_button.UseVisualStyleBackColor = true;
            this.szerkesztes_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // osszes_radio
            // 
            this.osszes_radio.AutoSize = true;
            this.osszes_radio.Location = new System.Drawing.Point(426, 145);
            this.osszes_radio.Name = "osszes_radio";
            this.osszes_radio.Size = new System.Drawing.Size(123, 21);
            this.osszes_radio.TabIndex = 2;
            this.osszes_radio.TabStop = true;
            this.osszes_radio.Text = "Összes termék";
            this.osszes_radio.UseVisualStyleBackColor = true;
            // 
            // rendelendo_radio
            // 
            this.rendelendo_radio.AutoSize = true;
            this.rendelendo_radio.Location = new System.Drawing.Point(426, 172);
            this.rendelendo_radio.Name = "rendelendo_radio";
            this.rendelendo_radio.Size = new System.Drawing.Size(190, 21);
            this.rendelendo_radio.TabIndex = 3;
            this.rendelendo_radio.TabStop = true;
            this.rendelendo_radio.Text = "Megrendelendő termékek";
            this.rendelendo_radio.UseVisualStyleBackColor = true;
            // 
            // rak_allapot_button
            // 
            this.rak_allapot_button.Location = new System.Drawing.Point(14, 17);
            this.rak_allapot_button.Name = "rak_allapot_button";
            this.rak_allapot_button.Size = new System.Drawing.Size(188, 39);
            this.rak_allapot_button.TabIndex = 4;
            this.rak_allapot_button.Text = "Raktár állapota";
            this.rak_allapot_button.UseVisualStyleBackColor = true;
            // 
            // rendelendo_button
            // 
            this.rendelendo_button.Location = new System.Drawing.Point(208, 111);
            this.rendelendo_button.Name = "rendelendo_button";
            this.rendelendo_button.Size = new System.Drawing.Size(188, 37);
            this.rendelendo_button.TabIndex = 5;
            this.rendelendo_button.Text = "Rendelendő termékek";
            this.rendelendo_button.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(284, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(8, 8);
            this.button4.TabIndex = 6;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // bejovo_rendeles_button
            // 
            this.bejovo_rendeles_button.Location = new System.Drawing.Point(14, 112);
            this.bejovo_rendeles_button.Name = "bejovo_rendeles_button";
            this.bejovo_rendeles_button.Size = new System.Drawing.Size(188, 34);
            this.bejovo_rendeles_button.TabIndex = 7;
            this.bejovo_rendeles_button.Text = "Bejövő rendelések";
            this.bejovo_rendeles_button.UseVisualStyleBackColor = true;
            // 
            // uj_termek_button
            // 
            this.uj_termek_button.Location = new System.Drawing.Point(208, 17);
            this.uj_termek_button.Name = "uj_termek_button";
            this.uj_termek_button.Size = new System.Drawing.Size(188, 39);
            this.uj_termek_button.TabIndex = 8;
            this.uj_termek_button.Text = "Új termék";
            this.uj_termek_button.UseVisualStyleBackColor = true;
            // 
            // uj_beszallito_button
            // 
            this.uj_beszallito_button.Location = new System.Drawing.Point(208, 61);
            this.uj_beszallito_button.Name = "uj_beszallito_button";
            this.uj_beszallito_button.Size = new System.Drawing.Size(188, 42);
            this.uj_beszallito_button.TabIndex = 10;
            this.uj_beszallito_button.Text = "Új beszállító";
            this.uj_beszallito_button.UseVisualStyleBackColor = true;
            // 
            // kereses_textbox
            // 
            this.kereses_textbox.Location = new System.Drawing.Point(429, 17);
            this.kereses_textbox.Name = "kereses_textbox";
            this.kereses_textbox.Size = new System.Drawing.Size(190, 22);
            this.kereses_textbox.TabIndex = 11;
            // 
            // kereses_button
            // 
            this.kereses_button.Location = new System.Drawing.Point(636, 17);
            this.kereses_button.Name = "kereses_button";
            this.kereses_button.Size = new System.Drawing.Size(75, 23);
            this.kereses_button.TabIndex = 12;
            this.kereses_button.Text = "Keresés";
            this.kereses_button.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Megjelenítendő termékek:";
            // 
            // beszallito_radio
            // 
            this.beszallito_radio.AutoSize = true;
            this.beszallito_radio.Location = new System.Drawing.Point(529, 72);
            this.beszallito_radio.Name = "beszallito_radio";
            this.beszallito_radio.Size = new System.Drawing.Size(89, 21);
            this.beszallito_radio.TabIndex = 16;
            this.beszallito_radio.TabStop = true;
            this.beszallito_radio.Text = "Beszállító";
            this.beszallito_radio.UseVisualStyleBackColor = true;
            // 
            // azon_radio
            // 
            this.azon_radio.AutoSize = true;
            this.azon_radio.Location = new System.Drawing.Point(529, 48);
            this.azon_radio.Name = "azon_radio";
            this.azon_radio.Size = new System.Drawing.Size(91, 21);
            this.azon_radio.TabIndex = 15;
            this.azon_radio.TabStop = true;
            this.azon_radio.Text = "Azonosító";
            this.azon_radio.UseVisualStyleBackColor = true;
            // 
            // mennyiseg_radio
            // 
            this.mennyiseg_radio.AutoSize = true;
            this.mennyiseg_radio.Location = new System.Drawing.Point(426, 75);
            this.mennyiseg_radio.Name = "mennyiseg_radio";
            this.mennyiseg_radio.Size = new System.Drawing.Size(97, 21);
            this.mennyiseg_radio.TabIndex = 18;
            this.mennyiseg_radio.TabStop = true;
            this.mennyiseg_radio.Text = "Mennyiség";
            this.mennyiseg_radio.UseVisualStyleBackColor = true;
            // 
            // ar_radio
            // 
            this.ar_radio.AutoSize = true;
            this.ar_radio.Location = new System.Drawing.Point(426, 48);
            this.ar_radio.Name = "ar_radio";
            this.ar_radio.Size = new System.Drawing.Size(43, 21);
            this.ar_radio.TabIndex = 17;
            this.ar_radio.TabStop = true;
            this.ar_radio.Text = "Ár";
            this.ar_radio.UseVisualStyleBackColor = true;
            // 
            // rendelesek_button
            // 
            this.rendelesek_button.Location = new System.Drawing.Point(14, 152);
            this.rendelesek_button.Name = "rendelesek_button";
            this.rendelesek_button.Size = new System.Drawing.Size(382, 37);
            this.rendelesek_button.TabIndex = 19;
            this.rendelesek_button.Text = "Megrendelések";
            this.rendelesek_button.UseVisualStyleBackColor = true;
            this.rendelesek_button.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 559);
            this.Controls.Add(this.rendelesek_button);
            this.Controls.Add(this.mennyiseg_radio);
            this.Controls.Add(this.ar_radio);
            this.Controls.Add(this.beszallito_radio);
            this.Controls.Add(this.azon_radio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kereses_button);
            this.Controls.Add(this.kereses_textbox);
            this.Controls.Add(this.uj_beszallito_button);
            this.Controls.Add(this.uj_termek_button);
            this.Controls.Add(this.bejovo_rendeles_button);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.rendelendo_button);
            this.Controls.Add(this.rak_allapot_button);
            this.Controls.Add(this.rendelendo_radio);
            this.Controls.Add(this.osszes_radio);
            this.Controls.Add(this.szerkesztes_button);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button szerkesztes_button;
        private System.Windows.Forms.RadioButton osszes_radio;
        private System.Windows.Forms.RadioButton rendelendo_radio;
        private System.Windows.Forms.Button rak_allapot_button;
        private System.Windows.Forms.Button rendelendo_button;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bejovo_rendeles_button;
        private System.Windows.Forms.Button uj_termek_button;
        private System.Windows.Forms.Button uj_beszallito_button;
        private System.Windows.Forms.TextBox kereses_textbox;
        private System.Windows.Forms.Button kereses_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton beszallito_radio;
        private System.Windows.Forms.RadioButton azon_radio;
        private System.Windows.Forms.RadioButton mennyiseg_radio;
        private System.Windows.Forms.RadioButton ar_radio;
        private System.Windows.Forms.Button rendelesek_button;
    }
}

