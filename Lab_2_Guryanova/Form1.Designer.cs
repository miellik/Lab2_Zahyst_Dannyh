
namespace Lab_2_Guryanova
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
            this.textBox_P = new System.Windows.Forms.TextBox();
            this.textBox_Key = new System.Windows.Forms.TextBox();
            this.textBox_C = new System.Windows.Forms.TextBox();
            this.button1_XOR = new System.Windows.Forms.Button();
            this.button_clean = new System.Windows.Forms.Button();
            this.labelBinP = new System.Windows.Forms.Label();
            this.labelDecimalP = new System.Windows.Forms.Label();
            this.labelDecimalKey = new System.Windows.Forms.Label();
            this.labelBinKey = new System.Windows.Forms.Label();
            this.labelDecimalC = new System.Windows.Forms.Label();
            this.labelBinC = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_C_reverse = new System.Windows.Forms.TextBox();
            this.textBox_Key_reverse = new System.Windows.Forms.TextBox();
            this.textBox_P_reverse = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Key";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "C";
            // 
            // textBox_P
            // 
            this.textBox_P.Location = new System.Drawing.Point(75, 36);
            this.textBox_P.Name = "textBox_P";
            this.textBox_P.Size = new System.Drawing.Size(100, 20);
            this.textBox_P.TabIndex = 3;
            // 
            // textBox_Key
            // 
            this.textBox_Key.Location = new System.Drawing.Point(75, 90);
            this.textBox_Key.Name = "textBox_Key";
            this.textBox_Key.Size = new System.Drawing.Size(100, 20);
            this.textBox_Key.TabIndex = 4;
            // 
            // textBox_C
            // 
            this.textBox_C.Location = new System.Drawing.Point(75, 142);
            this.textBox_C.Name = "textBox_C";
            this.textBox_C.Size = new System.Drawing.Size(100, 20);
            this.textBox_C.TabIndex = 5;
            // 
            // button1_XOR
            // 
            this.button1_XOR.Location = new System.Drawing.Point(237, 185);
            this.button1_XOR.Name = "button1_XOR";
            this.button1_XOR.Size = new System.Drawing.Size(75, 23);
            this.button1_XOR.TabIndex = 6;
            this.button1_XOR.Text = "XOR";
            this.button1_XOR.UseVisualStyleBackColor = true;
            this.button1_XOR.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_clean
            // 
            this.button_clean.Location = new System.Drawing.Point(87, 180);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(75, 23);
            this.button_clean.TabIndex = 7;
            this.button_clean.Text = "Прибрати";
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // labelBinP
            // 
            this.labelBinP.AutoSize = true;
            this.labelBinP.Location = new System.Drawing.Point(181, 25);
            this.labelBinP.Name = "labelBinP";
            this.labelBinP.Size = new System.Drawing.Size(0, 13);
            this.labelBinP.TabIndex = 8;
            // 
            // labelDecimalP
            // 
            this.labelDecimalP.AutoSize = true;
            this.labelDecimalP.Location = new System.Drawing.Point(181, 52);
            this.labelDecimalP.Name = "labelDecimalP";
            this.labelDecimalP.Size = new System.Drawing.Size(0, 13);
            this.labelDecimalP.TabIndex = 9;
            // 
            // labelDecimalKey
            // 
            this.labelDecimalKey.AutoSize = true;
            this.labelDecimalKey.Location = new System.Drawing.Point(181, 106);
            this.labelDecimalKey.Name = "labelDecimalKey";
            this.labelDecimalKey.Size = new System.Drawing.Size(0, 13);
            this.labelDecimalKey.TabIndex = 11;
            // 
            // labelBinKey
            // 
            this.labelBinKey.AutoSize = true;
            this.labelBinKey.Location = new System.Drawing.Point(181, 79);
            this.labelBinKey.Name = "labelBinKey";
            this.labelBinKey.Size = new System.Drawing.Size(0, 13);
            this.labelBinKey.TabIndex = 10;
            // 
            // labelDecimalC
            // 
            this.labelDecimalC.AutoSize = true;
            this.labelDecimalC.Location = new System.Drawing.Point(181, 165);
            this.labelDecimalC.Name = "labelDecimalC";
            this.labelDecimalC.Size = new System.Drawing.Size(0, 13);
            this.labelDecimalC.TabIndex = 13;
            // 
            // labelBinC
            // 
            this.labelBinC.AutoSize = true;
            this.labelBinC.Location = new System.Drawing.Point(181, 138);
            this.labelBinC.Name = "labelBinC";
            this.labelBinC.Size = new System.Drawing.Size(0, 13);
            this.labelBinC.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(496, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(496, 32);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(496, 106);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(496, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 22;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(496, 158);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 13);
            this.label14.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(496, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 20;
            // 
            // textBox_C_reverse
            // 
            this.textBox_C_reverse.Location = new System.Drawing.Point(390, 36);
            this.textBox_C_reverse.Name = "textBox_C_reverse";
            this.textBox_C_reverse.Size = new System.Drawing.Size(100, 20);
            this.textBox_C_reverse.TabIndex = 19;
            // 
            // textBox_Key_reverse
            // 
            this.textBox_Key_reverse.Location = new System.Drawing.Point(390, 90);
            this.textBox_Key_reverse.Name = "textBox_Key_reverse";
            this.textBox_Key_reverse.Size = new System.Drawing.Size(100, 20);
            this.textBox_Key_reverse.TabIndex = 18;
            // 
            // textBox_P_reverse
            // 
            this.textBox_P_reverse.Location = new System.Drawing.Point(390, 142);
            this.textBox_P_reverse.Name = "textBox_P_reverse";
            this.textBox_P_reverse.Size = new System.Drawing.Size(100, 20);
            this.textBox_P_reverse.TabIndex = 17;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(352, 39);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "C";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(352, 93);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(25, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "Key";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(352, 149);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 13);
            this.label18.TabIndex = 14;
            this.label18.Text = "P";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 240);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox_C_reverse);
            this.Controls.Add(this.textBox_Key_reverse);
            this.Controls.Add(this.textBox_P_reverse);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.labelDecimalC);
            this.Controls.Add(this.labelBinC);
            this.Controls.Add(this.labelDecimalKey);
            this.Controls.Add(this.labelBinKey);
            this.Controls.Add(this.labelDecimalP);
            this.Controls.Add(this.labelBinP);
            this.Controls.Add(this.button_clean);
            this.Controls.Add(this.button1_XOR);
            this.Controls.Add(this.textBox_C);
            this.Controls.Add(this.textBox_Key);
            this.Controls.Add(this.textBox_P);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Xor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_P;
        private System.Windows.Forms.TextBox textBox_Key;
        private System.Windows.Forms.TextBox textBox_C;
        private System.Windows.Forms.Button button1_XOR;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Label labelBinP;
        private System.Windows.Forms.Label labelDecimalP;
        private System.Windows.Forms.Label labelDecimalKey;
        private System.Windows.Forms.Label labelBinKey;
        private System.Windows.Forms.Label labelDecimalC;
        private System.Windows.Forms.Label labelBinC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_C_reverse;
        private System.Windows.Forms.TextBox textBox_Key_reverse;
        private System.Windows.Forms.TextBox textBox_P_reverse;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
    }
}

