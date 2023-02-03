namespace StokTakipSistemi
{
    partial class IadeAl
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
            this.label1 = new System.Windows.Forms.Label();
            this.textiade = new System.Windows.Forms.TextBox();
            this.btniade = new System.Windows.Forms.Button();
            this.btnanasayfa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Adı : ";
            // 
            // textiade
            // 
            this.textiade.Location = new System.Drawing.Point(133, 62);
            this.textiade.Name = "textiade";
            this.textiade.Size = new System.Drawing.Size(100, 20);
            this.textiade.TabIndex = 1;
            // 
            // btniade
            // 
            this.btniade.BackColor = System.Drawing.SystemColors.GrayText;
            this.btniade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btniade.ForeColor = System.Drawing.SystemColors.Info;
            this.btniade.Location = new System.Drawing.Point(252, 55);
            this.btniade.Name = "btniade";
            this.btniade.Size = new System.Drawing.Size(75, 32);
            this.btniade.TabIndex = 2;
            this.btniade.Text = "İADE AL";
            this.btniade.UseVisualStyleBackColor = false;
            this.btniade.Click += new System.EventHandler(this.btniade_Click);
            // 
            // btnanasayfa
            // 
            this.btnanasayfa.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnanasayfa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnanasayfa.ForeColor = System.Drawing.SystemColors.Info;
            this.btnanasayfa.Location = new System.Drawing.Point(333, 55);
            this.btnanasayfa.Name = "btnanasayfa";
            this.btnanasayfa.Size = new System.Drawing.Size(89, 32);
            this.btnanasayfa.TabIndex = 3;
            this.btnanasayfa.Text = "ANASAYFA";
            this.btnanasayfa.UseVisualStyleBackColor = false;
            this.btnanasayfa.Click += new System.EventHandler(this.btnanasayfa_Click);
            // 
            // IadeAl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(487, 186);
            this.Controls.Add(this.btnanasayfa);
            this.Controls.Add(this.btniade);
            this.Controls.Add(this.textiade);
            this.Controls.Add(this.label1);
            this.Name = "IadeAl";
            this.Text = "IadeAl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textiade;
        private System.Windows.Forms.Button btniade;
        private System.Windows.Forms.Button btnanasayfa;
    }
}