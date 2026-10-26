namespace Code_NT106.R14._2_Lab02_24520314
{
    partial class Bai2
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
            btnRead = new Button();
            btnDel = new Button();
            btnOut = new Button();
            rtbNoiDung = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTenFile = new TextBox();
            txtKichThuoc = new TextBox();
            txtURL = new TextBox();
            txtSoDong = new TextBox();
            txtSoTu = new TextBox();
            txtSoKyTu = new TextBox();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Location = new Point(12, 12);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(298, 34);
            btnRead.TabIndex = 0;
            btnRead.Text = "Đọc file";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(12, 354);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(298, 34);
            btnDel.TabIndex = 1;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnOut
            // 
            btnOut.Location = new Point(12, 404);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(298, 34);
            btnOut.TabIndex = 2;
            btnOut.Text = "Thoát";
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click;
            // 
            // rtbNoiDung
            // 
            rtbNoiDung.BackColor = SystemColors.ButtonHighlight;
            rtbNoiDung.Location = new Point(350, 12);
            rtbNoiDung.Name = "rtbNoiDung";
            rtbNoiDung.ReadOnly = true;
            rtbNoiDung.Size = new Size(438, 426);
            rtbNoiDung.TabIndex = 3;
            rtbNoiDung.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 71);
            label1.Name = "label1";
            label1.Size = new Size(66, 25);
            label1.TabIndex = 4;
            label1.Text = "Tên file";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 118);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 5;
            label2.Text = "Kích thước";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 163);
            label3.Name = "label3";
            label3.Size = new Size(43, 25);
            label3.TabIndex = 6;
            label3.Text = "URL";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 210);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 7;
            label4.Text = "Số dòng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 259);
            label5.Name = "label5";
            label5.Size = new Size(55, 25);
            label5.TabIndex = 8;
            label5.Text = "Số từ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 311);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 9;
            label6.Text = "Số ký tự";
            // 
            // txtTenFile
            // 
            txtTenFile.BackColor = SystemColors.ButtonHighlight;
            txtTenFile.Location = new Point(109, 65);
            txtTenFile.Name = "txtTenFile";
            txtTenFile.ReadOnly = true;
            txtTenFile.Size = new Size(201, 31);
            txtTenFile.TabIndex = 10;
            // 
            // txtKichThuoc
            // 
            txtKichThuoc.BackColor = SystemColors.ButtonHighlight;
            txtKichThuoc.Location = new Point(109, 112);
            txtKichThuoc.Name = "txtKichThuoc";
            txtKichThuoc.ReadOnly = true;
            txtKichThuoc.Size = new Size(201, 31);
            txtKichThuoc.TabIndex = 11;
            // 
            // txtURL
            // 
            txtURL.BackColor = SystemColors.ButtonHighlight;
            txtURL.Location = new Point(109, 157);
            txtURL.Name = "txtURL";
            txtURL.ReadOnly = true;
            txtURL.Size = new Size(201, 31);
            txtURL.TabIndex = 12;
            // 
            // txtSoDong
            // 
            txtSoDong.BackColor = SystemColors.ButtonHighlight;
            txtSoDong.Location = new Point(109, 204);
            txtSoDong.Name = "txtSoDong";
            txtSoDong.ReadOnly = true;
            txtSoDong.Size = new Size(201, 31);
            txtSoDong.TabIndex = 13;
            // 
            // txtSoTu
            // 
            txtSoTu.BackColor = SystemColors.ButtonHighlight;
            txtSoTu.Location = new Point(109, 253);
            txtSoTu.Name = "txtSoTu";
            txtSoTu.ReadOnly = true;
            txtSoTu.Size = new Size(201, 31);
            txtSoTu.TabIndex = 14;
            // 
            // txtSoKyTu
            // 
            txtSoKyTu.BackColor = SystemColors.ButtonHighlight;
            txtSoKyTu.Location = new Point(109, 305);
            txtSoKyTu.Name = "txtSoKyTu";
            txtSoKyTu.ReadOnly = true;
            txtSoKyTu.Size = new Size(201, 31);
            txtSoKyTu.TabIndex = 15;
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSoKyTu);
            Controls.Add(txtSoTu);
            Controls.Add(txtSoDong);
            Controls.Add(txtURL);
            Controls.Add(txtKichThuoc);
            Controls.Add(txtTenFile);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(rtbNoiDung);
            Controls.Add(btnOut);
            Controls.Add(btnDel);
            Controls.Add(btnRead);
            Name = "Bai2";
            Text = "Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRead;
        private Button btnDel;
        private Button btnOut;
        private RichTextBox rtbNoiDung;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtTenFile;
        private TextBox txtKichThuoc;
        private TextBox txtURL;
        private TextBox txtSoDong;
        private TextBox txtSoTu;
        private TextBox txtSoKyTu;
    }
}