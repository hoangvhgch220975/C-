namespace Cw1551_final
{
    partial class delete
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
            this.btn_delete = new System.Windows.Forms.Button();
            this.admin_lable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.load_question)).BeginInit();
            this.SuspendLayout();
            // 
            // load_question
            // 
            this.load_question.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.load_question.Location = new System.Drawing.Point(23, 105);
            this.load_question.Name = "load_question";
            this.load_question.RowHeadersWidth = 51;
            this.load_question.RowTemplate.Height = 24;
            this.load_question.Size = new System.Drawing.Size(750, 320);
            this.load_question.TabIndex = 1;
            // 
            // btn_delete
            // 
            this.btn_delete.Font = new System.Drawing.Font("Showcard Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(329, 441);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(106, 43);
            this.btn_delete.TabIndex = 6;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // admin_lable
            // 
            this.admin_lable.AutoSize = true;
            this.admin_lable.Font = new System.Drawing.Font("Showcard Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_lable.Location = new System.Drawing.Point(178, 28);
            this.admin_lable.Name = "admin_lable";
            this.admin_lable.Size = new System.Drawing.Size(586, 53);
            this.admin_lable.TabIndex = 7;
            this.admin_lable.Text = "Hey Ad! You want delete?";
            // 
            // delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.admin_lable);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.load_question);
            this.Name = "delete";
            this.Text = "delete";
            this.Load += new System.EventHandler(this.delete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.load_question)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView load_question;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label admin_lable;
    }
}