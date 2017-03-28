using System;
using System.Collections.Generic;

using System.Text;

namespace BHXH.Util
{
    enum Can {No, Giap, At, Binh, Dinh, Mau, Ky, Canh, Tan, Nham, Quy};
    enum Chi { No, Ti, Suu, Dan, Mao, Thin, Ty, Ngo, Mui, Than, Dau, Tuat, Hoi };

  
    public class _DateTime
    {

        public static DateTime GetFirstDateOfMonth(DateTime date)
        {
            return (new DateTime(date.Year, date.Month, 1));
        }

        public static DateTime GetLastDateOfMonth(DateTime date)
        {
            return (new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month)));
        }

        public static DateTime convertLunar2Solar(int lunarDay, int lunarMonth, int lunarYear, int lunarLeap, int timeZone)
        {
            int k, a11, b11, off, leapOff, leapMonth, monthStart;
            if (lunarMonth < 11)
            {
                a11 = getLunarMonth11(lunarYear - 1, timeZone);
                b11 = getLunarMonth11(lunarYear, timeZone);
            }
            else
            {
                a11 = getLunarMonth11(lunarYear, timeZone);
                b11 = getLunarMonth11(lunarYear + 1, timeZone);
            }
            off = lunarMonth - 11;
            if (off < 0)
            {
                off += 12;
            }
            if (b11 - a11 > 365)
            {
                leapOff = getLeapMonthOffset(a11, timeZone);
                leapMonth = leapOff - 2;
                if (leapMonth < 0)
                {
                    leapMonth += 12;
                }
                if (lunarLeap != 0 && lunarMonth != leapMonth)
                {
                    return new DateTime();
                }
                else if (lunarLeap != 0 || off >= leapOff)
                {
                    off += 1;
                }
            }
            k = (int)Math.Floor((double)(0.5 + (a11 - 2415021.076998695) / 29.530588853));
            monthStart = getNewMoonDay(k + off, timeZone);
            return jdToDate(monthStart + lunarDay - 1);
        }

        public static int getNewMoonDay(int k, int timeZone)
        {

            double T, T2, T3, dr, Jd1, M, Mpr, F, C1, deltat, JdNew;
            T = k / 1236.85; // Time in Julian centuries from 1900 January 0.5
            T2 = T * T;
            T3 = T2 * T;
            dr = Math.PI / 180;
            Jd1 = 2415020.75933 + 29.53058868 * k + 0.0001178 * T2 - 0.000000155 * T3;
            Jd1 = Jd1 + 0.00033 * Math.Sin((166.56 + 132.87 * T - 0.009173 * T2) * dr); // Mean new moon
            M = 359.2242 + 29.10535608 * k - 0.0000333 * T2 - 0.00000347 * T3; // Sun's mean anomaly
            Mpr = 306.0253 + 385.81691806 * k + 0.0107306 * T2 + 0.00001236 * T3; // Moon's mean anomaly
            F = 21.2964 + 390.67050646 * k - 0.0016528 * T2 - 0.00000239 * T3; // Moon's argument of latitude
            C1 = (0.1734 - 0.000393 * T) * Math.Sin(M * dr) + 0.0021 * Math.Sin(2 * dr * M);
            C1 = C1 - 0.4068 * Math.Sin(Mpr * dr) + 0.0161 * Math.Sin(dr * 2 * Mpr);
            C1 = C1 - 0.0004 * Math.Sin(dr * 3 * Mpr);
            C1 = C1 + 0.0104 * Math.Sin(dr * 2 * F) - 0.0051 * Math.Sin(dr * (M + Mpr));
            C1 = C1 - 0.0074 * Math.Sin(dr * (M - Mpr)) + 0.0004 * Math.Sin(dr * (2 * F + M));
            C1 = C1 - 0.0004 * Math.Sin(dr * (2 * F - M)) - 0.0006 * Math.Sin(dr * (2 * F + Mpr));
            C1 = C1 + 0.0010 * Math.Sin(dr * (2 * F - Mpr)) + 0.0005 * Math.Sin(dr * (2 * Mpr + M));

            if (T < -11)
            {
                deltat = 0.001 + 0.000839 * T + 0.0002261 * T2 - 0.00000845 * T3 - 0.000000081 * T * T3;
            }
            else
            {
                deltat = -0.000278 + 0.000265 * T + 0.000262 * T2;
            };
            JdNew = Jd1 + C1 - deltat;
            return (int)Math.Floor(JdNew + 0.5 + timeZone / 24);
        }


        public static int GetjdNewMoonDay(int k, int timeZone)
        {
            double T = k / 1236.85;
            double T2 = T * T;
            double T3 = T2 * T;
            double dr = Math.PI / 180;
            double Jd1 = 2415020.75933 + 29.53058868 * k + 0.0001178 * T2 - 0.000000155 * T3;
            Jd1 = Jd1 + 0.00033 * Math.Sin((166.56 + 132.87 * T - 0.009173 * T2) * dr);
            double M = 359.2242 + 29.10535608 * k - 0.0000333 * T2 - 0.00000347 * T3;
            double Mpr = 306.0253 + 385.81691806 * k + 0.0107306 * T2 + 0.00001236 * T3;
            double F = 21.2964 + 390.67050646 * k - 0.0016528 * T2 - 0.00000239 * T3;
            double C1 = (0.1734 - 0.000393 * T) * Math.Sin(M * dr) + 0.0021 * Math.Sin(2 * dr * M);
            C1 = C1 - 0.4068 * Math.Sin(Mpr * dr) + 0.0161 * Math.Sin(dr * 2 * Mpr);
            C1 = C1 - 0.0004 * Math.Sin(dr * 3 * Mpr);
            C1 = C1 + 0.0104 * Math.Sin(dr * 2 * F) - 0.0051 * Math.Sin(dr * (M + Mpr));
            C1 = C1 - 0.0074 * Math.Sin(dr * (M - Mpr)) + 0.0004 * Math.Sin(dr * (2 * F + M));
            C1 = C1 - 0.0004 * Math.Sin(dr * (2 * F - M)) - 0.0006 * Math.Sin(dr * (2 * F + Mpr));
            C1 = C1 + 0.0010 * Math.Sin(dr * (2 * F - Mpr)) + 0.0005 * Math.Sin(dr * (2 * Mpr + M));
            double deltat;
            if (T < -11)
            {
                deltat = 0.001 + 0.000839 * T + 0.0002261 * T2 - 0.00000845 * T3 - 0.000000081 * T * T3;
            }
            else
            {
                deltat = -0.000278 + 0.000265 * T + 0.000262 * T2;
            };
            double JdNew = Jd1 + C1 - deltat;
            return (int)Math.Floor(JdNew + 0.5 + timeZone / 24);
        }

        public static int getSunLongitude(int jdn, int timeZone)
        {
            //System.Windows.Forms.MyMessageBox.Show(Math.PI.ToString());
            double T, T2, dr, M, L0, DL, L;
            T = (jdn - 2451545.5 - timeZone / 24) / 36525; // Time in Julian centuries from 2000-01-01 12:00:00 GMT
            T2 = T * T;
            dr = Math.PI / 180; // degree to radian
            M = 357.52910 + 35999.05030 * T - 0.0001559 * T2 - 0.00000048 * T * T2; // mean anomaly, degree
            L0 = 280.46645 + 36000.76983 * T + 0.0003032 * T2; // mean intitude, degree
            DL = (1.914600 - 0.004817 * T - 0.000014 * T2) * Math.Sin(dr * M);
            DL = DL + (0.019993 - 0.000101 * T) * Math.Sin(dr * 2 * M) + 0.000290 * Math.Sin(dr * 3 * M);
            L = L0 + DL; // true intitude, degree
            L = L * dr;
            L = L - Math.PI * 2 * (Math.Floor(L / (Math.PI * 2))); // Normalize to (0, 2*PI)
            return Convert.ToInt32(Math.Floor(L / Math.PI * 6));

        }
        public static int getLunarMonth11(int yy, int timeZone)
        {

            int offs = ToJuliusID(31, 12, yy) - 2415021;
            int k = (int)Math.Floor((double)(offs / 29.530588853));
            int nm = GetjdNewMoonDay(k, timeZone);
            int sunLong = getSunLongitude(nm, timeZone);
            if (sunLong >= 9) nm = GetjdNewMoonDay(k - 1, timeZone);
            return nm;


        }

        public static int ToJuliusID(int dd, int mm, int yy)
        {

            int a = (14 - mm) / 12;
            int y = yy + 4800 - a;
            int m = mm + 12 * a - 3;
            int jd = dd + (153 * m + 2) / 5 + 365 * y + y / 4 - y / 100 + y / 400 - 32045;

            if (jd < 2299161)
            {
                jd = dd + (153 * m + 2) / 5 + 365 * y + y / 4 - 32083;
            }

            return jd;

        }

        public static int getLeapMonthOffset(int a11, int timeZone)
        {
            int k, last, arc, i;
            k = Convert.ToInt32(Math.Floor((a11 - 2415021.076998695) / 29.530588853 + 0.5));
            last = 0;
            i = 1;
            arc = getSunLongitude(GetjdNewMoonDay(k + i, timeZone), timeZone);
            do
            {
                last = arc;
                i++;
                arc = getSunLongitude(GetjdNewMoonDay(k + i, timeZone), timeZone);
            } while (arc != last && i < 14);
            return i - 1;

        }

        public static DateTime jdToDate(int jd)
        {

            int a, b, c, d, e, m, day, month, year;
            if (jd > 2299160)
            { // After 5/10/1582, Gregorian calendar
                a = jd + 32044;
                b = (int)Math.Floor((double)(4 * a + 3) / 146097);
                c = a - (int)Math.Floor((double)(b * 146097) / 4);

            }
            else
            {
                b = 0;
                c = jd + 32082;
            }
            d = (int)Math.Floor((double)(4 * c + 3) / 1461);
            e = c - (int)Math.Floor((double)(1461 * d) / 4);
            m = (int)Math.Floor((double)(5 * e + 2) / 153);
            day = e - (int)Math.Floor((double)(153 * m + 2) / 5) + 1;
            month = m + 3 - 12 * (int)Math.Floor((double)m / 10);
            year = b * 100 + d - 4800 + (int)Math.Floor((double)m / 10);

            return new DateTime(year, month, day);
            //return day.ToString() + ":" + month.ToString() + ":" + year.ToString();
        }
        public static string ngaycanchi(int dd, int mm, int yy) //Xem ngay hom do thuoc can chi gi
        {
            int id = ToJuliusID((int)dd, (int)mm, (int)yy) - 1;
            int id1 = id + 2;

            int can = (int)(id - (id / 10) * 10) + 1;
            int chi = (int)(id1 - (id1 / 12) * 12) + 1;

            return TextCan(can) + " " + TextChi(chi);
        }
        public static string thangcanchi(int dd, int mm, int yy) //Xem thang do thuoc can chi gi
        {

            int thangam = Convert.ToInt32(convertSolar2Lunar(dd, mm, yy, 7).Split(':')[1]);

            int cannam = IntCan(namcanchi(dd, mm, yy).Split(':')[0].Split(' ')[0]);
            return thangcanchi(thangam, cannam);
        }
        public static string thangcanchi(int thangam, int cannam)
        {
            int can, cangieng, chi;
            cangieng = 0;
            chi = 0;
            switch (thangam)
            {
                case 1: chi = (int)Chi.Dan; break;
                case 2: chi = (int)Chi.Mao; break;
                case 3: chi = (int)Chi.Thin; break;
                case 4: chi = (int)Chi.Ty; break;
                case 5: chi = (int)Chi.Ngo; break;
                case 6: chi = (int)Chi.Mui; break;
                case 7: chi = (int)Chi.Than; break;
                case 8: chi = (int)Chi.Dau; break;
                case 9: chi = (int)Chi.Tuat; break;
                case 10: chi = (int)Chi.Hoi; break;
                case 11: chi = (int)Chi.Ti; break;
                case 12: chi = (int)Chi.Suu; break;

            }
            switch (cannam)
            {
                case (int)Can.Ky:
                case (int)Can.Giap: cangieng = (int)Can.Binh; break;

                case (int)Can.At:
                case (int)Can.Canh: cangieng = (int)Can.Mau; break;

                case (int)Can.Binh:
                case (int)Can.Tan: cangieng = (int)Can.Canh; break;

                case (int)Can.Dinh:
                case (int)Can.Nham: cangieng = (int)Can.Nham; break;

                case (int)Can.Mau:
                case (int)Can.Quy: cangieng = (int)Can.Giap; break;
            }
            can = (cangieng + thangam - 1);
            if (can > 10) can = can - 10;

            ///System.Windows.Forms.MyMessageBox.Show(can.ToString());



            return TextCan(can) + " " + TextChi(chi);
        }

        public static int IntCan(string s) //Chuyen Can tu chu sang so
        {
            if (s == "Giáp") return 1;
            if (s == "Ất") return 2;
            if (s == "Bính") return 3;
            if (s == "Đinh") return 4;
            if (s == "Mậu") return 5;
            if (s == "Kỷ") return 6;
            if (s == "Canh") return 7;
            if (s == "Tân") return 8;
            if (s == "Nhâm") return 9;
            if (s == "Quý") return 10;
            return 0;
        }

        public static int yearfromtext(string te)//Lay nam tu text cho duoc tu ham chuyen doi
        {
            string[] split = te.Split(':');
            return Convert.ToInt32(split[2]);

        }

        public static string namcanchi(int dd, int mm, int yy)//Xem ngay_thang_nam (duong) do thuoc nam gi? Can chi
        {

            int nam = yearfromtext(convertSolar2Lunar(dd, mm, yy, 7));
            int x, y;
            string can, chi;
            can = chi = "";
            x = nam % 10;
            y = nam % 12;
            switch (x)
            {
                case 0: can = "Canh"; break;
                case 1: can = "Tân"; break;
                case 2: can = "Nhâm"; break;
                case 3: can = "Quý"; break;
                case 4: can = "Giáp"; break;
                case 5: can = "Ất"; break;
                case 6: can = "Bính"; break;
                case 7: can = "Đinh"; break;
                case 8: can = "Mậu"; break;
                case 9: can = "Kỷ"; break;
            };

            switch (y)
            {
                case 0: chi = "Thân"; break;
                case 1: chi = "Dậu"; break;
                case 2: chi = "Tuất"; break;
                case 3: chi = "Hợi"; break;
                case 4: chi = "Tý"; break;
                case 5: chi = "Sửu"; break;
                case 6: chi = "Dần"; break;
                case 7: chi = "Mão"; break;
                case 8: chi = "Thìn"; break;
                case 9: chi = "Tỵ"; break;
                case 10: chi = "Ngọ"; break;
                case 11: chi = "Mùi"; break;

            };


            return can + " " + chi;
        }

        public static string CanGioTi(int canngay) //VS2008
        {
            int canty = 1;
            switch (canngay)
            {
                case (int)Can.Giap:
                case (int)Can.Ky: canty = (int)Can.Giap; break;

                case (int)Can.At:
                case (int)Can.Canh: canty = (int)Can.Binh; break;

                case (int)Can.Binh:
                case (int)Can.Tan: canty = (int)Can.Mau; break;

                case (int)Can.Dinh:
                case (int)Can.Nham: canty = (int)Can.Canh; break;

                case (int)Can.Mau:
                case (int)Can.Quy: canty = (int)Can.Nham; break;


            }
            return TextCan(canty);

        }
        public static string TextCan(int can) //Chuyen can tu so sang chu ICHTE2008
        {
            string c = "";
            switch (can)
            {
                case 1: c = "Giáp"; break;
                case 2: c = "Ất"; break;
                case 3: c = "Bính"; break;
                case 4: c = "Đinh"; break;
                case 5: c = "Mậu"; break;
                case 6: c = "Kỷ"; break;
                case 7: c = "Canh"; break;
                case 8: c = "Tân"; break;
                case 9: c = "Nhâm"; break;
                case 10: c = "Quý"; break;
            }
            return c;
        }

        public static string TextChi(int chi) //Chuyen tu chi ky hieu so sang chu IchTe2008
        {
            string c = "";
            switch (chi)
            {
                case 1: c = "Tí"; break;
                case 2: c = "Sửu"; break;
                case 3: c = "Dần"; break;
                case 4: c = "Mão"; break;
                case 5: c = "Thìn"; break;
                case 6: c = "Tỵ"; break;
                case 7: c = "Ngọ"; break;
                case 8: c = "Mùi"; break;
                case 9: c = "Thân"; break;
                case 10: c = "Dậu"; break;
                case 11: c = "Tuất"; break;
                case 12: c = "Hợi"; break;
            }
            return c;
        }


        public static string convertSolar2Lunar(int dd, int mm, int yy, int timeZone)
        {
            int dayNumber = ToJuliusID(dd, mm, yy);
            int k = (int)Math.Floor((dayNumber - 2415021.076998695) / 29.530588853);
            int monthStart = GetjdNewMoonDay(k + 1, timeZone);
            if (monthStart > dayNumber) monthStart = GetjdNewMoonDay(k, timeZone);
            int a11 = getLunarMonth11(yy, timeZone);
            int b11 = a11;
            int lunarYear;
            if (a11 >= monthStart)
            {
                lunarYear = yy;
                a11 = getLunarMonth11(yy - 1, timeZone);
            }
            else
            {
                lunarYear = yy + 1;
                b11 = getLunarMonth11(yy + 1, timeZone);
            }
            int lunarDay = dayNumber - monthStart + 1;
            int diff = (int)Math.Floor((double)((monthStart - a11) / 29));
            int lunarLeap = 0;
            int lunarMonth = diff + 11;
            int leapMonthDiff;
            if (b11 - a11 > 365)
            {
                leapMonthDiff = getLeapMonthOffset(a11, timeZone);
                if (diff >= leapMonthDiff)
                {
                    lunarMonth = diff + 10;
                    if (diff == leapMonthDiff)
                    {
                        lunarLeap = 1;
                    }
                }
            }
            if (lunarMonth > 12) lunarMonth = lunarMonth - 12;

            if ((lunarMonth >= 11) && (diff < 4)) lunarYear = lunarYear - 1;
            string nhuan = "";
            if (lunarLeap == 1) nhuan = "Nhuận";
            return lunarDay.ToString() + ":" + lunarMonth.ToString() + ":" + lunarYear.ToString() + ":" + nhuan;
        }



    }


}
 