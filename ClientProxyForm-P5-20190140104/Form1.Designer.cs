
namespace ClientProxyForm_P5_20190140104
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lTambah = new System.Windows.Forms.Label();
            this.lKurang = new System.Windows.Forms.Label();
            this.lKali = new System.Windows.Forms.Label();
            this.lBagi = new System.Windows.Forms.Label();
            this.btnHasil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angka 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Angka 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasil Penjumlahan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hasil Pengurangan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hasil Perkalian";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hasil Pembagian";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(253, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(135, 22);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(253, 190);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(135, 22);
            this.textBox2.TabIndex = 7;
            // 
            // lTambah
            // 
            this.lTambah.AutoSize = true;
            this.lTambah.Location = new System.Drawing.Point(631, 126);
            this.lTambah.Name = "lTambah";
            this.lTambah.Size = new System.Drawing.Size(0, 17);
            this.lTambah.TabIndex = 8;
            // 
            // lKurang
            // 
            this.lKurang.AutoSize = true;
            this.lKurang.Location = new System.Drawing.Point(631, 167);
            this.lKurang.Name = "lKurang";
            this.lKurang.Size = new System.Drawing.Size(0, 17);
            this.lKurang.TabIndex = 9;
            // 
            // lKali
            // 
            this.lKali.AutoSize = true;
            this.lKali.Location = new System.Drawing.Point(631, 210);
            this.lKali.Name = "lKali";
            this.lKali.Size = new System.Drawing.Size(0, 17);
            this.lKali.TabIndex = 10;
            // 
            // lBagi
            // 
            this.lBagi.AutoSize = true;
            this.lBagi.Location = new System.Drawing.Point(631, 252);
            this.lBagi.Name = "lBagi";
            this.lBagi.Size = new System.Drawing.Size(0, 17);
            this.lBagi.TabIndex = 11;
            // 
            // btnHasil
            // 
            this.btnHasil.Location = new System.Drawing.Point(302, 279);
            this.btnHasil.Name = "btnHasil";
            this.btnHasil.Size = new System.Drawing.Size(86, 37);
            this.btnHasil.TabIndex = 12;
            this.btnHasil.Text = "Hitung";
            this.btnHasil.UseVisualStyleBackColor = true;
            this.btnHasil.Click += new System.EventHandler(this.btnHasil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHasil);
            this.Controls.Add(this.lBagi);
            this.Controls.Add(this.lKali);
            this.Controls.Add(this.lKurang);
            this.Controls.Add(this.lTambah);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lTambah;
        private System.Windows.Forms.Label lKurang;
        private System.Windows.Forms.Label lKali;
        private System.Windows.Forms.Label lBagi;
        private System.Windows.Forms.Button btnHasil;
    }
}

