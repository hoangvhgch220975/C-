using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Cw1551_final
{
    public partial class edit : Form
    {
        // Connection string to your database
        string connectString = @"Data Source=VH24\SQLEXPRESS;Initial Catalog=cw1551;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();

        public edit()
        {
            InitializeComponent();
        }

        // On form load, load all questions into DataGridView
        private void edit_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectString);
            LoadQuestions();
            load_question.CellClick += new DataGridViewCellEventHandler(load_question_CellClick); // Register CellClick event
            txt_id.ReadOnly = true; // Make ID field read-only
        }

        // Load questions into DataGridView
        private void LoadQuestions()
        {
            try
            {
                dt.Clear();
                conn.Open();

                cmd = new SqlCommand(@"
                    SELECT
                    q.question_id AS 'ID Question',
                    q.content AS 'Question Content',
                    a.answer_content AS 'Right Answer Content'
                    FROM
                    question q
                    JOIN
                    answer a ON q.question_id = a.question_id
                    WHERE
                    a.is_correct = 1", conn);

                adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                load_question.DataSource = dt;

                load_question.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Ensure text wrapping is enabled in DataGridView
                foreach (DataGridViewColumn column in load_question.Columns)
                {
                    column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading questions: " + ex.Message);
            }
        }

        // Handle when a user selects a row in DataGridView
        private void load_question_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = load_question.Rows[e.RowIndex];

                // Populate textboxes with the selected row data
                if (row.Cells["ID Question"].Value != null)
                {
                    txt_id.Text = row.Cells["ID Question"].Value.ToString();
                    txt_questionContent.Text = row.Cells["Question Content"].Value.ToString();
                    txt_rightAnswerContent.Text = row.Cells["Right Answer Content"].Value.ToString();
                }
            }
        }

        // Handle save button click event
        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs (optional, but recommended)
                if (string.IsNullOrEmpty(txt_questionContent.Text) || string.IsNullOrEmpty(txt_rightAnswerContent.Text))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                // Update the question in the database
                conn.Open();

                string updateQuery = @"
                    UPDATE question
                    SET content = @content
                    WHERE question_id = @question_id;
            
                    UPDATE answer
                    SET answer_content = @answer_content
                    WHERE question_id = @question_id AND is_correct = 1;
                ";

                cmd = new SqlCommand(updateQuery, conn);
                cmd.Parameters.AddWithValue("@content", txt_questionContent.Text);
                cmd.Parameters.AddWithValue("@answer_content", txt_rightAnswerContent.Text);
                cmd.Parameters.AddWithValue("@question_id", txt_id.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                conn.Close();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Question updated successfully.");
                    LoadQuestions(); // Reload the updated questions
                }
                else
                {
                    MessageBox.Show("Update failed. Please try again.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving changes: " + ex.Message);
            }
        }
    }
}


