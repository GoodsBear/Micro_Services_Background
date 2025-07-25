using MicroServices.Models.Dtos;
using MricoServices.Shared.ApiResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServices.Application.IService.ProcessInfo
{
    public interface IProcessCompositionService
    {
        Task<ApiResult<List<ProcessCompositionDto>>> CreateProcessCompositionAsync(CreateOrUpdateProcessCompositionDto createOrUpdateProcessCompositionDto);
        Task<ApiResult<List<ProcessCompositionDto>>> GetProcessCompositionAsync(int? processrouteId);
    }
}
