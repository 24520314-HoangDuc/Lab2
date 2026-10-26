namespace Code_NT106.R14._2_Lab02_24520314
{
    partial class Bai6
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
            groupBox1 = new GroupBox();
            btnAdd = new Button();
            btnAddImage = new Button();
            txtFoodImageAdded = new TextBox();
            txtFoodNameAdded = new TextBox();
            txtContributorNameAdded = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnFindFoods = new Button();
            picFoodImageFound = new PictureBox();
            lvFoodList = new ListView();
            label4 = new Label();
            label5 = new Label();
            txtContributorNameFound = new TextBox();
            txtFoodNameFound = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFoodImageFound).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnAddImage);
            groupBox1.Controls.Add(txtFoodImageAdded);
            groupBox1.Controls.Add(txtFoodNameAdded);
            groupBox1.Controls.Add(txtContributorNameAdded);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(398, 283);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thêm món ăn";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(199, 220);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(161, 34);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Thêm món ăn";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnAddImage
            // 
            btnAddImage.Location = new Point(26, 220);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(167, 34);
            btnAddImage.TabIndex = 6;
            btnAddImage.Text = "Thêm hình ảnh";
            btnAddImage.UseVisualStyleBackColor = true;
            btnAddImage.Click += btnAddImage_Click;
            // 
            // txtFoodImageAdded
            // 
            txtFoodImageAdded.Location = new Point(196, 154);
            txtFoodImageAdded.Name = "txtFoodImageAdded";
            txtFoodImageAdded.ReadOnly = true;
            txtFoodImageAdded.Size = new Size(150, 31);
            txtFoodImageAdded.TabIndex = 5;
            // 
            // txtFoodNameAdded
            // 
            txtFoodNameAdded.Location = new Point(196, 100);
            txtFoodNameAdded.Name = "txtFoodNameAdded";
            txtFoodNameAdded.Size = new Size(150, 31);
            txtFoodNameAdded.TabIndex = 4;
            // 
            // txtContributorNameAdded
            // 
            txtContributorNameAdded.Location = new Point(196, 54);
            txtContributorNameAdded.Name = "txtContributorNameAdded";
            txtContributorNameAdded.Size = new Size(150, 31);
            txtContributorNameAdded.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 160);
            label3.Name = "label3";
            label3.Size = new Size(83, 25);
            label3.TabIndex = 2;
            label3.Text = "Hình ảnh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 106);
            label2.Name = "label2";
            label2.Size = new Size(104, 25);
            label2.TabIndex = 1;
            label2.Text = "Tên món ăn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 60);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 0;
            label1.Text = "Tên của bạn";
            // 
            // btnFindFoods
            // 
            btnFindFoods.Location = new Point(696, 63);
            btnFindFoods.Name = "btnFindFoods";
            btnFindFoods.Size = new Size(155, 34);
            btnFindFoods.TabIndex = 1;
            btnFindFoods.Text = "Tìm món ăn";
            btnFindFoods.UseVisualStyleBackColor = true;
            btnFindFoods.Click += btnFindFoods_Click;
            // 
            // picFoodImageFound
            // 
            picFoodImageFound.Location = new Point(593, 131);
            picFoodImageFound.Name = "picFoodImageFound";
            picFoodImageFound.Size = new Size(382, 291);
            picFoodImageFound.SizeMode = PictureBoxSizeMode.StretchImage;
            picFoodImageFound.TabIndex = 2;
            picFoodImageFound.TabStop = false;
            // 
            // lvFoodList
            // 
            lvFoodList.Location = new Point(12, 301);
            lvFoodList.Name = "lvFoodList";
            lvFoodList.Size = new Size(398, 236);
            lvFoodList.TabIndex = 3;
            lvFoodList.UseCompatibleStateImageBehavior = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(593, 443);
            label4.Name = "label4";
            label4.Size = new Size(176, 25);
            label4.TabIndex = 4;
            label4.Text = "Tên người đóng góp";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(593, 489);
            label5.Name = "label5";
            label5.Size = new Size(104, 25);
            label5.TabIndex = 5;
            label5.Text = "Tên món ăn";
            // 
            // txtContributorNameFound
            // 
            txtContributorNameFound.Location = new Point(779, 443);
            txtContributorNameFound.Name = "txtContributorNameFound";
            txtContributorNameFound.ReadOnly = true;
            txtContributorNameFound.Size = new Size(196, 31);
            txtContributorNameFound.TabIndex = 6;
            // 
            // txtFoodNameFound
            // 
            txtFoodNameFound.Location = new Point(779, 489);
            txtFoodNameFound.Name = "txtFoodNameFound";
            txtFoodNameFound.ReadOnly = true;
            txtFoodNameFound.Size = new Size(196, 31);
            txtFoodNameFound.TabIndex = 7;
            // 
            // Bai6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 549);
            Controls.Add(txtFoodNameFound);
            Controls.Add(txtContributorNameFound);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lvFoodList);
            Controls.Add(picFoodImageFound);
            Controls.Add(btnFindFoods);
            Controls.Add(groupBox1);
            Name = "Bai6";
            Text = "Bai6";
            Load += Bai6_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picFoodImageFound).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAdd;
        private Button btnAddImage;
        private TextBox txtFoodImageAdded;
        private TextBox txtFoodNameAdded;
        private TextBox txtContributorNameAdded;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnFindFoods;
        private PictureBox picFoodImageFound;
        private ListView lvFoodList;
        private Label label4;
        private Label label5;
        private TextBox txtContributorNameFound;
        private TextBox txtFoodNameFound;
    }
}