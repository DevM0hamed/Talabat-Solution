﻿using System.Collections.Generic;
using Talabat.API.Dtos;

namespace Talabat.API.Helpers
{
    public class Pagination<T>
    {



        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int Count { get; set; }
        public IReadOnlyList<T> Data { get; set; }


        public Pagination(int pageIndex, int pageSize, int totalItems, IReadOnlyList<T> data)
        {
            PageIndex = pageIndex;
            PageSize = pageSize;
            Count = totalItems;
            Data = data;
        }
    }
}