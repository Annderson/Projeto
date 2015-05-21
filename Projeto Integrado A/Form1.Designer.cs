namespace Projeto_Integrado_A
{
    partial class P_Integrado_A
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P_Integrado_A));
            this.LBLnum = new System.Windows.Forms.Label();
            this.BUTvap = new System.Windows.Forms.Button();
            this.BUTlimp = new System.Windows.Forms.Button();
            this.BUTcons = new System.Windows.Forms.Button();
            this.TXTent = new System.Windows.Forms.TextBox();
            this.LBLsaida = new System.Windows.Forms.Label();
            this.LBLregras = new System.Windows.Forms.Label();
            this.BUTregras = new System.Windows.Forms.Button();
            this.TXTconsult = new System.Windows.Forms.TextBox();
            this.LBLconsulta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LBLnum
            // 
            this.LBLnum.AutoSize = true;
            this.LBLnum.BackColor = System.Drawing.Color.White;
            this.LBLnum.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLnum.ForeColor = System.Drawing.Color.Blue;
            this.LBLnum.Location = new System.Drawing.Point(22, 439);
            this.LBLnum.Name = "LBLnum";
            this.LBLnum.Size = new System.Drawing.Size(234, 17);
            this.LBLnum.TabIndex = 0;
            this.LBLnum.Text = "Digite os números que deseja apostar:";
            // 
            // BUTvap
            // 
            this.BUTvap.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTvap.ForeColor = System.Drawing.Color.Blue;
            this.BUTvap.Location = new System.Drawing.Point(25, 488);
            this.BUTvap.Name = "BUTvap";
            this.BUTvap.Size = new System.Drawing.Size(115, 23);
            this.BUTvap.TabIndex = 2;
            this.BUTvap.Text = "Validar aposta.";
            this.BUTvap.UseVisualStyleBackColor = true;
            this.BUTvap.Click += new System.EventHandler(this.BUTvap_Click);
            // 
            // BUTlimp
            // 
            this.BUTlimp.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTlimp.ForeColor = System.Drawing.Color.Blue;
            this.BUTlimp.Location = new System.Drawing.Point(155, 487);
            this.BUTlimp.Name = "BUTlimp";
            this.BUTlimp.Size = new System.Drawing.Size(116, 24);
            this.BUTlimp.TabIndex = 3;
            this.BUTlimp.Text = "Limpar";
            this.BUTlimp.UseVisualStyleBackColor = true;
            this.BUTlimp.Click += new System.EventHandler(this.BUTlimp_Click);
            // 
            // BUTcons
            // 
            this.BUTcons.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTcons.ForeColor = System.Drawing.Color.Blue;
            this.BUTcons.Location = new System.Drawing.Point(410, 488);
            this.BUTcons.Name = "BUTcons";
            this.BUTcons.Size = new System.Drawing.Size(120, 23);
            this.BUTcons.TabIndex = 4;
            this.BUTcons.Text = "Consultar aposta.";
            this.BUTcons.UseVisualStyleBackColor = true;
            this.BUTcons.Click += new System.EventHandler(this.BUTcons_Click);
            // 
            // TXTent
            // 
            this.TXTent.AutoCompleteCustomSource.AddRange(new string[] {
            "100"});
            this.TXTent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.TXTent.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTent.ForeColor = System.Drawing.Color.Red;
            this.TXTent.Location = new System.Drawing.Point(25, 459);
            this.TXTent.MaxLength = 59;
            this.TXTent.Name = "TXTent";
            this.TXTent.Size = new System.Drawing.Size(348, 22);
            this.TXTent.TabIndex = 6;
            this.TXTent.TextChanged += new System.EventHandler(this.TXTent_TextChanged);
            this.TXTent.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTent_KeyPress);
            // 
            // LBLsaida
            // 
            this.LBLsaida.BackColor = System.Drawing.Color.White;
            this.LBLsaida.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLsaida.ForeColor = System.Drawing.Color.Red;
            this.LBLsaida.Location = new System.Drawing.Point(620, 9);
            this.LBLsaida.Name = "LBLsaida";
            this.LBLsaida.Size = new System.Drawing.Size(30, 11);
            this.LBLsaida.TabIndex = 7;
            this.LBLsaida.Visible = false;
            this.LBLsaida.Click += new System.EventHandler(this.LBLsaida_Click);
            // 
            // LBLregras
            // 
            this.LBLregras.BackColor = System.Drawing.SystemColors.Control;
            this.LBLregras.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LBLregras.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLregras.ForeColor = System.Drawing.Color.Blue;
            this.LBLregras.Location = new System.Drawing.Point(79, 79);
            this.LBLregras.Name = "LBLregras";
            this.LBLregras.Size = new System.Drawing.Size(501, 263);
            this.LBLregras.TabIndex = 8;
            this.LBLregras.Click += new System.EventHandler(this.LBLregras_Click);
            // 
            // BUTregras
            // 
            this.BUTregras.BackColor = System.Drawing.SystemColors.Control;
            this.BUTregras.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTregras.ForeColor = System.Drawing.Color.Blue;
            this.BUTregras.Location = new System.Drawing.Point(552, 521);
            this.BUTregras.Name = "BUTregras";
            this.BUTregras.Size = new System.Drawing.Size(98, 23);
            this.BUTregras.TabIndex = 9;
            this.BUTregras.Text = "Regras";
            this.BUTregras.UseVisualStyleBackColor = false;
            this.BUTregras.Click += new System.EventHandler(this.BUTregras_Click);
            // 
            // TXTconsult
            // 
            this.TXTconsult.Location = new System.Drawing.Point(410, 459);
            this.TXTconsult.Multiline = true;
            this.TXTconsult.Name = "TXTconsult";
            this.TXTconsult.Size = new System.Drawing.Size(158, 22);
            this.TXTconsult.TabIndex = 10;
            this.TXTconsult.TextChanged += new System.EventHandler(this.TXTconsult_TextChanged);
            this.TXTconsult.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXTconsult_KeyPress);
            // 
            // LBLconsulta
            // 
            this.LBLconsulta.AutoSize = true;
            this.LBLconsulta.BackColor = System.Drawing.Color.White;
            this.LBLconsulta.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLconsulta.ForeColor = System.Drawing.Color.Blue;
            this.LBLconsulta.Location = new System.Drawing.Point(407, 439);
            this.LBLconsulta.Name = "LBLconsulta";
            this.LBLconsulta.Size = new System.Drawing.Size(228, 17);
            this.LBLconsulta.TabIndex = 11;
            this.LBLconsulta.Text = "Digite nº do Protocolo para Consulta:";
            this.LBLconsulta.Click += new System.EventHandler(this.label1_Click);
            // 
            // P_Integrado_A
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(662, 556);
            this.Controls.Add(this.LBLconsulta);
            this.Controls.Add(this.TXTconsult);
            this.Controls.Add(this.BUTregras);
            this.Controls.Add(this.LBLregras);
            this.Controls.Add(this.LBLsaida);
            this.Controls.Add(this.TXTent);
            this.Controls.Add(this.BUTcons);
            this.Controls.Add(this.BUTlimp);
            this.Controls.Add(this.BUTvap);
            this.Controls.Add(this.LBLnum);
            this.Name = "P_Integrado_A";
            this.Text = "MEGA TIME";
            this.Load += new System.EventHandler(this.P_Integrado_A_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLnum;
        private System.Windows.Forms.Button BUTvap;
        private System.Windows.Forms.Button BUTlimp;
        private System.Windows.Forms.Button BUTcons;
        private System.Windows.Forms.TextBox TXTent;
        private System.Windows.Forms.Label LBLsaida;
        private System.Windows.Forms.Label LBLregras;
        private System.Windows.Forms.Button BUTregras;
        private System.Windows.Forms.TextBox TXTconsult;
        private System.Windows.Forms.Label LBLconsulta;
    }
}

