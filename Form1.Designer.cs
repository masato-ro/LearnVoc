
namespace LearnVoc
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
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2_Next = new System.Windows.Forms.Button();
            this.button3_Reset = new System.Windows.Forms.Button();
            this.button4_Exit = new System.Windows.Forms.Button();
            this.button5_About = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_question = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_kanji = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label_chinese = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButtonN1 = new System.Windows.Forms.RadioButton();
            this.radioButtonN2 = new System.Windows.Forms.RadioButton();
            this.radioButtonN3 = new System.Windows.Forms.RadioButton();
            this.radioButtonN4 = new System.Windows.Forms.RadioButton();
            this.radioButtonN5 = new System.Windows.Forms.RadioButton();
            this.button1_Chinese = new System.Windows.Forms.Button();
            this.button1_Kanji = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2_Next
            // 
            this.button2_Next.Location = new System.Drawing.Point(12, 215);
            this.button2_Next.Name = "button2_Next";
            this.button2_Next.Size = new System.Drawing.Size(75, 85);
            this.button2_Next.TabIndex = 1;
            this.button2_Next.Text = "出題(&N)";
            this.button2_Next.UseVisualStyleBackColor = true;
            this.button2_Next.Click += new System.EventHandler(this.button2_Next_Click);
            // 
            // button3_Reset
            // 
            this.button3_Reset.Location = new System.Drawing.Point(266, 306);
            this.button3_Reset.Name = "button3_Reset";
            this.button3_Reset.Size = new System.Drawing.Size(75, 23);
            this.button3_Reset.TabIndex = 2;
            this.button3_Reset.Text = "重置(&R)";
            this.button3_Reset.UseVisualStyleBackColor = true;
            this.button3_Reset.Click += new System.EventHandler(this.button3_Reset_Click);
            // 
            // button4_Exit
            // 
            this.button4_Exit.Location = new System.Drawing.Point(347, 306);
            this.button4_Exit.Name = "button4_Exit";
            this.button4_Exit.Size = new System.Drawing.Size(75, 23);
            this.button4_Exit.TabIndex = 3;
            this.button4_Exit.Text = "離開(&Q)";
            this.button4_Exit.UseVisualStyleBackColor = true;
            this.button4_Exit.Click += new System.EventHandler(this.button4_Exit_Click);
            // 
            // button5_About
            // 
            this.button5_About.Location = new System.Drawing.Point(347, 277);
            this.button5_About.Name = "button5_About";
            this.button5_About.Size = new System.Drawing.Size(75, 23);
            this.button5_About.TabIndex = 4;
            this.button5_About.Text = "關於我(&I)";
            this.button5_About.UseVisualStyleBackColor = true;
            this.button5_About.Click += new System.EventHandler(this.button5_About_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_question);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(312, 72);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "仮名";
            // 
            // label_question
            // 
            this.label_question.AutoSize = true;
            this.label_question.Font = new System.Drawing.Font("Meiryo", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_question.Location = new System.Drawing.Point(7, 22);
            this.label_question.Name = "label_question";
            this.label_question.Size = new System.Drawing.Size(63, 36);
            this.label_question.TabIndex = 0;
            this.label_question.Text = "問題";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label_kanji);
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(312, 50);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "漢字";
            // 
            // label_kanji
            // 
            this.label_kanji.AutoSize = true;
            this.label_kanji.Font = new System.Drawing.Font("Meiryo", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_kanji.Location = new System.Drawing.Point(10, 18);
            this.label_kanji.Name = "label_kanji";
            this.label_kanji.Size = new System.Drawing.Size(56, 18);
            this.label_kanji.TabIndex = 0;
            this.label_kanji.Text = "日文漢字";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label_chinese);
            this.groupBox3.Location = new System.Drawing.Point(12, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(312, 50);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "中文";
            // 
            // label_chinese
            // 
            this.label_chinese.AutoSize = true;
            this.label_chinese.Location = new System.Drawing.Point(11, 18);
            this.label_chinese.Name = "label_chinese";
            this.label_chinese.Size = new System.Drawing.Size(53, 12);
            this.label_chinese.TabIndex = 0;
            this.label_chinese.Text = "中文解答";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.radioButtonN1);
            this.groupBox4.Controls.Add(this.radioButtonN2);
            this.groupBox4.Controls.Add(this.radioButtonN3);
            this.groupBox4.Controls.Add(this.radioButtonN4);
            this.groupBox4.Controls.Add(this.radioButtonN5);
            this.groupBox4.Location = new System.Drawing.Point(347, 13);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(75, 128);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "等級";
            // 
            // radioButtonN1
            // 
            this.radioButtonN1.AutoSize = true;
            this.radioButtonN1.Location = new System.Drawing.Point(6, 108);
            this.radioButtonN1.Name = "radioButtonN1";
            this.radioButtonN1.Size = new System.Drawing.Size(37, 16);
            this.radioButtonN1.TabIndex = 4;
            this.radioButtonN1.TabStop = true;
            this.radioButtonN1.Text = "N1";
            this.radioButtonN1.UseVisualStyleBackColor = true;
            this.radioButtonN1.CheckedChanged += new System.EventHandler(this.radioButtonN1_CheckedChanged);
            // 
            // radioButtonN2
            // 
            this.radioButtonN2.AutoSize = true;
            this.radioButtonN2.Location = new System.Drawing.Point(6, 86);
            this.radioButtonN2.Name = "radioButtonN2";
            this.radioButtonN2.Size = new System.Drawing.Size(37, 16);
            this.radioButtonN2.TabIndex = 3;
            this.radioButtonN2.TabStop = true;
            this.radioButtonN2.Text = "N2";
            this.radioButtonN2.UseVisualStyleBackColor = true;
            this.radioButtonN2.CheckedChanged += new System.EventHandler(this.radioButtonN2_CheckedChanged);
            // 
            // radioButtonN3
            // 
            this.radioButtonN3.AutoSize = true;
            this.radioButtonN3.Location = new System.Drawing.Point(6, 64);
            this.radioButtonN3.Name = "radioButtonN3";
            this.radioButtonN3.Size = new System.Drawing.Size(37, 16);
            this.radioButtonN3.TabIndex = 2;
            this.radioButtonN3.TabStop = true;
            this.radioButtonN3.Text = "N3";
            this.radioButtonN3.UseVisualStyleBackColor = true;
            this.radioButtonN3.CheckedChanged += new System.EventHandler(this.radioButtonN3_CheckedChanged);
            // 
            // radioButtonN4
            // 
            this.radioButtonN4.AutoSize = true;
            this.radioButtonN4.Location = new System.Drawing.Point(6, 42);
            this.radioButtonN4.Name = "radioButtonN4";
            this.radioButtonN4.Size = new System.Drawing.Size(37, 16);
            this.radioButtonN4.TabIndex = 1;
            this.radioButtonN4.TabStop = true;
            this.radioButtonN4.Text = "N4";
            this.radioButtonN4.UseVisualStyleBackColor = true;
            // 
            // radioButtonN5
            // 
            this.radioButtonN5.AutoSize = true;
            this.radioButtonN5.Location = new System.Drawing.Point(6, 20);
            this.radioButtonN5.Name = "radioButtonN5";
            this.radioButtonN5.Size = new System.Drawing.Size(37, 16);
            this.radioButtonN5.TabIndex = 0;
            this.radioButtonN5.TabStop = true;
            this.radioButtonN5.Text = "N5";
            this.radioButtonN5.UseVisualStyleBackColor = true;
            // 
            // button1_Chinese
            // 
            this.button1_Chinese.Location = new System.Drawing.Point(93, 306);
            this.button1_Chinese.Name = "button1_Chinese";
            this.button1_Chinese.Size = new System.Drawing.Size(75, 23);
            this.button1_Chinese.TabIndex = 9;
            this.button1_Chinese.Text = "解答(&C)";
            this.button1_Chinese.UseVisualStyleBackColor = true;
            this.button1_Chinese.Click += new System.EventHandler(this.button1_Chinese_Click);
            // 
            // button1_Kanji
            // 
            this.button1_Kanji.Location = new System.Drawing.Point(12, 306);
            this.button1_Kanji.Name = "button1_Kanji";
            this.button1_Kanji.Size = new System.Drawing.Size(75, 23);
            this.button1_Kanji.TabIndex = 10;
            this.button1_Kanji.Text = "漢字(&K)";
            this.button1_Kanji.UseVisualStyleBackColor = true;
            this.button1_Kanji.Click += new System.EventHandler(this.button1_Kanji_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 341);
            this.Controls.Add(this.button1_Kanji);
            this.Controls.Add(this.button1_Chinese);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5_About);
            this.Controls.Add(this.button4_Exit);
            this.Controls.Add(this.button3_Reset);
            this.Controls.Add(this.button2_Next);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "背單字v1.01";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2_Next;
        private System.Windows.Forms.Button button3_Reset;
        private System.Windows.Forms.Button button4_Exit;
        private System.Windows.Forms.Button button5_About;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label_question;
        private System.Windows.Forms.Label label_kanji;
        private System.Windows.Forms.Label label_chinese;
        private System.Windows.Forms.Button button1_Chinese;
        private System.Windows.Forms.Button button1_Kanji;
        private System.Windows.Forms.RadioButton radioButtonN1;
        private System.Windows.Forms.RadioButton radioButtonN2;
        private System.Windows.Forms.RadioButton radioButtonN3;
        private System.Windows.Forms.RadioButton radioButtonN4;
        private System.Windows.Forms.RadioButton radioButtonN5;
    }
}

