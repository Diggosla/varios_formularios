namespace varios_formularios
{
    partial class Form2
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
            this.textBoxMultiTexto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxMultiTexto
            // 
            this.textBoxMultiTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxMultiTexto.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxMultiTexto.Enabled = false;
            this.textBoxMultiTexto.Location = new System.Drawing.Point(12, 12);
            this.textBoxMultiTexto.Multiline = true;
            this.textBoxMultiTexto.Name = "textBoxMultiTexto";
            this.textBoxMultiTexto.Size = new System.Drawing.Size(313, 426);
            this.textBoxMultiTexto.TabIndex = 0;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(337, 450);
            this.Controls.Add(this.textBoxMultiTexto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form2";
            this.Text = "TextBoxMulttitexto";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMultiTexto;
    }
}