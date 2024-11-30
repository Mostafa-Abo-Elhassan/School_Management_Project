﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Data.Routing
{
    public static class Routing
    {
        public const string route = "Api";
        public const string virsion = "V1";
        public const string Rule = route + "/" + virsion + "/";

        public static class StudentRoute
        {
            public const string previx =Rule+ "Student";
            public const string List = previx+"/List";
            public const string GetByID = previx + "/id";

        }


    }
}
