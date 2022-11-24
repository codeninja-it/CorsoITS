namespace BMI
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
            this.btnCalcola = new System.Windows.Forms.Button();
            this.numPeso = new System.Windows.Forms.NumericUpDown();
            this.numAltezza = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRisultato = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAltezza)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcola
            // 
            this.btnCalcola.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalcola.Location = new System.Drawing.Point(266, 365);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(94, 29);
            this.btnCalcola.TabIndex = 0;
            this.btnCalcola.Text = "calcola";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click);
            // 
            // numPeso
            // 
            this.numPeso.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numPeso.DecimalPlaces = 2;
            this.numPeso.Location = new System.Drawing.Point(103, 12);
            this.numPeso.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numPeso.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numPeso.Name = "numPeso";
            this.numPeso.Size = new System.Drawing.Size(257, 27);
            this.numPeso.TabIndex = 1;
            this.numPeso.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // numAltezza
            // 
            this.numAltezza.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numAltezza.DecimalPlaces = 2;
            this.numAltezza.Location = new System.Drawing.Point(103, 45);
            this.numAltezza.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            this.numAltezza.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numAltezza.Name = "numAltezza";
            this.numAltezza.Size = new System.Drawing.Size(257, 27);
            this.numAltezza.TabIndex = 2;
            this.numAltezza.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Peso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Altezza";
            // 
            // lblRisultato
            // 
            this.lblRisultato.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRisultato.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRisultato.Location = new System.Drawing.Point(12, 83);
            this.lblRisultato.Name = "lblRisultato";
            this.lblRisultato.Size = new System.Drawing.Size(348, 279);
            this.lblRisultato.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 406);
            this.Controls.Add(this.lblRisultato);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numAltezza);
            this.Controls.Add(this.numPeso);
            this.Controls.Add(this.btnCalcola);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numPeso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAltezza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCalcola;
        private NumericUpDown numPeso;
        private NumericUpDown numAltezza;
        private Label label1;
        private Label label2;
        private Label lblRisultato;
    }
}