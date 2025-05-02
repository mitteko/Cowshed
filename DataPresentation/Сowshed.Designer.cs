namespace DataPresentation
{
    partial class Сowshed
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
            splitContainer1 = new SplitContainer();
            pictureBox = new PictureBox();
            treeView = new TreeView();
            dataGridViewAll = new DataGridView();
            detailsButton = new Button();
            loadDataButton = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAll).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(pictureBox);
            splitContainer1.Panel1.Controls.Add(treeView);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGridViewAll);
            splitContainer1.Panel2.Controls.Add(detailsButton);
            splitContainer1.Panel2.Controls.Add(loadDataButton);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 266;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBox
            // 
            pictureBox.BackgroundImage = Properties.Resources._4;
            pictureBox.Image = Properties.Resources._4;
            pictureBox.ImageLocation = "";
            pictureBox.InitialImage = Properties.Resources._4;
            pictureBox.Location = new Point(12, 331);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(236, 107);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // treeView
            // 
            treeView.BackColor = SystemColors.Info;
            treeView.Location = new Point(0, 0);
            treeView.Name = "treeView";
            treeView.Size = new Size(263, 450);
            treeView.TabIndex = 0;
            // 
            // dataGridViewAll
            // 
            dataGridViewAll.BackgroundColor = Color.DarkSeaGreen;
            dataGridViewAll.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAll.Location = new Point(3, 79);
            dataGridViewAll.Name = "dataGridViewAll";
            dataGridViewAll.Size = new Size(515, 359);
            dataGridViewAll.TabIndex = 3;
            // 
            // detailsButton
            // 
            detailsButton.Location = new Point(260, 23);
            detailsButton.Name = "detailsButton";
            detailsButton.Size = new Size(124, 33);
            detailsButton.TabIndex = 2;
            detailsButton.Text = "Показать";
            detailsButton.UseVisualStyleBackColor = true;
            detailsButton.Click += detailsButton_Click;
            // 
            // loadDataButton
            // 
            loadDataButton.Location = new Point(130, 23);
            loadDataButton.Name = "loadDataButton";
            loadDataButton.Size = new Size(124, 33);
            loadDataButton.TabIndex = 0;
            loadDataButton.Text = "Загрузить";
            loadDataButton.UseVisualStyleBackColor = true;
            loadDataButton.Click += loadDataButton_Click;
            // 
            // Сowshed
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Сowshed";
            Text = "Сowshed";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAll).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private TreeView treeView;
        private Button loadDataButton;
        private PictureBox pictureBox;
        private DataGridView dataGridViewStalls;
        private DataGridView dataGridViewAll;
        private Button detailsButton;
    }
}