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
    public partial class open_end : Form
    {
        public open_end()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string questionContent = txt_questionContent.Text;
            string questionType = "open-end";
            string[] answerContent = new string[]
            {
                txt_answerContent.Text,
            };
            bool[] isCorrect = new bool[] 
            {
                true,
            };

            add_question addQuestionForm = new add_question();
            addQuestionForm.SaveQuestion(questionContent, questionType, answerContent, isCorrect);
        }
    }
}
