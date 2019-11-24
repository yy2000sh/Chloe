﻿using Chloe.Mapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Chloe.Query.Mapping
{
    public interface IObjectActivatorCreator
    {
        Type ObjectType { get; }
        bool IsRoot { get; set; }
        IObjectActivator CreateObjectActivator();
        IObjectActivator CreateObjectActivator(IDbContext dbContext);
        IFitter CreateFitter(IDbContext dbContext);
    }
}
