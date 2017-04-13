using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.Common.Business
{
    class Users
    {
        /// <summary>
        /// Đăng nhập
        /// </summary>
        /// <param name="LoginName"></param>
        /// <param name="Password"></param>
        /// <returns>True: Đăng nhập thành công - False: Đăng nhập thất bại</returns>
        public static bool Login(string LoginName, string Password)

        {
            // Ghi lại ngày login vào LastLogin 


            return false;
        }
        /// <summary>
        /// Thay đổi mật khẩu người sử dụng
        /// </summary>
        /// <param name="LoginName"></param>
        /// <param name="OldPassword"></param>
        /// <param name="NewPassword"></param>
        public static bool ChangePassword(string LoginName, string OldPassword, string NewPassword)
        {
            return false;
        }
       /// <summary>
       /// 
       /// </summary>
      // public static IEnumerable <object> GetUserRole(BHXH.)
    }
}
