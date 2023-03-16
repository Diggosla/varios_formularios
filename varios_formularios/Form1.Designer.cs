namespace varios_formularios
{
    partial class form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textinserir1 = new System.Windows.Forms.TextBox();
            this.txtmulti = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bntform = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(266, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Inserir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textinserir1
            // 
            this.textinserir1.Location = new System.Drawing.Point(12, 27);
            this.textinserir1.Multiline = true;
            this.textinserir1.Name = "textinserir1";
            this.textinserir1.Size = new System.Drawing.Size(248, 24);
            this.textinserir1.TabIndex = 1;
            // 
            // txtmulti
            // 
            this.txtmulti.BackColor = System.Drawing.SystemColors.Menu;
            this.txtmulti.Cursor = System.Windows.Forms.Cursors.No;
            this.txtmulti.Enabled = false;
            this.txtmulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmulti.Location = new System.Drawing.Point(12, 57);
            this.txtmulti.Multiline = true;
            this.txtmulti.Name = "txtmulti";
            this.txtmulti.Size = new System.Drawing.Size(329, 310);
            this.txtmulti.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(329, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "Limpar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Digite os nomes de seus convidados";
            // 
            // bntform
            // 
            this.bntform.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bntform.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.bntform.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.bntform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntform.Location = new System.Drawing.Point(12, 403);
            this.bntform.Name = "bntform";
            this.bntform.Size = new System.Drawing.Size(329, 24);
            this.bntform.TabIndex = 5;
            this.bntform.Text = "abrir segundo formulario";
            this.bntform.UseVisualStyleBackColor = false;
            this.bntform.Click += new System.EventHandler(this.bntform_Click);
            // 
            // form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(358, 449);
            this.Controls.Add(this.bntform);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtmulti);
            this.Controls.Add(this.textinserir1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textinserir1;
        private System.Windows.Forms.TextBox txtmulti;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bntform;
    }
}

