namespace Code_NT106.R14._2_Lab02_24520314
{
    partial class Bai5
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
            groupBox1 = new GroupBox();
            cboSeat = new ComboBox();
            btnBuy = new Button();
            cboTicketClass = new ComboBox();
            cboRooms = new ComboBox();
            cboFilmName = new ComboBox();
            txtCustomName = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            rtbCustomInfo = new RichTextBox();
            pb_progress = new ProgressBar();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRead
            // 
            btnRead.Location = new Point(22, 35);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(150, 34);
            btnRead.TabIndex = 0;
            btnRead.Text = "Đọc thông tin";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(22, 92);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(150, 34);
            btnWrite.TabIndex = 1;
            btnWrite.Text = "Ghi thông tin";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboSeat);
            groupBox1.Controls.Add(btnBuy);
            groupBox1.Controls.Add(cboTicketClass);
            groupBox1.Controls.Add(cboRooms);
            groupBox1.Controls.Add(cboFilmName);
            groupBox1.Controls.Add(txtCustomName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(205, 35);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(452, 433);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mua vé";
            // 
            // cboSeat
            // 
            cboSeat.FormattingEnabled = true;
            cboSeat.Location = new Point(251, 328);
            cboSeat.Name = "cboSeat";
            cboSeat.Size = new Size(182, 33);
            cboSeat.TabIndex = 9;
            // 
            // btnBuy
            // 
            btnBuy.Location = new Point(171, 393);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(112, 34);
            btnBuy.TabIndex = 4;
            btnBuy.Text = "Mua";
            btnBuy.UseVisualStyleBackColor = true;
            btnBuy.Click += btnBuy_Click;
            // 
            // cboTicketClass
            // 
            cboTicketClass.FormattingEnabled = true;
            cboTicketClass.Location = new Point(251, 250);
            cboTicketClass.Name = "cboTicketClass";
            cboTicketClass.Size = new Size(182, 33);
            cboTicketClass.TabIndex = 8;
            cboTicketClass.SelectedIndexChanged += cboTicketClass_SelectedIndexChanged;
            // 
            // cboRooms
            // 
            cboRooms.FormattingEnabled = true;
            cboRooms.Location = new Point(251, 179);
            cboRooms.Name = "cboRooms";
            cboRooms.Size = new Size(182, 33);
            cboRooms.TabIndex = 7;
            // 
            // cboFilmName
            // 
            cboFilmName.FormattingEnabled = true;
            cboFilmName.Location = new Point(251, 112);
            cboFilmName.Name = "cboFilmName";
            cboFilmName.Size = new Size(182, 33);
            cboFilmName.TabIndex = 6;
            cboFilmName.SelectedIndexChanged += cboFileName_SelectedIndexChanged;
            // 
            // txtCustomName
            // 
            txtCustomName.Location = new Point(251, 44);
            txtCustomName.Name = "txtCustomName";
            txtCustomName.Size = new Size(182, 31);
            txtCustomName.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 336);
            label6.Name = "label6";
            label6.Size = new Size(85, 25);
            label6.TabIndex = 4;
            label6.Text = "Chỗ ngồi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 258);
            label5.Name = "label5";
            label5.Size = new Size(76, 25);
            label5.TabIndex = 3;
            label5.Text = "Hạn chế";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 187);
            label4.Name = "label4";
            label4.Size = new Size(110, 25);
            label4.TabIndex = 2;
            label4.Text = "Phòng chiếu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 120);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 1;
            label3.Text = "Tên phim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 50);
            label2.Name = "label2";
            label2.Size = new Size(152, 25);
            label2.TabIndex = 0;
            label2.Text = "Nhập tên của bạn";
            // 
            // rtbCustomInfo
            // 
            rtbCustomInfo.Location = new Point(682, 41);
            rtbCustomInfo.Name = "rtbCustomInfo";
            rtbCustomInfo.ReadOnly = true;
            rtbCustomInfo.Size = new Size(459, 427);
            rtbCustomInfo.TabIndex = 0;
            rtbCustomInfo.Text = "";
            // 
            // pb_progress
            // 
            pb_progress.Location = new Point(22, 166);
            pb_progress.Name = "pb_progress";
            pb_progress.Size = new Size(150, 34);
            pb_progress.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(712, 9);
            label1.Name = "label1";
            label1.Size = new Size(184, 25);
            label1.TabIndex = 5;
            label1.Text = "Thông tin khách hàng";
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1153, 511);
            Controls.Add(label1);
            Controls.Add(pb_progress);
            Controls.Add(rtbCustomInfo);
            Controls.Add(groupBox1);
            Controls.Add(btnWrite);
            Controls.Add(btnRead);
            Name = "Bai5";
            Text = "Bai5";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRead;
        private Button btnWrite;
        private GroupBox groupBox1;
        private RichTextBox rtbCustomInfo;
        private ProgressBar pb_progress;
        private Button btnBuy;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cboSeat;
        private ComboBox cboTicketClass;
        private ComboBox cboRooms;
        private ComboBox cboFilmName;
        private TextBox txtCustomName;
    }
}