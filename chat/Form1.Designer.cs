namespace chat
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
            this.btnInvia = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDestinatario = new System.Windows.Forms.TextBox();
            this.lstMessaggi = new System.Windows.Forms.ListBox();
            this.processoParallelo = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnInvia
            // 
            this.btnInvia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInvia.Location = new System.Drawing.Point(319, 301);
            this.btnInvia.Name = "btnInvia";
            this.btnInvia.Size = new System.Drawing.Size(94, 29);
            this.btnInvia.TabIndex = 0;
            this.btnInvia.Text = "invia";
            this.btnInvia.UseVisualStyleBackColor = true;
            this.btnInvia.Click += new System.EventHandler(this.btnInvia_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Destinatario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtDestinatario
            // 
            this.txtDestinatario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestinatario.Location = new System.Drawing.Point(111, 303);
            this.txtDestinatario.Name = "txtDestinatario";
            this.txtDestinatario.Size = new System.Drawing.Size(202, 27);
            this.txtDestinatario.TabIndex = 3;
            this.txtDestinatario.Text = "127.0.0.1";
            this.txtDestinatario.TextChanged += new System.EventHandler(this.txtDestinatario_TextChanged);
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
            this.lstMessaggi.Size = new System.Drawing.Size(401, 283);
            this.lstMessaggi.TabIndex = 4;
            this.lstMessaggi.SelectedIndexChanged += new System.EventHandler(this.lstMessaggi_SelectedIndexChanged);
            // 
            // processoParallelo
            // 
            this.processoParallelo.DoWork += new System.ComponentModel.DoWorkEventHandler(this.processoParallelo_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 342);
            this.Controls.Add(this.lstMessaggi);
            this.Controls.Add(this.txtDestinatario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInvia);
            this.Name = "Form1";
            this.Text = "Chat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnInvia;
        private Label label1;
        private TextBox txtDestinatario;
        private ListBox lstMessaggi;
        private System.ComponentModel.BackgroundWorker processoParallelo;
    }
}