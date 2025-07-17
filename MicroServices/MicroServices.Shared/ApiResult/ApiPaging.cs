using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MricoServices.Shared.ApiResult
{
    /// <summary>
    /// 分页
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ApiPaging<T>
    {
        public int TotleCount { get; set; }
        public int TotlePage { get; set; }
        public T Data { get; set; }
    }
}
