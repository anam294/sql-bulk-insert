using System;
using Microsoft.Extensions.DependencyInjection;
using SqlBulkInsertTool.Data;
using SqlBulkInsertTool.Process;
using Microsoft.EntityFrameworkCore;

namespace SqlBulkInsertTool
{
    public class ContainerBuilder
    {
        public IServiceProvider Build()
        {
            var container = new ServiceCollection();

            container.AddDbContext<DataContext>(options =>
            {
                options.UseSqlite("Data source=test.db");
            });

            container.AddSingleton<IProcess, ProcessStarter>();

            return container.BuildServiceProvider();
        }
    }
}

