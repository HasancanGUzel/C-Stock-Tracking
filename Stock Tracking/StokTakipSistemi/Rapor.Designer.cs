namespace StokTakipSistemi
{
    partial class Rapor
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
            this.raporlist = new System.Windows.Forms.DataGridView();
            this.btnsatis = new System.Windows.Forms.Button();
            this.btniade = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblbilgi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.raporlist)).BeginInit();
            this.SuspendLayout();
            // 
            // raporlist
            // 
            this.raporlist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.raporlist.Location = new System.Drawing.Point(31, 162);
            this.raporlist.Name = "raporlist";
            this.raporlist.Size = new System.Drawing.Size(695, 214);
            this.raporlist.TabIndex = 0;
            // 
            // btnsatis
            // 
            this.btnsatis.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnsatis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsatis.ForeColor = System.Drawing.SystemColors.Info;
            this.btnsatis.Location = new System.Drawing.Point(49, 29);
            this.btnsatis.Name = "btnsatis";
            this.btnsatis.Size = new System.Drawing.Size(139, 44);
            this.btnsatis.TabIndex = 1;
            this.btnsatis.Text = "SATIŞLARI GÖR";
            this.btnsatis.UseVisualStyleBackColor = false;
            this.btnsatis.Click += new System.EventHandler(this.btnsatis_Click);
            // 
            // btniade
            // 
            this.btniade.BackColor = System.Drawing.SystemColors.GrayText;
            this.btniade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btniade.ForeColor = System.Drawing.SystemColors.Info;
            this.btniade.Location = new System.Drawing.Point(218, 29);
            this.btniade.Name = "btniade";
            this.btniade.Size = new System.Drawing.Size(132, 44);
            this.btniade.TabIndex = 2;
            this.btniade.Text = "İADELERİ GÖR";
            this.btniade.UseVisualStyleBackColor = false;
            this.btniade.Click += new System.EventHandler(this.btniade_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GrayText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(371, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "GÜNLÜK TOPLAM CİRO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GrayText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.SystemColors.Info;
            this.button2.Location = new System.Drawing.Point(559, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(124, 44);
            this.button2.TabIndex = 4;
            this.button2.Text = "ANASAYFA";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblbilgi
            // 
            this.lblbilgi.AutoSize = true;
            this.lblbilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbilgi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblbilgi.Location = new System.Drawing.Point(56, 93);
            this.lblbilgi.Name = "lblbilgi";
            this.lblbilgi.Size = new System.Drawing.Size(0, 15);
            this.lblbilgi.TabIndex = 5;
            // 
            // Rapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblbilgi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btniade);
            this.Controls.Add(this.btnsatis);
            this.Controls.Add(this.raporlist);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Rapor";
            this.Text = "Rapor";
            ((System.ComponentModel.ISupportInitialize)(this.raporlist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView raporlist;
        private System.Windows.Forms.Button btnsatis;
        private System.Windows.Forms.Button btniade;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblbilgi;
    }
}