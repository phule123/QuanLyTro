using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Linq;



namespace Webthuetro
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write("Button clicked!");

           

        }
        public string keySearch = null;

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            string searchKeyword = searchTextBox.Text; // Lấy từ khóa tìm kiếm từ ô input
            Response.Redirect("Default.aspx?searchKeyword=" + Server.UrlEncode(searchKeyword));

        }
        protected void MyButton_Click(object sender, EventArgs e)
        {
            string a = TextBox1.Text;
            string b = TextBox2.Text;

            Connet connet = new Connet();
            SqlConnection con = new SqlConnection(connet.connect1);
            con.Open();
            string sql = "select * from USERR";
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);

            bool loggedIn = false;
            string user = "";
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                string usernameDB = row["USERNAME"].ToString();
                string passwordDB = row["PASSWORK"].ToString();

                if (a == usernameDB && b == passwordDB)
                {
                    user = usernameDB.ToString();
                    Session["UserID"] = user; 
                    loggedIn = true;
                    Session["isLoggedIn"] = true;
                    break;
                }
            }

            con.Close();

            if (loggedIn)
            {

                Session["isLoggedIn"] = true;
                //ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Đăng nhập thành công!');", true);
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Đăng nhập thành công!"+user+"');", true);
                Session["Username"] = user;

                // Chuyển qua trang quản lý bài đăng
                Response.Redirect("~/QuanLyBaiDang.aspx");

            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Đăng nhập thất bại!');", true);
            }
        }

        protected void Btn_register_Click(object sender, EventArgs e)
        {
            string hoten = TB_name.Text;
            string tendangnhap = TB_username.Text;
            string passwork = TB_password.Text;
            string sdt = TB_sdt.Text;
            string email = TB_email.Text;
            string gioiTinh = RadioButton1.Checked ? "Nam" : "Nữ";

            Connet connet = new Connet();
            string sqlconnection = connet.connect1;
            using (SqlConnection con = new SqlConnection(sqlconnection))
            {
                con.Open();
                string query = "INSERT INTO USERR (USERNAME,TENKHACHHANG,  GIOITINH,SDT, EMAIL, PASSWORK) " +
                               "VALUES (@Username,@Name, @GioiTinh, @SDT, @Email,  @Password)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", tendangnhap);
                    cmd.Parameters.AddWithValue("@Name", hoten);
                    cmd.Parameters.AddWithValue("@Password", passwork);
                    cmd.Parameters.AddWithValue("@SDT", sdt);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Thành công: Thực hiện các hành động sau khi thêm dữ liệu vào cơ sở dữ liệu
                        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Đăng ký thành công');", true);
                    }
                    else
                    {
                        // Xử lý trường hợp câu lệnh không thành công
                        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Đăng ký thất bại');", true);
                    }
                }
                con.Close();
                

            }
        }

        protected void logoutClick(object sender, EventArgs e)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('logout');", true);

            // Xóa tất cả các session và cookie
            Session.Clear();
            Session.Abandon();
            Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
            // Redirect về trang đăng nhập hoặc trang chính
            Response.Redirect("Default.aspx"); // Change 'Default.aspx' to your desired redirect page


        }



    }
}