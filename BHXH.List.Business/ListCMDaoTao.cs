using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListCMDaoTao    
    {
        public static IEnumerable<BHXH.Data.ListCMDaoTao> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListCMDaoTao> list;

            var query = from c in ctx.ListCMDaoTao select c;

            list = query.ToList();
            return list;
        }

        public static BHXH.Data.ListCMDaoTao New(string MaCMDaoTao, string TenCMDaoTao, string LoaiCMDaoTao)
           
        {
            if (MaCMDaoTao == "" || TenCMDaoTao == "" || LoaiCMDaoTao=="")
                return null;
            if (IsExisted(MaCMDaoTao, TenCMDaoTao, LoaiCMDaoTao) != null)
                return IsExisted(MaCMDaoTao, TenCMDaoTao, LoaiCMDaoTao);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListCMDaoTao n = new Data.ListCMDaoTao();
            n.MaCMDaoTao = MaCMDaoTao;
            n.TenCMDaoTao = TenCMDaoTao;
            n.LoaiCMDaoTao = LoaiCMDaoTao;
            ctx.ListCMDaoTao.Add(n);

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
        public static void Edit(string MaCMDaoTao, string TenCMDaoTao, string LoaiCMDaoTao)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListCMDaoTao
                        where c.MaCMDaoTao == MaCMDaoTao || c.LoaiCMDaoTao== LoaiCMDaoTao
                        select c;
            BHXH.Data.ListCMDaoTao n = query.First();
            n.MaCMDaoTao = MaCMDaoTao;
            n.TenCMDaoTao = TenCMDaoTao;
            n.LoaiCMDaoTao = LoaiCMDaoTao;
            try
            {
                ctx.SaveChanges();
            }
            finally
            { }
        }
        public static Data.ListCMDaoTao IsExisted(string MaCMDaoTao, string TenCMDaoTao, string LoaiCMDaoTao)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListCMDaoTao
                        where c.MaCMDaoTao == MaCMDaoTao && c.TenCMDaoTao == TenCMDaoTao && c.LoaiCMDaoTao== LoaiCMDaoTao
                        select c;
            if (query.Count() > 0)
                return query.First();
            else
                return null;



        }

        public static void Delete(string MaCMDaoTao)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            Data.ListCMDaoTao obj = GetData(MaCMDaoTao);

            ctx.ListCMDaoTao.Attach(obj);
            ctx.ListCMDaoTao.Remove(obj);
            
            ctx.SaveChanges();


        }

        public static BHXH.Data.ListCMDaoTao GetData(string MaCMDaoTao)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListCMDaoTao
                        where c.MaCMDaoTao == MaCMDaoTao
                        select c;

            return query.ToList().First();


        }
       // public void STT()
       // { }
    }
}
