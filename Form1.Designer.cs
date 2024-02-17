namespace ColorSearch
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pic_Colors = new System.Windows.Forms.PictureBox();
            this.TXThex = new System.Windows.Forms.TextBox();
            this.TXTrgb = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Colors)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_Colors
            // 
            this.pic_Colors.Location = new System.Drawing.Point(1, 3);
            this.pic_Colors.Name = "pic_Colors";
            this.pic_Colors.Size = new System.Drawing.Size(100, 62);
            this.pic_Colors.TabIndex = 0;
            this.pic_Colors.TabStop = false;
            // 
            // TXThex
            // 
            this.TXThex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXThex.Location = new System.Drawing.Point(107, 38);
            this.TXThex.Name = "TXThex";
            this.TXThex.Size = new System.Drawing.Size(180, 26);
            this.TXThex.TabIndex = 1;
            // 
            // TXTrgb
            // 
            this.TXTrgb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TXTrgb.Location = new System.Drawing.Point(107, 3);
            this.TXTrgb.Name = "TXTrgb";
            this.TXTrgb.Size = new System.Drawing.Size(180, 26);
            this.TXTrgb.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 71);
            this.Controls.Add(this.TXTrgb);
            this.Controls.Add(this.TXThex);
            this.Controls.Add(this.pic_Colors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Color Search";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Colors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_Colors;
        private System.Windows.Forms.TextBox TXThex;
        private System.Windows.Forms.TextBox TXTrgb;
        private System.Windows.Forms.Timer timer1;
    }
}

