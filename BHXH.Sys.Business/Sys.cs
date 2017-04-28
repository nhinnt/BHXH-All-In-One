using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections;

namespace BHXH.Sys.Business
{
  public  class Sys
    {
        public static BHXH.Data.SysUser LoginedUser;
        public static BHXH.Data.SysUserSettings UserSettings;

   
        public void SaveConnectionString(string Server, string Database, string User, string Password)
        {

//            string myConnectionString = ConfigurationManager.ConnectionStrings["BHXHEntities"].ConnectionString;


            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var connectionStringsSection = (ConnectionStringsSection)config.GetSection("connectionStrings");
            connectionStringsSection.ConnectionStrings["BHXHEntities"].ConnectionString = "Data Source="+Server+";Initial Catalog="+Database+";UID="+User+";password="+Password;
            config.Save();
            ConfigurationManager.RefreshSection("connectionStrings");

        }

    }
}
