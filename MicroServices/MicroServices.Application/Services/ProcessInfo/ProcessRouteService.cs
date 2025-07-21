using AutoMapper;
using MicroServices.Application.IService.ProcessInfo;
using MicroServices.Models.Dtos;
using MicroServices.Repository.IRepository.I_Process_Repository;
using MricoServices.Shared.ApiResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServices.Application.Services.ProcessInfo
{
    public class ProcessRouteService:IProcessRouteService
    {
        private readonly IProcessRouteRepository processRouteRepository;
        private readonly IMapper mapper;

        public ProcessRouteService(IProcessRouteRepository processRouteRepository,IMapper mapper)
        {
            this.processRouteRepository = processRouteRepository;
            this.mapper = mapper;
        }
        /// <summary>
        /// 获取工序路线
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResult<List<ProcessRouteDto>>> GetProcessRouteAsync()
        {
            try
            {
                var processRoute =await processRouteRepository.GetAll().ToListAsync();
                if (processRoute == null)
                {
                    return ApiResult<List<ProcessRouteDto>>.Fail(ResultCode.Fail, "获取工序路线数据失败");
                }
                var dtoinfo=mapper.Map<List<ProcessRouteDto>>(processRoute);
                return ApiResult<List<ProcessRouteDto>>.Success(ResultCode.Ok, dtoinfo);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
