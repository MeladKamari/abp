﻿using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using Volo.Abp.AspNetCore.Components.Web.Extensibility.EntityActions;

namespace Volo.Abp.AspNetCore.Components.Web.Extensibility.TableColumns
{
    public class TableColumn
    {
        public string Title { get; set; }
        public string Data { get; set; }
        [CanBeNull]
        public string DisplayFormat { get; set; }
        [CanBeNull]
        public Type Component { get; set; }
        public List<EntityAction> Actions { get; set; }
        [CanBeNull]
        public Func<object,string> ValueConverter { get; set; }

        public TableColumn()
        {
            Actions = new List<EntityAction>();
        }
    }
}