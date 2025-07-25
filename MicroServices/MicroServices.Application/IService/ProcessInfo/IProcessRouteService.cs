using MicroServices.Models.Dtos;
using MricoServices.Shared.ApiResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServices.Application.IService.ProcessInfo
{
    public interface IProcessRouteService
    {
        Task<ApiResult<List<ProcessRouteDto>>> GetProcessRouteAsync();
        Task<ApiResult<List<ProcessRouteDto>>> CreateProcessRouteAsync(CreateOrUpdateProcessRouteDto createOrUpdateProcessRouteDto);
    }
}
