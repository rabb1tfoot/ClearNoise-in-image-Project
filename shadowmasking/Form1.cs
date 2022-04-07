using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OpenCvSharp;

namespace shadowmasking
{
    public partial class Form1 : Form
    {
        static string START_FOLDER = "C:\\DeeDiim";
        List<Mat> imgs = new List<Mat>();
        List<Mat> saveImgs = new List<Mat>();
        Mat refImage = new Mat();
        Mat windowREF = new Mat();
        Mat background;
        bool bRed = false;
        bool bTransparent = false;
        bool bReverse = false;
        bool bFreeView = false;

        string nameExt = ".png";
        public Form1()
        {
            InitializeComponent();
            tbPath.Text = START_FOLDER;
            InitBar();
            CheckFolder();
        }

        private void btnAdjust_Click(object sender, EventArgs e)
        {
            bool save = true;
            operation(save);
        }

        private void btnGetImages_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "이미지 열기";
            ofd.Filter = "그림 파일 (*.jpg, *.png, *.bmp) | *.jpg; *.png; *.bmp; | 모든 파일 (*.*) | *.*";
            ofd.Multiselect = true;

            DialogResult dr = ofd.ShowDialog();
            
            if (dr == DialogResult.OK)
            {
                var filename = ofd.FileNames;
                imgs.Clear();
                cbImgs.Items.Clear();
                foreach (var files in filename)
                {
                    imgs.Add(Cv2.ImRead(files));
                    cbImgs.Items.Add(files);
                }
                cbImgs.SelectedIndex = 0;
            }
        }

        private void btnGetBeMaskImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "이미지 열기";
            ofd.Filter = "그림 파일 (*.jpg, *.png, *.bmp) | *.jpg; *.png; *.bmp; | 모든 파일 (*.*) | *.*";

            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {
                refImage = Cv2.ImRead(ofd.FileName);
                tbMaskImage.Text = ofd.FileName;
            }
        }

        private void ShowImage(Mat _img, string _windowName)
        {
            Cv2.Resize(_img, windowREF, new OpenCvSharp.Size(800, 600));
            Cv2.ImShow(_windowName, windowREF);
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            bool save = false;
            bFreeView = true;
            operation(save);
        }

        private void chkRed_CheckedChanged(object sender, EventArgs e)
        {
            bRed = !bRed;
        }

        private void btnSavePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = tbPath.Text;
            DialogResult dr = dialog.ShowDialog();
            if(dr == DialogResult.OK)
            {
                tbPath.Text = dialog.SelectedPath;
            }
        }

        private void chkTransparent_CheckedChanged(object sender, EventArgs e)
        {
            bTransparent = !bTransparent;
            tbTransRate.Visible = !tbTransRate.Visible;
            lbAlphaRate.Visible = !lbAlphaRate.Visible;
        }

        private void operation(bool _bSave)
        {
            int thresBlack = -1;
            int thresWhite = -1;
            int pixelValue = -1;
            int.TryParse(tbThresBlack.Text, out thresBlack);
            int.TryParse(tbThresWhite.Text, out thresWhite);
            int.TryParse(tbPixel.Text, out pixelValue);

            string path = tbPath.Text;
            double alpha = 0;
            double.TryParse(tbTransRate.Text, out alpha);

            ExceedChk(ref thresBlack, 255, true);
            ExceedChk(ref thresBlack, 0, false);

            ExceedChk(ref thresWhite, 255, true);
            ExceedChk(ref thresWhite, 0, false);

            ExceedChk(ref pixelValue, 255, true);
            ExceedChk(ref pixelValue, 0, false);

            ExceedChk(ref alpha, 1, true);
            ExceedChk(ref alpha, 0, false);


            Mat refClone = refImage.Clone();

            if (thresBlack >= 0 && thresWhite >= 0 && pixelValue >= 0
                && thresBlack <= 255 && thresWhite <= 255 && pixelValue <= 255
                && alpha <= 1 && alpha >= 0)
            {
                if (imgs.Count != 0 && refClone.Height > 0)
                {
                    saveImgs.Clear();
                    background = new Mat(refClone.Rows, refClone.Cols, MatType.CV_8UC3, Scalar.FromRgb(pixelValue, pixelValue, pixelValue));

                    if(!bReverse)
                    {
                        Cv2.Threshold(refClone, refClone, thresBlack, thresWhite, ThresholdTypes.Binary);
                    }
                    else
                    {
                        Cv2.Threshold(refClone, refClone, thresBlack, thresWhite, ThresholdTypes.BinaryInv);
                    }
                    Mat revserserefImage = ~refClone;


                    if (!bRed)
                        Cv2.Subtract(revserserefImage, Scalar.FromRgb(255 - pixelValue, 255 - pixelValue, 255 - pixelValue), background);
                    else
                        Cv2.Subtract(revserserefImage, Scalar.FromRgb((pixelValue) / 2, pixelValue, pixelValue), background);

                    ShowImage(background, "ThresREF");

                    for (int i = 0; i < imgs.Count; ++i)
                    {
                        saveImgs.Add(imgs[i].Clone());

                        Cv2.BitwiseAnd(saveImgs[i], refClone, saveImgs[i]);

                        if (bTransparent)
                        {
                            Cv2.AddWeighted(imgs[i], 1, background, (1 - alpha), 0, saveImgs[i]);
                        }
                        else
                        {
                            Cv2.Add(saveImgs[i], background, saveImgs[i]);
                        }

                        ShowImage(saveImgs[i], string.Format("result_{0}", i));

                        cbImgs.SelectedIndex = i;
                        if (_bSave)
                        {
                            if (path == "")
                            {
                                string fileName = cbImgs.SelectedItem.ToString();
                                string[] names = fileName.Split('.');
                                names[0] += "filled" + nameExt;
                                string saveName = names[0];
                                Cv2.ImWrite(saveName, saveImgs[i]);
                            }
                            else
                            {
                                string fullname = cbImgs.SelectedItem.ToString();
                                string[] split = fullname.Split('\\');

                                string fileName = split[split.Length - 1];
                                string[] names = fileName.Split('.');
                                names[0] += "filled" + nameExt;
                                string savefileName = "\\" + names[0];
                                string saveFullname = path + savefileName;

                                Cv2.ImWrite(saveFullname, saveImgs[i]);

                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("이미지 로딩 안됨");
                }
            }
            else
            {
                MessageBox.Show("파라미터 값 오류");
            }
        }

        void ExceedChk(ref int _value, int _limit, bool _over)
        {
            if(_over)
            {
                if (_value > _limit)
                    _value = _limit;
            }
            else
            {
                if (_value < _limit)
                    _value = _limit;
            }
        }
        void ExceedChk(ref double _value, double _limit, bool _over)
        {
            if (_over)
            {
                if (_value > _limit)
                    _value = _limit;
            }
            else
            {
                if (_value < _limit)
                    _value = _limit;
            }
        }
        void CheckFolder()
        {
            if(!Directory.Exists(START_FOLDER))
            {
                Directory.CreateDirectory(START_FOLDER);
            }
        }

        private void rbPng_CheckedChanged(object sender, EventArgs e)
        {
            nameExt = ".png";
        }

        private void rbBmp_CheckedChanged(object sender, EventArgs e)
        {
            nameExt = ".bmp";
        }

        private void chkReverse_CheckedChanged(object sender, EventArgs e)
        {
            bReverse = !bReverse;
        }

        private void tbThresBlack_TextChanged(object sender, EventArgs e)
        {
            int thresBlack;
            int.TryParse(tbThresBlack.Text, out thresBlack);
            ExceedChk(ref thresBlack, 255, true);
            ExceedChk(ref thresBlack, 0, false);

            barMin.Value = thresBlack;

            if (bFreeView)
                operation(false);
        }

        private void tbThresWhite_TextChanged(object sender, EventArgs e)
        {
            int thresWhite;
            int.TryParse(tbThresWhite.Text, out thresWhite);
            ExceedChk(ref thresWhite, 255, true);
            ExceedChk(ref thresWhite, 0, false);

            barMax.Value = thresWhite;

            if (bFreeView)
                operation(false);
        }

        private void InitBar()
        {
            barMin.Minimum = 0;
            barMax.Minimum = 0;
            barMin.Maximum = 255;
            barMax.Maximum = 255;
            int thresBlack;
            int thresWhite;


            int.TryParse(tbThresBlack.Text, out thresBlack);
            int.TryParse(tbThresWhite.Text, out thresWhite);

            barMin.Value = thresBlack;
            barMax.Value = thresWhite;
        }

        private void barMin_Scroll(object sender, EventArgs e)
        {
            tbThresBlack.Text = barMin.Value.ToString();

            if(bFreeView)
                operation(false);
        }

        private void barMax_Scroll(object sender, EventArgs e)
        {
            tbThresWhite.Text = barMax.Value.ToString();

            if(bFreeView)
                operation(false);
        }
    }
}
