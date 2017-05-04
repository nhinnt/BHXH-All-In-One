﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListLHDaoTao    
    {
        public static IEnumerable<BHXH.Data.ListLHDaoTao> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListLHDaoTao> list;

            var query = from c in ctx.ListLHDaoTao select c;

            list = query.ToList();
            ctx.Dispose();
            return list;
           
        }

        public static BHXH.Data.ListLHDaoTao New(string MaLHDaoTao, string TenLHDaoTao)
           
        {
            if (MaLHDaoTao == "" || TenLHDaoTao == "")
                return null;
            if (IsExisted(MaLHDaoTao, TenLHDaoTao) != null)
                return IsExisted(MaLHDaoTao, TenLHDaoTao);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListLHDaoTao n = new Data.ListLHDaoTao();
            n.MaLHDaoTao = MaLHDaoTao;
            n.TenLHDaoTao = TenLHDaoTao;
            ctx.ListLHDaoTao.Add(n);

            try
            {
                ctx.SaveChanges();
                ctx.Dispose();
                return n;
               
            }
            catch (Exception)
            {
                return null;
            }

            finally
            { }



        }
        public static void Edit(string MaLHDaoTao, string TenLHDaoTao)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListLHDaoTao
                        where c.MaLHDaoTao == MaLHDaoTao
                        select c;
            BHXH.Data.ListLHDaoTao n = query.First();
            n.MaLHDaoTao = MaLHDaoTao;
            n.TenLHDaoTao = TenLHDaoTao;

            try
            {
                ctx.SaveChanges();
            }
            finally
            {
                ctx.Dispose();
            }
        }
        public static Data.ListLHDaoTao IsExisted(string MaLHDaoTao, string TenLHDaoTao)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListLHDaoTao
                        where c.MaLHDaoTao == MaLHDaoTao && c.TenLHDaoTao == TenLHDaoTao
                        select c;
            if (query.Count() > 0)
            {
                ctx.Dispose();
                return query.First();
            }
            else
                return null;
            


        }

        public static void Delete(string MaLHDaoTao)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            var obj = new Data.ListLHDaoTao { MaLHDaoTao = MaLHDaoTao };
            ctx.ListLHDaoTao.Attach(obj);
            ctx.ListLHDaoTao.Remove(obj);

            ctx.SaveChanges();
            ctx.Dispose();
        }

        public static BHXH.Data.ListLHDaoTao GetData(string MaLHDaoTao)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListLHDaoTao
                        where c.MaLHDaoTao == MaLHDaoTao
                        select c;
            ctx.Dispose();
            return query.ToList().First();
       

        }
       // public void STT()
       // { }
    }
}
