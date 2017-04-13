using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BHXH.List.Business
{
    public class ListNationality
    {
        public static IEnumerable<BHXH.Data.ListNationality> GetAll()
        {
            BHXH.Data.BHXH ctx = new Data.BHXH();

            IEnumerable<BHXH.Data.ListNationality> list;

            var query = from c in ctx.ListNationality select c;

            list = query.ToList();
            return list;
        }

        public static BHXH.Data.ListNationality New(string NationalityCode, string NationalityName)
        {
            if (NationalityCode == "" || NationalityName == "")
                return null;
            if (IsExisted(NationalityCode, NationalityName) != null)
                return IsExisted(NationalityCode, NationalityName);

            try
            {

                BHXH.Data.BHXH ctx = new Data.BHXH();
                BHXH.Data.ListNationality n = new Data.ListNationality();
                n.NationalityCode = NationalityCode;
                n.NationalityName = NationalityName;

                ctx.ListNationality.Add(n);
                ctx.SaveChanges();
                return n;
            }
            //catch (Exception)
            //{ return n; }
            finally
            { }



        }
        public static void Edit(string NationalityCode, string NationalityName)
        {
            BHXH.Data.BHXH ctx = new Data.BHXH();
            var query = from c in ctx.ListNationality
                        where c.NationalityCode == NationalityCode
                        select c;
            BHXH.Data.ListNationality n = query.First();
            n.NationalityCode = NationalityCode;
            n.NationalityName = NationalityName;

            try
            {
                ctx.SaveChanges();
            }
            finally
            { }
        }
        public static Data.ListNationality IsExisted(string NationalityCode, string NationalityName)
        {
            BHXH.Data.BHXH ctx = new Data.BHXH();
            var query = from c in ctx.ListNationality
                        where c.NationalityCode == NationalityCode && c.NationalityName == NationalityName
                        select c;

            return query.First();


        }

        public static void Delete(string NationalityCode)
        {
            BHXH.Data.BHXH ctx = new Data.BHXH();
            var query = from c in ctx.ListNationality
                        where c.NationalityCode == NationalityCode
                        select c;

            if (query.Count() > 0)
                ctx.ListNationality.Remove(query.First());


        }
    }
}
