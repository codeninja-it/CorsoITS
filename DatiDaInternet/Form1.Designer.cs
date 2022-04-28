
namespace DatiDaInternet
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
			this.txtIndirizzo = new System.Windows.Forms.TextBox();
			this.btnCarica = new System.Windows.Forms.Button();
			this.txtRisultato = new System.Windows.Forms.TextBox();
			this.btnTrasforma = new System.Windows.Forms.Button();
			this.lstDati = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// txtIndirizzo
			// 
			this.txtIndirizzo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtIndirizzo.Location = new System.Drawing.Point(13, 13);
			this.txtIndirizzo.Name = "txtIndirizzo";
			this.txtIndirizzo.Size = new System.Drawing.Size(808, 27);
			this.txtIndirizzo.TabIndex = 0;
			this.txtIndirizzo.Text = "https://staticmy.zanichelli.it/catalogo/CatalogoZanichelli.csv";
			// 
			// btnCarica
			// 
			this.btnCarica.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCarica.Location = new System.Drawing.Point(827, 13);
			this.btnCarica.Name = "btnCarica";
			this.btnCarica.Size = new System.Drawing.Size(88, 29);
			this.btnCarica.TabIndex = 1;
			this.btnCarica.Text = "carica";
			this.btnCarica.UseVisualStyleBackColor = true;
			this.btnCarica.Click += new System.EventHandler(this.btnCarica_Click);
			// 
			// txtRisultato
			// 
			this.txtRisultato.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.txtRisultato.Location = new System.Drawing.Point(14, 57);
			this.txtRisultato.Multiline = true;
			this.txtRisultato.Name = "txtRisultato";
			this.txtRisultato.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtRisultato.Size = new System.Drawing.Size(278, 445);
			this.txtRisultato.TabIndex = 2;
			// 
			// btnTrasforma
			// 
			this.btnTrasforma.Location = new System.Drawing.Point(298, 170);
			this.btnTrasforma.Name = "btnTrasforma";
			this.btnTrasforma.Size = new System.Drawing.Size(94, 29);
			this.btnTrasforma.TabIndex = 3;
			this.btnTrasforma.Text = ">>";
			this.btnTrasforma.UseVisualStyleBackColor = true;
			this.btnTrasforma.Click += new System.EventHandler(this.btnTrasforma_Click);
			// 
			// lstDati
			// 
			this.lstDati.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstDati.FormattingEnabled = true;
			this.lstDati.IntegralHeight = false;
			this.lstDati.ItemHeight = 20;
			this.lstDati.Location = new System.Drawing.Point(402, 48);
			this.lstDati.Name = "lstDati";
			this.lstDati.Size = new System.Drawing.Size(513, 445);
			this.lstDati.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(927, 505);
			this.Controls.Add(this.lstDati);
			this.Controls.Add(this.btnTrasforma);
			this.Controls.Add(this.txtRisultato);
			this.Controls.Add(this.btnCarica);
			this.Controls.Add(this.txtIndirizzo);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtIndirizzo;
		private System.Windows.Forms.Button btnCarica;
		private System.Windows.Forms.TextBox txtRisultato;
		private System.Windows.Forms.Button btnTrasforma;
		private System.Windows.Forms.ListBox lstDati;
	}
}

