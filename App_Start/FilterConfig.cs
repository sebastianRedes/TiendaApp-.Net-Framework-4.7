﻿using System.Web;
using System.Web.Mvc;

namespace CRUD_FRAMEWORK_4._7
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
