namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbPlain01 = new System.Windows.Forms.Label();
            this.txtPlain01 = new System.Windows.Forms.TextBox();
            this.lbShift01 = new System.Windows.Forms.Label();
            this.updownImageList = new System.Windows.Forms.ImageList(this.components);
            this.btnEncrypt01 = new System.Windows.Forms.Button();
            this.btnDecrypt01 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.lbDecrypt01 = new System.Windows.Forms.Label();
            this.txtDecrypt01 = new System.Windows.Forms.TextBox();
            this.btnReset01 = new System.Windows.Forms.Button();
            this.btnExit01 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // plainLabel
            // 
            this.lbPlain01.AutoSize = true;
            this.lbPlain01.Location = new System.Drawing.Point(26, 26);
            this.lbPlain01.Name = "lbPlain01";
            this.lbPlain01.Size = new System.Drawing.Size(33, 12);
            this.lbPlain01.TabIndex = 0;
            this.lbPlain01.Text = "평 문";
            // 
            // plainTextBox
            // 
            this.txtPlain01.Location = new System.Drawing.Point(65, 23);
            this.txtPlain01.Multiline = true;
            this.txtPlain01.Name = "txtPlain01";
            this.txtPlain01.Size = new System.Drawing.Size(474, 64);
            this.txtPlain01.TabIndex = 1;
            // 
            // shiftLabel
            // 
            this.lbShift01.AutoSize = true;
            this.lbShift01.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbShift01.Location = new System.Drawing.Point(178, 129);
            this.lbShift01.Name = "lbShift01";
            this.lbShift01.Size = new System.Drawing.Size(184, 24);
            this.lbShift01.TabIndex = 2;
            this.lbShift01.Text = "암호화 Shift Key";
            // 
            // updownImageList
            // 
            this.updownImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("updownImageList.ImageStream")));
            this.updownImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.updownImageList.Images.SetKeyName(0, "Down.png");
            this.updownImageList.Images.SetKeyName(1, "Up.png");
            // 
            // encryptButton
            // 
            this.btnEncrypt01.ImageIndex = 0;
            this.btnEncrypt01.ImageList = this.updownImageList;
            this.btnEncrypt01.Location = new System.Drawing.Point(65, 113);
            this.btnEncrypt01.Name = "btnEncrypt01";
            this.btnEncrypt01.Size = new System.Drawing.Size(55, 55);
            this.btnEncrypt01.TabIndex = 3;
            this.btnEncrypt01.UseVisualStyleBackColor = true;
            this.btnEncrypt01.Click += new System.EventHandler(this.btnEncrypt01_Click);
            // 
            // decryptButton
            // 
            this.btnDecrypt01.ImageIndex = 1;
            this.btnDecrypt01.ImageList = this.updownImageList;
            this.btnDecrypt01.Location = new System.Drawing.Point(484, 113);
            this.btnDecrypt01.Name = "btnDecrypt01";
            this.btnDecrypt01.Size = new System.Drawing.Size(55, 55);
            this.btnDecrypt01.TabIndex = 4;
            this.btnDecrypt01.UseVisualStyleBackColor = true;
            this.btnDecrypt01.Click += new System.EventHandler(this.btnDecrypt01_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.numericUpDown1.Location = new System.Drawing.Point(368, 126);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numericUpDown1.Size = new System.Drawing.Size(50, 29);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // decryptLabel
            // 
            this.lbDecrypt01.AutoSize = true;
            this.lbDecrypt01.Location = new System.Drawing.Point(20, 189);
            this.lbDecrypt01.Name = "lbDecrypt01";
            this.lbDecrypt01.Size = new System.Drawing.Size(41, 12);
            this.lbDecrypt01.TabIndex = 6;
            this.lbDecrypt01.Text = "암호문";
            // 
            // decryptTextBox
            // 
            this.txtDecrypt01.Location = new System.Drawing.Point(65, 189);
            this.txtDecrypt01.Multiline = true;
            this.txtDecrypt01.Name = "txtDecrypt01";
            this.txtDecrypt01.Size = new System.Drawing.Size(474, 64);
            this.txtDecrypt01.TabIndex = 7;
            // 
            // resetButton
            // 
            this.btnReset01.Location = new System.Drawing.Point(28, 273);
            this.btnReset01.Name = "btnReset01";
            this.btnReset01.Size = new System.Drawing.Size(81, 28);
            this.btnReset01.TabIndex = 8;
            this.btnReset01.Text = "초기화";
            this.btnReset01.UseVisualStyleBackColor = true;
            this.btnReset01.Click += new System.EventHandler(this.btnReset01_Click);
            // 
            // exitButton
            // 
            this.btnExit01.Location = new System.Drawing.Point(458, 273);
            this.btnExit01.Name = "btnExit01";
            this.btnExit01.Size = new System.Drawing.Size(81, 28);
            this.btnExit01.TabIndex = 9;
            this.btnExit01.Text = "종료";
            this.btnExit01.UseVisualStyleBackColor = true;
            this.btnExit01.Click += new System.EventHandler(this.btnExit01_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 320);
            this.Controls.Add(this.btnExit01);
            this.Controls.Add(this.btnReset01);
            this.Controls.Add(this.txtDecrypt01);
            this.Controls.Add(this.lbDecrypt01);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btnDecrypt01);
            this.Controls.Add(this.btnEncrypt01);
            this.Controls.Add(this.lbShift01);
            this.Controls.Add(this.lbPlain01);
            this.Controls.Add(this.txtPlain01);
            this.Name = "Form1";
            this.Text = "시저 암호 프로그램";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPlain01;
        private System.Windows.Forms.TextBox txtPlain01;
        private System.Windows.Forms.Label lbShift01;
        private System.Windows.Forms.ImageList updownImageList;
        private System.Windows.Forms.Button btnEncrypt01;
        private System.Windows.Forms.Button btnDecrypt01;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label lbDecrypt01;
        private System.Windows.Forms.TextBox txtDecrypt01;
        private System.Windows.Forms.Button btnReset01;
        private System.Windows.Forms.Button btnExit01;
    }
}

