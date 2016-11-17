namespace ImageForm
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.save_asToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negaPosiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToneCurveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.s_shapedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linearFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.BackgroundImage = global::ImageEditor.Properties.Resources.clear;
            this.pictureBox1.ErrorImage = global::ImageEditor.Properties.Resources.clear;
            this.pictureBox1.InitialImage = global::ImageEditor.Properties.Resources.clear;
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 372);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "bmp|*.bmp|all|*.*";
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(630, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.save_asToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "file";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // save_asToolStripMenuItem
            // 
            this.save_asToolStripMenuItem.Enabled = false;
            this.save_asToolStripMenuItem.Name = "save_asToolStripMenuItem";
            this.save_asToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.save_asToolStripMenuItem.Text = "save_as";
            this.save_asToolStripMenuItem.Click += new System.EventHandler(this.save_asToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Enabled = false;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem1_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.grayScaleToolStripMenuItem,
            this.negaPosiToolStripMenuItem,
            this.ToneCurveToolStripMenuItem,
            this.linearFilterToolStripMenuItem});
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "edit";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.resetToolStripMenuItem.Text = "Reset";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // grayScaleToolStripMenuItem
            // 
            this.grayScaleToolStripMenuItem.Name = "grayScaleToolStripMenuItem";
            this.grayScaleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.grayScaleToolStripMenuItem.Text = "GrayScale";
            this.grayScaleToolStripMenuItem.Click += new System.EventHandler(this.grayScaleToolStripMenuItem_Click);
            // 
            // negaPosiToolStripMenuItem
            // 
            this.negaPosiToolStripMenuItem.Name = "negaPosiToolStripMenuItem";
            this.negaPosiToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.negaPosiToolStripMenuItem.Text = "NegaPosi";
            this.negaPosiToolStripMenuItem.Click += new System.EventHandler(this.negaPosiToolStripMenuItem_Click);
            // 
            // ToneCurveToolStripMenuItem
            // 
            this.ToneCurveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sinToolStripMenuItem,
            this.cosToolStripMenuItem,
            this.s_shapedToolStripMenuItem});
            this.ToneCurveToolStripMenuItem.Name = "ToneCurveToolStripMenuItem";
            this.ToneCurveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ToneCurveToolStripMenuItem.Text = "ToneCurve";
            // 
            // sinToolStripMenuItem
            // 
            this.sinToolStripMenuItem.Name = "sinToolStripMenuItem";
            this.sinToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.sinToolStripMenuItem.Text = "Sin";
            this.sinToolStripMenuItem.Click += new System.EventHandler(this.sinToolStripMenuItem_Click);
            // 
            // cosToolStripMenuItem
            // 
            this.cosToolStripMenuItem.Name = "cosToolStripMenuItem";
            this.cosToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.cosToolStripMenuItem.Text = "Cos";
            this.cosToolStripMenuItem.Click += new System.EventHandler(this.cosToolStripMenuItem_Click);
            // 
            // s_shapedToolStripMenuItem
            // 
            this.s_shapedToolStripMenuItem.Name = "s_shapedToolStripMenuItem";
            this.s_shapedToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.s_shapedToolStripMenuItem.Text = "S_Shaped";
            this.s_shapedToolStripMenuItem.Click += new System.EventHandler(this.s_shapedToolStripMenuItem_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "bmp|*.bmp|all|*.*";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.BackgroundImage = global::ImageEditor.Properties.Resources.clear;
            this.pictureBox2.ErrorImage = global::ImageEditor.Properties.Resources.clear;
            this.pictureBox2.InitialImage = global::ImageEditor.Properties.Resources.clear;
            this.pictureBox2.Location = new System.Drawing.Point(364, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(142, 372);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox2_Paint);
            // 
            // linearFilterToolStripMenuItem
            // 
            this.linearFilterToolStripMenuItem.Name = "linearFilterToolStripMenuItem";
            this.linearFilterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.linearFilterToolStripMenuItem.Text = "LinearFilter";
            this.linearFilterToolStripMenuItem.Click += new System.EventHandler(this.linearFilterToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(630, 405);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem save_asToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grayScaleToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripMenuItem negaPosiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToneCurveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem s_shapedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linearFilterToolStripMenuItem;
    }
}

