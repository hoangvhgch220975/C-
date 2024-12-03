namespace Cw1551_final
{
    partial class player
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_question = new System.Windows.Forms.RichTextBox();
            this.cb_campus = new System.Windows.Forms.ComboBox();
            this.lbl_campus = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.btn_play = new System.Windows.Forms.Button();
            this.txt_score = new System.Windows.Forms.RichTextBox();
            this.lbl_score = new System.Windows.Forms.Label();
            this.txt_showinfo = new System.Windows.Forms.TextBox();
            this.txt_answer = new System.Windows.Forms.RichTextBox();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_quit = new System.Windows.Forms.Button();
            this.opt1 = new System.Windows.Forms.RadioButton();
            this.opt2 = new System.Windows.Forms.RadioButton();
            this.opt3 = new System.Windows.Forms.RadioButton();
            this.opt4 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txt_question
            // 
            this.txt_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_question.Location = new System.Drawing.Point(265, 177);
            this.txt_question.Name = "txt_question";
            this.txt_question.Size = new System.Drawing.Size(444, 155);
            this.txt_question.TabIndex = 0;
            this.txt_question.Text = "";
            // 
            // cb_campus
            // 
            this.cb_campus.FormattingEnabled = true;
            this.cb_campus.Items.AddRange(new object[] {
            "Ha Noi",
            "HCM",
            "Da Nang",
            "Can Tho"});
            this.cb_campus.Location = new System.Drawing.Point(96, 58);
            this.cb_campus.Name = "cb_campus";
            this.cb_campus.Size = new System.Drawing.Size(100, 24);
            this.cb_campus.TabIndex = 8;
            // 
            // lbl_campus
            // 
            this.lbl_campus.AutoSize = true;
            this.lbl_campus.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_campus.Location = new System.Drawing.Point(0, 56);
            this.lbl_campus.Name = "lbl_campus";
            this.lbl_campus.Size = new System.Drawing.Size(83, 21);
            this.lbl_campus.TabIndex = 7;
            this.lbl_campus.Text = "Campus:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(96, 21);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 22);
            this.txt_name.TabIndex = 6;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(21, 21);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(64, 21);
            this.lbl_name.TabIndex = 5;
            this.lbl_name.Text = "Name: ";
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.Orange;
            this.btn_play.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.Location = new System.Drawing.Point(413, 29);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(129, 53);
            this.btn_play.TabIndex = 9;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // txt_score
            // 
            this.txt_score.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_score.Location = new System.Drawing.Point(865, 36);
            this.txt_score.Name = "txt_score";
            this.txt_score.Size = new System.Drawing.Size(47, 37);
            this.txt_score.TabIndex = 12;
            this.txt_score.Text = "";
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(789, 47);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(68, 21);
            this.lbl_score.TabIndex = 11;
            this.lbl_score.Text = "Score:";
            this.lbl_score.UseWaitCursor = true;
            // 
            // txt_showinfo
            // 
            this.txt_showinfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_showinfo.Location = new System.Drawing.Point(265, 113);
            this.txt_showinfo.Name = "txt_showinfo";
            this.txt_showinfo.Size = new System.Drawing.Size(444, 27);
            this.txt_showinfo.TabIndex = 13;
            // 
            // txt_answer
            // 
            this.txt_answer.Location = new System.Drawing.Point(265, 350);
            this.txt_answer.Name = "txt_answer";
            this.txt_answer.Size = new System.Drawing.Size(444, 72);
            this.txt_answer.TabIndex = 14;
            this.txt_answer.Text = "";
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.Orange;
            this.btn_next.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.Location = new System.Drawing.Point(265, 467);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(129, 51);
            this.btn_next.TabIndex = 15;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_quit
            // 
            this.btn_quit.BackColor = System.Drawing.Color.Orange;
            this.btn_quit.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quit.Location = new System.Drawing.Point(580, 467);
            this.btn_quit.Name = "btn_quit";
            this.btn_quit.Size = new System.Drawing.Size(129, 51);
            this.btn_quit.TabIndex = 16;
            this.btn_quit.Text = "Finish";
            this.btn_quit.UseVisualStyleBackColor = false;
            this.btn_quit.Click += new System.EventHandler(this.btn_quit_Click);
            // 
            // opt1
            // 
            this.opt1.AutoSize = true;
            this.opt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt1.Location = new System.Drawing.Point(265, 351);
            this.opt1.Name = "opt1";
            this.opt1.Size = new System.Drawing.Size(143, 29);
            this.opt1.TabIndex = 17;
            this.opt1.TabStop = true;
            this.opt1.Text = "radioButton1";
            this.opt1.UseVisualStyleBackColor = true;
            // 
            // opt2
            // 
            this.opt2.AutoSize = true;
            this.opt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt2.Location = new System.Drawing.Point(265, 393);
            this.opt2.Name = "opt2";
            this.opt2.Size = new System.Drawing.Size(143, 29);
            this.opt2.TabIndex = 18;
            this.opt2.TabStop = true;
            this.opt2.Text = "radioButton2";
            this.opt2.UseVisualStyleBackColor = true;
            // 
            // opt3
            // 
            this.opt3.AutoSize = true;
            this.opt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt3.Location = new System.Drawing.Point(566, 351);
            this.opt3.Name = "opt3";
            this.opt3.Size = new System.Drawing.Size(143, 29);
            this.opt3.TabIndex = 19;
            this.opt3.TabStop = true;
            this.opt3.Text = "radioButton3";
            this.opt3.UseVisualStyleBackColor = true;
            // 
            // opt4
            // 
            this.opt4.AutoSize = true;
            this.opt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt4.Location = new System.Drawing.Point(564, 393);
            this.opt4.Name = "opt4";
            this.opt4.Size = new System.Drawing.Size(143, 29);
            this.opt4.TabIndex = 20;
            this.opt4.TabStop = true;
            this.opt4.Text = "radioButton4";
            this.opt4.UseVisualStyleBackColor = true;
            // 
            // player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 620);
            this.Controls.Add(this.opt4);
            this.Controls.Add(this.opt3);
            this.Controls.Add(this.opt2);
            this.Controls.Add(this.opt1);
            this.Controls.Add(this.btn_quit);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.txt_answer);
            this.Controls.Add(this.txt_showinfo);
            this.Controls.Add(this.txt_score);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.cb_campus);
            this.Controls.Add(this.lbl_campus);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.txt_question);
            this.Name = "player";
            this.Text = "player";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_question;
        private System.Windows.Forms.ComboBox cb_campus;
        protected System.Windows.Forms.Label lbl_campus;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.RichTextBox txt_score;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.TextBox txt_showinfo;
        private System.Windows.Forms.RichTextBox txt_answer;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_quit;
        private System.Windows.Forms.RadioButton opt1;
        private System.Windows.Forms.RadioButton opt2;
        private System.Windows.Forms.RadioButton opt3;
        private System.Windows.Forms.RadioButton opt4;
    }
}