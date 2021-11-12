using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace PMQLSQA.Models.Process
{
    public class StringProcess
    {
        public string AutoGenerateKey(string MaSanPham)
        {
            string numPart, strPart, newKey = "", newNumpart = "";
            int a;
            numPart = Regex.Match(MaSanPham, @"\d+").Value;
            strPart = Regex.Match(MaSanPham, @"\D+").Value;
            a = Convert.ToInt32(numPart) + 1;
            for (int i = 0; i < numPart.Length - a.ToString().Length; i++)
            {
                newNumpart += "0";
            }
            newNumpart += a;
            newKey = strPart + newNumpart;
            return newKey;
        }
        public string AutoGenerateKey1(string MaNhanVien)
        {
            string numPart1, strPart1, newKey1 = "", newNumpart1 = "";
            int a1;
            numPart1 = Regex.Match(MaNhanVien, @"\d+").Value;
            strPart1 = Regex.Match(MaNhanVien, @"\D+").Value;
            a1 = Convert.ToInt32(numPart1) + 1;
            for (int i = 0; i < numPart1.Length - a1.ToString().Length; i++)
            {
                newNumpart1 += "0";
            }
            newNumpart1 += a1;
            newKey1 = strPart1 + newNumpart1;
            return newKey1;
        }
        public string AutoGenerateKey2(string MaHoaDon)
        {
            string numPart2, strPart2, newKey2 = "", newNumpart2 = "";
            int a2;
            numPart2 = Regex.Match(MaHoaDon, @"\d+").Value;
            strPart2 = Regex.Match(MaHoaDon, @"\D+").Value;
            a2 = Convert.ToInt32(numPart2) + 1;
            for (int i = 0; i < numPart2.Length - a2.ToString().Length; i++)
            {
                newNumpart2 += "0";
            }
            newNumpart2 += a2;
            newKey2 = strPart2 + newNumpart2;
            return newKey2;
        }
        public string AutoGenerateKey3(string MaUser)
        {
            string numPart3, strPart3, newKey3 = "", newNumpart3 = "";
            int a3;
            numPart3 = Regex.Match(MaUser, @"\d+").Value;
            strPart3 = Regex.Match(MaUser, @"\D+").Value;
            a3 = Convert.ToInt32(numPart3) + 1;
            for (int i = 0; i < numPart3.Length - a3.ToString().Length; i++)
            {
                newNumpart3 += "0";
            }
            newNumpart3 += a3;
            newKey3 = strPart3 + newNumpart3;
            return newKey3;
        }
        public string AutoGenerateKey4(string MaPhieuNhap)
        {
            string numPart4, strPart4, newKey4 = "", newNumpart4 = "";
            int a4;
            numPart4 = Regex.Match(MaPhieuNhap, @"\d+").Value;
            strPart4 = Regex.Match(MaPhieuNhap, @"\D+").Value;
            a4 = Convert.ToInt32(numPart4) + 1;
            for (int i = 0; i < numPart4.Length - a4.ToString().Length; i++)
            {
                newNumpart4 += "0";
            }
            newNumpart4 += a4;
            newKey4 = strPart4 + newNumpart4;
            return newKey4;
        }
        public string AutoGenerateKey5(string MaPhieuXuat)
        {
            string numPart5, strPart5, newKey5 = "", newNumpart5 = "";
            int a5;
            numPart5 = Regex.Match(MaPhieuXuat, @"\d+").Value;
            strPart5 = Regex.Match(MaPhieuXuat, @"\D+").Value;
            a5 = Convert.ToInt32(numPart5) + 1;
            for (int i = 0; i < numPart5.Length - a5.ToString().Length; i++)
            {
                newNumpart5 += "0";
            }
            newNumpart5 += a5;
            newKey5 = strPart5 + newNumpart5;
            return newKey5;
        }
    }
}