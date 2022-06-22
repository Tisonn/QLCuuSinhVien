using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLCuuSinhVien.Models;

namespace QLCuuSinhVien
{
    public class LocalVar
    {
        public static List<NguoiDung> NGUOIDUNG_DATA = new List<NguoiDung>();
        public static void SET_DATA(List<NguoiDung> data)
        {
            NGUOIDUNG_DATA = data;
        }

        public static List<NguoiDung> GET_DATA()
        {
            return NGUOIDUNG_DATA;
        }
    }
}
