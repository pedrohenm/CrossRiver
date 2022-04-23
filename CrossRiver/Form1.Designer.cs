namespace CrossRiver
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLadoEsquerdo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BtnLadoDireito = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SegundoPassageiroBarco = new System.Windows.Forms.Label();
            this.PrimeiroPassageiroBarco = new System.Windows.Forms.Label();
            this.Filho1 = new System.Windows.Forms.Panel();
            this.Filho2 = new System.Windows.Forms.Panel();
            this.Filha1 = new System.Windows.Forms.Panel();
            this.Filha2 = new System.Windows.Forms.Panel();
            this.Pai = new System.Windows.Forms.Panel();
            this.Mae = new System.Windows.Forms.Panel();
            this.Ladrao = new System.Windows.Forms.Panel();
            this.Policial = new System.Windows.Forms.Panel();
            this.PrimeiroPassageiro = new System.Windows.Forms.Label();
            this.SegundoPassageiro = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.BtnLadoEsquerdo);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 523);
            this.panel1.TabIndex = 0;
            // 
            // BtnLadoEsquerdo
            // 
            this.BtnLadoEsquerdo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLadoEsquerdo.Location = new System.Drawing.Point(41, 44);
            this.BtnLadoEsquerdo.Name = "BtnLadoEsquerdo";
            this.BtnLadoEsquerdo.Size = new System.Drawing.Size(178, 90);
            this.BtnLadoEsquerdo.TabIndex = 14;
            this.BtnLadoEsquerdo.Text = "Mandar para o lado direito";
            this.BtnLadoEsquerdo.UseVisualStyleBackColor = true;
            this.BtnLadoEsquerdo.Click += new System.EventHandler(this.BtnLadoEsquerdo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Controls.Add(this.BtnLadoDireito);
            this.panel2.Location = new System.Drawing.Point(878, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 523);
            this.panel2.TabIndex = 1;
            // 
            // BtnLadoDireito
            // 
            this.BtnLadoDireito.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BtnLadoDireito.Location = new System.Drawing.Point(107, 58);
            this.BtnLadoDireito.Name = "BtnLadoDireito";
            this.BtnLadoDireito.Size = new System.Drawing.Size(178, 90);
            this.BtnLadoDireito.TabIndex = 15;
            this.BtnLadoDireito.Text = "Mandar para o lado esquerdo";
            this.BtnLadoDireito.UseVisualStyleBackColor = true;
            this.BtnLadoDireito.Click += new System.EventHandler(this.BtnLadoDireito_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Controls.Add(this.SegundoPassageiroBarco);
            this.panel3.Controls.Add(this.PrimeiroPassageiroBarco);
            this.panel3.Location = new System.Drawing.Point(287, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(610, 523);
            this.panel3.TabIndex = 2;
            // 
            // SegundoPassageiroBarco
            // 
            this.SegundoPassageiroBarco.AutoSize = true;
            this.SegundoPassageiroBarco.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SegundoPassageiroBarco.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SegundoPassageiroBarco.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SegundoPassageiroBarco.Location = new System.Drawing.Point(269, 266);
            this.SegundoPassageiroBarco.Name = "SegundoPassageiroBarco";
            this.SegundoPassageiroBarco.Size = new System.Drawing.Size(0, 25);
            this.SegundoPassageiroBarco.TabIndex = 1;
            // 
            // PrimeiroPassageiroBarco
            // 
            this.PrimeiroPassageiroBarco.AutoSize = true;
            this.PrimeiroPassageiroBarco.BackColor = System.Drawing.Color.DarkSlateGray;
            this.PrimeiroPassageiroBarco.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrimeiroPassageiroBarco.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PrimeiroPassageiroBarco.Location = new System.Drawing.Point(269, 222);
            this.PrimeiroPassageiroBarco.Name = "PrimeiroPassageiroBarco";
            this.PrimeiroPassageiroBarco.Size = new System.Drawing.Size(0, 25);
            this.PrimeiroPassageiroBarco.TabIndex = 0;
            // 
            // Filho1
            // 
            this.Filho1.BackColor = System.Drawing.Color.Orange;
            this.Filho1.Location = new System.Drawing.Point(12, 223);
            this.Filho1.Name = "Filho1";
            this.Filho1.Size = new System.Drawing.Size(47, 60);
            this.Filho1.TabIndex = 8;
            // 
            // Filho2
            // 
            this.Filho2.BackColor = System.Drawing.Color.DarkBlue;
            this.Filho2.Location = new System.Drawing.Point(74, 222);
            this.Filho2.Name = "Filho2";
            this.Filho2.Size = new System.Drawing.Size(47, 60);
            this.Filho2.TabIndex = 9;
            // 
            // Filha1
            // 
            this.Filha1.BackColor = System.Drawing.Color.Violet;
            this.Filha1.Location = new System.Drawing.Point(135, 222);
            this.Filha1.Name = "Filha1";
            this.Filha1.Size = new System.Drawing.Size(47, 60);
            this.Filha1.TabIndex = 10;
            // 
            // Filha2
            // 
            this.Filha2.BackColor = System.Drawing.Color.DarkOrchid;
            this.Filha2.Location = new System.Drawing.Point(197, 222);
            this.Filha2.Name = "Filha2";
            this.Filha2.Size = new System.Drawing.Size(51, 61);
            this.Filha2.TabIndex = 11;
            // 
            // Pai
            // 
            this.Pai.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Pai.Location = new System.Drawing.Point(224, 318);
            this.Pai.Name = "Pai";
            this.Pai.Size = new System.Drawing.Size(45, 91);
            this.Pai.TabIndex = 7;
            // 
            // Mae
            // 
            this.Mae.BackColor = System.Drawing.Color.SlateBlue;
            this.Mae.Location = new System.Drawing.Point(158, 318);
            this.Mae.Name = "Mae";
            this.Mae.Size = new System.Drawing.Size(45, 91);
            this.Mae.TabIndex = 6;
            // 
            // Ladrao
            // 
            this.Ladrao.BackColor = System.Drawing.Color.GhostWhite;
            this.Ladrao.Location = new System.Drawing.Point(81, 318);
            this.Ladrao.Name = "Ladrao";
            this.Ladrao.Size = new System.Drawing.Size(53, 91);
            this.Ladrao.TabIndex = 5;
            // 
            // Policial
            // 
            this.Policial.BackColor = System.Drawing.Color.Blue;
            this.Policial.Location = new System.Drawing.Point(12, 318);
            this.Policial.Name = "Policial";
            this.Policial.Size = new System.Drawing.Size(52, 91);
            this.Policial.TabIndex = 4;
            this.Policial.Tag = "Policial";
            // 
            // PrimeiroPassageiro
            // 
            this.PrimeiroPassageiro.AutoSize = true;
            this.PrimeiroPassageiro.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PrimeiroPassageiro.Location = new System.Drawing.Point(367, 318);
            this.PrimeiroPassageiro.Name = "PrimeiroPassageiro";
            this.PrimeiroPassageiro.Size = new System.Drawing.Size(0, 25);
            this.PrimeiroPassageiro.TabIndex = 12;
            // 
            // SegundoPassageiro
            // 
            this.SegundoPassageiro.AutoSize = true;
            this.SegundoPassageiro.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SegundoPassageiro.Location = new System.Drawing.Point(367, 360);
            this.SegundoPassageiro.Name = "SegundoPassageiro";
            this.SegundoPassageiro.Size = new System.Drawing.Size(0, 25);
            this.SegundoPassageiro.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1219, 525);
            this.Controls.Add(this.SegundoPassageiro);
            this.Controls.Add(this.PrimeiroPassageiro);
            this.Controls.Add(this.Filha2);
            this.Controls.Add(this.Filha1);
            this.Controls.Add(this.Filho2);
            this.Controls.Add(this.Filho1);
            this.Controls.Add(this.Pai);
            this.Controls.Add(this.Mae);
            this.Controls.Add(this.Ladrao);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.Policial);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel Filho1;
        private Panel Filho2;
        private Panel Filha1;
        private Panel Filha2;
        private Panel Pai;
        private Panel Mae;
        private Panel Ladrao;
        private Panel Policial;
        private Label PrimeiroPassageiro;
        private Label SegundoPassageiro;
        private Button BtnLadoEsquerdo;
        private Button BtnLadoDireito;
        private Label SegundoPassageiroBarco;
        private Label PrimeiroPassageiroBarco;
    }
}