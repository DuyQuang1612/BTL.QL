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
             a = Convert.ToInt32(numPart) +1;
            for(int i = 0; i<numPart.Length - a.ToString().Length; i++)
            {
                newNumpart += "0";
            }
            newNumpart += a;
            newKey = strPart +newNumpart ;
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
    }
}