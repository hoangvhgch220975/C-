using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cw1551_final
{
    public partial class delete : Form
    {

        string connectstring = @"Data Source=VH24\SQLEXPRESS;Initial Catalog=cw1551;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        public delete()
        {
            InitializeComponent();
        }

        private void delete_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectstring);
            LoadQuestions();

        }
        private void LoadQuestions()
        {
            try
            {
                // Clear old data in DataTable
                dt.Clear();

                // Open connection to database
                conn.Open();

                // Create SQL statement to join question and answer tables and get only the right answer
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

                // Use SqlDataAdapter to fill data into DataTable
                adapter = new SqlDataAdapter(cmd);

                // Fill data into DataTable
                adapter.Fill(dt);

                // Set DataGridView data source to updated DataTable
                load_question.DataSource = dt;

                // Add CheckBox column for deleting questions
                DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
                checkBoxColumn.HeaderText = "Select";
                checkBoxColumn.Name = "select";
                load_question.Columns.Insert(0, checkBoxColumn);

                // Set AutoSizeColumnsMode to make sure columns adjust to fit content
                load_question.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Set WrapMode to allow text wrapping in cells
                foreach (DataGridViewColumn column in load_question.Columns)
                {
                    column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }

                // Optionally, set the row height to auto-adjust based on the wrapped content
                foreach (DataGridViewRow row in load_question.Rows)
                {
                    row.Height = Math.Max(25, row.Height); // Adjust the 25 value if needed
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            string connectstring = @"Data Source=VH24\SQLEXPRESS;Initial Catalog=cw1551;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectstring))
            {
                connection.Open();
                // Iterate through the rows in the DataGridView and delete the selected question
                foreach (DataGridViewRow row in load_question.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["select"].Value)) // Nếu CheckBox được chọn
                    {
                        int questionId = Convert.ToInt32(row.Cells["ID Question"].Value);

                        // Xóa các câu trả lời liên quan đến câu hỏi
                        string deleteAnswersQuery = "DELETE FROM answer WHERE question_id = @question_id";
                        SqlCommand deleteAnswersCommand = new SqlCommand(deleteAnswersQuery, connection);
                        deleteAnswersCommand.Parameters.AddWithValue("@question_id", questionId);
                        deleteAnswersCommand.ExecuteNonQuery();

                        // Xóa câu hỏi từ bảng question
                        string deleteQuestionQuery = "DELETE FROM question WHERE question_id = @question_id";
                        SqlCommand deleteQuestionCommand = new SqlCommand(deleteQuestionQuery, connection);
                        deleteQuestionCommand.Parameters.AddWithValue("@question_id", questionId);
                        deleteQuestionCommand.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Question Deleted Successfully!");
                LoadQuestions();
                }
            }
        }
    }

