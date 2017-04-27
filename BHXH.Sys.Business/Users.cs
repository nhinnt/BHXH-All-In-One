using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.Sys.Business
{
    public class Users
    {
        public static string bien;

        /// <summary>
        /// Thay đổi mật khẩu người sử dụng
        /// </summary>
        /// <param name="LoginName"></param>
        /// <param name="OldPassword"></param>
        /// <param name="NewPassword"></param>
        public static bool ChangePassword(string LoginName, string OldPassword, string NewPassword)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.SysUser
                        where c.UserID == LoginName && c.Pwd==OldPassword
                        select c;
            BHXH.Data.SysUser n = query.First();
            n.Pwd = NewPassword;
        

            try
            {
                ctx.SaveChanges();
            }
            finally
            { }
            return false;
        }
        public static bool Resetpass(string LoginName)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.SysUser
                        where c.UserID == LoginName
                        select c;
            BHXH.Data.SysUser n = query.First();
            n.Pwd = "1" ;


            try
            {
                ctx.SaveChanges();
            }
            finally
            { }
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
        public static BHXH.Data.SysUser NewUser(Guid MaNhanVien, string UserID, string Password, bool IsActive)    // Nam tự thêm các tham số
        {
            if (UserID == "" || Password == "")
                return null;
            if (IsExisted(UserID) != null)
                return IsExisted(UserID);
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.SysUser n = new Data.SysUser();
            n.UserID = UserID;
            n.Pwd = Password;
            n.MaNhanVien = MaNhanVien;
            n.CreatedDate = DateTime.Now;
            n.IsActive = true;


            ctx.SysUser.Add(n);

            try
            {
                ctx.SaveChanges();
                return n;
            }
            catch (Exception)
            {
                return null;
            }

            finally
            { }

        }
        public static void EditUser(string UserID)
        {


        }
        public static IEnumerable<BHXH.Data.SysUser> GetUserInPhongBan(string MaPhongBan)
        {
            return null;
        }

        public static Data.SysUser IsExisted(string userID)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.SysUser
                        where c.UserID == userID
                        select c;
            if (query.Count() > 0)
                return query.First();
            else
                return null;

        }
        public static IEnumerable<BHXH.Data.HrNhanVien> GetNhanVien(string MaPhongBan)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.HrNhanVien> list;

            var query = from c in ctx.HrNhanVien
                        where c.MaPhongBan == MaPhongBan
                        select c;

            list = query.ToList();
            return list;
        }
        public static IEnumerable<BHXH.Data.ListPhongBan> GetPhongBan()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListPhongBan> list;

            var query = from c in ctx.ListPhongBan select c;

            list = query.ToList();
            return list;
        }
        public static IEnumerable<BHXH.Data.HrNhanVien> Getuser(string MaPhongBan)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.HrNhanVien> list;

            var query = from c in ctx.HrNhanVien
                        join p in ctx.SysUser on c.MaNhanVien equals p.MaNhanVien
                        where c.MaPhongBan == MaPhongBan
                        select c;

            list = query.ToList();

            return list;



        }
        public static BHXH.Data.SysUser Login(string user, string pass)
        {
            //Guid g = new Guid(user.ToString());
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.SysUser
                        where (c.UserID.ToString() == user) && (c.Pwd == pass) && c.IsActive == true
                        select c;
            if (query.Count() > 0)
                return query.First();
            else
                return null;
        }

        public static BHXH.Data.HrNhanVien GetName(string UserID)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.SysUser
                        join p in ctx.HrNhanVien on c.MaNhanVien equals p.MaNhanVien
                        where c.UserID == UserID
                        select p;

            return query.ToList().First();


        }

    }

}

