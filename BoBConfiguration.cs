using BoB.BoBConfiguration;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace $projectname$Entity
{
    public class BoBConfiguration
    {
        static BoBConfiguration()
        {
            BaseBoBConfiguration.Init(Assembly.GetExecutingAssembly());
        }

        //使用InMemory数据库不需要
        //[WriteAble]
        //public static readonly string ConnectionStr = "Data Source=.;Initial Catalog=CSNAutoEntityTest;User ID=sa;Password=As412563";
    }
}
