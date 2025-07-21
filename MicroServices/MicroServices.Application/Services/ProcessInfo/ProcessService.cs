using AutoMapper;
using MicroServices.Application.IService.ProcessInfo;
using MicroServices.Domain.ProcessInfo;
using MicroServices.Models.Dtos;
using MicroServices.Repository.IRepository.I_Process_Repository;
using MicroServices.Repository.Repository.Process_Repository;
using MricoServices.Shared.ApiResult;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServices.Application.Services.ProcessInfo
{
    public class ProcessService : IProcessService
    {
        private readonly IProcessRepository processRepository;
        private readonly IMapper mapper;

        public ProcessService(IProcessRepository processRepository,IMapper mapper)
        {
            this.processRepository = processRepository;
            this.mapper = mapper;
        }
        /// <summary>
        /// 获取工序信息
        /// </summary>
        /// <returns></returns>
        public async Task<ApiResult<List<ProcessDto>>> GetProcessAsync()
        {
            try
            {
                // 查询所有工序数据
                var processes = await processRepository.GetAll().ToListAsync();

                var dtoinfo=mapper.Map<List<ProcessDto>>(processes);

                if (dtoinfo == null|| dtoinfo.Count <= 0)
                {
                    return ApiResult<List<ProcessDto>>.Fail(ResultCode.Fail, "获取工序数据失败");
                }

                return ApiResult<List<ProcessDto>>.Success(ResultCode.Ok, dtoinfo);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
