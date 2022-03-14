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
            this.LbA = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtCalcular = new System.Windows.Forms.Button();
            this.TxtC = new System.Windows.Forms.TextBox();
            this.TxtB = new System.Windows.Forms.TextBox();
            this.TxtA = new System.Windows.Forms.TextBox();
            this.LbC = new System.Windows.Forms.Label();
            this.LbB = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbA
            // 
            this.LbA.AutoSize = true;
            this.LbA.Location = new System.Drawing.Point(6, 19);
            this.LbA.Name = "LbA";
            this.LbA.Size = new System.Drawing.Size(18, 15);
            this.LbA.TabIndex = 0;
            this.LbA.Text = "A:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtCalcular);
            this.groupBox1.Controls.Add(this.TxtC);
            this.groupBox1.Controls.Add(this.TxtB);
            this.groupBox1.Controls.Add(this.TxtA);
            this.groupBox1.Controls.Add(this.LbC);
            this.groupBox1.Controls.Add(this.LbB);
            this.groupBox1.Controls.Add(this.LbA);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 126);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calcular";
            // 
            // BtCalcular
            // 
            this.BtCalcular.Location = new System.Drawing.Point(282, 97);
            this.BtCalcular.Name = "BtCalcular";
            this.BtCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtCalcular.TabIndex = 6;
            this.BtCalcular.Text = "Calcular";
            this.BtCalcular.UseVisualStyleBackColor = true;
            this.BtCalcular.Click += new System.EventHandler(this.BtCalcular_Click);
            // 
            // TxtC
            // 
            this.TxtC.Location = new System.Drawing.Point(29, 65);
            this.TxtC.Name = "TxtC";
            this.TxtC.Size = new System.Drawing.Size(220, 23);
            this.TxtC.TabIndex = 5;
            // 
            // TxtB
            // 
            this.TxtB.Location = new System.Drawing.Point(29, 40);
            this.TxtB.Name = "TxtB";
            this.TxtB.Size = new System.Drawing.Size(220, 23);
            this.TxtB.TabIndex = 4;
            // 
            // TxtA
            // 
            this.TxtA.Location = new System.Drawing.Point(29, 16);
            this.TxtA.Name = "TxtA";
            this.TxtA.Size = new System.Drawing.Size(220, 23);
            this.TxtA.TabIndex = 3;
            // 
            // LbC
            // 
            this.LbC.AutoSize = true;
            this.LbC.Location = new System.Drawing.Point(6, 68);
            this.LbC.Name = "LbC";
            this.LbC.Size = new System.Drawing.Size(18, 15);
            this.LbC.TabIndex = 2;
            this.LbC.Text = "C:";
            // 
            // LbB
            // 
            this.LbB.AutoSize = true;
            this.LbB.Location = new System.Drawing.Point(6, 43);
            this.LbB.Name = "LbB";
            this.LbB.Size = new System.Drawing.Size(17, 15);
            this.LbB.TabIndex = 1;
            this.LbB.Text = "B:";
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

        private Label LbA;
        private GroupBox groupBox1;
        private Button BtCalcular;
        private TextBox TxtC;
        private TextBox TxtB;
        private TextBox TxtA;
        private Label LbC;
        private Label LbB;
    }
}