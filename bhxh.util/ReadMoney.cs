using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BHXH.Util
{
    public class ReadMoney
    {
        /// <summary>
        /// Pronounce a digits tring to Vietnames ,return a Unicode string
        /// </summary>
        /// <param name="Money"> String with only digit chars </param>
        /// <returns></returns>
        public static  string Read(string Money)
        {
            string temp = "";
            // Cho đủ 12 số
            while (Money.Length < 12)
            {
                Money = "0" + Money;
            }
            string g1 = Money.Substring(0, 3);
            string g2 = Money.Substring(3, 3);
            string g3 = Money.Substring(6, 3);
            string g4 = Money.Substring(9, 3);

            //Đọc nhóm 1 ---------------------
            if (g1 != "000")
            {
                temp = ReadGroup3(g1);
                temp += " Tỷ";
            }
            //Đọc nhóm 2-----------------------
            if (g2 != "000")
            {
                temp += ReadGroup3(g2);
                temp += " Triệu";
            }
            //---------------------------------
            if (g3 != "000")
            {
                temp += ReadGroup3(g3);
                temp += " Ngàn";
            }
            //-----------------------------------
            //Chỗ này ko biết có nên ko ?
            //temp =temp + ReadGroup3(g4).Replace("Không Trăm Lẻ","Lẻ"); // Đọc 1000001 là Một Triệu Lẻ Một thay vì Một Triệu Không Trăm Lẻ 1;
            temp = temp + ReadGroup3(g4);
            //---------------------------------
            // Tinh chỉnh
            temp = temp.Replace("Một Mươi", "Mười");
            temp = temp.Trim();
            if (temp.IndexOf("Không Trăm") == 0)
                temp = temp.Remove(0, 10);
            temp = temp.Trim();
            if (temp.IndexOf("Lẻ") == 0)
                temp = temp.Remove(0, 2);
            temp = temp.Trim();
            temp = temp.Replace("Mươi Một", "Mươi Mốt");
            temp = temp.Trim();
            //Change Case then Return
            return temp.Substring(0, 1).ToUpper() + temp.Substring(1).ToLower() + " đồng y";
        }
        //Private
        private static string ReadGroup3(string G3)
        {
            string[] ReadDigit = new string[10] { " Không", " Một", " Hai", " Ba", " Bốn", " Năm", " Sáu", " Bảy", " Tám", " Chín" };
            string temp = "";
            if (G3 == "000") return "";

            //Đọc số hàng trăm
            temp = ReadDigit[int.Parse(G3[0].ToString())] + " Trăm";
            //Đọc số hàng chục
            if (G3[1].ToString() == "0")
                if (G3[2].ToString() == "0") return temp;
                else
                {
                    temp += " Lẻ" + ReadDigit[int.Parse(G3[2].ToString())];
                    return temp;
                }
            else
                temp += ReadDigit[int.Parse(G3[1].ToString())] + " Mươi";
            //--------------Đọc hàng đơn vị

            if (G3[2].ToString() == "5") temp += " Lăm";
            else if (G3[2].ToString() != "0") temp += ReadDigit[int.Parse(G3[2].ToString())];
            return temp;


        }

        private bool IsInteger(string number)
        {
            Regex notIntPattern = new Regex("[^0-9-]");
            Regex intPattern = new Regex(" ^-[0-9]+$|^[0-9]+$");
            return !notIntPattern.IsMatch(number) && intPattern.IsMatch(number);
        }
    }
}
