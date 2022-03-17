
namespace secondaApplicazione
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
			this.txtNone = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtCognome = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtTelefono = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSalva = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// txtNone
			// 
			this.txtNone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtNone.Location = new System.Drawing.Point(119, 12);
			this.txtNone.Name = "txtNone";
			this.txtNone.Size = new System.Drawing.Size(305, 27);
			this.txtNone.TabIndex = 0;
			this.txtNone.Text = "ciao";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(50, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Nome";
			// 
			// txtCognome
			// 
			this.txtCognome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtCognome.Location = new System.Drawing.Point(119, 46);
			this.txtCognome.Name = "txtCognome";
			this.txtCognome.Size = new System.Drawing.Size(305, 27);
			this.txtCognome.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 49);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(74, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Cognome";
			// 
			// txtTelefono
			// 
			this.txtTelefono.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTelefono.Location = new System.Drawing.Point(119, 80);
			this.txtTelefono.Name = "txtTelefono";
			this.txtTelefono.Size = new System.Drawing.Size(305, 27);
			this.txtTelefono.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Telefono";
			// 
			// btnSalva
			// 
			this.btnSalva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSalva.Location = new System.Drawing.Point(329, 211);
			this.btnSalva.Name = "btnSalva";
			this.btnSalva.Size = new System.Drawing.Size(94, 29);
			this.btnSalva.TabIndex = 6;
			this.btnSalva.Text = "salva";
			this.btnSalva.UseVisualStyleBackColor = true;
			this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(436, 252);
			this.Controls.Add(this.btnSalva);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtTelefono);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtCognome);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtNone);
			this.Name = "Form1";
			this.Text = "Seconda applicazione";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNone;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtCognome;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtTelefono;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnSalva;
	}
}

