
namespace PersonnummerKontroll_Form
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.cmbPersNum = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAngiven = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtCalc = new System.Windows.Forms.TextBox();
            this.cmbCalc = new System.Windows.Forms.Button();
            this.cmbAvsluta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(104, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ange personnummer med 10 siffror";
            // 
            // cmbPersNum
            // 
            this.cmbPersNum.FormattingEnabled = true;
            this.cmbPersNum.Location = new System.Drawing.Point(104, 76);
            this.cmbPersNum.Name = "cmbPersNum";
            this.cmbPersNum.Size = new System.Drawing.Size(397, 33);
            this.cmbPersNum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(104, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ålder";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(104, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kön";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(103, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 32);
            this.label4.TabIndex = 4;
            this.label4.Text = "Beräknad kontrollsiffra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(103, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 32);
            this.label5.TabIndex = 5;
            this.label5.Text = "Angiven kontrollsiffra";
            // 
            // txtAngiven
            // 
            this.txtAngiven.Location = new System.Drawing.Point(363, 179);
            this.txtAngiven.Name = "txtAngiven";
            this.txtAngiven.Size = new System.Drawing.Size(138, 31);
            this.txtAngiven.TabIndex = 6;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(363, 290);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(138, 31);
            this.txtAge.TabIndex = 7;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(363, 253);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(138, 31);
            this.txtGender.TabIndex = 8;
            // 
            // txtCalc
            // 
            this.txtCalc.Location = new System.Drawing.Point(363, 216);
            this.txtCalc.Name = "txtCalc";
            this.txtCalc.Size = new System.Drawing.Size(138, 31);
            this.txtCalc.TabIndex = 9;
            // 
            // cmbCalc
            // 
            this.cmbCalc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmbCalc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCalc.Location = new System.Drawing.Point(363, 353);
            this.cmbCalc.Name = "cmbCalc";
            this.cmbCalc.Size = new System.Drawing.Size(138, 40);
            this.cmbCalc.TabIndex = 10;
            this.cmbCalc.Text = "Beräkna";
            this.cmbCalc.UseVisualStyleBackColor = false;
            this.cmbCalc.Click += new System.EventHandler(this.cmbCalc_Click);
            // 
            // cmbAvsluta
            // 
            this.cmbAvsluta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cmbAvsluta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbAvsluta.Location = new System.Drawing.Point(364, 399);
            this.cmbAvsluta.Name = "cmbAvsluta";
            this.cmbAvsluta.Size = new System.Drawing.Size(138, 40);
            this.cmbAvsluta.TabIndex = 11;
            this.cmbAvsluta.Text = "Avsluta";
            this.cmbAvsluta.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 875);
            this.Controls.Add(this.cmbAvsluta);
            this.Controls.Add(this.cmbCalc);
            this.Controls.Add(this.txtCalc);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtAngiven);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbPersNum);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Personnummer Kontroll";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbPersNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAngiven;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtCalc;
        private System.Windows.Forms.Button cmbCalc;
        private System.Windows.Forms.Button cmbAvsluta;
    }
}

