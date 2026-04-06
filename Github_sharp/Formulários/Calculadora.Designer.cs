namespace Github_csharp.Formulários
{
    partial class Calculadora
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
            this.panel1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCE = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.trocabtn = new System.Windows.Forms.Button();
            this.virgulabtn = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.expobtn = new System.Windows.Forms.Button();
            this.divbtn = new System.Windows.Forms.Button();
            this.multibtn = new System.Windows.Forms.Button();
            this.subbtn = new System.Windows.Forms.Button();
            this.somabtn = new System.Windows.Forms.Button();
            this.visorlbl = new System.Windows.Forms.Label();
            this.btnIgual = new System.Windows.Forms.Button();
            this.lblHistorico = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.lblCE);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.trocabtn);
            this.panel1.Controls.Add(this.virgulabtn);
            this.panel1.Controls.Add(this.button0);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.button7);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(32, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 373);
            this.panel1.TabIndex = 2;
            this.panel1.TabStop = false;
            this.panel1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 30);
            this.label1.TabIndex = 10;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(198, 25);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(71, 62);
            this.btnBack.TabIndex = 17;
            this.btnBack.Text = "<=";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCE
            // 
            this.lblCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCE.Location = new System.Drawing.Point(107, 25);
            this.lblCE.Name = "lblCE";
            this.lblCE.Size = new System.Drawing.Size(71, 62);
            this.lblCE.TabIndex = 16;
            this.lblCE.Text = "CE";
            this.lblCE.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(21, 25);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(71, 62);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // trocabtn
            // 
            this.trocabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trocabtn.Location = new System.Drawing.Point(21, 297);
            this.trocabtn.Name = "trocabtn";
            this.trocabtn.Size = new System.Drawing.Size(71, 62);
            this.trocabtn.TabIndex = 14;
            this.trocabtn.Text = "+/-";
            this.trocabtn.UseVisualStyleBackColor = true;
            this.trocabtn.Click += new System.EventHandler(this.trocabtn_Click);
            // 
            // virgulabtn
            // 
            this.virgulabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.virgulabtn.Location = new System.Drawing.Point(198, 297);
            this.virgulabtn.Name = "virgulabtn";
            this.virgulabtn.Size = new System.Drawing.Size(71, 62);
            this.virgulabtn.TabIndex = 13;
            this.virgulabtn.Text = ",";
            this.virgulabtn.UseVisualStyleBackColor = true;
            this.virgulabtn.Click += new System.EventHandler(this.virgulabtn_Click);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button0.Location = new System.Drawing.Point(107, 297);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(71, 62);
            this.button0.TabIndex = 12;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.f_digitos);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(198, 229);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(71, 62);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.f_digitos);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(107, 229);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(71, 62);
            this.button8.TabIndex = 10;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.f_digitos);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(21, 230);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(71, 62);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.f_digitos);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(198, 161);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 62);
            this.button6.TabIndex = 8;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.f_digitos);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(107, 161);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(71, 62);
            this.button5.TabIndex = 7;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.f_digitos);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(21, 161);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(71, 62);
            this.button4.TabIndex = 6;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.f_digitos);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(198, 93);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 62);
            this.button3.TabIndex = 5;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.f_digitos);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(107, 93);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 62);
            this.button2.TabIndex = 4;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.f_digitos);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(21, 93);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(71, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.f_digitos);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.expobtn);
            this.groupBox2.Controls.Add(this.divbtn);
            this.groupBox2.Controls.Add(this.multibtn);
            this.groupBox2.Controls.Add(this.subbtn);
            this.groupBox2.Controls.Add(this.somabtn);
            this.groupBox2.Location = new System.Drawing.Point(336, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(107, 373);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // expobtn
            // 
            this.expobtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expobtn.Location = new System.Drawing.Point(7, 297);
            this.expobtn.Name = "expobtn";
            this.expobtn.Size = new System.Drawing.Size(94, 62);
            this.expobtn.TabIndex = 7;
            this.expobtn.Text = "^";
            this.expobtn.UseVisualStyleBackColor = true;
            this.expobtn.Click += new System.EventHandler(this.f_operacoes);
            // 
            // divbtn
            // 
            this.divbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divbtn.Location = new System.Drawing.Point(7, 229);
            this.divbtn.Name = "divbtn";
            this.divbtn.Size = new System.Drawing.Size(94, 62);
            this.divbtn.TabIndex = 6;
            this.divbtn.Text = ":";
            this.divbtn.UseVisualStyleBackColor = true;
            this.divbtn.Click += new System.EventHandler(this.f_operacoes);
            // 
            // multibtn
            // 
            this.multibtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multibtn.Location = new System.Drawing.Point(7, 162);
            this.multibtn.Name = "multibtn";
            this.multibtn.Size = new System.Drawing.Size(94, 62);
            this.multibtn.TabIndex = 5;
            this.multibtn.Text = "x";
            this.multibtn.UseVisualStyleBackColor = true;
            this.multibtn.Click += new System.EventHandler(this.f_operacoes);
            // 
            // subbtn
            // 
            this.subbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subbtn.Location = new System.Drawing.Point(7, 106);
            this.subbtn.Name = "subbtn";
            this.subbtn.Size = new System.Drawing.Size(94, 62);
            this.subbtn.TabIndex = 4;
            this.subbtn.Text = "-";
            this.subbtn.UseVisualStyleBackColor = true;
            this.subbtn.Click += new System.EventHandler(this.f_operacoes);
            // 
            // somabtn
            // 
            this.somabtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.somabtn.Location = new System.Drawing.Point(6, 25);
            this.somabtn.Name = "somabtn";
            this.somabtn.Size = new System.Drawing.Size(94, 62);
            this.somabtn.TabIndex = 4;
            this.somabtn.Text = "+";
            this.somabtn.UseVisualStyleBackColor = true;
            this.somabtn.Click += new System.EventHandler(this.f_operacoes);
            // 
            // visorlbl
            // 
            this.visorlbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.visorlbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.visorlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visorlbl.Location = new System.Drawing.Point(32, 39);
            this.visorlbl.Name = "visorlbl";
            this.visorlbl.Size = new System.Drawing.Size(411, 51);
            this.visorlbl.TabIndex = 5;
            this.visorlbl.Text = "0";
            this.visorlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.visorlbl.Click += new System.EventHandler(this.visorlbl_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(32, 472);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(411, 50);
            this.btnIgual.TabIndex = 8;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // lblHistorico
            // 
            this.lblHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHistorico.Location = new System.Drawing.Point(343, 2);
            this.lblHistorico.Name = "lblHistorico";
            this.lblHistorico.Size = new System.Drawing.Size(100, 37);
            this.lblHistorico.TabIndex = 9;
            this.lblHistorico.Text = "0";
            this.lblHistorico.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(461, 538);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHistorico);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.visorlbl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Calculadora";
            this.Click += new System.EventHandler(this.f_operacoes);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Calculadora_keydown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Calculadora_keyup);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button somabtn;
        private System.Windows.Forms.Button subbtn;
        private System.Windows.Forms.Button divbtn;
        private System.Windows.Forms.Button multibtn;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Label visorlbl;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button lblCE;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button trocabtn;
        private System.Windows.Forms.Button virgulabtn;
        private System.Windows.Forms.Button expobtn;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Label lblHistorico;
        private System.Windows.Forms.Label label1;
    }
}