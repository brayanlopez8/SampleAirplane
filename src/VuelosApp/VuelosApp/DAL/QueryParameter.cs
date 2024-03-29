﻿using System;
using System.Linq.Expressions;

namespace VuelosApp.DAL
{
    public class QueryParameter<T>
    {
        public QueryParameter(int page, int top)
        {
            Page = page;
            Top = top;
            Where = null;
            OrderBy = null;
            OrderByDescending = null;
        }
        public QueryParameter()
        {

        }

        public int Page { get; set; }
        public int Top { get; set; }
        public Expression<Func<T, bool>> Where { get; set; }
        public Func<T, object> OrderBy { get; set; }
        public Func<T, object> OrderByDescending { get; set; }
    }
}