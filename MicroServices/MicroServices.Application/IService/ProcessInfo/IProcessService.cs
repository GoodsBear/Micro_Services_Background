using MicroServices.Domain.ProcessInfo;
using MicroServices.Models.Dtos;
using MricoServices.Shared.ApiResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServices.Application.IService.ProcessInfo
{
    public interface IProcessService
    {
        /// <summary>
        /// 获取工序信息
        /// </summary>
        /// <returns></returns>
        Task<ApiResult<List<ProcessDto>>> GetProcessAsync();


    }
}
