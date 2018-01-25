namespace rft_raktarnyilvantarto
{
    partial class Form2
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.kereses_textbox = new System.Windows.Forms.TextBox();
            this.kereses_gomb = new System.Windows.Forms.Button();
            this.lejartak_gomb = new System.Windows.Forms.Button();
            this.megrendeles_jelentes_gom = new System.Windows.Forms.Button();
            this.raktar_gomb = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(322, 53);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(110, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(447, 53);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(322, 80);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(110, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "radioButton3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(447, 80);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(110, 21);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "radioButton4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // kereses_textbox
            // 
            this.kereses_textbox.Location = new System.Drawing.Point(322, 13);
            this.kereses_textbox.Name = "kereses_textbox";
            this.kereses_textbox.Size = new System.Drawing.Size(110, 22);
            this.kereses_textbox.TabIndex = 4;
            // 
            // kereses_gomb
            // 
            this.kereses_gomb.Location = new System.Drawing.Point(447, 13);
            this.kereses_gomb.Name = "kereses_gomb";
            this.kereses_gomb.Size = new System.Drawing.Size(110, 23);
            this.kereses_gomb.TabIndex = 5;
            this.kereses_gomb.Text = "Keresés";
            this.kereses_gomb.UseVisualStyleBackColor = true;
            // 
            // lejartak_gomb
            // 
            this.lejartak_gomb.Location = new System.Drawing.Point(12, 13);
            this.lejartak_gomb.Name = "lejartak_gomb";
            this.lejartak_gomb.Size = new System.Drawing.Size(269, 23);
            this.lejartak_gomb.TabIndex = 6;
            this.lejartak_gomb.Text = "Lejárt megrendelések";
            this.lejartak_gomb.UseVisualStyleBackColor = true;
            // 
            // megrendeles_jelentes_gom
            // 
            this.megrendeles_jelentes_gom.Location = new System.Drawing.Point(12, 53);
            this.megrendeles_jelentes_gom.Name = "megrendeles_jelentes_gom";
            this.megrendeles_jelentes_gom.Size = new System.Drawing.Size(269, 23);
            this.megrendeles_jelentes_gom.TabIndex = 7;
            this.megrendeles_jelentes_gom.Text = "Megrendelesek jelentése";
            this.megrendeles_jelentes_gom.UseVisualStyleBackColor = true;
            // 
            // raktar_gomb
            // 
            this.raktar_gomb.Location = new System.Drawing.Point(12, 92);
            this.raktar_gomb.Name = "raktar_gomb";
            this.raktar_gomb.Size = new System.Drawing.Size(269, 23);
            this.raktar_gomb.TabIndex = 8;
            this.raktar_gomb.Text = "Raktár";
            this.raktar_gomb.UseVisualStyleBackColor = true;
            this.raktar_gomb.Click += new System.EventHandler(this.raktar_gomb_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 135);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(598, 276);
            this.listBox1.TabIndex = 9;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 447);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.raktar_gomb);
            this.Controls.Add(this.megrendeles_jelentes_gom);
            this.Controls.Add(this.lejartak_gomb);
            this.Controls.Add(this.kereses_gomb);
            this.Controls.Add(this.kereses_textbox);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.TextBox kereses_textbox;
        private System.Windows.Forms.Button kereses_gomb;
        private System.Windows.Forms.Button lejartak_gomb;
        private System.Windows.Forms.Button megrendeles_jelentes_gom;
        private System.Windows.Forms.Button raktar_gomb;
        private System.Windows.Forms.ListBox listBox1;
    }
}