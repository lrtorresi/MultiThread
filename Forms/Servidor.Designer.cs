namespace mdc.m7.setup
{
    partial class Servidor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Servidor));
            this.label4 = new System.Windows.Forms.Label();
            this.estacao = new System.Windows.Forms.Button();
            this.srv = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.msgInstalacao = new System.Windows.Forms.Label();
            this.msgInstalacao2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(129, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 18);
            this.label4.TabIndex = 22;
            this.label4.Text = "Escolha uma opção abaixo (SERVIDOR):";
            // 
            // estacao
            // 
            this.estacao.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estacao.Location = new System.Drawing.Point(409, 158);
            this.estacao.Margin = new System.Windows.Forms.Padding(6);
            this.estacao.Name = "estacao";
            this.estacao.Size = new System.Drawing.Size(128, 45);
            this.estacao.TabIndex = 24;
            this.estacao.Text = "ATUALIZAÇÃO";
            this.estacao.UseVisualStyleBackColor = true;
            this.estacao.Click += new System.EventHandler(this.Estacao_Click);
            // 
            // srv
            // 
            this.srv.FlatAppearance.BorderSize = 2;
            this.srv.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srv.Location = new System.Drawing.Point(228, 158);
            this.srv.Margin = new System.Windows.Forms.Padding(6);
            this.srv.Name = "srv";
            this.srv.Size = new System.Drawing.Size(128, 45);
            this.srv.TabIndex = 23;
            this.srv.Text = "NOVA INSTALAÇÃO";
            this.srv.UseVisualStyleBackColor = true;
            this.srv.Click += new System.EventHandler(this.Srv_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(644, 364);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 29);
            this.button1.TabIndex = 25;
            this.button1.Text = "VOLTAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // msgInstalacao
            // 
            this.msgInstalacao.AutoSize = true;
            this.msgInstalacao.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgInstalacao.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.msgInstalacao.Location = new System.Drawing.Point(129, 118);
            this.msgInstalacao.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.msgInstalacao.Name = "msgInstalacao";
            this.msgInstalacao.Size = new System.Drawing.Size(448, 18);
            this.msgInstalacao.TabIndex = 26;
            this.msgInstalacao.Text = "Aguarde, estamos configurando o sistema MDC para você...";
            this.msgInstalacao.Visible = false;
            this.msgInstalacao.Click += new System.EventHandler(this.msgInstalacao_Click);
            // 
            // msgInstalacao2
            // 
            this.msgInstalacao2.AutoSize = true;
            this.msgInstalacao2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msgInstalacao2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.msgInstalacao2.Location = new System.Drawing.Point(129, 139);
            this.msgInstalacao2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.msgInstalacao2.Name = "msgInstalacao2";
            this.msgInstalacao2.Size = new System.Drawing.Size(314, 14);
            this.msgInstalacao2.TabIndex = 27;
            this.msgInstalacao2.Text = "(Essa configuração pode demorar alguns minutos)";
            this.msgInstalacao2.Visible = false;
            this.msgInstalacao2.Click += new System.EventHandler(this.Label9_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 438);
            this.pictureBox1.TabIndex = 68;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(129, 385);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "(c) 2019 MDC Software ❤";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(129, 362);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(227, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "pode resultar em penalidades civis e criminais.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(129, 338);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(436, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "Copiar, distribuir ou reproduzir este programa ou parte dele, sem autorização por" +
    " escrito,";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(129, 315);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(442, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Este programa está protegido por leis internacionais de copyright contra reproduç" +
    "ão ilegal.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::mdc.m7.setup.Properties.Resources.horizontal_line;
            this.pictureBox2.Location = new System.Drawing.Point(99, 73);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(636, 2);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 63;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(129, 45);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(345, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Este programa irá instalar\\atualizar o sistema MDC em seu computador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(129, 29);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Bem-vindo a instalação\\atualização do sistema MDC Software.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(129, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Olá, ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(132, 158);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(342, 47);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 69;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // Servidor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(741, 412);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msgInstalacao2);
            this.Controls.Add(this.estacao);
            this.Controls.Add(this.srv);
            this.Controls.Add(this.msgInstalacao);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox3);
            this.Font = new System.Drawing.Font("Tahoma", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Servidor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Servidor";
            this.Load += new System.EventHandler(this.Servidor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button estacao;
        private System.Windows.Forms.Button srv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label msgInstalacao;
        private System.Windows.Forms.Label msgInstalacao2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}