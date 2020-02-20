namespace RecipeHelperApp
{
    partial class Form1
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
            this.clbl = new System.Windows.Forms.Label();
            this.txtCel = new System.Windows.Forms.TextBox();
            this.CtoFbtn = new System.Windows.Forms.Button();
            this.fbl = new System.Windows.Forms.Label();
            this.txtFah = new System.Windows.Forms.TextBox();
            this.mlbl = new System.Windows.Forms.Label();
            this.txtMil = new System.Windows.Forms.TextBox();
            this.mtocupsbtn = new System.Windows.Forms.Button();
            this.cupslbl = new System.Windows.Forms.Label();
            this.txtCup = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // clbl
            // 
            this.clbl.AutoSize = true;
            this.clbl.Location = new System.Drawing.Point(33, 37);
            this.clbl.Name = "clbl";
            this.clbl.Size = new System.Drawing.Size(40, 13);
            this.clbl.TabIndex = 0;
            this.clbl.Text = "Celsius";
            // 
            // txtCel
            // 
            this.txtCel.Location = new System.Drawing.Point(86, 37);
            this.txtCel.Name = "txtCel";
            this.txtCel.Size = new System.Drawing.Size(100, 20);
            this.txtCel.TabIndex = 1;
            this.txtCel.TextChanged += new System.EventHandler(this.CelText_TextChanged);
            // 
            // CtoFbtn
            // 
            this.CtoFbtn.Location = new System.Drawing.Point(61, 87);
            this.CtoFbtn.Name = "CtoFbtn";
            this.CtoFbtn.Size = new System.Drawing.Size(84, 37);
            this.CtoFbtn.TabIndex = 2;
            this.CtoFbtn.Text = "&Convert to Fahrenheit";
            this.CtoFbtn.UseVisualStyleBackColor = true;
            this.CtoFbtn.Click += new System.EventHandler(this.CtoFbtn_Click);
            // 
            // fbl
            // 
            this.fbl.AutoSize = true;
            this.fbl.Location = new System.Drawing.Point(16, 165);
            this.fbl.Name = "fbl";
            this.fbl.Size = new System.Drawing.Size(57, 13);
            this.fbl.TabIndex = 3;
            this.fbl.Text = "Fahrenheit";
            // 
            // txtFah
            // 
            this.txtFah.Location = new System.Drawing.Point(95, 163);
            this.txtFah.Name = "txtFah";
            this.txtFah.ReadOnly = true;
            this.txtFah.Size = new System.Drawing.Size(100, 20);
            this.txtFah.TabIndex = 4;
            // 
            // mlbl
            // 
            this.mlbl.AutoSize = true;
            this.mlbl.Location = new System.Drawing.Point(301, 37);
            this.mlbl.Name = "mlbl";
            this.mlbl.Size = new System.Drawing.Size(45, 13);
            this.mlbl.TabIndex = 5;
            this.mlbl.Text = "Milliliters";
            // 
            // txtMil
            // 
            this.txtMil.Location = new System.Drawing.Point(370, 37);
            this.txtMil.Name = "txtMil";
            this.txtMil.Size = new System.Drawing.Size(100, 20);
            this.txtMil.TabIndex = 6;
            // 
            // mtocupsbtn
            // 
            this.mtocupsbtn.Location = new System.Drawing.Point(328, 87);
            this.mtocupsbtn.Name = "mtocupsbtn";
            this.mtocupsbtn.Size = new System.Drawing.Size(75, 37);
            this.mtocupsbtn.TabIndex = 7;
            this.mtocupsbtn.Text = "&Convert to Cups";
            this.mtocupsbtn.UseVisualStyleBackColor = true;
            this.mtocupsbtn.Click += new System.EventHandler(this.mtocupsbtn_Click);
            // 
            // cupslbl
            // 
            this.cupslbl.AutoSize = true;
            this.cupslbl.Location = new System.Drawing.Point(304, 163);
            this.cupslbl.Name = "cupslbl";
            this.cupslbl.Size = new System.Drawing.Size(31, 13);
            this.cupslbl.TabIndex = 8;
            this.cupslbl.Text = "Cups";
            // 
            // txtCup
            // 
            this.txtCup.Location = new System.Drawing.Point(370, 162);
            this.txtCup.Name = "txtCup";
            this.txtCup.ReadOnly = true;
            this.txtCup.Size = new System.Drawing.Size(100, 20);
            this.txtCup.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 219);
            this.Controls.Add(this.txtCup);
            this.Controls.Add(this.cupslbl);
            this.Controls.Add(this.mtocupsbtn);
            this.Controls.Add(this.txtMil);
            this.Controls.Add(this.mlbl);
            this.Controls.Add(this.txtFah);
            this.Controls.Add(this.fbl);
            this.Controls.Add(this.CtoFbtn);
            this.Controls.Add(this.txtCel);
            this.Controls.Add(this.clbl);
            this.Name = "Form1";
            this.Text = "Recipe Helper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clbl;
        private System.Windows.Forms.TextBox txtCel;
        private System.Windows.Forms.Button CtoFbtn;
        private System.Windows.Forms.Label fbl;
        private System.Windows.Forms.TextBox txtFah;
        private System.Windows.Forms.Label mlbl;
        private System.Windows.Forms.TextBox txtMil;
        private System.Windows.Forms.Button mtocupsbtn;
        private System.Windows.Forms.Label cupslbl;
        private System.Windows.Forms.TextBox txtCup;
    }
}

