﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListNganHang    
    {
        public static IEnumerable<BHXH.Data.ListNganHang> GetAll()
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            IEnumerable<BHXH.Data.ListNganHang> list;

            var query = from c in ctx.ListNganHang select c;

            list = query.ToList();
     
            ctx.Dispose();
            return list;
        }

        public static BHXH.Data.ListNganHang New(string MaNganHang, string TenNganHang)
           
        {
            if (MaNganHang == "" || TenNganHang == "")
                return null;
            if (IsExisted(MaNganHang, TenNganHang) != null)
                return IsExisted(MaNganHang, TenNganHang);
              BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            BHXH.Data.ListNganHang n = new Data.ListNganHang();
            n.MaNganHang = MaNganHang;
            n.TenNganHang = TenNganHang;
            ctx.ListNganHang.Add(n);

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
        public static void Edit(string MaNganHang, string TenNganHang)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListNganHang
                        where c.MaNganHang == MaNganHang
                        select c;
            BHXH.Data.ListNganHang n = query.First();
            n.MaNganHang = MaNganHang;
            n.TenNganHang = TenNganHang;

            try
            {
                ctx.SaveChanges();
            }
            finally
            {
                ctx.Dispose();
            }
        }
        public static Data.ListNganHang IsExisted(string MaNganHang, string TenNganHang)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListNganHang
                        where c.MaNganHang == MaNganHang && c.TenNganHang == TenNganHang
                        select c;
            if (query.Count() > 0)
            {
                ctx.Dispose();
                return query.First();
            }
            else
                return null;
          


        }

        public static void Delete(string MaNganHang)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();

            var obj = new Data.ListNganHang { MaNganHang = MaNganHang };
            ctx.ListNganHang.Attach(obj);
            ctx.ListNganHang.Remove(obj);

            ctx.SaveChanges();
            ctx.Dispose();

        }

        public static BHXH.Data.ListNganHang GetData(string MaNganHang)
        {
            BHXH.Data.BHXHEntities ctx = new Data.BHXHEntities();
            var query = from c in ctx.ListNganHang
                        where c.MaNganHang == MaNganHang
                        select c;
            ctx.Dispose();
            return query.ToList().First();
         

        }
       // public void STT()
       // { }
    }
}
