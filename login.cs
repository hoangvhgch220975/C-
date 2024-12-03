using Cw1551_final;
using System;
using System.Data.SqlClient;
using System.Numerics;
using System.Windows.Forms;

namespace CW1551_UI
{
    public partial class LogIn : Form
    {
        private string actualPassword = ""; // To store the real password
        private string connectionString = @"Data Source=VH24\SQLEXPRESS; Initial Catalog=cw1551; Integrated Security=True";

        public LogIn()
        {
            InitializeComponent();
            txt_password.TextChanged += Txt_password_TextChanged; // Gắn sự kiện TextChanged
        }

        private void Txt_password_TextChanged(object sender, EventArgs e)
        {
            int selectionStart = txt_password.SelectionStart;

            // Lưu trữ mật khẩu thực tế theo đầu vào của người dùng
            string currentText = txt_password.Text;
            if (currentText.Length > actualPassword.Length)
            {
                // Thêm ký tự mới
                actualPassword += currentText[currentText.Length - 1];
            }
            else if (currentText.Length < actualPassword.Length)
            {
                // Xóa ký tự
                actualPassword = actualPassword.Substring(0, currentText.Length);
            }

            // Thay thế nội dung hiển thị bằng dấu sao
            txt_password.Text = new string('*', actualPassword.Length);
            txt_password.SelectionStart = selectionStart; // Giữ nguyên vị trí con trỏ
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu username và password không rỗng
                if (string.IsNullOrWhiteSpace(txt_username.Text) || string.IsNullOrWhiteSpace(actualPassword))
                {
                    MessageBox.Show("Please enter both username and password.");
                    return;
                }

                // Mở kết nối tới cơ sở dữ liệu
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // SQL truy vấn kiểm tra tài khoản và mật khẩu
                    string query = "SELECT role FROM account WHERE username = @username AND password = @password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", txt_username.Text);
                        cmd.Parameters.AddWithValue("@password", actualPassword); // So sánh mật khẩu trực tiếp

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Kiểm tra nếu có kết quả
                            {
                                string role = reader["role"].ToString();
                                if (role == "admin")
                                {
                                    admin form_create = new admin();
                                    form_create.Show();
                                }
                                else if (role == "user")
                                {
                                    player form_create = new player();
                                    form_create.Show();
                                }
                                else
                                {
                                    MessageBox.Show("Invalid role.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Incorrect username or password.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
    }
}