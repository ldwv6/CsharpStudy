namespace CaesarCipher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnDown = new System.Windows.Forms.Button();
            this.btnUp = new System.Windows.Forms.Button();
            this.txtPlain = new System.Windows.Forms.TextBox();
            this.txtCipher = new System.Windows.Forms.TextBox();
            this.numShift = new System.Windows.Forms.NumericUpDown();
            this.lblShift = new System.Windows.Forms.Label();
            this.lblPlain = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCipher = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numShift)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDown
            // 
            this.btnDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDown.BackgroundImage")));
            this.btnDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDown.Location = new System.Drawing.Point(80, 97);
            this.btnDown.MaximumSize = new System.Drawing.Size(80, 70);
            this.btnDown.MinimumSize = new System.Drawing.Size(80, 70);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(80, 70);
            this.btnDown.TabIndex = 0;
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUp.BackgroundImage")));
            this.btnUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnUp.Location = new System.Drawing.Point(519, 97);
            this.btnUp.MaximumSize = new System.Drawing.Size(80, 70);
            this.btnUp.MinimumSize = new System.Drawing.Size(80, 70);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(80, 70);
            this.btnUp.TabIndex = 1;
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // txtPlain
            // 
            this.txtPlain.Location = new System.Drawing.Point(80, 12);
            this.txtPlain.Multiline = true;
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.Size = new System.Drawing.Size(519, 68);
            this.txtPlain.TabIndex = 2;
            // 
            // txtCipher
            // 
            this.txtCipher.Location = new System.Drawing.Point(80, 182);
            this.txtCipher.Multiline = true;
            this.txtCipher.Name = "txtCipher";
            this.txtCipher.Size = new System.Drawing.Size(519, 68);
            this.txtCipher.TabIndex = 3;
            // 
            // numShift
            // 
            this.numShift.Location = new System.Drawing.Point(383, 124);
            this.numShift.Name = "numShift";
            this.numShift.Size = new System.Drawing.Size(120, 21);
            this.numShift.TabIndex = 4;
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblShift.Location = new System.Drawing.Point(181, 124);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(170, 21);
            this.lblShift.TabIndex = 5;
            this.lblShift.Text = "암호화 Shift Key";
            // 
            // lblPlain
            // 
            this.lblPlain.AutoSize = true;
            this.lblPlain.Location = new System.Drawing.Point(12, 33);
            this.lblPlain.Name = "lblPlain";
            this.lblPlain.Size = new System.Drawing.Size(29, 12);
            this.lblPlain.TabIndex = 6;
            this.lblPlain.Text = "평문";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 7;
            // 
            // lblCipher
            // 
            this.lblCipher.AutoSize = true;
            this.lblCipher.Location = new System.Drawing.Point(12, 209);
            this.lblCipher.Name = "lblCipher";
            this.lblCipher.Size = new System.Drawing.Size(41, 12);
            this.lblCipher.TabIndex = 8;
            this.lblCipher.Text = "암호문";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(80, 256);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 38);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "초기화";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(524, 256);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 38);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "종료";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 306);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblCipher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPlain);
            this.Controls.Add(this.lblShift);
            this.Controls.Add(this.numShift);
            this.Controls.Add(this.txtCipher);
            this.Controls.Add(this.txtPlain);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDown);
            this.Name = "Form1";
            this.Text = "시저 암호기 ";
            ((System.ComponentModel.ISupportInitialize)(this.numShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.TextBox txtPlain;
        private System.Windows.Forms.TextBox txtCipher;
        private System.Windows.Forms.NumericUpDown numShift;
        private System.Windows.Forms.Label lblShift;
        private System.Windows.Forms.Label lblPlain;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCipher;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
    }
}

