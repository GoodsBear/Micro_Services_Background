using AutoMapper;
using MicroServices.Application.IService.ProcessInfo;
using MicroServices.Domain.ProcessInfo;
using MicroServices.Models.Dtos;
using MicroServices.Repository.IRepository.I_Process_Repository;
using MicroServices.Repository.Repository.Process_Repository;
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
        /// 新增工艺路线
        /// </summary>
        /// <param name="createOrUpdateProcessRouteDto"></param>
        /// <returns></returns>
        public async Task<ApiResult<List<ProcessRouteDto>>> CreateProcessRouteAsync(CreateOrUpdateProcessRouteDto createOrUpdateProcessRouteDto)
        {
            try
            {
                // 自动生成唯一工艺路线编号
                string routeCode;
                bool exists;
                var datePart = DateTime.Now.ToString("yyyyMMdd");
                var prefix = "GYLXBH" + datePart;
                var random = new Random();
                int tryCount = 0;
                do
                {
                    var randomNumber = random.Next(0, 10000).ToString("D4");
                    routeCode = prefix + randomNumber;
                    // 判断编号是否已存在
                    exists = await processRouteRepository.GetAll()
                        .AnyAsync(r => r.ProcessRouteCode == routeCode);
                    tryCount++;
                    if (tryCount > 20)
                        throw new Exception("生成唯一工艺路线编号失败，请重试。");
                } while (exists);

                // 赋值到DTO
                createOrUpdateProcessRouteDto.ProcessRouteCode = routeCode;

                var processRoute = mapper.Map<ProcessRoute>(createOrUpdateProcessRouteDto);
                await processRouteRepository.AddAsync(processRoute);

                // 获取工艺路线
                var allroute = await processRouteRepository.GetAll().ToListAsync();
                var RouteDtos = mapper.Map<List<ProcessRouteDto>>(allroute);
                return ApiResult<List<ProcessRouteDto>>.Success(ResultCode.Ok, RouteDtos);
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 获取工艺路线
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
