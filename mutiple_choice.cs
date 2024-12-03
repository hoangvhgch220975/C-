using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cw1551_final
{
    public partial class mutiple_choice : Form
    {
        public mutiple_choice()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string questionContent = txt_content.Text;
            string questionType = "multiple choice";
            string[] answerContent = new string[]
            {
                txt_opt1.Text,
                txt_opt2.Text,
                txt_opt3.Text,
                txt_opt4.Text,
            };
            bool[] isCorrect = new bool[]
            {
                chk_opt1.Checked,
                chk_opt2.Checked,
                chk_opt3.Checked,
                chk_opt4.Checked
            };
            add_question addQuestionForm = new add_question();
            addQuestionForm.SaveQuestion(questionContent, questionType, answerContent, isCorrect);
        }
    }
}
