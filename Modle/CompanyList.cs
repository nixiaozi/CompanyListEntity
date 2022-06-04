using MainDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace $projectname$Entity.Modle
{
    public class $safeprojectname$:MainDbBaseEntity<Guid>,IMainDbBaseEntity<Guid>
    {
        // /// <summary>
        // /// 公司名称
        // /// </summary>
        // public string CompanyName { get; set; }


    }

    public class AppListCreator : IMaindbModelCreator
    {
        public void CreateModel(ModelBuilder builder)
        {
            builder.Entity<$safeprojectname$>().ToTable("$safeprojectname$");

        }
    }



}
