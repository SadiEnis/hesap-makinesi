namespace hafta4_odev1_hesapMakinesi
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.button_sin = new System.Windows.Forms.Button();
            this.button_cos = new System.Windows.Forms.Button();
            this.button_cot = new System.Windows.Forms.Button();
            this.button_tan = new System.Windows.Forms.Button();
            this.button_csc = new System.Windows.Forms.Button();
            this.button_sec = new System.Windows.Forms.Button();
            this.button_uslu = new System.Windows.Forms.Button();
            this.deger1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.deger2 = new System.Windows.Forms.Label();
            this.op = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.button_mutlak = new System.Windows.Forms.Button();
            this.button_toplam = new System.Windows.Forms.Button();
            this.button_cikartma = new System.Windows.Forms.Button();
            this.button_log = new System.Windows.Forms.Button();
            this.button_kok = new System.Windows.Forms.Button();
            this.button_fakt = new System.Windows.Forms.Button();
            this.button_mod = new System.Windows.Forms.Button();
            this.button_kokgenel = new System.Windows.Forms.Button();
            this.button_carpim = new System.Windows.Forms.Button();
            this.button_ln = new System.Windows.Forms.Button();
            this.button_bolme = new System.Windows.Forms.Button();
            this.sonuc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::hafta4_odev1_hesapMakinesi.Properties.Resources.images6050;
            this.pictureBox1.Location = new System.Drawing.Point(11, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 60);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.DarkOrange;
            this.button_clear.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_clear.Location = new System.Drawing.Point(11, 87);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(59, 90);
            this.button_clear.TabIndex = 2;
            this.button_clear.Text = "C";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_sin
            // 
            this.button_sin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_sin.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sin.ForeColor = System.Drawing.Color.Black;
            this.button_sin.Location = new System.Drawing.Point(11, 193);
            this.button_sin.Name = "button_sin";
            this.button_sin.Size = new System.Drawing.Size(59, 30);
            this.button_sin.TabIndex = 3;
            this.button_sin.Text = "sin(x)";
            this.button_sin.UseVisualStyleBackColor = false;
            this.button_sin.Click += new System.EventHandler(this.button_sin_Click);
            // 
            // button_cos
            // 
            this.button_cos.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_cos.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_cos.ForeColor = System.Drawing.Color.Black;
            this.button_cos.Location = new System.Drawing.Point(93, 194);
            this.button_cos.Name = "button_cos";
            this.button_cos.Size = new System.Drawing.Size(59, 30);
            this.button_cos.TabIndex = 4;
            this.button_cos.Text = "cos(x)";
            this.button_cos.UseVisualStyleBackColor = false;
            this.button_cos.Click += new System.EventHandler(this.button_cos_Click);
            // 
            // button_cot
            // 
            this.button_cot.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_cot.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_cot.ForeColor = System.Drawing.Color.Black;
            this.button_cot.Location = new System.Drawing.Point(253, 194);
            this.button_cot.Name = "button_cot";
            this.button_cot.Size = new System.Drawing.Size(59, 30);
            this.button_cot.TabIndex = 5;
            this.button_cot.Text = "cot(x)";
            this.button_cot.UseVisualStyleBackColor = false;
            this.button_cot.Click += new System.EventHandler(this.button_cot_Click);
            // 
            // button_tan
            // 
            this.button_tan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_tan.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_tan.ForeColor = System.Drawing.Color.Black;
            this.button_tan.Location = new System.Drawing.Point(173, 194);
            this.button_tan.Name = "button_tan";
            this.button_tan.Size = new System.Drawing.Size(59, 30);
            this.button_tan.TabIndex = 6;
            this.button_tan.Text = "tan(x)";
            this.button_tan.UseVisualStyleBackColor = false;
            this.button_tan.Click += new System.EventHandler(this.button_tan_Click);
            // 
            // button_csc
            // 
            this.button_csc.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_csc.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_csc.ForeColor = System.Drawing.Color.Black;
            this.button_csc.Location = new System.Drawing.Point(411, 194);
            this.button_csc.Name = "button_csc";
            this.button_csc.Size = new System.Drawing.Size(59, 30);
            this.button_csc.TabIndex = 7;
            this.button_csc.Text = "csc(x)";
            this.button_csc.UseVisualStyleBackColor = false;
            this.button_csc.Click += new System.EventHandler(this.button_csc_Click);
            // 
            // button_sec
            // 
            this.button_sec.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_sec.Font = new System.Drawing.Font("Arial", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_sec.ForeColor = System.Drawing.Color.Black;
            this.button_sec.Location = new System.Drawing.Point(336, 194);
            this.button_sec.Name = "button_sec";
            this.button_sec.Size = new System.Drawing.Size(59, 30);
            this.button_sec.TabIndex = 8;
            this.button_sec.Text = "sec(x)";
            this.button_sec.UseVisualStyleBackColor = false;
            this.button_sec.Click += new System.EventHandler(this.button_sec_Click);
            // 
            // button_uslu
            // 
            this.button_uslu.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_uslu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_uslu.Location = new System.Drawing.Point(11, 240);
            this.button_uslu.Name = "button_uslu";
            this.button_uslu.Size = new System.Drawing.Size(101, 51);
            this.button_uslu.TabIndex = 9;
            this.button_uslu.Text = "xʸ";
            this.button_uslu.UseVisualStyleBackColor = false;
            this.button_uslu.Click += new System.EventHandler(this.button_uslu_Click);
            // 
            // deger1
            // 
            this.deger1.AutoSize = true;
            this.deger1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deger1.Location = new System.Drawing.Point(198, 43);
            this.deger1.Name = "deger1";
            this.deger1.Size = new System.Drawing.Size(16, 19);
            this.deger1.TabIndex = 24;
            this.deger1.Text = "x";
            this.deger1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deger1.Click += new System.EventHandler(this.deger1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 25;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(232, 102);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 26;
            // 
            // deger2
            // 
            this.deger2.AutoSize = true;
            this.deger2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deger2.Location = new System.Drawing.Point(198, 103);
            this.deger2.Name = "deger2";
            this.deger2.Size = new System.Drawing.Size(18, 19);
            this.deger2.TabIndex = 27;
            this.deger2.Text = "y";
            // 
            // op
            // 
            this.op.AutoSize = true;
            this.op.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.op.Location = new System.Drawing.Point(259, 74);
            this.op.Name = "op";
            this.op.Size = new System.Drawing.Size(11, 16);
            this.op.TabIndex = 28;
            this.op.Text = " ";
            this.op.Click += new System.EventHandler(this.op_Click);
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.DarkOrange;
            this.button_save.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_save.Location = new System.Drawing.Point(78, 142);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(101, 35);
            this.button_save.TabIndex = 34;
            this.button_save.Text = "SAVE";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_mutlak
            // 
            this.button_mutlak.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_mutlak.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_mutlak.Location = new System.Drawing.Point(133, 320);
            this.button_mutlak.Name = "button_mutlak";
            this.button_mutlak.Size = new System.Drawing.Size(101, 51);
            this.button_mutlak.TabIndex = 35;
            this.button_mutlak.Text = "|x|";
            this.button_mutlak.UseVisualStyleBackColor = false;
            this.button_mutlak.Click += new System.EventHandler(this.button_mutlak_Click);
            // 
            // button_toplam
            // 
            this.button_toplam.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_toplam.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_toplam.Location = new System.Drawing.Point(133, 240);
            this.button_toplam.Name = "button_toplam";
            this.button_toplam.Size = new System.Drawing.Size(101, 51);
            this.button_toplam.TabIndex = 36;
            this.button_toplam.Text = "+";
            this.button_toplam.UseVisualStyleBackColor = false;
            this.button_toplam.Click += new System.EventHandler(this.button_toplam_Click);
            // 
            // button_cikartma
            // 
            this.button_cikartma.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_cikartma.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_cikartma.Location = new System.Drawing.Point(253, 240);
            this.button_cikartma.Name = "button_cikartma";
            this.button_cikartma.Size = new System.Drawing.Size(101, 51);
            this.button_cikartma.TabIndex = 37;
            this.button_cikartma.Text = "−";
            this.button_cikartma.UseVisualStyleBackColor = false;
            this.button_cikartma.Click += new System.EventHandler(this.button_cikartma_Click);
            // 
            // button_log
            // 
            this.button_log.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_log.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_log.Location = new System.Drawing.Point(133, 400);
            this.button_log.Name = "button_log";
            this.button_log.Size = new System.Drawing.Size(101, 51);
            this.button_log.TabIndex = 38;
            this.button_log.Text = "logx^y";
            this.button_log.UseVisualStyleBackColor = false;
            this.button_log.Click += new System.EventHandler(this.button_log_Click);
            // 
            // button_kok
            // 
            this.button_kok.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_kok.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kok.Location = new System.Drawing.Point(11, 320);
            this.button_kok.Name = "button_kok";
            this.button_kok.Size = new System.Drawing.Size(101, 51);
            this.button_kok.TabIndex = 41;
            this.button_kok.Text = "√x";
            this.button_kok.UseVisualStyleBackColor = false;
            this.button_kok.Click += new System.EventHandler(this.button_kok_Click);
            // 
            // button_fakt
            // 
            this.button_fakt.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_fakt.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_fakt.Location = new System.Drawing.Point(253, 320);
            this.button_fakt.Name = "button_fakt";
            this.button_fakt.Size = new System.Drawing.Size(101, 51);
            this.button_fakt.TabIndex = 43;
            this.button_fakt.Text = "x!";
            this.button_fakt.UseVisualStyleBackColor = false;
            this.button_fakt.Click += new System.EventHandler(this.button_fakt_Click);
            // 
            // button_mod
            // 
            this.button_mod.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_mod.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_mod.Location = new System.Drawing.Point(370, 400);
            this.button_mod.Name = "button_mod";
            this.button_mod.Size = new System.Drawing.Size(101, 51);
            this.button_mod.TabIndex = 44;
            this.button_mod.Text = "mod";
            this.button_mod.UseVisualStyleBackColor = false;
            this.button_mod.Click += new System.EventHandler(this.button_mod_Click);
            // 
            // button_kokgenel
            // 
            this.button_kokgenel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_kokgenel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_kokgenel.Location = new System.Drawing.Point(11, 400);
            this.button_kokgenel.Name = "button_kokgenel";
            this.button_kokgenel.Size = new System.Drawing.Size(101, 51);
            this.button_kokgenel.TabIndex = 50;
            this.button_kokgenel.Text = "y√x";
            this.button_kokgenel.UseVisualStyleBackColor = false;
            this.button_kokgenel.Click += new System.EventHandler(this.button_kokgenel_Click);
            // 
            // button_carpim
            // 
            this.button_carpim.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_carpim.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_carpim.Location = new System.Drawing.Point(368, 240);
            this.button_carpim.Name = "button_carpim";
            this.button_carpim.Size = new System.Drawing.Size(101, 51);
            this.button_carpim.TabIndex = 51;
            this.button_carpim.Text = "×";
            this.button_carpim.UseVisualStyleBackColor = false;
            this.button_carpim.Click += new System.EventHandler(this.button_carpim_Click);
            // 
            // button_ln
            // 
            this.button_ln.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_ln.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_ln.Location = new System.Drawing.Point(253, 400);
            this.button_ln.Name = "button_ln";
            this.button_ln.Size = new System.Drawing.Size(101, 51);
            this.button_ln.TabIndex = 52;
            this.button_ln.Text = "lnx";
            this.button_ln.UseVisualStyleBackColor = false;
            this.button_ln.Click += new System.EventHandler(this.button_ln_Click);
            // 
            // button_bolme
            // 
            this.button_bolme.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_bolme.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button_bolme.Location = new System.Drawing.Point(370, 320);
            this.button_bolme.Name = "button_bolme";
            this.button_bolme.Size = new System.Drawing.Size(101, 51);
            this.button_bolme.TabIndex = 53;
            this.button_bolme.Text = "÷";
            this.button_bolme.UseVisualStyleBackColor = false;
            this.button_bolme.Click += new System.EventHandler(this.button_bolme_Click);
            // 
            // sonuc
            // 
            this.sonuc.AutoSize = true;
            this.sonuc.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuc.Location = new System.Drawing.Point(367, 74);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(44, 16);
            this.sonuc.TabIndex = 54;
            this.sonuc.Text = "Sonuç";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(476, 481);
            this.Controls.Add(this.sonuc);
            this.Controls.Add(this.button_bolme);
            this.Controls.Add(this.button_ln);
            this.Controls.Add(this.button_carpim);
            this.Controls.Add(this.button_kokgenel);
            this.Controls.Add(this.button_mod);
            this.Controls.Add(this.button_fakt);
            this.Controls.Add(this.button_kok);
            this.Controls.Add(this.button_log);
            this.Controls.Add(this.button_cikartma);
            this.Controls.Add(this.button_toplam);
            this.Controls.Add(this.button_mutlak);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.op);
            this.Controls.Add(this.deger2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.deger1);
            this.Controls.Add(this.button_uslu);
            this.Controls.Add(this.button_sec);
            this.Controls.Add(this.button_csc);
            this.Controls.Add(this.button_tan);
            this.Controls.Add(this.button_cot);
            this.Controls.Add(this.button_cos);
            this.Controls.Add(this.button_sin);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Hesap Makinesi - Sadi Enis Güçlüer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Button button_sin;
        private System.Windows.Forms.Button button_cos;
        private System.Windows.Forms.Button button_cot;
        private System.Windows.Forms.Button button_tan;
        private System.Windows.Forms.Button button_csc;
        private System.Windows.Forms.Button button_sec;
        private System.Windows.Forms.Button button_uslu;
        private System.Windows.Forms.Label deger1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label deger2;
        private System.Windows.Forms.Label op;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_mutlak;
        private System.Windows.Forms.Button button_toplam;
        private System.Windows.Forms.Button button_cikartma;
        private System.Windows.Forms.Button button_log;
        private System.Windows.Forms.Button button_kok;
        private System.Windows.Forms.Button button_fakt;
        private System.Windows.Forms.Button button_mod;
        private System.Windows.Forms.Button button_kokgenel;
        private System.Windows.Forms.Button button_carpim;
        private System.Windows.Forms.Button button_ln;
        private System.Windows.Forms.Button button_bolme;
        private System.Windows.Forms.Label sonuc;
    }
}

