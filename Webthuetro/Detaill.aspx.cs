//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;
//using System.Data.SqlClient;
//using System.Data;

//namespace Webthuetro
//{
//    public partial class Detaill : System.Web.UI.Page
//    {
//        Connet create = new Connet();

//        protected void Page_Load(object sender, EventArgs e)
//        {
//            if (!IsPostBack)
//            {
//                string baiDangId = Request.QueryString["id"];
//                if (baiDangId != null)
//                {

//                    string sql = "select b.ID_BAIDANG,b.USERNAME,b.NOIDUNGTIN,b.NGAYDANG,b.GIA,b.TIEUDE,b.HINHANH,b.DIACHI,b.DIENTICH,b.TIENCOC,b.LOAITIN,u.TENKHACHHANG,u.SDT,u.EMAIL from BAIDANG b,USERR u where b.USERNAME = u.USERNAME and ID_BAIDANG = @baiDangId";
//                    //DataTable dt = create.readdata(sql);
//                    SqlConnection connection = create.getConnection();
//                    SqlCommand cmd = new SqlCommand(sql, connection);
//                    cmd.Parameters.AddWithValue("@baiDangId", baiDangId);
//                    connection.Open();

//                    // Thực thi truy vấn và lấy dữ liệu vào DataTable
//                    DataTable dt = new DataTable();
//                    dt.Load(cmd.ExecuteReader());

//                    // Đóng kết nối sau khi đã sử dụng xong
//                    connection.Close();
//                    string htmlString = "";
//                    foreach (DataRow row in dt.Rows)
//                    {
//                        htmlString += "<div class=\"container-detail-left\">";

//                        htmlString += "<div class=\"listimg\">";
//                        htmlString += "<img src=\"/Images/" + row["HINHANH"].ToString() + "\" alt=\"\">";
//                        htmlString += "</div>";
//                        htmlString += "<h3>" + row["TIEUDE"].ToString() + "</h3>";
//                        htmlString += "<div class=\"thongtin\">";
//                        htmlString += "<p class=\"gia\">" + row["GIA"].ToString() + " /tháng</p>";
//                        htmlString += "<p class=\"dientich\">-" + row["DIENTICH"].ToString() + "m2</p>";
//                        htmlString += "<p><i class=\"fa-solid fa-share\"></i>chia sẽ</p>";
//                        htmlString += "<p><i class=\"fa-solid fa-heart\"></i>lưu tin</p>";
//                        htmlString += "</div>";
//                        htmlString += "<div class=\"diachi \"><i class=\"fa-solid fa-location-dot\"></i>" + row["DIACHI"].ToString() + "</div>";
//                        htmlString += "<div class=\"thoigian \"><i class=\"fa-solid fa-business-time\"></i>đăng 3 giờ trước</div>";
//                        htmlString += "<div class=\"kiemduyet \"><i class=\"fa-solid fa-shield\"></i>tin đã được kiểm duyệt</div>";
//                        htmlString += "<div class=\"content-characteristic\">";
//                        htmlString += "<h4>đặc điểm bất động sản</h4>";
//                        htmlString += "<div class=\"characteristic\">";
//                        htmlString += "<div class=\"characteristic-left\">";
//                        htmlString += "<p><i class=\"fa-solid fa-cart-shopping\"></i>cho thuê</p>";
//                        htmlString += "<p><i class=\"fa-solid fa-couch\"></i>tình trạng nội thất: nội thất đầy đủ</p>";
//                        htmlString += "</div>";
//                        htmlString += "<div class=\"characteristic-right\">";
//                        htmlString += "<p><i class=\"fa-brands fa-codepen\"></i>diện tích: " + row["DIENTICH"].ToString() + " m²</p>";
//                        htmlString += "<p><i class=\"fa-solid fa-dollar-sign\"></i>số tiền cọc:" + row["TIENCOC"].ToString() + " đ</p>";
//                        htmlString += "</div>";
//                        htmlString += "</div>";
//                        htmlString += "</div>";
//                        htmlString += "<div class=\"content-characteristic\">";
//                        htmlString += "<h4>mô tả chi tiết</h4>";
//                        htmlString += "<p>" + row["NOIDUNGTIN"].ToString() + "</p>";
//                        htmlString += "</div>";
//                        htmlString += "</div>";


//                        //
//                        htmlString += "<div class='container-detail-right'>";
//                        htmlString += "    <div class='taikhoan'>";
//                        htmlString += "        <div class='taikhoan-left'>";
//                        htmlString += "            <h4 class='ten'>" + row["TENKHACHHANG"].ToString() + "</h4>";
//                        htmlString += "            <p class='con'><i class='fa-solid fa-folder'></i>môi giới</p>";
//                        htmlString += "            <p class='con'>hoạt động 21 giờ trước</p>";
//                        htmlString += "        </div>";
//                        htmlString += "        <div class='taikhoan-right'>";
//                        htmlString += "            <div class='xemtrang'>xem trang<i class='fa-solid fa-chevron-right'></i></div>";
//                        htmlString += "        </div>";
//                        htmlString += "    </div>";
//                        htmlString += "    <div class='lienhe'>";
//                        htmlString += "        <p class='dau'>liên hệ người bán</p>";
//                        htmlString += "        <p class='cuoi'>phản hồi: 90%</p>";
//                        htmlString += "    </div>";
//                        htmlString += "    <div class='call'>";
//                        htmlString += "        <a class='sdt' href='/contact.html'><p><i class='fa-solid fa-phone'></i>" + row["SDT"].ToString() + "</p><p>bấm để hiện số</p></a>";
//                        htmlString += "        <a class='chat' href=''><p><i class='fa-solid fa-message'></i></p><p>chat với người bán</p></a>";
//                        htmlString += "    </div>";
//                        htmlString += "</div>";





//                    }
//                    Literal2.Text = htmlString;

//                    //

//                    string sqll = "select u.TENKHACHHANG,b.ID_BAIDANG,d.ID_DANHGIA,d.NOIDUNG,d.NGAYDANHGIA,d.HINHANH from USERR u,BAIDANG b,DANHGIA d where b.ID_BAIDANG = @baiDangId and u.USERNAME =b.USERNAME and b.ID_BAIDANG = d.ID_BAIDANG";
//                    //DataTable dt = create.readdata(sql);
//                    SqlConnection connectionn = create.getConnection();
//                    SqlCommand cmdd = new SqlCommand(sqll, connectionn);
//                    cmdd.Parameters.AddWithValue("@baiDangId", baiDangId);
//                    connectionn.Open();

//                    // Thực thi truy vấn và lấy dữ liệu vào DataTable
//                    DataTable dtt = new DataTable();
//                    dtt.Load(cmdd.ExecuteReader());

//                    // Đóng kết nối sau khi đã sử dụng xong
//                    connectionn.Close();
//                    string htmlStringg = "";
//                    foreach (DataRow row in dtt.Rows)
//                    {
//                        htmlStringg += "<div >";
//                        htmlStringg += "    <div >";
//                        htmlStringg += "        <div >";
//                        htmlStringg += "        <h1 > Bình luận</h1>";

//                        htmlStringg += "            <h4 >" + row["TENKHACHHANG"].ToString() + "</h4>";
//                        htmlStringg += "            <p >" + row["d.NOIDUNG"].ToString() + "</p>";
//                        htmlStringg += "        </div>";
//                        htmlStringg += "            <div >NGÀY Đăng" + row["d.NGAYDANHGIA"].ToString() + " </div>";
//                        htmlStringg += "    </div>";
//                        htmlStringg += "</div>";
//                    }
//                    Literal1.Text = htmlStringg;
//                    //
//                }
//                else
//                {
//                    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('ID chưa lấy thành công');", true);

//                }
//                //if (baiDangId != null)
//                //{

//                //    string sql = "select u.TENKHACHHANG,b.ID_BAIDANG,d.ID_DANHGIA,d.NOIDUNG,d.NGAYDANHGIA,d.HINHANH from USERR u,BAIDANG b,DANHGIA d where ID_BAIDANG = @baiDangId and u.USERNAME =b.USERNAME and b.ID_BAIDANG = d.ID_BAIDANG";
//                //    //DataTable dt = create.readdata(sql);
//                //    SqlConnection connection = create.getConnection();
//                //    SqlCommand cmd = new SqlCommand(sql, connection);
//                //    cmd.Parameters.AddWithValue("@baiDangId", baiDangId);
//                //    connection.Open();

//                //    // Thực thi truy vấn và lấy dữ liệu vào DataTable
//                //    DataTable dt = new DataTable();
//                //    dt.Load(cmd.ExecuteReader());

//                //    // Đóng kết nối sau khi đã sử dụng xong
//                //    connection.Close();
//                //    string htmlString = "";
//                //    foreach (DataRow row in dt.Rows)
//                //    {
//                //        htmlString += "<div >";
//                //        htmlString += "    <div >";
//                //        htmlString += "        <div >";
//                //        htmlString += "        <h1 > Bình luận</h1>";

//                //        htmlString += "            <h4 >" + row["TENKHACHHANG"].ToString() + "</h4>";
//                //        htmlString += "            <p >" + row["d.NOIDUNG"].ToString() + "</p>";
//                //        htmlString += "        </div>";
//                //        htmlString += "            <div >NGÀY Đăng" + row["d.NGAYDANHGIA"].ToString() + " </div>";
//                //        htmlString += "    </div>";
//                //        htmlString += "</div>";
//                //    }
//                //    Literal1.Text = htmlString;
//                //}
//                //else
//                //{
//                //    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('ID chưa lấy thành công');", true);

//                //}
//            }
//            else
//            {
//                return; 
//            }




//        }
//        protected void btnSubmitComment_Click(object sender, EventArgs e)
//        {

//            //if (baiDangId != null)
//            //{

//            //    string sql = "select u.TENKHACHHANG,b.ID_BAIDANG,d.ID_DANHGIA,d.NOIDUNG,d.NGAYDANHGIA,d.HINHANH from USERR u,BAIDANG b,DANHGIA d where ID_BAIDANG = @baiDangId and u.USERNAME =b.USERNAME and b.ID_BAIDANG = d.ID_BAIDANG";
//            //    //DataTable dt = create.readdata(sql);
//            //    SqlConnection connection = create.getConnection();
//            //    SqlCommand cmd = new SqlCommand(sql, connection);
//            //    cmd.Parameters.AddWithValue("@baiDangId", baiDangId);
//            //    connection.Open();

//            //    // Thực thi truy vấn và lấy dữ liệu vào DataTable
//            //    DataTable dt = new DataTable();
//            //    dt.Load(cmd.ExecuteReader());

//            //    // Đóng kết nối sau khi đã sử dụng xong
//            //    connection.Close();
//            //    string htmlString = "";
//            //    foreach (DataRow row in dt.Rows)
//            //    {
//            //        htmlString += "<div >";
//            //        htmlString += "    <div >";
//            //        htmlString += "        <div >";
//            //        htmlString += "        <h1 > Bình luận</h1>";

//            //        htmlString += "            <h4 >" + row["TENKHACHHANG"].ToString() + "</h4>";
//            //        htmlString += "            <p >" + row["d.NOIDUNG"].ToString() + "</p>";
//            //        htmlString += "        </div>";
//            //        htmlString += "            <div >NGÀY Đăng" + row["d.NGAYDANHGIA"].ToString() + " </div>";
//            //        htmlString += "    </div>";
//            //        htmlString += "</div>";
//            //    }
//            //    Literal1.Text = htmlString;
//            //}
//            //else
//            //{
//            //    ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('ID chưa lấy thành công');", true);

//            //}





//            //
//            string username = Session["UserID"] as string;
//            string text = txtComment.ToString();

//            string baiDangId = Request.QueryString["id"];
//            string hinhanh = "";

//            Connet connet = new Connet();
//            string sqlconnection = connet.connect1;
//            using (SqlConnection con = new SqlConnection(sqlconnection))
//            {
//                con.Open();
//                string query = "INSERT INTO DANHGIA (ID_BAIDANG,  NOIDUNG,NGAYDANHGIA, HINHANH, USERNAME) " +
//                               "VALUES (@idbaidang, @noidung, Getdate(), @hinhanh,  @username)";

//                using (SqlCommand cmd = new SqlCommand(query, con))
//                {
//                    cmd.Parameters.AddWithValue("@idbaidang", baiDangId);
//                    cmd.Parameters.AddWithValue("@noidung", text);
//                    cmd.Parameters.AddWithValue("@hinhanh", hinhanh);
//                    cmd.Parameters.AddWithValue("@username", username);

//                    int rowsAffected = cmd.ExecuteNonQuery();

//                    if (rowsAffected > 0)
//                    {
//                        // Thành công: Thực hiện các hành động sau khi thêm dữ liệu vào cơ sở dữ liệu
//                        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('bình luận thành công');", true);
//                    }
//                    else
//                    {
//                        // Xử lý trường hợp câu lệnh không thành công
//                        ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('bình luận thất bại');", true);
//                    }
//                }
//                con.Close();


//            }

//        }
//    }
//}
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Webthuetro
{
    public partial class Detaill : System.Web.UI.Page
    {
        Connet create = new Connet();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string baiDangId = Request.QueryString["id"];
                if (baiDangId != null)
                {
                    LoadBaiDangDetails(baiDangId);
                    LoadComments(baiDangId);
                }
                else
                {
                    ShowAlert("ID chưa lấy thành công");
                }
            }
        }

        private void LoadBaiDangDetails(string baiDangId)
        {
            string sql = @"SELECT b.ID_BAIDANG, b.USERNAME, b.NOIDUNGTIN, b.NGAYDANG, b.GIA, b.TIEUDE, b.HINHANH, b.DIACHI, b.DIENTICH, b.TIENCOC, b.LOAITIN, 
                                  u.TENKHACHHANG, u.SDT, u.EMAIL 
                           FROM BAIDANG b 
                           JOIN USERR u ON b.USERNAME = u.USERNAME 
                           WHERE b.ID_BAIDANG = @baiDangId";

            using (SqlConnection connection = create.getConnection())
            {
                connection.ConnectionString = create.connect1; // Ensure the ConnectionString is set
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@baiDangId", baiDangId);
                    connection.Open();

                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    connection.Close();
                    Literal2.Text = GenerateBaiDangHtml(dt);
                }
            }
        }

        private string GenerateBaiDangHtml(DataTable dt)
        {
            string htmlString = "";
            foreach (DataRow row in dt.Rows)
            {
                htmlString += $@"
                <div class='container-detail-left'>
                    <div class='listimg'>
                        <img src='/Images/{row["HINHANH"]}' alt=''>
                    </div>
                    <h3>{row["TIEUDE"]}</h3>
                    <div class='thongtin'>
                        <p class='gia'>{row["GIA"]} /tháng</p>
                        <p class='dientich'>-{row["DIENTICH"]}m2</p>
                        <p><i class='fa-solid fa-share'></i>chia sẽ</p>
                        <p><i class='fa-solid fa-heart'></i>lưu tin</p>
                    </div>
                    <div class='diachi'><i class='fa-solid fa-location-dot'></i>{row["DIACHI"]}</div>
                    <div class='thoigian'><i class='fa-solid fa-business-time'></i>đăng 3 giờ trước</div>
                    <div class='kiemduyet'><i class='fa-solid fa-shield'></i>tin đã được kiểm duyệt</div>
                    <div class='content-characteristic'>
                        <h4>đặc điểm bất động sản</h4>
                        <div class='characteristic'>
                            <div class='characteristic-left'>
                                <p><i class='fa-solid fa-cart-shopping'></i>cho thuê</p>
                                <p><i class='fa-solid fa-couch'></i>tình trạng nội thất: nội thất đầy đủ</p>
                            </div>
                            <div class='characteristic-right'>
                                <p><i class='fa-brands fa-codepen'></i>diện tích: {row["DIENTICH"]} m²</p>
                                <p><i class='fa-solid fa-dollar-sign'></i>số tiền cọc:{row["TIENCOC"]} đ</p>
                            </div>
                        </div>
                    </div>
                    <div class='content-characteristic'>
                        <h4>mô tả chi tiết</h4>
                        <p>{row["NOIDUNGTIN"]}</p>
                    </div>
                </div>
                <div class='container-detail-right'>
                    <div class='taikhoan'>
                        <div class='taikhoan-left'>
                            <h4 class='ten'>{row["TENKHACHHANG"]}</h4>
                            <p class='con'><i class='fa-solid fa-folder'></i>môi giới</p>
                            <p class='con'>hoạt động 21 giờ trước</p>
                        </div>
                        <div class='taikhoan-right'>
                            <div class='xemtrang'>xem trang<i class='fa-solid fa-chevron-right'></i></div>
                        </div>
                    </div>
                    <div class='lienhe'>
                        <p class='dau'>liên hệ người bán</p>
                        <p class='cuoi'>phản hồi: 90%</p>
                    </div>
                    <div class='call'>
                        <a class='sdt' href='/contact.html'><p><i class='fa-solid fa-phone'></i>{row["SDT"]}</p><p>bấm để hiện số</p></a>
                        <a class='chat' href=''><p><i class='fa-solid fa-message'></i></p><p>chat với người bán</p></a>
                    </div>
                </div>";
            }
            return htmlString;
        }

        private void LoadComments(string baiDangId)
        {
            string sql = @"SELECT u.TENKHACHHANG, b.ID_BAIDANG, d.ID_DANHGIA, d.NOIDUNG, d.NGAYDANHGIA, d.HINHANH 
                           FROM USERR u 
                           JOIN BAIDANG b ON u.USERNAME = b.USERNAME 
                           JOIN DANHGIA d ON b.ID_BAIDANG = d.ID_BAIDANG 
                           WHERE b.ID_BAIDANG = @baiDangId";

            using (SqlConnection connection = create.getConnection())
            {
                connection.ConnectionString = create.connect1; // Ensure the ConnectionString is set
                using (SqlCommand cmd = new SqlCommand(sql, connection))
                {
                    cmd.Parameters.AddWithValue("@baiDangId", baiDangId);
                    connection.Open();

                    DataTable dt = new DataTable();
                    dt.Load(cmd.ExecuteReader());

                    connection.Close();
                    Literal1.Text = GenerateCommentsHtml(dt);
                }
            }
        }

        private string GenerateCommentsHtml(DataTable dt)
        {
            string htmlString = "";
            foreach (DataRow row in dt.Rows)
            {
                htmlString += $@"
                <div>
                    <div>
                        <div>
                            <h1>Bình luận</h1>
                            <h4>{row["TENKHACHHANG"]}</h4>
                            <p>{row["NOIDUNG"]}</p>
                        </div>
                        <div>NGÀY Đăng {row["NGAYDANHGIA"]}</div>
                    </div>
                </div>";
            }
            return htmlString;
        }

        protected void btnSubmitComment_Click(object sender, EventArgs e)
        {
            string username = Session["UserID"] as string;
            string text = txtComment.Text;
            string baiDangId = Request.QueryString["id"];
            string hinhanh = "";

            if (!string.IsNullOrEmpty(baiDangId) && !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(text))
            {
                InsertComment(baiDangId, text, hinhanh, username);
            }
            else
            {
                ShowAlert("Vui lòng nhập bình luận và thử lại.");
            }
        }

        private void InsertComment(string baiDangId, string text, string hinhanh, string username)
        {
            string sql = @"INSERT INTO DANHGIA (ID_BAIDANG, NOIDUNG, NGAYDANHGIA, HINHANH, USERNAME) 
                           VALUES (@idbaidang, @noidung, GetDate(), @hinhanh, @username)";

            using (SqlConnection con = new SqlConnection(create.connect1))
            {
                con.ConnectionString = create.connect1; // Ensure the ConnectionString is set
                using (SqlCommand cmd = new SqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@idbaidang", baiDangId);
                    cmd.Parameters.AddWithValue("@noidung", text);
                    cmd.Parameters.AddWithValue("@hinhanh", hinhanh);
                    cmd.Parameters.AddWithValue("@username", username);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    con.Close();

                    if (rowsAffected > 0)
                    {
                        ShowAlert("Bình luận thành công");
                        LoadComments(baiDangId); // Reload comments to display the new one
                    }
                    else
                    {
                        ShowAlert("Bình luận thất bại");
                    }
                }
            }
        }

        private void ShowAlert(string message)
        {
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", $"alert('{message}');", true);
        }
    }
}