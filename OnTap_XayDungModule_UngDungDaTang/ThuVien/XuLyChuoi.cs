using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThuVien
{
    public static class XuLyChuoi
    {
        public static bool kiemTraChuoiHoaThuongXenKe(string text)
        {
            if (string.IsNullOrEmpty(text) || text.Length == 1)
                return true;

            for (int i = 1; i < text.Length; i++)
            {
                if ((char.IsLower(text[i]) && char.IsLower(text[i - 1])) || (char.IsUpper(text[i]) && char.IsUpper(text[i - 1])))
                {
                    return false;
                }
            }

            return true;
        }

        public static bool kiemTraChuoiSo(string text)
        {
            if (string.IsNullOrEmpty(text)) return false;

            foreach (char c in text)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool KiemTraCCCD(string cccd)
        {
            if (cccd.Length != 12)
                return false;

            foreach (char c in cccd)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
