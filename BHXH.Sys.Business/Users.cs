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
        public static BHXH.Data.SysUser Login(string LoginName, string Password)

        {
            // Ghi lại ngày login vào LastLogin 

            
            

            return  null;
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

        public static IEnumerable<BHXH.Data.SysUserRoles> GetUserRoles(string UserID)
        {
            return null;
        }
        /// <summary>
        /// Tạo mới user
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="NhanVienID"></param>
        /// <param name=""></param>
        /// <returns></returns>
        public static BHXH.Data.SysUser NewUser(Guid NhanVienID,  string UserID, string Password)    // Nam tự thêm các tham số
        {
         
            return null;
        }
        public static void EditUser(string UserID)
        {


        }
        public static IEnumerable<BHXH.Data.SysUser> GetUserInPhongBan(string MaPhongBan)
        {
            return null;
        }


    }
}
