using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;


namespace ImageForm
{
    /// <summary>
    /// あくまでもImageデータを取り扱う
    /// Bitmapやjpegなどのフォーマット詳細は別のプロジェクトで行う．
    /// </summary>
    public partial class MainForm : Form
    {
        string openPath = null;
        string closePath = null;
        bool openfile;
        public MainForm()
        {
            openfile = false;
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Console.WriteLine(this.Width);
            Console.WriteLine(this.Height);
            Console.WriteLine("form_resize");
        }

        #region File

        // ファイルオープン----------
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // フラグ解除
            {
                openfile = true;
                saveToolStripMenuItem.Enabled = true;
                // 編集メニュー
                this.editToolStripMenuItem.Enabled = true;
            }

            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            openPath = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(openPath);
            pictureBox2.Image = Image.FromFile(openPath);
            Console.WriteLine("OpenEnd");
        }

        // 上書き保存----------
        // 非対応
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Image tmp = pictureBox1.Image;
            tmp.Save(openPath);
            Console.WriteLine("SaveEnd");
        }

        // 新規保存----------
        private void save_asToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            closePath = saveFileDialog1.FileName;
            pictureBox1.Image.Save(closePath);
            Console.WriteLine("SaveAsEnd");
        }

        #endregion

        #region PictureBox描画

        // 元データ
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (openfile)
            {

                pictureBox1.Width = pictureBox1.Image.Width;
                pictureBox1.Height = pictureBox1.Image.Height;
                Console.WriteLine(pictureBox1.Width);
                Console.WriteLine(pictureBox1.Height);
                Console.WriteLine(pictureBox1.Image.Width);
                Console.WriteLine(pictureBox1.Image.Height);
                this.Text = openPath;
            }
            Console.WriteLine("paint1");
        }

        // 変更データ
        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            if (openfile)
            {
                pictureBox2.Width = pictureBox2.Image.Width;
                pictureBox2.Height = pictureBox2.Image.Height;
                Console.WriteLine(pictureBox2.Width);
                Console.WriteLine(pictureBox2.Height);
                Console.WriteLine(pictureBox2.Image.Width);
                Console.WriteLine(pictureBox2.Image.Height);
            }
            Console.WriteLine("paint2");
        }

        #endregion



        #region EditEvent

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = pictureBox1.Image;
        }

        private void grayScaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = BmpClass.DoBmp.DoGrayScale(pictureBox2.Image);
        }

        private void negaPosiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = BmpClass.DoBmp.DoNegaPosi(pictureBox2.Image);
        }

        private void sinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = BmpClass.DoBmp.DoToneCurve_Sin(pictureBox2.Image);
        }

        private void cosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = BmpClass.DoBmp.DoToneCurve_Cos(pictureBox2.Image);
        }

        private void s_shapedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = BmpClass.DoBmp.DoToneCurve_S_Shaped(pictureBox2.Image);
        }
        
        private void linearFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox2.Image = BmpClass.DoBmp.DoLinearFilter(pictureBox2.Image);
        }

        #endregion


    }
}
