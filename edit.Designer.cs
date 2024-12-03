namespace Cw1551_final
{
    partial class edit
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
            this.load_question = new System.Windows.Forms.DataGridView();
            this.txt_questionContent = new System.Windows.Forms.RichTextBox();
            this.txt_rightAnswerContent = new System.Windows.Forms.RichTextBox();
            this.txt_id = new System.Windows.Forms.RichTextBox();
            this.admin_lable = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.load_question)).BeginInit();
            this.SuspendLayout();
            // 
            // load_question
            // 
            this.load_question.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.load_question.Location = new System.Drawing.Point(41, 116);
            this.load_question.Name = "load_question";
            this.load_question.RowHeadersWidth = 51;
            this.load_question.RowTemplate.Height = 24;
            this.load_question.Size = new System.Drawing.Size(742, 320);
            this.load_question.TabIndex = 2;
            // 
            // txt_questionContent
            // 
            this.txt_questionContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_questionContent.Location = new System.Drawing.Point(883, 240);
            this.txt_questionContent.Name = "txt_questionContent";
            this.txt_questionContent.Size = new System.Drawing.Size(285, 76);
            this.txt_questionContent.TabIndex = 3;
            this.txt_questionContent.Text = "";
            // 
            // txt_rightAnswerContent
            // 
            this.txt_rightAnswerContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rightAnswerContent.Location = new System.Drawing.Point(883, 357);
            this.txt_rightAnswerContent.Name = "txt_rightAnswerContent";
            this.txt_rightAnswerContent.Size = new System.Drawing.Size(285, 76);
            this.txt_rightAnswerContent.TabIndex = 4;
            this.txt_rightAnswerContent.Text = "";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(883, 113);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(87, 76);
            this.txt_id.TabIndex = 5;
            this.txt_id.Text = "";
            // 
            // admin_lable
            // 
            this.admin_lable.AutoSize = true;
            this.admin_lable.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_lable.Location = new System.Drawing.Point(470, 21);
            this.admin_lable.Name = "admin_lable";
            this.admin_lable.Size = new System.Drawing.Size(429, 42);
            this.admin_lable.TabIndex = 8;
            this.admin_lable.Text = "Hey Ad! You want edit?";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(592, 508);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(151, 61);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 631);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.admin_lable);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_rightAnswerContent);
            this.Controls.Add(this.txt_questionContent);
            this.Controls.Add(this.load_question);
            this.Name = "edit";
            this.Text = "edit";
            this.Load += new System.EventHandler(this.edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.load_question)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView load_question;
        private System.Windows.Forms.RichTextBox txt_rightAnswerContent;
        private System.Windows.Forms.RichTextBox txt_id;
        private System.Windows.Forms.RichTextBox txt_questionContent;
        private System.Windows.Forms.Label admin_lable;
        private System.Windows.Forms.Button btn_save;
    }
}