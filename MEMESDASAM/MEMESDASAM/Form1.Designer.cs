namespace MEMESDASAM
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxBaixo = new System.Windows.Forms.TextBox();
            this.textBoxCima = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelCima = new System.Windows.Forms.Label();
            this.labelBaixo = new System.Windows.Forms.Label();
            this.buttonAbrir = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonPreto = new System.Windows.Forms.Button();
            this.buttonBranco = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxBaixo);
            this.groupBox1.Controls.Add(this.textBoxCima);
            this.groupBox1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 399);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "EDITAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Texto Baixo";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Texto Cima";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxBaixo
            // 
            this.textBoxBaixo.Location = new System.Drawing.Point(29, 245);
            this.textBoxBaixo.Multiline = true;
            this.textBoxBaixo.Name = "textBoxBaixo";
            this.textBoxBaixo.Size = new System.Drawing.Size(273, 80);
            this.textBoxBaixo.TabIndex = 1;
            this.textBoxBaixo.TextChanged += new System.EventHandler(this.textBoxBaixo_TextChanged);
            // 
            // textBoxCima
            // 
            this.textBoxCima.Location = new System.Drawing.Point(29, 50);
            this.textBoxCima.Multiline = true;
            this.textBoxCima.Name = "textBoxCima";
            this.textBoxCima.Size = new System.Drawing.Size(273, 80);
            this.textBoxCima.TabIndex = 0;
            this.textBoxCima.TextChanged += new System.EventHandler(this.textBoxCima_TextChanged);
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(436, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(352, 399);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // labelCima
            // 
            this.labelCima.AutoSize = true;
            this.labelCima.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCima.ForeColor = System.Drawing.Color.White;
            this.labelCima.Location = new System.Drawing.Point(473, 44);
            this.labelCima.Name = "labelCima";
            this.labelCima.Size = new System.Drawing.Size(292, 45);
            this.labelCima.TabIndex = 2;
            this.labelCima.Text = "TEXTO DE CIMA";
            this.labelCima.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBaixo
            // 
            this.labelBaixo.AutoSize = true;
            this.labelBaixo.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBaixo.ForeColor = System.Drawing.Color.White;
            this.labelBaixo.Location = new System.Drawing.Point(462, 338);
            this.labelBaixo.Name = "labelBaixo";
            this.labelBaixo.Size = new System.Drawing.Size(313, 45);
            this.labelBaixo.TabIndex = 3;
            this.labelBaixo.Text = "TEXTO DE BAIXO";
            this.labelBaixo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAbrir
            // 
            this.buttonAbrir.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbrir.Location = new System.Drawing.Point(436, 417);
            this.buttonAbrir.Name = "buttonAbrir";
            this.buttonAbrir.Size = new System.Drawing.Size(177, 30);
            this.buttonAbrir.TabIndex = 4;
            this.buttonAbrir.Text = "ABRIR";
            this.buttonAbrir.UseVisualStyleBackColor = true;
            this.buttonAbrir.Click += new System.EventHandler(this.buttonAbrir_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalvar.Location = new System.Drawing.Point(619, 417);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(169, 30);
            this.buttonSalvar.TabIndex = 5;
            this.buttonSalvar.Text = "SALVAR";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonPreto
            // 
            this.buttonPreto.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPreto.Location = new System.Drawing.Point(12, 417);
            this.buttonPreto.Name = "buttonPreto";
            this.buttonPreto.Size = new System.Drawing.Size(126, 30);
            this.buttonPreto.TabIndex = 6;
            this.buttonPreto.Text = "PRETO";
            this.buttonPreto.UseVisualStyleBackColor = true;
            this.buttonPreto.Click += new System.EventHandler(this.buttonPreto_Click);
            // 
            // buttonBranco
            // 
            this.buttonBranco.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBranco.Location = new System.Drawing.Point(211, 417);
            this.buttonBranco.Name = "buttonBranco";
            this.buttonBranco.Size = new System.Drawing.Size(128, 30);
            this.buttonBranco.TabIndex = 7;
            this.buttonBranco.Text = "BRANCO";
            this.buttonBranco.UseVisualStyleBackColor = true;
            this.buttonBranco.Click += new System.EventHandler(this.buttonBranco_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MEMESDASAM.Properties.Resources.a;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonBranco);
            this.Controls.Add(this.buttonPreto);
            this.Controls.Add(this.buttonSalvar);
            this.Controls.Add(this.buttonAbrir);
            this.Controls.Add(this.labelBaixo);
            this.Controls.Add(this.labelCima);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MEMEZADA DA GALERA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxBaixo;
        private System.Windows.Forms.TextBox textBoxCima;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelCima;
        private System.Windows.Forms.Label labelBaixo;
        private System.Windows.Forms.Button buttonAbrir;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonPreto;
        private System.Windows.Forms.Button buttonBranco;
    }
}

