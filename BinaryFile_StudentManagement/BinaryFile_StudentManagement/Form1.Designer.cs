namespace BinaryFile_StudentManagement
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
            this.buttonLoadStudentInfo = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonStudent1Delete_Binary = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxDisplay1_Memo = new System.Windows.Forms.TextBox();
            this.buttonStudent1Save_Binary = new System.Windows.Forms.Button();
            this.comboBoxStudent1Gender_Binary = new System.Windows.Forms.ComboBox();
            this.textBoxStudent1ID_Binary = new System.Windows.Forms.TextBox();
            this.textBoxStudent1Name_Binary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonStudent2Delete_Binary = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonStudent2Save_Binary = new System.Windows.Forms.Button();
            this.comboBoxStudent2Gender_Binary = new System.Windows.Forms.ComboBox();
            this.textBoxStudent2ID_Binary = new System.Windows.Forms.TextBox();
            this.textBoxStudent2Name_Binary = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonStudent3Delete_Binary = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonStudent3Save_Binary = new System.Windows.Forms.Button();
            this.comboBoxStudent3Gender_Binary = new System.Windows.Forms.ComboBox();
            this.textBoxStudent3ID_Binary = new System.Windows.Forms.TextBox();
            this.textBoxStudent3Name_Binary = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLoadStudentInfo
            // 
            this.buttonLoadStudentInfo.Location = new System.Drawing.Point(28, 12);
            this.buttonLoadStudentInfo.Name = "buttonLoadStudentInfo";
            this.buttonLoadStudentInfo.Size = new System.Drawing.Size(269, 117);
            this.buttonLoadStudentInfo.TabIndex = 1;
            this.buttonLoadStudentInfo.Text = "학생정보 불러오기";
            this.buttonLoadStudentInfo.UseVisualStyleBackColor = true;
            this.buttonLoadStudentInfo.Click += new System.EventHandler(this.buttonLoadStudentInfo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonStudent1Delete_Binary);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.textBoxDisplay1_Memo);
            this.groupBox1.Controls.Add(this.buttonStudent1Save_Binary);
            this.groupBox1.Controls.Add(this.comboBoxStudent1Gender_Binary);
            this.groupBox1.Controls.Add(this.textBoxStudent1ID_Binary);
            this.groupBox1.Controls.Add(this.textBoxStudent1Name_Binary);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(37, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 418);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "학생1";
            // 
            // buttonStudent1Delete_Binary
            // 
            this.buttonStudent1Delete_Binary.Location = new System.Drawing.Point(37, 371);
            this.buttonStudent1Delete_Binary.Name = "buttonStudent1Delete_Binary";
            this.buttonStudent1Delete_Binary.Size = new System.Drawing.Size(184, 31);
            this.buttonStudent1Delete_Binary.TabIndex = 9;
            this.buttonStudent1Delete_Binary.Text = "삭제";
            this.buttonStudent1Delete_Binary.UseVisualStyleBackColor = true;
            this.buttonStudent1Delete_Binary.Click += new System.EventHandler(this.buttonStudent1Delete_Binary_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(34, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 18);
            this.label11.TabIndex = 8;
            this.label11.Text = "메모";
            // 
            // textBoxDisplay1_Memo
            // 
            this.textBoxDisplay1_Memo.Location = new System.Drawing.Point(84, 183);
            this.textBoxDisplay1_Memo.Multiline = true;
            this.textBoxDisplay1_Memo.Name = "textBoxDisplay1_Memo";
            this.textBoxDisplay1_Memo.Size = new System.Drawing.Size(137, 142);
            this.textBoxDisplay1_Memo.TabIndex = 7;
            // 
            // buttonStudent1Save_Binary
            // 
            this.buttonStudent1Save_Binary.Location = new System.Drawing.Point(37, 334);
            this.buttonStudent1Save_Binary.Name = "buttonStudent1Save_Binary";
            this.buttonStudent1Save_Binary.Size = new System.Drawing.Size(184, 31);
            this.buttonStudent1Save_Binary.TabIndex = 6;
            this.buttonStudent1Save_Binary.Text = "저장";
            this.buttonStudent1Save_Binary.UseVisualStyleBackColor = true;
            // 
            // comboBoxStudent1Gender_Binary
            // 
            this.comboBoxStudent1Gender_Binary.FormattingEnabled = true;
            this.comboBoxStudent1Gender_Binary.Location = new System.Drawing.Point(84, 140);
            this.comboBoxStudent1Gender_Binary.Name = "comboBoxStudent1Gender_Binary";
            this.comboBoxStudent1Gender_Binary.Size = new System.Drawing.Size(137, 26);
            this.comboBoxStudent1Gender_Binary.TabIndex = 5;
            // 
            // textBoxStudent1ID_Binary
            // 
            this.textBoxStudent1ID_Binary.Location = new System.Drawing.Point(84, 92);
            this.textBoxStudent1ID_Binary.Name = "textBoxStudent1ID_Binary";
            this.textBoxStudent1ID_Binary.Size = new System.Drawing.Size(137, 28);
            this.textBoxStudent1ID_Binary.TabIndex = 4;
            // 
            // textBoxStudent1Name_Binary
            // 
            this.textBoxStudent1Name_Binary.Location = new System.Drawing.Point(84, 49);
            this.textBoxStudent1Name_Binary.Name = "textBoxStudent1Name_Binary";
            this.textBoxStudent1Name_Binary.Size = new System.Drawing.Size(132, 28);
            this.textBoxStudent1Name_Binary.TabIndex = 3;
            this.textBoxStudent1Name_Binary.Text = "학생정보 없음";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "학번";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "성별";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonStudent2Delete_Binary);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.buttonStudent2Save_Binary);
            this.groupBox2.Controls.Add(this.comboBoxStudent2Gender_Binary);
            this.groupBox2.Controls.Add(this.textBoxStudent2ID_Binary);
            this.groupBox2.Controls.Add(this.textBoxStudent2Name_Binary);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(349, 164);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 417);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "학생2";
            // 
            // buttonStudent2Delete_Binary
            // 
            this.buttonStudent2Delete_Binary.Location = new System.Drawing.Point(48, 370);
            this.buttonStudent2Delete_Binary.Name = "buttonStudent2Delete_Binary";
            this.buttonStudent2Delete_Binary.Size = new System.Drawing.Size(184, 31);
            this.buttonStudent2Delete_Binary.TabIndex = 10;
            this.buttonStudent2Delete_Binary.Text = "삭제";
            this.buttonStudent2Delete_Binary.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 185);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 18);
            this.label12.TabIndex = 9;
            this.label12.Text = "메모";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 174);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 142);
            this.textBox1.TabIndex = 8;
            // 
            // buttonStudent2Save_Binary
            // 
            this.buttonStudent2Save_Binary.Location = new System.Drawing.Point(48, 333);
            this.buttonStudent2Save_Binary.Name = "buttonStudent2Save_Binary";
            this.buttonStudent2Save_Binary.Size = new System.Drawing.Size(184, 31);
            this.buttonStudent2Save_Binary.TabIndex = 6;
            this.buttonStudent2Save_Binary.Text = "저장";
            this.buttonStudent2Save_Binary.UseVisualStyleBackColor = true;
            // 
            // comboBoxStudent2Gender_Binary
            // 
            this.comboBoxStudent2Gender_Binary.FormattingEnabled = true;
            this.comboBoxStudent2Gender_Binary.Location = new System.Drawing.Point(89, 131);
            this.comboBoxStudent2Gender_Binary.Name = "comboBoxStudent2Gender_Binary";
            this.comboBoxStudent2Gender_Binary.Size = new System.Drawing.Size(136, 26);
            this.comboBoxStudent2Gender_Binary.TabIndex = 5;
            // 
            // textBoxStudent2ID_Binary
            // 
            this.textBoxStudent2ID_Binary.Location = new System.Drawing.Point(88, 84);
            this.textBoxStudent2ID_Binary.Name = "textBoxStudent2ID_Binary";
            this.textBoxStudent2ID_Binary.Size = new System.Drawing.Size(136, 28);
            this.textBoxStudent2ID_Binary.TabIndex = 4;
            // 
            // textBoxStudent2Name_Binary
            // 
            this.textBoxStudent2Name_Binary.Location = new System.Drawing.Point(88, 45);
            this.textBoxStudent2Name_Binary.Name = "textBoxStudent2Name_Binary";
            this.textBoxStudent2Name_Binary.Size = new System.Drawing.Size(136, 28);
            this.textBoxStudent2Name_Binary.TabIndex = 3;
            this.textBoxStudent2Name_Binary.Text = "학생정보 없음";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "학번";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "성별";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "이름";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonStudent3Delete_Binary);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.buttonStudent3Save_Binary);
            this.groupBox3.Controls.Add(this.comboBoxStudent3Gender_Binary);
            this.groupBox3.Controls.Add(this.textBoxStudent3ID_Binary);
            this.groupBox3.Controls.Add(this.textBoxStudent3Name_Binary);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(652, 164);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 417);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "학생3";
            // 
            // buttonStudent3Delete_Binary
            // 
            this.buttonStudent3Delete_Binary.Location = new System.Drawing.Point(48, 370);
            this.buttonStudent3Delete_Binary.Name = "buttonStudent3Delete_Binary";
            this.buttonStudent3Delete_Binary.Size = new System.Drawing.Size(184, 31);
            this.buttonStudent3Delete_Binary.TabIndex = 10;
            this.buttonStudent3Delete_Binary.Text = "삭제";
            this.buttonStudent3Delete_Binary.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(34, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 18);
            this.label13.TabIndex = 9;
            this.label13.Text = "메모";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 174);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(141, 142);
            this.textBox2.TabIndex = 8;
            // 
            // buttonStudent3Save_Binary
            // 
            this.buttonStudent3Save_Binary.Location = new System.Drawing.Point(48, 333);
            this.buttonStudent3Save_Binary.Name = "buttonStudent3Save_Binary";
            this.buttonStudent3Save_Binary.Size = new System.Drawing.Size(184, 31);
            this.buttonStudent3Save_Binary.TabIndex = 6;
            this.buttonStudent3Save_Binary.Text = "저장";
            this.buttonStudent3Save_Binary.UseVisualStyleBackColor = true;
            // 
            // comboBoxStudent3Gender_Binary
            // 
            this.comboBoxStudent3Gender_Binary.FormattingEnabled = true;
            this.comboBoxStudent3Gender_Binary.Location = new System.Drawing.Point(91, 131);
            this.comboBoxStudent3Gender_Binary.Name = "comboBoxStudent3Gender_Binary";
            this.comboBoxStudent3Gender_Binary.Size = new System.Drawing.Size(141, 26);
            this.comboBoxStudent3Gender_Binary.TabIndex = 5;
            // 
            // textBoxStudent3ID_Binary
            // 
            this.textBoxStudent3ID_Binary.Location = new System.Drawing.Point(91, 84);
            this.textBoxStudent3ID_Binary.Name = "textBoxStudent3ID_Binary";
            this.textBoxStudent3ID_Binary.Size = new System.Drawing.Size(141, 28);
            this.textBoxStudent3ID_Binary.TabIndex = 4;
            // 
            // textBoxStudent3Name_Binary
            // 
            this.textBoxStudent3Name_Binary.Location = new System.Drawing.Point(91, 36);
            this.textBoxStudent3Name_Binary.Name = "textBoxStudent3Name_Binary";
            this.textBoxStudent3Name_Binary.Size = new System.Drawing.Size(141, 28);
            this.textBoxStudent3Name_Binary.TabIndex = 3;
            this.textBoxStudent3Name_Binary.Text = "학생정보 없음";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 2;
            this.label7.Text = "학번";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "성별";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "이름";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.checkBox1);
            this.groupBox4.Location = new System.Drawing.Point(349, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(521, 116);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "설정 및 정보";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 69);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(204, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "현재 저장 된 학생 수: 0 ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(33, 38);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(364, 22);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "프로그램시작 시 자동으로 학생정보 로드";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 603);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonLoadStudentInfo);
            this.Name = "Form1";
            this.Text = "데이터베이스 프로그래밍 실습1";
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

        private System.Windows.Forms.Button buttonLoadStudentInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonStudent1Delete_Binary;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxDisplay1_Memo;
        private System.Windows.Forms.Button buttonStudent1Save_Binary;
        private System.Windows.Forms.ComboBox comboBoxStudent1Gender_Binary;
        private System.Windows.Forms.TextBox textBoxStudent1ID_Binary;
        private System.Windows.Forms.TextBox textBoxStudent1Name_Binary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonStudent2Delete_Binary;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonStudent2Save_Binary;
        private System.Windows.Forms.ComboBox comboBoxStudent2Gender_Binary;
        private System.Windows.Forms.TextBox textBoxStudent2ID_Binary;
        private System.Windows.Forms.TextBox textBoxStudent2Name_Binary;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonStudent3Delete_Binary;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonStudent3Save_Binary;
        private System.Windows.Forms.ComboBox comboBoxStudent3Gender_Binary;
        private System.Windows.Forms.TextBox textBoxStudent3ID_Binary;
        private System.Windows.Forms.TextBox textBoxStudent3Name_Binary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

