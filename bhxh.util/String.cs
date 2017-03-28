using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BHXH.Util
{
    public class TextUtil
    {
        //-------------------------------------------------
        //Use for textbox : thousand separator // 
        // Dont Use : incompleted code
        /*
         public string ToSeparatorText(string strText, string chrCommaOrDot)
         {
             string str = strText;
             str = str.Replace(chrCommaOrDot, "");
             int len = str.Length;
            

                 while (len > 3)
                 {

                      str = str.Insert(len - 3, chrCommaOrDot);
                     len = len - 3;

                  }
            
             return str ;
         }

         */

        //----------------------------------------------


        /// <summary>
        /// Convert a Unicode string to NameCase ( Title Case) By Le Nho Man
        /// Trimming Included 
        /// </summary>
        /// <param name="Name">Unicode string to convert </param>
        /// <returns></returns>
        public static string ToNameCase(string Name)
        {
            string strTemp = Name.ToLower().Trim();
            while (strTemp.IndexOf("  ") != -1) //Contains 2 continued space characters
            {
                strTemp = strTemp.Replace("  ", " ");// Replace 2 spaces by 1 space
            }

            System.Globalization.CultureInfo cultureInfo =

            System.Threading.Thread.CurrentThread.CurrentCulture;

            System.Globalization.TextInfo textInfo = cultureInfo.TextInfo;

            return textInfo.ToTitleCase(strTemp.ToLower());


        }
        /// <summary>
        /// Check the string is  DateTime format or not.
        /// </summary>
        /// <param name="stream">String to check</param>
        /// <example>u.IsDate("Your string here") </example>
        /// <returns>Return a boolean Value</returns>
        public bool IsDate(string stream)
        {
            try
            {
                if (stream == null || stream == string.Empty)
                    return false;
                DateTime checkDate = new DateTime();
                bool dateType = true;
                try
                {
                    checkDate = DateTime.Parse(stream);
                }
                catch
                {
                    dateType = false;
                }
                return dateType;
            }
            catch
            {
                //ErrorTool.ProcessError(ex);
                return false;
            }
        }
        /// <summary>
        /// Returns the number of times, that the key character is found
        /// in the stream string
        /// </summary>
        /// <param name="stream">
        /// string in which to locate key character
        /// </param>
        /// <param name="keyChar">
        /// key character: the string or char to count inside the stream
        /// </param>
        /// <returns>
        /// The number of times the string or char was located
        /// </returns>
        /// 


        public static int GetKeyCharCount(string stream, string keyChar)
        {
            try
            {
                string current;
                int keyCount = 0;
                for (int i = 0; i < stream.Length; i++)
                {
                    current = stream.Substring(i, 1);
                    if (current == keyChar)
                        keyCount += 1;
                }
                if (keyCount <= 0)
                    return -1;
                else
                    return keyCount;
            }
            catch
            {
                //ErrorTool.ProcessError(ex);
                return -1;
            }
        }

        /// <summary>
        /// Is CASE-SENSITIVE
        /// Returns x position of sChar in sstream, where x = iCharInst.
        /// If: getCharPos('pineapple', 'p', 3) Then: 6 is returned
        /// </summary>
        /// <param name="stream">
        /// string in which to pinpoint the character (or string) position
        /// </param>
        /// <param name="charToPinpoint">character or string to locate</param>
        /// <param name="whichCharInstance">
        /// Number indicating WHICH instance of the character/string to locate
        /// </param>
        /// <returns>
        /// The index of the character or string found inside the input string.
        /// Will return -1 if the string/character is not found, or if the
        /// instance number is not found
        /// </returns>
        public  static int GetCharPosition(string stream, string charToPinpoint, int whichCharInstance)
        {
            try
            {
                string current;
                int keyCharCount = 0;
                for (int i = 0; i < stream.Length; i++)
                {
                    current = stream.Substring(i, 1);
                    //was BLOCKED SCRIPT sCurr = sstream.charAt(i);
                    if (current == charToPinpoint)
                    {
                        keyCharCount += 1;
                        if (keyCharCount == whichCharInstance)
                            return i;
                    }
                }
                return -1;
            }
            catch
            {
                //ErrorTool.ProcessError(ex);
                return -1;
            }
        }
        public  static void ReDim(ref string[] arr, int length)
        {

            string[] arrTemp = new string[length];

            if (length > arr.Length)
            {

                Array.Copy(arr, 0, arrTemp, 0, arr.Length);

                arr = arrTemp;

            }

            else
            {

                Array.Copy(arr, 0, arrTemp, 0, length);

                arr = arrTemp;

            }

        }
        public  static bool IsNumeric(object Expression)
        {

            bool isNum;

            double retNum;

            isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);

            return isNum;

        }
        public  static bool IsEmail(string email)
        {
            
            return Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            
        }
        public static  bool IsWebURL(string url)
        {

            string reg = @"http(s)?://([\w-]+\.)+[\w-]+(/[\w- ./?%&=]*)?";
            return Regex.IsMatch(url, reg);

        }

        /// <summary>
        /// Trim all doubled spaces
        /// </summary>
        /// <param name="StringToTrim"></param>
        /// <returns>String with no double spaces</returns>

        public  static string Trim(string StringToTrim)
        {
            string strTemp = StringToTrim;
            while (strTemp.IndexOf("  ") != -1) //Contains 2 continued space characters
            {
                strTemp = strTemp.Replace("  ", " ");// Replace 2 spaces by 1 space
            }

            return strTemp;
        }
        public  static string TrimAccent(string TextToTrim)
        {
            Regex regex = new Regex(@"\p{IsCombiningDiacriticalMarks}+");
            string strFormD = TextToTrim.Normalize(System.Text.NormalizationForm.FormD);
            return regex.Replace(strFormD, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D');
        }
    }
    
}
