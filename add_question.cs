using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cw1551_final
{
    public partial class add_question : Form
    {
        public add_question()
        {
            InitializeComponent();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (opt_multiple.Checked)
            {
                mutiple_choice form_create = new mutiple_choice();
                form_create.Show();
                this.Close();
            }
            else if (opt_open_end.Checked)
            {
                open_end form_create = new open_end();
                form_create.Show();
                this.Close();
            }
            else if (opt_true_false.Checked)
            {
                true_false form_create = new true_false();
                form_create.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please choose 1 option");
            }
        }

        // Function to save questions and answers to the database
        public void SaveQuestion(string questionContent, string questionType, string[] answerContents, bool[] isCorrect)
        {
            string connectionString = "Data Source=VH24\\SQLEXPRESS;Initial Catalog=cw1551;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Step 1: Save the question to the questions table
                string insertQuestionQuery = "INSERT INTO question (content, question_type) VALUES (@content, @question_type); SELECT SCOPE_IDENTITY();";
                SqlCommand insertQuestionCommand = new SqlCommand(insertQuestionQuery, connection);
                insertQuestionCommand.Parameters.Add("@content", SqlDbType.NVarChar, 500).Value = questionContent;
                insertQuestionCommand.Parameters.Add("@question_type", SqlDbType.NVarChar, 20).Value = questionType;

                int questionId = Convert.ToInt32(insertQuestionCommand.ExecuteScalar()); // Get the newly inserted question_id

                // Step 2: Save the answers to the answer table
                for (int i = 0; i < answerContents.Length; i++)
                {
                    string insertAnswerQuery = "INSERT INTO answer (question_id, answer_content, is_correct) VALUES (@question_id, @answer_content, @is_correct)";
                    SqlCommand insertAnswerCommand = new SqlCommand(insertAnswerQuery, connection);
                    insertAnswerCommand.Parameters.Add("@question_id", SqlDbType.Int).Value = questionId;
                    insertAnswerCommand.Parameters.Add("@answer_content", SqlDbType.NVarChar, 500).Value = answerContents[i];
                    insertAnswerCommand.Parameters.Add("@is_correct", SqlDbType.Bit).Value = isCorrect[i];

                    insertAnswerCommand.ExecuteNonQuery(); // Execute the insert command
                }

                MessageBox.Show("Question and answer saved successfully!");
            }
        }
    }
}
