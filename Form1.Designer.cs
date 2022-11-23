namespace CS_AESDES128
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
            this.tb_Sentence = new System.Windows.Forms.TextBox();
            this.tb_Result = new System.Windows.Forms.TextBox();
            this.tb_KeyValue = new System.Windows.Forms.TextBox();
            this.bt_Encryption = new System.Windows.Forms.Button();
            this.bt_Decryption = new System.Windows.Forms.Button();
            this.lb_Result = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_Sentence
            // 
            this.tb_Sentence.Location = new System.Drawing.Point(135, 27);
            this.tb_Sentence.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Sentence.Multiline = true;
            this.tb_Sentence.Name = "tb_Sentence";
            this.tb_Sentence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Sentence.Size = new System.Drawing.Size(436, 85);
            this.tb_Sentence.TabIndex = 0;
            this.tb_Sentence.Text = "Input a sentence to be encrypted or decrypted.\r\nAnd press the below button what y" +
    "ou want to execute";
            this.tb_Sentence.Click += new System.EventHandler(this.tb_Sentence_Click);
            // 
            // tb_Result
            // 
            this.tb_Result.Location = new System.Drawing.Point(135, 212);
            this.tb_Result.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_Result.Multiline = true;
            this.tb_Result.Name = "tb_Result";
            this.tb_Result.ReadOnly = true;
            this.tb_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Result.Size = new System.Drawing.Size(436, 85);
            this.tb_Result.TabIndex = 0;
            this.tb_Result.Click += new System.EventHandler(this.tb_Result_Click);
            // 
            // tb_KeyValue
            // 
            this.tb_KeyValue.Location = new System.Drawing.Point(135, 139);
            this.tb_KeyValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_KeyValue.Multiline = true;
            this.tb_KeyValue.Name = "tb_KeyValue";
            this.tb_KeyValue.Size = new System.Drawing.Size(132, 46);
            this.tb_KeyValue.TabIndex = 0;
            this.tb_KeyValue.Text = "Key Value";
            this.tb_KeyValue.Click += new System.EventHandler(this.tb_KeyValue_Click);
            // 
            // bt_Encryption
            // 
            this.bt_Encryption.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Encryption.ForeColor = System.Drawing.Color.Red;
            this.bt_Encryption.Location = new System.Drawing.Point(287, 139);
            this.bt_Encryption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_Encryption.Name = "bt_Encryption";
            this.bt_Encryption.Size = new System.Drawing.Size(132, 48);
            this.bt_Encryption.TabIndex = 1;
            this.bt_Encryption.Text = "Encryption";
            this.bt_Encryption.UseVisualStyleBackColor = true;
            this.bt_Encryption.Click += new System.EventHandler(this.bt_Encryption_Click);
            // 
            // bt_Decryption
            // 
            this.bt_Decryption.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Decryption.ForeColor = System.Drawing.Color.Blue;
            this.bt_Decryption.Location = new System.Drawing.Point(439, 139);
            this.bt_Decryption.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_Decryption.Name = "bt_Decryption";
            this.bt_Decryption.Size = new System.Drawing.Size(132, 48);
            this.bt_Decryption.TabIndex = 1;
            this.bt_Decryption.Text = "Decryption";
            this.bt_Decryption.UseVisualStyleBackColor = true;
            this.bt_Decryption.Click += new System.EventHandler(this.bt_Decryption_Click);
            // 
            // lb_Result
            // 
            this.lb_Result.AutoSize = true;
            this.lb_Result.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Result.Location = new System.Drawing.Point(37, 245);
            this.lb_Result.Name = "lb_Result";
            this.lb_Result.Size = new System.Drawing.Size(58, 19);
            this.lb_Result.TabIndex = 2;
            this.lb_Result.Text = "Result";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sentence";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Key Value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 323);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Result);
            this.Controls.Add(this.bt_Decryption);
            this.Controls.Add(this.bt_Encryption);
            this.Controls.Add(this.tb_KeyValue);
            this.Controls.Add(this.tb_Result);
            this.Controls.Add(this.tb_Sentence);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "AES128 by MJ Kim";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Sentence;
        private System.Windows.Forms.TextBox tb_Result;
        private System.Windows.Forms.TextBox tb_KeyValue;
        private System.Windows.Forms.Button bt_Encryption;
        private System.Windows.Forms.Button bt_Decryption;
        private System.Windows.Forms.Label lb_Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

