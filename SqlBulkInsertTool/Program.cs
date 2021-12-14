﻿using System;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using SqlBulkInsertTool.Process;

namespace SqlBulkInsertTool
{
    class Program
    {
        public static readonly IServiceProvider Container = new ContainerBuilder().Build();

        static void Main(string[] args)
        {
            Container.GetServices<IProcess>().ToList().ForEach(p => p.Process());
        }
    }
}

