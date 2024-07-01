using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace Webthuetro
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            //Application.Lock();
            ////kiemtra file dem.txt đã có chưa
            ////nếu chưa có thì tạo mới file
            //if (System.IO.File.Exists(Server.MapPath("~/dem.txt")))
            //{
            //    System.IO.File.WriteAllText(Server.MapPath("~/dem.txt"), "0");

                
            //}
            ////nếu có, đọc giá trị lưu trong file
            //Application["soluottc"] = int.Parse(System.IO.File.ReadAllText(Server.MapPath("~/dem.txt")));
            //Application.UnLock();
        }
        //void Session_Star(object sender, EventArgs e)
        //{
        //    //tăng số lượng lên 1
        //    Application["soluottc"] = (int)Application["soluottc"] + 1;
        //    //lưu vào file đếm .txt
        //    System.IO.File.WriteAllText(Server.MapPath("~/dem.txt"), Application["soluottc"].ToString());
        //}
    }
}