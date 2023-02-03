namespace StokTakipSistemi
{
    partial class Stok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stok));
            this.gridstok = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.texturun = new System.Windows.Forms.TextBox();
            this.btnsorgula = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridstok)).BeginInit();
            this.SuspendLayout();
            // 
            // gridstok
            // 
            this.gridstok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridstok.Location = new System.Drawing.Point(32, 104);
            this.gridstok.Name = "gridstok";
            this.gridstok.Size = new System.Drawing.Size(737, 224);
            this.gridstok.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÜRÜN ADI :";
            // 
            // texturun
            // 
            this.texturun.Location = new System.Drawing.Point(176, 55);
            this.texturun.Name = "texturun";
            this.texturun.Size = new System.Drawing.Size(100, 20);
            this.texturun.TabIndex = 2;
            // 
            // btnsorgula
            // 
            this.btnsorgula.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnsorgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsorgula.ForeColor = System.Drawing.SystemColors.Info;
            this.btnsorgula.Image = ((System.Drawing.Image)(resources.GetObject("btnsorgula.Image")));
            this.btnsorgula.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsorgula.Location = new System.Drawing.Point(282, 47);
            this.btnsorgula.Name = "btnsorgula";
            this.btnsorgula.Size = new System.Drawing.Size(106, 34);
            this.btnsorgula.TabIndex = 3;
            this.btnsorgula.Text = "SORGULA";
            this.btnsorgula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsorgula.UseVisualStyleBackColor = false;
            this.btnsorgula.Click += new System.EventHandler(this.btnsorgula_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(602, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "ANASAYFA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Stok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 418);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsorgula);
            this.Controls.Add(this.texturun);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridstok);
            this.Name = "Stok";
            this.Text = "Stok";
            this.Load += new System.EventHandler(this.Stok_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridstok)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridstok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texturun;
        private System.Windows.Forms.Button btnsorgula;
        private System.Windows.Forms.Button button1;
    }
}