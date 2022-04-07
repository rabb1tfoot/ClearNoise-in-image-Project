namespace shadowmasking
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGetImages = new System.Windows.Forms.Button();
            this.btnAdjust = new System.Windows.Forms.Button();
            this.tbThresBlack = new System.Windows.Forms.TextBox();
            this.tbPixel = new System.Windows.Forms.TextBox();
            this.cbImgs = new System.Windows.Forms.ComboBox();
            this.tbThresWhite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetBeMaskImage = new System.Windows.Forms.Button();
            this.tbMaskImage = new System.Windows.Forms.TextBox();
            this.btnPreview = new System.Windows.Forms.Button();
            this.chkRed = new System.Windows.Forms.CheckBox();
            this.chkTransparent = new System.Windows.Forms.CheckBox();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.btnSavePath = new System.Windows.Forms.Button();
            this.tbTransRate = new System.Windows.Forms.TextBox();
            this.lbAlphaRate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbPng = new System.Windows.Forms.RadioButton();
            this.rbBmp = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.chkReverse = new System.Windows.Forms.CheckBox();
            this.barMin = new System.Windows.Forms.TrackBar();
            this.barMax = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.barMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barMax)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGetImages
            // 
            this.btnGetImages.Location = new System.Drawing.Point(322, 69);
            this.btnGetImages.Name = "btnGetImages";
            this.btnGetImages.Size = new System.Drawing.Size(84, 23);
            this.btnGetImages.TabIndex = 0;
            this.btnGetImages.Text = "GetImages";
            this.btnGetImages.UseVisualStyleBackColor = true;
            this.btnGetImages.Click += new System.EventHandler(this.btnGetImages_Click);
            // 
            // btnAdjust
            // 
            this.btnAdjust.Location = new System.Drawing.Point(322, 220);
            this.btnAdjust.Name = "btnAdjust";
            this.btnAdjust.Size = new System.Drawing.Size(84, 23);
            this.btnAdjust.TabIndex = 1;
            this.btnAdjust.Text = "Save";
            this.btnAdjust.UseVisualStyleBackColor = true;
            this.btnAdjust.Click += new System.EventHandler(this.btnAdjust_Click);
            // 
            // tbThresBlack
            // 
            this.tbThresBlack.Location = new System.Drawing.Point(167, 128);
            this.tbThresBlack.Name = "tbThresBlack";
            this.tbThresBlack.Size = new System.Drawing.Size(45, 24);
            this.tbThresBlack.TabIndex = 2;
            this.tbThresBlack.Text = "30";
            this.tbThresBlack.TextChanged += new System.EventHandler(this.tbThresBlack_TextChanged);
            // 
            // tbPixel
            // 
            this.tbPixel.Location = new System.Drawing.Point(79, 105);
            this.tbPixel.Name = "tbPixel";
            this.tbPixel.Size = new System.Drawing.Size(33, 24);
            this.tbPixel.TabIndex = 3;
            this.tbPixel.Text = "128";
            // 
            // cbImgs
            // 
            this.cbImgs.FormattingEnabled = true;
            this.cbImgs.Location = new System.Drawing.Point(12, 69);
            this.cbImgs.Name = "cbImgs";
            this.cbImgs.Size = new System.Drawing.Size(293, 23);
            this.cbImgs.TabIndex = 4;
            // 
            // tbThresWhite
            // 
            this.tbThresWhite.Location = new System.Drawing.Point(167, 176);
            this.tbThresWhite.Name = "tbThresWhite";
            this.tbThresWhite.Size = new System.Drawing.Size(45, 24);
            this.tbThresWhite.TabIndex = 5;
            this.tbThresWhite.Text = "255";
            this.tbThresWhite.TextChanged += new System.EventHandler(this.tbThresWhite_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(131, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Threshold";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "배경픽셀값";
            // 
            // btnGetBeMaskImage
            // 
            this.btnGetBeMaskImage.Location = new System.Drawing.Point(322, 36);
            this.btnGetBeMaskImage.Name = "btnGetBeMaskImage";
            this.btnGetBeMaskImage.Size = new System.Drawing.Size(84, 23);
            this.btnGetBeMaskImage.TabIndex = 8;
            this.btnGetBeMaskImage.Text = "GetMask(ref)";
            this.btnGetBeMaskImage.UseVisualStyleBackColor = true;
            this.btnGetBeMaskImage.Click += new System.EventHandler(this.btnGetBeMaskImage_Click);
            // 
            // tbMaskImage
            // 
            this.tbMaskImage.Location = new System.Drawing.Point(12, 37);
            this.tbMaskImage.Name = "tbMaskImage";
            this.tbMaskImage.Size = new System.Drawing.Size(293, 24);
            this.tbMaskImage.TabIndex = 9;
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(230, 220);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 10;
            this.btnPreview.Text = "PreView";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // chkRed
            // 
            this.chkRed.AutoSize = true;
            this.chkRed.Location = new System.Drawing.Point(12, 159);
            this.chkRed.Name = "chkRed";
            this.chkRed.Size = new System.Drawing.Size(46, 19);
            this.chkRed.TabIndex = 11;
            this.chkRed.Text = "Red";
            this.chkRed.UseVisualStyleBackColor = true;
            this.chkRed.CheckedChanged += new System.EventHandler(this.chkRed_CheckedChanged);
            // 
            // chkTransparent
            // 
            this.chkTransparent.AutoSize = true;
            this.chkTransparent.Location = new System.Drawing.Point(12, 184);
            this.chkTransparent.Name = "chkTransparent";
            this.chkTransparent.Size = new System.Drawing.Size(89, 19);
            this.chkTransparent.TabIndex = 12;
            this.chkTransparent.Text = "배경 투명화";
            this.chkTransparent.UseVisualStyleBackColor = true;
            this.chkTransparent.CheckedChanged += new System.EventHandler(this.chkTransparent_CheckedChanged);
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(12, 7);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(293, 24);
            this.tbPath.TabIndex = 13;
            // 
            // btnSavePath
            // 
            this.btnSavePath.Location = new System.Drawing.Point(321, 6);
            this.btnSavePath.Name = "btnSavePath";
            this.btnSavePath.Size = new System.Drawing.Size(84, 23);
            this.btnSavePath.TabIndex = 14;
            this.btnSavePath.Text = "SavePath";
            this.btnSavePath.UseVisualStyleBackColor = true;
            this.btnSavePath.Click += new System.EventHandler(this.btnSavePath_Click);
            // 
            // tbTransRate
            // 
            this.tbTransRate.Location = new System.Drawing.Point(79, 211);
            this.tbTransRate.Name = "tbTransRate";
            this.tbTransRate.Size = new System.Drawing.Size(33, 24);
            this.tbTransRate.TabIndex = 15;
            this.tbTransRate.Text = "0.5";
            this.tbTransRate.Visible = false;
            // 
            // lbAlphaRate
            // 
            this.lbAlphaRate.AutoSize = true;
            this.lbAlphaRate.Location = new System.Drawing.Point(6, 214);
            this.lbAlphaRate.Name = "lbAlphaRate";
            this.lbAlphaRate.Size = new System.Drawing.Size(61, 15);
            this.lbAlphaRate.TabIndex = 16;
            this.lbAlphaRate.Text = "투명비율 :";
            this.lbAlphaRate.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "max";
            // 
            // rbPng
            // 
            this.rbPng.AutoSize = true;
            this.rbPng.Checked = true;
            this.rbPng.Location = new System.Drawing.Point(78, 237);
            this.rbPng.Name = "rbPng";
            this.rbPng.Size = new System.Drawing.Size(46, 19);
            this.rbPng.TabIndex = 19;
            this.rbPng.TabStop = true;
            this.rbPng.Text = "png";
            this.rbPng.UseVisualStyleBackColor = true;
            this.rbPng.CheckedChanged += new System.EventHandler(this.rbPng_CheckedChanged);
            // 
            // rbBmp
            // 
            this.rbBmp.AutoSize = true;
            this.rbBmp.Location = new System.Drawing.Point(130, 237);
            this.rbBmp.Name = "rbBmp";
            this.rbBmp.Size = new System.Drawing.Size(49, 19);
            this.rbBmp.TabIndex = 20;
            this.rbBmp.TabStop = true;
            this.rbBmp.Text = "bmp";
            this.rbBmp.UseVisualStyleBackColor = true;
            this.rbBmp.CheckedChanged += new System.EventHandler(this.rbBmp_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "저장방식 :";
            // 
            // chkReverse
            // 
            this.chkReverse.AutoSize = true;
            this.chkReverse.Location = new System.Drawing.Point(12, 135);
            this.chkReverse.Name = "chkReverse";
            this.chkReverse.Size = new System.Drawing.Size(50, 19);
            this.chkReverse.TabIndex = 22;
            this.chkReverse.Text = "반전";
            this.chkReverse.UseVisualStyleBackColor = true;
            this.chkReverse.CheckedChanged += new System.EventHandler(this.chkReverse_CheckedChanged);
            // 
            // barMin
            // 
            this.barMin.Location = new System.Drawing.Point(231, 118);
            this.barMin.Name = "barMin";
            this.barMin.Size = new System.Drawing.Size(175, 45);
            this.barMin.TabIndex = 25;
            this.barMin.Scroll += new System.EventHandler(this.barMin_Scroll);
            // 
            // barMax
            // 
            this.barMax.Location = new System.Drawing.Point(231, 169);
            this.barMax.Name = "barMax";
            this.barMax.Size = new System.Drawing.Size(175, 45);
            this.barMax.TabIndex = 26;
            this.barMax.Scroll += new System.EventHandler(this.barMax_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 262);
            this.Controls.Add(this.barMax);
            this.Controls.Add(this.barMin);
            this.Controls.Add(this.chkReverse);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbBmp);
            this.Controls.Add(this.rbPng);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbAlphaRate);
            this.Controls.Add(this.tbTransRate);
            this.Controls.Add(this.btnSavePath);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.chkTransparent);
            this.Controls.Add(this.chkRed);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.tbMaskImage);
            this.Controls.Add(this.btnGetBeMaskImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbThresWhite);
            this.Controls.Add(this.cbImgs);
            this.Controls.Add(this.tbPixel);
            this.Controls.Add(this.tbThresBlack);
            this.Controls.Add(this.btnAdjust);
            this.Controls.Add(this.btnGetImages);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.barMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetImages;
        private System.Windows.Forms.Button btnAdjust;
        private System.Windows.Forms.TextBox tbThresBlack;
        private System.Windows.Forms.TextBox tbPixel;
        private System.Windows.Forms.ComboBox cbImgs;
        private System.Windows.Forms.TextBox tbThresWhite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetBeMaskImage;
        private System.Windows.Forms.TextBox tbMaskImage;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.CheckBox chkRed;
        private System.Windows.Forms.CheckBox chkTransparent;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button btnSavePath;
        private System.Windows.Forms.TextBox tbTransRate;
        private System.Windows.Forms.Label lbAlphaRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbPng;
        private System.Windows.Forms.RadioButton rbBmp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkReverse;
        private System.Windows.Forms.TrackBar barMin;
        private System.Windows.Forms.TrackBar barMax;
    }
}

