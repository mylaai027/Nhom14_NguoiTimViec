using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading;

namespace Form_Host
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Timviec" in both code and config file together.
    public class Timviec : ITimviec
    {
        public string GetAuthors()
        {
            string thanhvien = " NGUYỄN QUỐC VŨ 091481    NGUYỄN VIỆT TÙNG 092979     HUỲNH NGUYỄN ĐAN PHÚC 091433 ";
            return thanhvien;
        }
        public string Detai()
        {
            Thread.Sleep(5000);
            string detai = " Tạo dịch vụ web NGƯỜI TÌM VIỆC ";
            return detai;
        }
    }
}
