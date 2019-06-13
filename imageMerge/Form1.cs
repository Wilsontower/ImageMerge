using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.Stitching;
using Emgu.CV.Util;

namespace imageMerge
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        string file1;
        string file2;

        private void openFileBtn1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择图片文件";
            dialog.Filter = "*.jpg|*.jpg";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
               
                try
                {
                    file1 = dialog.FileName; ;   //获得文件的绝对路径
                    this.pictureBox1.Load(file1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
       

        private void openFilebtn2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择图片文件";
            dialog.Filter = "*.jpg|*.jpg";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                try
                {
                    file2 = dialog.FileName; ;   //获得文件的绝对路径
                    this.pictureBox2.Load(file2);//载入图片资源
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private static Image ResizeImage(Image imgToResize, Size size)
        {
            //获取图片宽度
            int sourceWidth = imgToResize.Width;
            //获取图片高度
            int sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //计算宽度的缩放比例
            nPercentW = ((float)size.Width / (float)sourceWidth);
            //计算高度的缩放比例
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH > nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //期望的宽度
            int destWidth = (int)(sourceWidth * nPercent);
            //期望的高度
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            //绘制图像
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (System.Drawing.Image)b;
        }
        private static Image ResizeImageLR(Image imgToResize, Size size)
        {
            //获取图片宽度
            int sourceWidth = imgToResize.Width;
            //获取图片高度
            int sourceHeight = imgToResize.Height;

            float nPercent = 0;
            float nPercentW = 0;
            float nPercentH = 0;
            //计算宽度的缩放比例
            nPercentW = ((float)size.Width / (float)sourceWidth);
            //计算高度的缩放比例
            nPercentH = ((float)size.Height / (float)sourceHeight);

            if (nPercentH > nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;
            //期望的宽度
            int destWidth = (int)(sourceWidth * nPercent);
            //期望的高度
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap b = new Bitmap(destWidth, destHeight);
            Graphics g = Graphics.FromImage((System.Drawing.Image)b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            //绘制图像
            g.DrawImage(imgToResize, 0, 0, destWidth, destHeight);
            g.Dispose();
            return (System.Drawing.Image)b;
        }
        private void mergeBtn_Click(object sender, EventArgs e)
        {
            Image img1 = this.pictureBox1.Image;
            Bitmap map1 = new Bitmap(img1);
            Image img2 = this.pictureBox2.Image;
            Bitmap map2 = new Bitmap(img2);
            //计算宽高
            var width = Math.Max(img1.Width, img2.Width);
            var height = img1.Height + img2.Height;
            if(img1.Width> img2.Width) img2=ResizeImage(map2,new Size(width,img2.Height));
            if (img1.Width <= img2.Width) img1 = ResizeImage(map1,new Size(width, img1.Height));
            map1 = new Bitmap(img1);
            map2 = new Bitmap(img2);
            // 初始化画布(最终的拼图画布)并设置宽高
            Bitmap bitMap = new Bitmap(width, height);
            // 初始化画板
            Graphics g1 = Graphics.FromImage(bitMap);
            // 将画布涂为白色(底部颜色可自行设置)
            g1.FillRectangle(Brushes.White, new Rectangle(0, 0, width, height));
            //在x=0，y=0处画上图一
            g1.DrawImage(map1, 0, 0, img1.Width, img1.Height);
            //在x=0，y在图一往下10像素处画上图二
            g1.DrawImage(map2, 0, img1.Height, img2.Width, img2.Height);
            map1.Dispose();
            map2.Dispose();
            Image img = bitMap;
            //保存
            this.pictureBox3.Image = img;
           


        }
        private void LRmergeBtn_Click(object sender, EventArgs e)
        {
            Image img1 = this.pictureBox1.Image;
            Bitmap map1 = new Bitmap(img1);
            Image img2 = this.pictureBox2.Image;
            Bitmap map2 = new Bitmap(img2);
            //计算宽高
            var width = img1.Width+img2.Width;
            var height = Math.Max(img1.Height ,img2.Height);
            if (img1.Height > img2.Height) img2 = ResizeImage(map2, new Size(img2.Width, height));
            if (img1.Height <= img2.Height) img1 = ResizeImage(map1, new Size(img1.Width, height));
            map1 = new Bitmap(img1);
            map2 = new Bitmap(img2);
            // 初始化画布(最终的拼图画布)并设置宽高
            Bitmap bitMap = new Bitmap(width, height);
            // 初始化画板
            Graphics g1 = Graphics.FromImage(bitMap);
            // 将画布涂为白色(底部颜色可自行设置)
            g1.FillRectangle(Brushes.White, new Rectangle(0, 0, width, height));
            //在x=0，y=0处画上图一
            g1.DrawImage(map1, 0, 0, img1.Width, img1.Height);
            //在x=0，y在图一往下10像素处画上图二
            g1.DrawImage(map2, img1.Width, 0, img2.Width, img2.Height);
            map1.Dispose();
            map2.Dispose();
            Image img = bitMap;
            //保存
            this.pictureBox3.Image = img;


        }
        private void jointBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此过程可能需要几秒钟的时间，请稍候...");
            Image<Bgr, byte>[] sources;
            Image img1 = this.pictureBox1.Image;
            Bitmap map1 = new Bitmap(img1);
            Image img2 = this.pictureBox2.Image;
            Bitmap map2 = new Bitmap(img2);

            sources = new Image<Bgr, byte>[2];  //图像集初始化，确定了图像集的页数。
                                               
            sources[0] = new Image<Bgr, byte>(map1);//填入位图数据
            sources[1] = new Image<Bgr, byte>(map2);

            Stitcher stitcher = new Stitcher(false);  //true代表使用GPU，false代表不使用GPU
            Mat panoramic_img = new Mat();
            bool ok = true;  //定义并初始化ok,用来标识是否拼接成功
            Mat[] mat = new Mat[] { sources[0].Mat, sources[1].Mat};
            VectorOfMat vc = new VectorOfMat(mat);
            try
            {
                ok = stitcher.Stitch(vc, panoramic_img);
            }  //ok为真，则拼接成功；ok为假，则拼接失败。
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (ok)
            {
                pictureBox3.Image = (Image)panoramic_img.Bitmap;
                MessageBox.Show("两张图像合成成功");

            }
            else
            {
                MessageBox.Show("合成失败,图像相似区域太少或者无法合成"); ;//拼接失败
            }
          

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveImageDialog = new SaveFileDialog();
            saveImageDialog.Title = "保存图片";
            saveImageDialog.Filter = @"*.jpg）|*.jpg";
            
            if (saveImageDialog.ShowDialog() == DialogResult.OK)
            {
           
                string fileName = saveImageDialog.FileName.ToString();
                saveImageDialog.FileName = fileName;
                if (fileName != "" && fileName != null)
                {
                   
                    System.Drawing.Imaging.ImageFormat imgformat = null;
                    imgformat = System.Drawing.Imaging.ImageFormat.Jpeg;


                    if (fileName != "")
                    {
                        try
                        {
                            Bitmap bit = new Bitmap(this.pictureBox3.Image);
                            MessageBox.Show(fileName);
                            this.pictureBox3.Image.Save(fileName, imgformat);
                        }
                        catch
                        {
                            MessageBox.Show("error");

                        }
                    }
                }
            }
        }

      

      
    }
}
