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
    public partial class true_false : Form
    {
        public true_false()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            string questionContent = txt_content.Text;
            string questionType = "true/false";
            string[] answerContents = new string[]
            {
                "true","false"
            };
            bool[] isCorrect = new bool[]
            {
                opt_true.Checked,
                opt_false.Checked,
            };
            add_question addQuestionForm = new add_question(); 
            addQuestionForm.SaveQuestion(questionContent,questionType, answerContents, isCorrect);
        }
    }

}
