using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cw1551_final
{
    public partial class player : Form
    {
        private int currentQuestionIndex;
        private int score;
        private string correctAnswer;
        private bool isAnswered = false;
        private DataTable questionsTable;
        private SqlConnection conn;

        private string connectionString = @"Data Source=VH24\SQLEXPRESS; Initial Catalog=cw1551; Integrated Security=True";


        public player()
        {
            InitializeComponent();
            hide();

            opt1.CheckedChanged += AnswerSelected;
            opt2.CheckedChanged += AnswerSelected;
            opt3.CheckedChanged += AnswerSelected;
            opt4.CheckedChanged += AnswerSelected;

        }

        // Event handler for when an answer option is selected
        private void AnswerSelected(object sender, EventArgs e)
        {
            isAnswered = true;
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_name.Text) || string.IsNullOrWhiteSpace(cb_campus.Text))
            {
                MessageBox.Show("Please enter your name and select your campus.");
                return;
            }

            lbl_name.Visible = false;
            txt_name.Visible = false;
            lbl_campus.Visible = false;
            cb_campus.Visible = false;
            btn_play.Visible = false;

            txt_showinfo.Text = $"Welcome {txt_name.Text} from {cb_campus.Text}! Let's start the quiz.";
            score = 0;
            currentQuestionIndex = 0;
            txt_score.Text = score.ToString();

            //Load question from db
            conn = new SqlConnection(connectionString);
            LoadQuestion();

            //Show the 1st questiob
            DisplayQuestion(currentQuestionIndex);
        }

        private void LoadQuestion()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
            SELECT 
                q.question_id, 
                q.content AS question_content, 
                q.question_type
            FROM question q
            ORDER BY q.question_id", conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                questionsTable = new DataTable();
                adapter.Fill(questionsTable);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading question: " + ex.Message);
            }
        }


        // Display the current question based on its type
        private void DisplayQuestion(int index)
        {
            if (index >= questionsTable.Rows.Count)
            {
                MessageBox.Show($"Quiz finished! Your score is: {score}");
                btn_next.Enabled = false;
                hide();
                txt_showinfo.Visible = false;
                lbl_score.Visible = false;
                txt_score.Visible = false;
                btn_next.Visible = false;
                btn_quit.Visible = false;
                txt_question.Text = $"Quiz finished! Your score is: {score}";
                return;
            }

            // Enable next button for valid questions
            btn_next.Enabled = true;

            DataRow row = questionsTable.Rows[index];
            string questionContent = row["question_content"].ToString();
            string type = row["question_type"].ToString();

            txt_question.Text = questionContent;

            // Lấy đáp án cho câu hỏi hiện tại
            ShowAnswersForCurrentQuestion(row["question_id"].ToString(), type);
        }

        private void ShowAnswersForCurrentQuestion(string questionId, string type)
        {
            SqlCommand cmd = new SqlCommand(@"
            SELECT a.answer_id, a.answer_content, a.is_correct
            FROM answer a
            WHERE a.question_id = @questionId
            ORDER BY a.answer_id", conn);

                cmd.Parameters.AddWithValue("@questionId", questionId);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable answersTable = new DataTable();
                adapter.Fill(answersTable);

            // Xử lý hiển thị các đáp án tùy theo loại câu hỏi
            switch (type)
            {
                case "multiple choice":
                    ShowMultipleChoiceAnswers(answersTable);
                    break;
                case "true/false":
                    ShowTrueFalseAnswers(answersTable);
                    break;
                case "open-end":
                    ShowOpenEndAnswer(answersTable);
                    break;
                default:
                    MessageBox.Show("Unknown question type");
                    break;
            }
        }


        private void ShowMultipleChoiceAnswers(DataTable answers)
        {
            hide();
            var sortedAnswers = answers.AsEnumerable().OrderBy(a => a["answer_id"]).ToArray();

            // Set the options to RadioButtons
            opt1.Text = sortedAnswers.Length > 0 ? sortedAnswers[0]["answer_content"].ToString() : "";
            opt2.Text = sortedAnswers.Length > 1 ? sortedAnswers[1]["answer_content"].ToString() : "";
            opt3.Text = sortedAnswers.Length > 2 ? sortedAnswers[2]["answer_content"].ToString() : "";
            opt4.Text = sortedAnswers.Length > 3 ? sortedAnswers[3]["answer_content"].ToString() : "";

            show();
            correctAnswer = sortedAnswers.FirstOrDefault(a => (bool)a["is_correct"])?.Field<string>("answer_content");
        }

        private void ShowTrueFalseAnswers(DataTable answers)
        {
            hide();
            opt1.Visible = true;
            opt3.Visible = true;

            opt1.Text = "True";
            opt3.Text = "False";

            correctAnswer = answers.AsEnumerable().FirstOrDefault(a => (bool)a["is_correct"])?.Field<string>("answer_content");
        }

        private void ShowOpenEndAnswer(DataTable answers)
        {
            hide();
            txt_answer.Visible = true;

            correctAnswer = answers.Rows[0]["answer_content"].ToString();
        }

        // Show answer options ( radio button)
        private void show()
        {
            opt1.Visible = true;
            opt2.Visible = true;
            opt3.Visible = true;
            opt4.Visible = true;
        }

        // Hide answer options ( radio button)
        private void hide()
        {
            txt_answer.Visible = false;
            opt1.Visible = false;
            opt2.Visible = false;
            opt3.Visible = false;
            opt4.Visible = false;
        }

        private string GetCorrectAnswer(int index)
        {
            DataRow[] answers = questionsTable.Select($"question_id = {questionsTable.Rows[index]["question_id"]}" +
                $" AND is_correct = 1");

            return answers.Length > 0 ? answers[0]["answer_content"].ToString() : string.Empty;

        }

        // Check if the answer is correct (for multiple choice, true/false, and open-ended)
        private bool CheckAnswer()
        {
            if (opt1.Checked && opt1.Text == correctAnswer)
                return true;
            if (opt2.Checked && opt2.Text == correctAnswer)
                return true;
            if (opt3.Checked && opt3.Text == correctAnswer)
                return true;
            if (opt4.Checked && opt4.Text == correctAnswer)
                return true;

            // Check for open-ended answers
            if (txt_answer.Visible && txt_answer.Text.Trim().Equals(correctAnswer.Trim(), StringComparison.OrdinalIgnoreCase))
                return true;

            return false;
        }


        private void btn_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            
                // Kiểm tra nếu chưa chọn câu trả lời
                if (!CheckIfAnswered())
                {
                    MessageBox.Show("Please answer the current question before moving to the next one.");
                    return;
                }

                bool isCorrect = CheckAnswer();
                if (isCorrect)
                {
                    score += 10;
                    txt_score.Text = $"{score}";
                    txt_showinfo.Text = "Correct!";


                }
                else
                {
                    txt_showinfo.Text = "Incorrect!";
                }

                if (currentQuestionIndex >= questionsTable.Rows.Count) // Kiểm tra nếu hết câu hỏi
                {
                    MessageBox.Show($"Quiz finished! Your score is: {score}");
                    btn_next.Enabled = false; // Vô hiệu hóa nút "Next" khi không còn câu hỏi
                    hide();
                    txt_showinfo.Visible = false;
                    lbl_score.Visible = false;
                    txt_score.Visible = false;
                    btn_next.Visible = false;
                    btn_quit.Visible = false;
                txt_question.Text = $"Quiz finished! Your score is: {score}";
                    return;
                }
                // Chuyển sang câu hỏi tiếp theo

                currentQuestionIndex++;

                DisplayQuestion(currentQuestionIndex);
                ResetQuestionState();

            }
        


        // Function to check if any answer is selected
        private bool CheckIfAnswered()
        {
            if (opt1.Checked || opt2.Checked || opt3.Checked || opt4.Checked ||
                (txt_answer.Visible && !string.IsNullOrWhiteSpace(txt_answer.Text)))
            {
                return true;

            }
            return false;
        }
        private void ResetQuestionState()
        {
            isAnswered = false;

            // Reset all answer checkboxes
            opt1.Checked = false;
            opt2.Checked = false;
            opt3.Checked = false;
            opt4.Checked = false;

            // Clear any input fields
            txt_answer.Text = string.Empty;
        }
    }
}
