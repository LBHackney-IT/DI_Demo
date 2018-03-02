namespace DependencyInjectionDemo
{
    partial class fmCalculator
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
            this.calculateCommission = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalesAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCommission = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateCommission
            // 
            this.calculateCommission.Location = new System.Drawing.Point(223, 173);
            this.calculateCommission.Name = "calculateCommission";
            this.calculateCommission.Size = new System.Drawing.Size(75, 23);
            this.calculateCommission.TabIndex = 0;
            this.calculateCommission.Text = "Calculate";
            this.calculateCommission.UseVisualStyleBackColor = true;
            this.calculateCommission.Click += new System.EventHandler(this.calculateCommission_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sales Amount";
            // 
            // txtSalesAmount
            // 
            this.txtSalesAmount.Location = new System.Drawing.Point(137, 67);
            this.txtSalesAmount.Name = "txtSalesAmount";
            this.txtSalesAmount.Size = new System.Drawing.Size(161, 20);
            this.txtSalesAmount.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Commission";
            // 
            // txtCommission
            // 
            this.txtCommission.AutoSize = true;
            this.txtCommission.Location = new System.Drawing.Point(134, 123);
            this.txtCommission.Name = "txtCommission";
            this.txtCommission.Size = new System.Drawing.Size(0, 13);
            this.txtCommission.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(329, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "A Multi-National Sales Corporation";
            // 
            // fmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 228);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCommission);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSalesAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculateCommission);
            this.Name = "fmCalculator";
            this.Text = "DI Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateCommission;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSalesAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtCommission;
        private System.Windows.Forms.Label label3;
    }
}

