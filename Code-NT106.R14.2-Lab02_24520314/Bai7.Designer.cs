namespace Code_NT106.R14._2_Lab02_24520314
{
    partial class Bai7
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
            rtbNoiDung = new RichTextBox();
            treev_tree = new TreeView();
            pic_fileContext = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pic_fileContext).BeginInit();
            SuspendLayout();
            // 
            // rtbNoiDung
            // 
            rtbNoiDung.BackColor = SystemColors.Control;
            rtbNoiDung.BorderStyle = BorderStyle.FixedSingle;
            rtbNoiDung.Location = new Point(484, 72);
            rtbNoiDung.Name = "rtbNoiDung";
            rtbNoiDung.ReadOnly = true;
            rtbNoiDung.Size = new Size(490, 448);
            rtbNoiDung.TabIndex = 1;
            rtbNoiDung.Text = "";
            // 
            // treev_tree
            // 
            treev_tree.Location = new Point(24, 44);
            treev_tree.Name = "treev_tree";
            treev_tree.Size = new Size(424, 476);
            treev_tree.TabIndex = 2;
            treev_tree.BeforeExpand += treev_tree_BeforeExpand;
            treev_tree.AfterSelect += treev_tree_AfterSelect;
            // 
            // pic_fileContext
            // 
            pic_fileContext.Location = new Point(484, 72);
            pic_fileContext.Name = "pic_fileContext";
            pic_fileContext.Size = new Size(490, 448);
            pic_fileContext.SizeMode = PictureBoxSizeMode.StretchImage;
            pic_fileContext.TabIndex = 3;
            pic_fileContext.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(484, 44);
            label1.Name = "label1";
            label1.Size = new Size(104, 25);
            label1.TabIndex = 4;
            label1.Text = "File Context";
            // 
            // Bai7
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 542);
            Controls.Add(label1);
            Controls.Add(pic_fileContext);
            Controls.Add(treev_tree);
            Controls.Add(rtbNoiDung);
            Name = "Bai7";
            Text = "Bai7";
            Load += Bai7_Load;
            ((System.ComponentModel.ISupportInitialize)pic_fileContext).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox rtbNoiDung;
        private TreeView treev_tree;
        private PictureBox pic_fileContext;
        private Label label1;
    }
}