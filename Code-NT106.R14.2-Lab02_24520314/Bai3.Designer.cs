namespace Code_NT106.R14._2_Lab02_24520314
{
    partial class Bai3
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
            btnDocFile = new Button();
            btnTinhToan = new Button();
            btnDel = new Button();
            btnOut = new Button();
            rtbNoiDung = new RichTextBox();
            SuspendLayout();
            // 
            // btnDocFile
            // 
            btnDocFile.Location = new Point(30, 36);
            btnDocFile.Name = "btnDocFile";
            btnDocFile.Size = new Size(232, 34);
            btnDocFile.TabIndex = 0;
            btnDocFile.Text = "Đọc file";
            btnDocFile.UseVisualStyleBackColor = true;
            btnDocFile.Click += btnDocFile_Click;
            // 
            // btnTinhToan
            // 
            btnTinhToan.Location = new Point(30, 111);
            btnTinhToan.Name = "btnTinhToan";
            btnTinhToan.Size = new Size(232, 34);
            btnTinhToan.TabIndex = 1;
            btnTinhToan.Text = "Tính toán";
            btnTinhToan.UseVisualStyleBackColor = true;
            btnTinhToan.Click += btnTinhToan_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(30, 185);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(232, 34);
            btnDel.TabIndex = 2;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnOut
            // 
            btnOut.Location = new Point(30, 260);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(232, 34);
            btnOut.TabIndex = 3;
            btnOut.Text = "Thoát";
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click;
            // 
            // rtbNoiDung
            // 
            rtbNoiDung.BackColor = SystemColors.ButtonHighlight;
            rtbNoiDung.Location = new Point(311, 36);
            rtbNoiDung.Name = "rtbNoiDung";
            rtbNoiDung.ReadOnly = true;
            rtbNoiDung.Size = new Size(424, 258);
            rtbNoiDung.TabIndex = 4;
            rtbNoiDung.Text = "";
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbNoiDung);
            Controls.Add(btnOut);
            Controls.Add(btnDel);
            Controls.Add(btnTinhToan);
            Controls.Add(btnDocFile);
            Name = "Bai3";
            Text = "Bai3";
            ResumeLayout(false);
        }

        #endregion

        private Button btnDocFile;
        private Button btnTinhToan;
        private Button btnDel;
        private Button btnOut;
        private RichTextBox rtbNoiDung;
    }
}