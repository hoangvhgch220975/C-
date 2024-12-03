namespace Cw1551_final
{
    partial class true_false
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
            this.txt_content = new System.Windows.Forms.RichTextBox();
            this.opt_true = new System.Windows.Forms.CheckBox();
            this.opt_false = new System.Windows.Forms.CheckBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "True - False Questions";
            // 
            // txt_content
            // 
            this.txt_content.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_content.Location = new System.Drawing.Point(31, 100);
            this.txt_content.Name = "txt_content";
            this.txt_content.Size = new System.Drawing.Size(300, 253);
            this.txt_content.TabIndex = 2;
            this.txt_content.Text = "";
            // 
            // opt_true
            // 
            this.opt_true.AutoSize = true;
            this.opt_true.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_true.Location = new System.Drawing.Point(435, 192);
            this.opt_true.Name = "opt_true";
            this.opt_true.Size = new System.Drawing.Size(86, 33);
            this.opt_true.TabIndex = 3;
            this.opt_true.Text = "True";
            this.opt_true.UseVisualStyleBackColor = true;
            // 
            // opt_false
            // 
            this.opt_false.AutoSize = true;
            this.opt_false.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_false.Location = new System.Drawing.Point(435, 258);
            this.opt_false.Name = "opt_false";
            this.opt_false.Size = new System.Drawing.Size(95, 33);
            this.opt_false.TabIndex = 4;
            this.opt_false.Text = "False";
            this.opt_false.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(275, 376);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(128, 51);
            this.btn_save.TabIndex = 5;
            this.btn_save.Text = "save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // true_false
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 450);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.opt_false);
            this.Controls.Add(this.opt_true);
            this.Controls.Add(this.txt_content);
            this.Controls.Add(this.label1);
            this.Name = "true_false";
            this.Text = "true_false";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txt_content;
        private System.Windows.Forms.CheckBox opt_true;
        private System.Windows.Forms.CheckBox opt_false;
        private System.Windows.Forms.Button btn_save;
    }
}