using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webthuetro
{
    public partial class QuanLyBaiDang : System.Web.UI.Page
    {
        Connet create = new Connet();
        string username = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Username"] != null)
                {
                    username = Session["Username"].ToString();
                    LoadBaiDang(username);
                }
                else
                {
                    // Xử lý khi không có thông tin người dùng đăng nhập
                    Response.Redirect("~/Default.aspx");
                }
            }
        }
        private void LoadBaiDang(string username)
        {
            string sql = $"SELECT * FROM BAIDANG WHERE USERNAME = '{username}'";

            // Gọi phương thức để đọc dữ liệu từ cơ sở dữ liệu và lưu vào DataTable
            DataTable dt = create.readdata(sql); // Chú ý: Đảm bảo rằng create.readdata đã được định nghĩa đúng và trả về đúng định dạng DataTable

            // Bind DataTable vào Repeater để hiển thị danh sách bài đăng
            repeaterPosts.DataSource = dt;
            repeaterPosts.DataBind();
        }

        protected void DeletePost_Click(object sender, EventArgs e)
        {
            try
            {
                Button btnDelete = (Button)sender;
                string idBaiDang = btnDelete.CommandArgument;
                //xoá đánh giá
                string sqlDeleteDanhGia = $"DELETE FROM DANHGIA WHERE ID_BAIDANG = '{idBaiDang}'";
                string sqlDeleteQuangCao = $"DELETE FROM QUANGCAO WHERE ID_BAIDANG = '{idBaiDang}'";
                create.excedata(sqlDeleteDanhGia);
                create.excedata(sqlDeleteQuangCao);
                //xoá bài đăng
                string sqlDelete = $"DELETE FROM BAIDANG WHERE ID_BAIDANG = '{idBaiDang}'";
                if (create.excedata(sqlDelete))
                {
                    string script = $"alert('Xoá thành công bài viết {idBaiDang}'); window.location.href = 'QuanLyBaiDang.aspx';";
                    ScriptManager.RegisterStartupScript(this, GetType(), "deleteSuccess", script, true);
                }
                else
                {
                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Xoá thất bại bài viết " + idBaiDang + "');", true);
                }
            }
            catch
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('Lỗi Xoá Bài Viết');", true);
            }

        }
    }
}