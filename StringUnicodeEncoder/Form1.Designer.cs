namespace StringUnicodeEncoder
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.rtb_Origin = new System.Windows.Forms.RichTextBox();
            this.btn_ToUnicode = new System.Windows.Forms.Button();
            this.btn_ToString = new System.Windows.Forms.Button();
            this.rtb_Result = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rtb_Origin
            // 
            this.rtb_Origin.Location = new System.Drawing.Point(39, 47);
            this.rtb_Origin.Name = "rtb_Origin";
            this.rtb_Origin.Size = new System.Drawing.Size(521, 103);
            this.rtb_Origin.TabIndex = 0;
            this.rtb_Origin.Text = "";
            // 
            // btn_ToUnicode
            // 
            this.btn_ToUnicode.Location = new System.Drawing.Point(39, 298);
            this.btn_ToUnicode.Name = "btn_ToUnicode";
            this.btn_ToUnicode.Size = new System.Drawing.Size(123, 23);
            this.btn_ToUnicode.TabIndex = 1;
            this.btn_ToUnicode.Text = "轉換為Unicode";
            this.btn_ToUnicode.UseVisualStyleBackColor = true;
            this.btn_ToUnicode.Click += new System.EventHandler(this.btn_ToUnicode_Click);
            // 
            // btn_ToString
            // 
            this.btn_ToString.Location = new System.Drawing.Point(437, 298);
            this.btn_ToString.Name = "btn_ToString";
            this.btn_ToString.Size = new System.Drawing.Size(123, 23);
            this.btn_ToString.TabIndex = 2;
            this.btn_ToString.Text = "轉換為字串";
            this.btn_ToString.UseVisualStyleBackColor = true;
            this.btn_ToString.Click += new System.EventHandler(this.btn_ToString_Click);
            // 
            // rtb_Result
            // 
            this.rtb_Result.Location = new System.Drawing.Point(39, 182);
            this.rtb_Result.Name = "rtb_Result";
            this.rtb_Result.Size = new System.Drawing.Size(521, 96);
            this.rtb_Result.TabIndex = 3;
            this.rtb_Result.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "原始文字：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "轉換結果：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 345);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtb_Result);
            this.Controls.Add(this.btn_ToString);
            this.Controls.Add(this.btn_ToUnicode);
            this.Controls.Add(this.rtb_Origin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_Origin;
        private System.Windows.Forms.Button btn_ToUnicode;
        private System.Windows.Forms.Button btn_ToString;
        private System.Windows.Forms.RichTextBox rtb_Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

