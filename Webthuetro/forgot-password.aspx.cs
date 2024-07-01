using System;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Web.UI;

namespace Webthuetro
{
    public partial class forgot_password : System.Web.UI.Page
    {
        Connet connet = new Connet();
        private static string verificationCode;
        private static string userEmail;

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (newPassword != confirmPassword)
            {
                lblMessage.Text = "Mật khẩu mới và xác nhận mật khẩu không khớp.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                return;
            }

            using (SqlConnection connection = new SqlConnection(connet.connect1))
            {
                try
                {
                    connection.Open();

                    string query = "SELECT EMAIL FROM USERR WHERE USERNAME = @Username";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);

                    string email = (string)command.ExecuteScalar();
                    if (!string.IsNullOrEmpty(email))
                    {
                        userEmail = email;
                        SendVerificationCode(email);
                        lblMessage.Text = "Mã xác minh đã được gửi đến email của bạn.";
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        lblMessage.Text = "Tên đăng nhập không tồn tại.";
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Đã xảy ra lỗi: " + ex.Message;
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private void SendVerificationCode(string email)
        {
            Random random = new Random();
            verificationCode = random.Next(100000, 999999).ToString();

            MailMessage mail = new MailMessage();
            mail.To.Add(email);
            mail.From = new MailAddress("slowlyfastfoodstore03@gmail.com");
            mail.Subject = "Mã xác minh";
            mail.Body = "Mã xác minh của bạn là: " + verificationCode;
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("slowlyfastfoodstore03@gmail.com", "wgubounrayryjfpq");
            smtp.EnableSsl = true;

            try
            {
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Đã xảy ra lỗi khi gửi email: " + ex.Message;
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnVerify_Click(object sender, EventArgs e)
        {
            string inputCode = txtVerificationCode.Text;

            if (inputCode == verificationCode)
            {
                UpdatePassword();
            }
            else
            {
                lblMessage.Text = "Mã xác minh không chính xác.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void UpdatePassword()
        {
            string username = txtUsername.Text;
            string newPassword = txtNewPassword.Text;

            using (SqlConnection connection = new SqlConnection(connet.connect1))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE USERR SET PASSWORK = @NewPassword WHERE USERNAME = @Username";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NewPassword", newPassword);
                    command.Parameters.AddWithValue("@Username", username);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        lblMessage.Text = "Mật khẩu đã được thay đổi thành công.";
                        lblMessage.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        lblMessage.Text = "Đã xảy ra lỗi khi cập nhật mật khẩu.";
                        lblMessage.ForeColor = System.Drawing.Color.Red;
                    }
                }
                catch (Exception ex)
                {
                    lblMessage.Text = "Đã xảy ra lỗi: " + ex.Message;
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                }
            }
        }
    }
}
