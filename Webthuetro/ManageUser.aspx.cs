using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Webthuetro
{
    public partial class ManageUser : System.Web.UI.Page
    {
        
        Connet DB = new Connet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }
            string user = Session["UserID"] as string;
            if (user == null)
            {
                // Xử lý khi không có người dùng nào được xác định
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Vui lòng đăng nhập để đăng tin.');", true);
                return; // Dừng hàm xử lý ở đây
            }
            string sql = "select * from USERR where ID_TAIKHOAN = '" + user + "'";
            DataTable dt = DB.readdata(sql);
            foreach (DataRow row in dt.Rows)
            {
                TEN.Text = row["TENKHACHHANG"].ToString();
                SEX.Text = row["GIOITINH"].ToString();
                NUMBER.Text = row["SDT"].ToString();
                EMAIL.Text = row["EMAIL"].ToString();
                PASSWORD.Text = row["PASSWORK"].ToString();
            }
        }

        protected void btnDangTin_Click(object sender, EventArgs e)
        {
            Connet connet = new Connet();
            string user = Session["UserID"] as string;
            if (user != "")
            {
                using (SqlConnection yourSqlConnection = new SqlConnection(connet.connect1))
                {
                    yourSqlConnection.Open();

                    string ten = TEN.Text;
                    string gt = SEX.Text;
                    string sdt = NUMBER.Text;
                    string email = EMAIL.Text;
                    string mk = PASSWORD.Text;

                    string sql = "UPDATE USERR SET TENKHACHHANG = @ten, GIOITINH = @gt, SDT = @sdt, EMAIL = @email, PASSWORK = @mk WHERE ID_TAIKHOAN = @user";

                    using (SqlCommand cmd = new SqlCommand(sql, yourSqlConnection))
                    {
                        cmd.Parameters.AddWithValue("@ten", ten);
                        cmd.Parameters.AddWithValue("@gt", gt);
                        cmd.Parameters.AddWithValue("@sdt", sdt);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@mk", mk);
                        cmd.Parameters.AddWithValue("@user", user);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            Label1.Text = "Cập nhật thành công!";
                            yourSqlConnection.Close(); // Close connection on success
                        }
                        else
                        {
                            Label1.Text = "Cập nhật thất bại!";
                            yourSqlConnection.Close(); // Close connection on failure
                        }
                    }
                }
            }
            else
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Vui lòng đăng nhập để đăng tin.');", true);
            }
        }
    }
}