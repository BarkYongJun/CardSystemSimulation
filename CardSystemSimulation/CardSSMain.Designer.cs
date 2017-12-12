namespace CardSystemSimulation
{
    partial class CardSystemSimulation
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Card1 = new System.Windows.Forms.Button();
            this.Card2 = new System.Windows.Forms.Button();
            this.Card3 = new System.Windows.Forms.Button();
            this.Card4 = new System.Windows.Forms.Button();
            this.Suffle = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.nectarCount = new System.Windows.Forms.Label();
            this.nectarValue = new System.Windows.Forms.Label();
            this.MessageBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Card1
            // 
            this.Card1.Location = new System.Drawing.Point(12, 281);
            this.Card1.Name = "Card1";
            this.Card1.Size = new System.Drawing.Size(75, 99);
            this.Card1.TabIndex = 0;
            this.Card1.Text = "Card";
            this.Card1.UseVisualStyleBackColor = true;
            this.Card1.Click += new System.EventHandler(this.Card_Click);
            // 
            // Card2
            // 
            this.Card2.Location = new System.Drawing.Point(93, 281);
            this.Card2.Name = "Card2";
            this.Card2.Size = new System.Drawing.Size(75, 99);
            this.Card2.TabIndex = 0;
            this.Card2.Text = "Card";
            this.Card2.UseVisualStyleBackColor = true;
            this.Card2.Click += new System.EventHandler(this.Card_Click);
            // 
            // Card3
            // 
            this.Card3.Location = new System.Drawing.Point(174, 281);
            this.Card3.Name = "Card3";
            this.Card3.Size = new System.Drawing.Size(75, 99);
            this.Card3.TabIndex = 0;
            this.Card3.Text = "Card";
            this.Card3.UseVisualStyleBackColor = true;
            this.Card3.Click += new System.EventHandler(this.Card_Click);
            // 
            // Card4
            // 
            this.Card4.Location = new System.Drawing.Point(255, 281);
            this.Card4.Name = "Card4";
            this.Card4.Size = new System.Drawing.Size(75, 99);
            this.Card4.TabIndex = 0;
            this.Card4.Text = "Card";
            this.Card4.UseVisualStyleBackColor = true;
            this.Card4.Click += new System.EventHandler(this.Card_Click);
            // 
            // Suffle
            // 
            this.Suffle.Location = new System.Drawing.Point(365, 281);
            this.Suffle.Name = "Suffle";
            this.Suffle.Size = new System.Drawing.Size(75, 23);
            this.Suffle.TabIndex = 1;
            this.Suffle.Text = "Suffle";
            this.Suffle.UseVisualStyleBackColor = true;
            this.Suffle.Click += new System.EventHandler(this.Suffle_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(365, 310);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(75, 23);
            this.Reset.TabIndex = 1;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // nectarCount
            // 
            this.nectarCount.AutoSize = true;
            this.nectarCount.Location = new System.Drawing.Point(28, 27);
            this.nectarCount.Name = "nectarCount";
            this.nectarCount.Size = new System.Drawing.Size(81, 12);
            this.nectarCount.TabIndex = 2;
            this.nectarCount.Text = "넥타르 소모량";
            // 
            // nectarValue
            // 
            this.nectarValue.AutoSize = true;
            this.nectarValue.Location = new System.Drawing.Point(131, 27);
            this.nectarValue.Name = "nectarValue";
            this.nectarValue.Size = new System.Drawing.Size(11, 12);
            this.nectarValue.TabIndex = 3;
            this.nectarValue.Text = "0";
            // 
            // MessageBox
            // 
            this.MessageBox.AutoSize = true;
            this.MessageBox.Location = new System.Drawing.Point(28, 155);
            this.MessageBox.Name = "MessageBox";
            this.MessageBox.Size = new System.Drawing.Size(137, 12);
            this.MessageBox.TabIndex = 4;
            this.MessageBox.Text = "현재 상태는 정상입니다.";
            // 
            // CardSystemSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 392);
            this.Controls.Add(this.MessageBox);
            this.Controls.Add(this.nectarValue);
            this.Controls.Add(this.nectarCount);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Suffle);
            this.Controls.Add(this.Card4);
            this.Controls.Add(this.Card3);
            this.Controls.Add(this.Card2);
            this.Controls.Add(this.Card1);
            this.Name = "CardSystemSimulation";
            this.Text = "CardSystemSimulation";
            this.Load += new System.EventHandler(this.CardSSMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Card1;
        private System.Windows.Forms.Button Card2;
        private System.Windows.Forms.Button Card3;
        private System.Windows.Forms.Button Card4;
        private System.Windows.Forms.Button Suffle;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label nectarCount;
        private System.Windows.Forms.Label nectarValue;
        private System.Windows.Forms.Label MessageBox;
    }
}

