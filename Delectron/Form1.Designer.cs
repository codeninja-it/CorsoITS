namespace Delectron
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
            this.lstMessaggi = new System.Windows.Forms.ListBox();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInvia = new System.Windows.Forms.Button();
            this.txtMessaggio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstMessaggi
            // 
            this.lstMessaggi.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMessaggi.FormattingEnabled = true;
            this.lstMessaggi.IntegralHeight = false;
            this.lstMessaggi.ItemHeight = 20;
            this.lstMessaggi.Location = new System.Drawing.Point(12, 12);
            this.lstMessaggi.Name = "lstMessaggi";
            this.lstMessaggi.Size = new System.Drawing.Size(555, 262);
            this.lstMessaggi.TabIndex = 8;
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestinatario.Location = new System.Drawing.Point(108, 313);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(459, 27);
            this.txtDestinatario.TabIndex = 7;
            this.txtDestinatario.Text = "127.0.0.1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Destinatario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnInvia
            // 
            this.btnInvia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInvia.Location = new System.Drawing.Point(12, 346);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(555, 29);
            this.btnInvia.TabIndex = 5;
            this.btnInvia.Text = "invia";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
            // 
            // txtMessaggio
            // 
            this.txtMessaggio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessaggio.Location = new System.Drawing.Point(108, 280);
            this.txtMessaggio.Name = "txtMessaggio";
            this.txtMessaggio.Size = new System.Drawing.Size(459, 27);
            this.txtMessaggio.TabIndex = 10;
            this.txtMessaggio.Text = "0||";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Messaggio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 387);
            this.Controls.Add(this.txtMessaggio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstMessaggi);
            this.Controls.Add(this.txtDestinatario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInvia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox lstMessaggi;
        private TextBox txtDestinatario;
        private Label label1;
        private Button btnInvia;
        private TextBox txtMessaggio;
        private Label label2;
    }
}