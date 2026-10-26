namespace Code_NT106.R14._2_Lab02_24520314
{
    partial class Bai1
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
            btnWrite = new Button();
            btnDel = new Button();
            btnOut = new Button();
            rtbNoiDung = new RichTextBox();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Location = new Point(55, 44);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(167, 83);
            btnRead.TabIndex = 1;
            btnRead.Text = "Đọc file";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(55, 164);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(167, 78);
            btnWrite.TabIndex = 2;
            btnWrite.Text = "Ghi file";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(55, 270);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(167, 34);
            btnDel.TabIndex = 3;
            btnDel.Text = "Xóa";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnOut
            // 
            btnOut.Location = new Point(55, 328);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(167, 34);
            btnOut.TabIndex = 4;
            btnOut.Text = "Thoát";
            btnOut.UseVisualStyleBackColor = true;
            btnOut.Click += btnOut_Click;
            // 
            // rtbNoiDung
            // 
            rtbNoiDung.Location = new Point(268, 44);
            rtbNoiDung.Name = "rtbNoiDung";
            rtbNoiDung.ReadOnly = true;
            rtbNoiDung.Size = new Size(476, 318);
            rtbNoiDung.TabIndex = 5;
            rtbNoiDung.Text = "";
            // 
            // Bai1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(rtbNoiDung);
            Controls.Add(btnOut);
            Controls.Add(btnDel);
            Controls.Add(btnWrite);
            Controls.Add(btnRead);
            Name = "Bai1";
            Text = "Bai1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRead;
        private Button btnWrite;
        private Button btnDel;
        private Button btnOut;
        private RichTextBox rtbNoiDung;
    }
}