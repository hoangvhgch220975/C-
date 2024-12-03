namespace Cw1551_final
{
    partial class open_end
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_questionContent = new System.Windows.Forms.RichTextBox();
            this.txt_answerContent = new System.Windows.Forms.RichTextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Open - End Question";
            // 
            // txt_questionContent
            // 
            this.txt_questionContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_questionContent.Location = new System.Drawing.Point(202, 91);
            this.txt_questionContent.Name = "txt_questionContent";
            this.txt_questionContent.Size = new System.Drawing.Size(447, 144);
            this.txt_questionContent.TabIndex = 1;
            this.txt_questionContent.Text = "";
            // 
            // txt_answerContent
            // 
            this.txt_answerContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_answerContent.Location = new System.Drawing.Point(202, 271);
            this.txt_answerContent.Name = "txt_answerContent";
            this.txt_answerContent.Size = new System.Drawing.Size(447, 144);
            this.txt_answerContent.TabIndex = 2;
            this.txt_answerContent.Text = "";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(334, 442);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(165, 57);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // open_end
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 511);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_answerContent);
            this.Controls.Add(this.txt_questionContent);
            this.Controls.Add(this.label1);
            this.Name = "open_end";
            this.Text = "open_end";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txt_questionContent;
        private System.Windows.Forms.RichTextBox txt_answerContent;
        private System.Windows.Forms.Button btn_save;
    }
}