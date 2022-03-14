namespace Equação2Grau
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
            this.lbA = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btCalcular = new System.Windows.Forms.Button();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lbC = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Location = new System.Drawing.Point(6, 19);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(18, 15);
            this.lbA.TabIndex = 0;
            this.lbA.Text = "A:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btCalcular);
            this.groupBox1.Controls.Add(this.txtC);
            this.groupBox1.Controls.Add(this.txtB);
            this.groupBox1.Controls.Add(this.txtA);
            this.groupBox1.Controls.Add(this.lbC);
            this.groupBox1.Controls.Add(this.lbB);
            this.groupBox1.Controls.Add(this.lbA);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calcular";
            // 
            // btCalcular
            // 
            this.btCalcular.Location = new System.Drawing.Point(282, 97);
            this.btCalcular.Name = "btCalcular";
            this.btCalcular.Size = new System.Drawing.Size(75, 23);
            this.btCalcular.TabIndex = 6;
            this.btCalcular.Text = "Calcular";
            this.btCalcular.UseVisualStyleBackColor = true;
            this.btCalcular.Click += new System.EventHandler(this.btCalcular_Click);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(29, 65);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(220, 23);
            this.txtC.TabIndex = 5;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(29, 40);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(220, 23);
            this.txtB.TabIndex = 4;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(29, 16);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(220, 23);
            this.txtA.TabIndex = 3;
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.Location = new System.Drawing.Point(6, 68);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(18, 15);
            this.lbC.TabIndex = 2;
            this.lbC.Text = "C:";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.Location = new System.Drawing.Point(6, 43);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(17, 15);
            this.lbB.TabIndex = 1;
            this.lbB.Text = "B:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 145);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Equação 2º Grau";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label lbA;
        private GroupBox groupBox1;
        private Button btCalcular;
        private TextBox txtC;
        private TextBox txtB;
        private TextBox txtA;
        private Label lbC;
        private Label lbB;
    }
}