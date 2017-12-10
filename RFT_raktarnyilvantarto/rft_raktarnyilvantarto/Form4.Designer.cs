namespace rft_raktarnyilvantarto
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_vonalkod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_megnevezes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_tipus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_raktaron = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_minimum = new System.Windows.Forms.TextBox();
            this.btn_termek_felvesz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Új termék felvétele";
            // 
            // tb_vonalkod
            // 
            this.tb_vonalkod.Location = new System.Drawing.Point(15, 78);
            this.tb_vonalkod.Name = "tb_vonalkod";
            this.tb_vonalkod.Size = new System.Drawing.Size(154, 22);
            this.tb_vonalkod.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vonalkód";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Megnevezés";
            // 
            // tb_megnevezes
            // 
            this.tb_megnevezes.Location = new System.Drawing.Point(188, 78);
            this.tb_megnevezes.Name = "tb_megnevezes";
            this.tb_megnevezes.Size = new System.Drawing.Size(154, 22);
            this.tb_megnevezes.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(362, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Típus";
            // 
            // tb_tipus
            // 
            this.tb_tipus.Location = new System.Drawing.Point(365, 78);
            this.tb_tipus.Name = "tb_tipus";
            this.tb_tipus.Size = new System.Drawing.Size(154, 22);
            this.tb_tipus.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Raktáron (db)";
            // 
            // tb_raktaron
            // 
            this.tb_raktaron.Location = new System.Drawing.Point(15, 143);
            this.tb_raktaron.Name = "tb_raktaron";
            this.tb_raktaron.Size = new System.Drawing.Size(154, 22);
            this.tb_raktaron.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Minimum (db)";
            // 
            // tb_minimum
            // 
            this.tb_minimum.Location = new System.Drawing.Point(188, 143);
            this.tb_minimum.Name = "tb_minimum";
            this.tb_minimum.Size = new System.Drawing.Size(154, 22);
            this.tb_minimum.TabIndex = 9;
            // 
            // btn_termek_felvesz
            // 
            this.btn_termek_felvesz.Location = new System.Drawing.Point(365, 142);
            this.btn_termek_felvesz.Name = "btn_termek_felvesz";
            this.btn_termek_felvesz.Size = new System.Drawing.Size(154, 41);
            this.btn_termek_felvesz.TabIndex = 11;
            this.btn_termek_felvesz.Text = "Felvétel";
            this.btn_termek_felvesz.UseVisualStyleBackColor = true;
            this.btn_termek_felvesz.Click += new System.EventHandler(this.btn_termek_felvesz_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 237);
            this.Controls.Add(this.btn_termek_felvesz);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_minimum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_raktaron);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_tipus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_megnevezes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_vonalkod);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_vonalkod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_megnevezes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_tipus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_raktaron;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_minimum;
        private System.Windows.Forms.Button btn_termek_felvesz;
    }
}