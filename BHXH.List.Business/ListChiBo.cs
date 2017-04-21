using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListChiBo    
    {
        public static IEnumerable<BHXH.Data.ListChiBo> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListChiBo> list;

            var query = from c in ctx.ListChiBo select c;

            list = query.ToList();
            return list;
        }

        public static BHXH.Data.ListChiBo New(string MaChiBo, string TenChiBo)
           
        {
            if (MaChiBo == "" || TenChiBo == "")
                return null;
            if (IsExisted(MaChiBo, TenChiBo) != null)
                return IsExisted(MaChiBo, TenChiBo);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListChiBo n = new Data.ListChiBo();
            n.MaChiBo = MaChiBo;
            n.TenChiBo = TenChiBo;
            ctx.ListChiBo.Add(n);

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
        public static void Edit(string MaChiBo, string TenChiBo)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListChiBo
                        where c.MaChiBo == MaChiBo
                        select c;
            BHXH.Data.ListChiBo n = query.First();
            n.MaChiBo = MaChiBo;
            n.TenChiBo = TenChiBo;

            try
            {
                ctx.SaveChanges();
            }
            finally
            { }
        }
        public static Data.ListChiBo IsExisted(string MaChiBo, string TenChiBo)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListChiBo
                        where c.MaChiBo == MaChiBo && c.TenChiBo == TenChiBo
                        select c;
            if (query.Count() > 0)
                return query.First();
            else
                return null;



        }

        public static void Delete(string MaChiBo)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            Data.ListChiBo obj = GetNationality(MaChiBo);

            ctx.ListChiBo.Attach(obj);
            ctx.ListChiBo.Remove(obj);
            
            ctx.SaveChanges();


        }

        public static BHXH.Data.ListChiBo GetNationality(string MaChiBo)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListChiBo
                        where c.MaChiBo == MaChiBo
                        select c;

            return query.ToList().First();


        }
       // public void STT()
       // { }
    }
}
