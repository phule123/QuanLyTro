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

    public partial class Default : System.Web.UI.Page
    {
        Connet create = new Connet();
        private int pageSize = 10; // Số lượng sản phẩm mỗi trang
        protected void Page_Load(object sender, EventArgs e)
        {
            // Kiểm tra xem người dùng đã đăng nhập hay chưa

            if (!IsPostBack)
            {
                if (Session["isLoggedIn"] != null && (bool)Session["isLoggedIn"])
                {
                    // Người dùng đã đăng nhập, hiển thị nút "Đăng tin mới"
                    themmoi.Visible = true;
                }
                else
                {
                    // Người dùng chưa đăng nhập, ẩn nút "Đăng tin mới"
                    themmoi.Visible = false;
                }
                LoadInitialData(null);
                GeneratePagingControls(null);
            }
        }
        public void LoadInitialData(string sql)
        {
            string searchKeyword = Request.QueryString["searchKeyword"];
            int pageNumber = int.Parse(Request.QueryString["pageNumber"] ?? "1");
            if (sql == null)
            {
                if (string.IsNullOrEmpty(searchKeyword))
                {
                    //sql = "SELECT b.*, b.ID_BAIDANG, u.USERNAME, u.EMAIL, u.PHONE, u.HOATDONG, u.LOAI FROM BAIDANG b JOIN USERR u ON b.USER_ID = u.USER_ID WHERE b.ID_BAIDANG = @baiDangId ORDER BY b.NGAYDANG DESC";
                    sql = "select * from BAIDANG";
                }
                else
                {
                    sql = $"SELECT * FROM BAIDANG WHERE TIEUDE LIKE N'%{searchKeyword}%'";
                }
            }

            DataTable dt = create.ReadDataPaged(sql, pageNumber, pageSize);
            string htmlString = GenerateHtml(dt);

            Literal1.Text = htmlString;
        }

        private string GenerateHtml(DataTable dt)
        {
            string htmlString = "";
            foreach (DataRow row in dt.Rows)
            {
                htmlString += "<a class=\"content-content\" href=\"Detaill.aspx?id=" + row["ID_BAIDANG"].ToString() + "\" >";
                htmlString += "<div class=\"view_content\">";
                htmlString += "<div class=\"img\">";
                htmlString += " <img  src=\"/Images/" + row["HINHANH"].ToString() + "\" alt=\"\">";
                htmlString += "</div>";
                htmlString += " <div class=\"content\">";
                htmlString += " <h6 id = \"tieude\" > " + row["TIEUDE"].ToString() + "</h6>";
                htmlString += " <div class=\"content1\">";
                htmlString += "  <p class=\"dientich\" id=\"dientich\">" + row["DIENTICH"].ToString() + "</p>";
                htmlString += " <p class=\"sophong\" id=\"phong\">2 PN</p>";
                htmlString += " </div>";
                htmlString += "<div class=\"gia\" id=\"gia\">" + row["GIA"].ToString() + " triệu/tháng</div>";
                htmlString += " <div class=\"content2\">";
                htmlString += " <div class=\"gio\" id=\"ngaydang\">" + row["NGAYDANG"].ToString() + "</div>";
                htmlString += " <div class=\"diachi\" id=\"diachi\">" + row["DIACHI"].ToString() + "</div>";
                htmlString += "</div>";
                htmlString += " </div>";
                htmlString += "</div>";
                htmlString += " </a>";
            }
            return htmlString;
        }

        //private void GeneratePagingControls(string sql)
        //{
        //    pagingContainer.Controls.Clear();
        //    string searchKeyword = Request.QueryString["searchKeyword"];

        //    if (sql == null)
        //    {
        //        if (string.IsNullOrEmpty(searchKeyword))
        //        {
        //            sql = "SELECT COUNT(*) FROM BAIDANG";
        //        }
        //        else
        //        {
        //            sql = $"SELECT COUNT(*) FROM BAIDANG WHERE TIEUDE LIKE N'%{searchKeyword}%'";
        //        }
        //    }

        //    int totalRecords = create.GetRecordCount(sql);
        //    int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

        //    for (int i = 1; i <= totalPages; i++)
        //    {
        //        pagingContainer.InnerHtml += $"<a href='Default.aspx?pageNumber={i}' class='paging-link'>{i}</a> ";
        //    }
        //}
        private void GeneratePagingControls(string sql)
        {
            pagingContainer.Controls.Clear(); // Clear previous paging controls
            string searchKeyword = Request.QueryString["searchKeyword"];

            string countSql;
            if (sql == null)
            {
                if (string.IsNullOrEmpty(searchKeyword))
                {
                    countSql = "SELECT COUNT(*) FROM BAIDANG";
                }
                else
                {
                    countSql = $"SELECT COUNT(*) FROM BAIDANG WHERE TIEUDE LIKE N'%{searchKeyword}%'";
                }
            }
            else
            {
                //// Tạo truy vấn đếm số lượng bản ghi từ truy vấn hiện tại bằng cách thay thế "SELECT *" bằng "SELECT COUNT(*)"
                //countSql = sql.Replace("SELECT *", "SELECT COUNT(*)");
                //// Loại bỏ phần ORDER BY nếu có trong truy vấn đếm
                //int orderByIndex = countSql.IndexOf("ORDER BY", StringComparison.OrdinalIgnoreCase);
                //if (orderByIndex > 0)
                //{
                //    countSql = countSql.Substring(0, orderByIndex);
                //}
                string a = sql.Substring(8);
                countSql = "SELECT COUNT(*)" + a;
            }

            int totalRecords = create.GetRecordCount(countSql);
            int totalPages = (int)Math.Ceiling((double)totalRecords / pageSize);

            for (int i = 1; i <= totalPages; i++)
            {
                pagingContainer.InnerHtml += $"<a href='Default.aspx?pageNumber={i}' class='paging-link'>{i}</a> ";
            }
        }
        protected void LinkButton2Click(object sender, EventArgs e)
        {
            string sql = "select * from BAIDANG where LOAITIN= N'THUÊ TRỌ'";
            LoadInitialData(sql);
            GeneratePagingControls(sql);
        }

        protected void LinkButton1Click(object sender, EventArgs e)
        {
            string sql = "select * from BAIDANG where LOAITIN= N'TÌM TRỌ'";
            LoadInitialData(sql);
            GeneratePagingControls(sql);
        }

        protected void LinkButton3Click(object sender, EventArgs e)
        {
            string sql = "select * from BAIDANG";
            LoadInitialData(sql);
            GeneratePagingControls(sql);
        }

        //protected void LinkButton2Click(object sender, EventArgs e)
        //{

        //    string sql = "select * from BAIDANG where LOAITIN= N'THUÊ TRỌ' ";
        //    DataTable dt = create.readdata(sql);
        //    string htmlString = "";

        //    foreach (DataRow row in dt.Rows)
        //    {

        //        //htmlString += "<a class=\"content-content\" href=\"Detaill.aspx?id=" + row["ID_BAIDANG"].ToString() + "\" >";
        //        htmlString += "<a class=\"content-content\" href=\"Detaill.aspx?id=" + row["ID_BAIDANG"].ToString() + "\" >";

        //        htmlString += "<div class=\"view_content\">";
        //        htmlString += "<div class=\"img\">";
        //        htmlString += " <img  src=\"/Images/" + row["HINHANH"].ToString() + "\" alt=\"\">";
        //        htmlString += "</div>";
        //        htmlString += " <div class=\"content\">";
        //        htmlString += " <h6 id = \"tieude\" > " + row["TIEUDE"].ToString() + "</h6>";
        //        htmlString += " <div class=\"content1\">";
        //        htmlString += "  <p class=\"dientich\" id=\"dientich\">" + row["DIENTICH"].ToString() + "</p>";
        //        htmlString += " <p class=\"sophong\" id=\"phong\">2 PN</p>";
        //        htmlString += " </div>";
        //        htmlString += "<div class=\"gia\" id=\"gia\">" + row["GIA"].ToString() + "triệu/tháng</div>";
        //        htmlString += " <div class=\"content2\">";
        //        htmlString += " <div class=\"gio\" id=\"ngaydang\">" + row["NGAYDANG"].ToString() + "</div>";
        //        htmlString += " <div class=\"diachi\" id=\"diachi\">" + row["DIACHI"].ToString() + "</div>";
        //        htmlString += "</div>";
        //        htmlString += " </div>";
        //        htmlString += "</div>";
        //        htmlString += " </a>";
        //    }

        //    // Gán chuỗi HTML cho Literal
        //    Literal1.Text = htmlString;


        //}
        //protected void LinkButton1Click(object sender, EventArgs e)
        //{
        //    string sql = "select * from BAIDANG where LOAITIN= N'TÌM TRỌ' ";
        //    DataTable dt = create.readdata(sql);
        //    string htmlString = "";

        //    foreach (DataRow row in dt.Rows)
        //    {
        //        //htmlString += "<a class=\"content-content\" href=\"Detaill.aspx?id=" + row["ID_BAIDANG"].ToString() + "\" >";
        //        htmlString += "<a class=\"content-content\" href=\"Detaill.aspx?id=" + row["ID_BAIDANG"].ToString() + "\" >";

        //        htmlString += "<div class=\"view_content\">";
        //        htmlString += "<div class=\"img\">";
        //        htmlString += " <img  src=\"/Images/" + row["HINHANH"].ToString() + "\" alt=\"\">";
        //        htmlString += "</div>";
        //        htmlString += " <div class=\"content\">";
        //        htmlString += " <h6 id = \"tieude\" > " + row["TIEUDE"].ToString() + "</h6>";
        //        htmlString += " <div class=\"content1\">";
        //        htmlString += "  <p class=\"dientich\" id=\"dientich\">" + row["DIENTICH"].ToString() + "</p>";
        //        htmlString += " <p class=\"sophong\" id=\"phong\">2 PN</p>";
        //        htmlString += " </div>";
        //        htmlString += "<div class=\"gia\" id=\"gia\">" + row["GIA"].ToString() + "triệu/tháng</div>";
        //        htmlString += " <div class=\"content2\">";
        //        htmlString += " <div class=\"gio\" id=\"ngaydang\">" + row["NGAYDANG"].ToString() + "</div>";
        //        htmlString += " <div class=\"diachi\" id=\"diachi\">" + row["DIACHI"].ToString() + "</div>";
        //        htmlString += "</div>";
        //        htmlString += " </div>";
        //        htmlString += "</div>";
        //        htmlString += " </a>";
        //    }

        //    // Gán chuỗi HTML cho Literal
        //    Literal1.Text = htmlString;


        //}
        //protected void LinkButton3Click(object sender, EventArgs e)
        //{
        //    string sql = "select * from BAIDANG  ";
        //    DataTable dt = create.readdata(sql);
        //    string htmlString = "";

        //    foreach (DataRow row in dt.Rows)
        //    {

        //        //htmlString += "<a class=\"content-content\" href=\"Detaill.aspx?id=" + row["ID_BAIDANG"].ToString() + "\" >";
        //        htmlString += "<a class=\"content-content\" href=\"Detaill.aspx?id=" + row["ID_BAIDANG"].ToString() + "\" >";

        //        htmlString += "<div class=\"view_content\">";
        //        htmlString += "<div class=\"img\">";
        //        htmlString += " <img  src=\"/Images/" + row["HINHANH"].ToString() + "\" alt=\"\">";
        //        htmlString += "</div>";
        //        htmlString += " <div class=\"content\">";
        //        htmlString += " <h6 id = \"tieude\" > " + row["TIEUDE"].ToString() + "</h6>";
        //        htmlString += " <div class=\"content1\">";
        //        htmlString += "  <p class=\"dientich\" id=\"dientich\">" + row["DIENTICH"].ToString() + "</p>";
        //        htmlString += " <p class=\"sophong\" id=\"phong\">2 PN</p>";
        //        htmlString += " </div>";
        //        htmlString += "<div class=\"gia\" id=\"gia\">" + row["GIA"].ToString() + "Đ/tháng</div>";
        //        htmlString += " <div class=\"content2\">";
        //        htmlString += " <div class=\"gio\" id=\"ngaydang\">" + row["NGAYDANG"].ToString() + "</div>";
        //        htmlString += " <div class=\"diachi\" id=\"diachi\">" + row["DIACHI"].ToString() + "</div>";
        //        htmlString += "</div>";
        //        htmlString += " </div>";
        //        htmlString += "</div>";
        //        htmlString += " </a>";
        //    }

        //    // Gán chuỗi HTML cho Literal
        //    Literal1.Text = htmlString;


        //}
    }
}