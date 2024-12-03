namespace Cw1551_final
{
    partial class add_question
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
            this.opt_multiple = new System.Windows.Forms.RadioButton();
            this.opt_open_end = new System.Windows.Forms.RadioButton();
            this.opt_true_false = new System.Windows.Forms.RadioButton();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // opt_multiple
            // 
            this.opt_multiple.AutoSize = true;
            this.opt_multiple.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_multiple.Location = new System.Drawing.Point(209, 74);
            this.opt_multiple.Name = "opt_multiple";
            this.opt_multiple.Size = new System.Drawing.Size(319, 30);
            this.opt_multiple.TabIndex = 0;
            this.opt_multiple.TabStop = true;
            this.opt_multiple.Text = "Multiple Choice Questions";
            this.opt_multiple.UseVisualStyleBackColor = true;
            // 
            // opt_open_end
            // 
            this.opt_open_end.AutoSize = true;
            this.opt_open_end.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_open_end.Location = new System.Drawing.Point(209, 151);
            this.opt_open_end.Name = "opt_open_end";
            this.opt_open_end.Size = new System.Drawing.Size(242, 30);
            this.opt_open_end.TabIndex = 1;
            this.opt_open_end.TabStop = true;
            this.opt_open_end.Text = "Open - end question";
            this.opt_open_end.UseVisualStyleBackColor = true;
            // 
            // opt_true_false
            // 
            this.opt_true_false.AutoSize = true;
            this.opt_true_false.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opt_true_false.Location = new System.Drawing.Point(209, 236);
            this.opt_true_false.Name = "opt_true_false";
            this.opt_true_false.Size = new System.Drawing.Size(251, 30);
            this.opt_true_false.TabIndex = 2;
            this.opt_true_false.TabStop = true;
            this.opt_true_false.Text = "true/false Question";
            this.opt_true_false.UseVisualStyleBackColor = true;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_confirm.Location = new System.Drawing.Point(250, 332);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(170, 63);
            this.btn_confirm.TabIndex = 3;
            this.btn_confirm.Text = "confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // add_question
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 440);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.opt_true_false);
            this.Controls.Add(this.opt_open_end);
            this.Controls.Add(this.opt_multiple);
            this.Name = "add_question";
            this.Text = "add_question";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton opt_multiple;
        private System.Windows.Forms.RadioButton opt_open_end;
        private System.Windows.Forms.RadioButton opt_true_false;
        private System.Windows.Forms.Button btn_confirm;
    }
}