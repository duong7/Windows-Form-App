namespace HeChuyenGia_Nhom2
{
    partial class tuvan
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
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.ricKQ = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTuVan = new System.Windows.Forms.Button();
            this.cbsothich = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbkhoi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbhocluc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(953, 470);
            this.progressBar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(669, 40);
            this.progressBar.TabIndex = 26;
            // 
            // ricKQ
            // 
            this.ricKQ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ricKQ.Enabled = false;
            this.ricKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ricKQ.Location = new System.Drawing.Point(789, 658);
            this.ricKQ.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ricKQ.Name = "ricKQ";
            this.ricKQ.ReadOnly = true;
            this.ricKQ.Size = new System.Drawing.Size(833, 119);
            this.ricKQ.TabIndex = 25;
            this.ricKQ.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(782, 470);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 38);
            this.label5.TabIndex = 24;
            this.label5.Text = "KẾT QUẢ";
            // 
            // btnTuVan
            // 
            this.btnTuVan.BackgroundImage = global::HeChuyenGia_Nhom2.Properties.Resources.tu_van_chon_nghe;
            this.btnTuVan.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTuVan.Location = new System.Drawing.Point(1225, 379);
            this.btnTuVan.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnTuVan.Name = "btnTuVan";
            this.btnTuVan.Size = new System.Drawing.Size(226, 75);
            this.btnTuVan.TabIndex = 22;
            this.btnTuVan.Text = "TƯ VẤN";
            this.btnTuVan.UseVisualStyleBackColor = true;
            this.btnTuVan.Click += new System.EventHandler(this.btnTuVan_Click);
            // 
            // cbsothich
            // 
            this.cbsothich.BackColor = System.Drawing.SystemColors.Window;
            this.cbsothich.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbsothich.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbsothich.FormattingEnabled = true;
            this.cbsothich.Location = new System.Drawing.Point(1225, 264);
            this.cbsothich.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbsothich.Name = "cbsothich";
            this.cbsothich.Size = new System.Drawing.Size(397, 31);
            this.cbsothich.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(784, 268);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(257, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Chọn sở thích của bạn";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbkhoi
            // 
            this.cbkhoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbkhoi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbkhoi.FormattingEnabled = true;
            this.cbkhoi.Location = new System.Drawing.Point(1225, 196);
            this.cbkhoi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbkhoi.Name = "cbkhoi";
            this.cbkhoi.Size = new System.Drawing.Size(397, 31);
            this.cbkhoi.TabIndex = 17;
            this.cbkhoi.SelectedIndexChanged += new System.EventHandler(this.cbkhoi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(784, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 28);
            this.label2.TabIndex = 16;
            this.label2.Text = "Chọn khối bạn muốn thi";
            // 
            // cbhocluc
            // 
            this.cbhocluc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbhocluc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbhocluc.FormattingEnabled = true;
            this.cbhocluc.Location = new System.Drawing.Point(1225, 126);
            this.cbhocluc.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbhocluc.Name = "cbhocluc";
            this.cbhocluc.Size = new System.Drawing.Size(397, 31);
            this.cbhocluc.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(784, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Học lực của bạn";
            // 
            // btnReset
            // 
            this.btnReset.BackgroundImage = global::HeChuyenGia_Nhom2.Properties.Resources.tu_van_chon_nghe;
            this.btnReset.Font = new System.Drawing.Font("Arial Rounded MT Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(1478, 379);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(144, 75);
            this.btnReset.TabIndex = 27;
            this.btnReset.Text = "HỦY";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::HeChuyenGia_Nhom2.Properties.Resources.tu_van_chon_nghe;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(14, -1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 796);
            this.panel1.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(906, 24);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(685, 38);
            this.label6.TabIndex = 29;
            this.label6.Text = "HỆ CHUYÊN GIA TƯ VẤN HƯỚNG NGHIỆP";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(789, 522);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(833, 101);
            this.richTextBox1.TabIndex = 30;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // tuvan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1660, 809);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.ricKQ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTuVan);
            this.Controls.Add(this.cbsothich);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbkhoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbhocluc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "tuvan";
            this.Text = "tuvan";
            this.Load += new System.EventHandler(this.tuvan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.RichTextBox ricKQ;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTuVan;
        private System.Windows.Forms.ComboBox cbsothich;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbkhoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbhocluc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}