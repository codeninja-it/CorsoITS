
namespace terzaApplicazione
{
	partial class Negozi
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Negozi));
			this.lstNegozi = new System.Windows.Forms.ListBox();
			this.txtNome = new System.Windows.Forms.TextBox();
			this.txtIndirizzo = new System.Windows.Forms.TextBox();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.btnChiudi = new System.Windows.Forms.Button();
			this.btnSalva = new System.Windows.Forms.Button();
			this.btnNuovo = new System.Windows.Forms.Button();
			this.btnCancella = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstNegozi
			// 
			this.lstNegozi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.lstNegozi.FormattingEnabled = true;
			this.lstNegozi.IntegralHeight = false;
			this.lstNegozi.ItemHeight = 20;
			this.lstNegozi.Location = new System.Drawing.Point(12, 12);
			this.lstNegozi.Name = "lstNegozi";
			this.lstNegozi.Size = new System.Drawing.Size(254, 267);
			this.lstNegozi.TabIndex = 0;
			this.lstNegozi.SelectedIndexChanged += new System.EventHandler(this.lstNegozi_SelectedIndexChanged);
			// 
			// txtNome
			// 
			this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNome.Location = new System.Drawing.Point(345, 12);
			this.txtNome.Name = "txtNome";
			this.txtNome.Size = new System.Drawing.Size(440, 27);
			this.txtNome.TabIndex = 1;
			// 
			// txtIndirizzo
			// 
			this.txtIndirizzo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtIndirizzo.Location = new System.Drawing.Point(344, 45);
			this.txtIndirizzo.Name = "txtIndirizzo";
			this.txtIndirizzo.Size = new System.Drawing.Size(441, 27);
			this.txtIndirizzo.TabIndex = 2;
			// 
			// txtTelefono
			// 
			this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTelefono.Location = new System.Drawing.Point(345, 79);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(439, 27);
			this.txtTelefono.TabIndex = 3;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(272, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Nome";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(272, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Indirizzo";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(272, 82);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Telefono";
			// 
			// btnChiudi
			// 
			this.btnChiudi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnChiudi.Location = new System.Drawing.Point(691, 293);
			this.btnChiudi.Name = "btnChiudi";
			this.btnChiudi.Size = new System.Drawing.Size(94, 29);
			this.btnChiudi.TabIndex = 7;
			this.btnChiudi.Text = "chiudi";
			this.btnChiudi.UseVisualStyleBackColor = true;
			this.btnChiudi.Click += new System.EventHandler(this.btnChiudi_Click);
			// 
			// btnSalva
			// 
			this.btnSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSalva.Location = new System.Drawing.Point(591, 293);
			this.btnSalva.Name = "btnSalva";
			this.btnSalva.Size = new System.Drawing.Size(94, 29);
			this.btnSalva.TabIndex = 8;
			this.btnSalva.Text = "salva";
			this.btnSalva.UseVisualStyleBackColor = true;
			this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
			// 
			// btnNuovo
			// 
			this.btnNuovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNuovo.Location = new System.Drawing.Point(12, 293);
			this.btnNuovo.Name = "btnNuovo";
			this.btnNuovo.Size = new System.Drawing.Size(94, 29);
			this.btnNuovo.TabIndex = 9;
			this.btnNuovo.Text = "nuovo";
			this.btnNuovo.UseVisualStyleBackColor = true;
			this.btnNuovo.Click += new System.EventHandler(this.btnNuovo_Click);
			// 
			// btnCancella
			// 
			this.btnCancella.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnCancella.Location = new System.Drawing.Point(172, 293);
			this.btnCancella.Name = "btnCancella";
			this.btnCancella.Size = new System.Drawing.Size(94, 29);
			this.btnCancella.TabIndex = 10;
			this.btnCancella.Text = "cancella";
			this.btnCancella.UseVisualStyleBackColor = true;
			this.btnCancella.Click += new System.EventHandler(this.btnCancella_Click);
			// 
			// Negozi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(797, 333);
			this.Controls.Add(this.btnCancella);
			this.Controls.Add(this.btnNuovo);
			this.Controls.Add(this.btnSalva);
			this.Controls.Add(this.btnChiudi);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.txtIndirizzo);
			this.Controls.Add(this.txtNome);
			this.Controls.Add(this.lstNegozi);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Negozi";
			this.Text = "Negozi";
			this.Load += new System.EventHandler(this.Negozi_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstNegozi;
		private System.Windows.Forms.TextBox txtNome;
		private System.Windows.Forms.TextBox txtIndirizzo;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnChiudi;
		private System.Windows.Forms.Button btnSalva;
		private System.Windows.Forms.Button btnNuovo;
		private System.Windows.Forms.Button btnCancella;
	}
}