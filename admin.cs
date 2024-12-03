using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cw1551_final
{
    public partial class admin : Form
    {
        string connectstring = @"Data Source=VH24\SQLEXPRESS;Initial Catalog=cw1551;Integrated Security=True";
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt = new DataTable();
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connectstring);
        }

        private void load_quest_Click(object sender, EventArgs e)
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

                // Set AutoSizeColumnsMode to make sure columns adjust to fit content
                load_question.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

                // Set WrapMode to allow text wrapping in cells (if content is too long)
                foreach (DataGridViewColumn column in load_question.Columns)
                {
                    column.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                }

                // Optionally, set the row height to auto-adjust based on the wrapped content
                foreach (DataGridViewRow row in load_question.Rows)
                {
                    row.Height = Math.Max(25, row.Height); // You can adjust the 25 value as needed
                }

                // Close connection
                conn.Close();
            }
            catch (Exception ex)
            {
                // Display error if any
                MessageBox.Show(ex.Message);
            }
        }

        

        private void btn_add_Click(object sender, EventArgs e)
        {
            add_question form_create = new add_question();
            form_create.Show();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            delete form_create = new delete();
            form_create .Show();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            edit form_create = new edit();
            form_create .Show();
        }
    }
}