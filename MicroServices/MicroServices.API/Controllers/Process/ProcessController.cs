using AutoMapper;
using MicroServices.Application.IService.ProcessInfo;
using MicroServices.Domain.ProcessInfo;
using MicroServices.Models.Dtos;
using MicroServices.Repository.IRepository.I_Process_Repository;
using MicroServices.Repository.Repository.Process_Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MricoServices.Shared.ApiResult;

namespace MicroServices.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProcessController : ControllerBase
    {
        private readonly IProcessService processService;
        private readonly IProcessCompositionService compositionService;

        public ProcessController(IProcessService processService,IProcessCompositionService compositionService)
        {
            this.processService = processService;
            this.compositionService = compositionService;
        }

        /// <summary>
        /// 获取工序信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ApiResult<List<ProcessDto>>> GetProcessAsync()
        {
            try
            {
                return await processService.GetProcessAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        /// <summary>
        /// 创建工序组合
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<ApiResult<List<ProcessCompositionDto>>> CreateProcessCompositionAsync(CreateOrUpdateProcessCompositionDto createOrUpdateProcessCompositionDto)
        {
            try
            {
                return await compositionService.CreateProcessCompositionAsync(createOrUpdateProcessCompositionDto);
            }
            catch (Exception ex)
            {
                return ApiResult<List<ProcessCompositionDto>>.Fail(ResultCode.Fail, ex.Message);
            }
        }

        /// <summary>
        /// 获取所有工序组合
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ApiResult<List<ProcessCompositionDto>>> GetProcessCompositionAsync(int? processrouteId)
        {
            try
            {
                return await compositionService.GetProcessCompositionAsync(processrouteId);
            }
            catch (Exception ex)
            {
                return ApiResult<List<ProcessCompositionDto>>.Fail(ResultCode.Fail, ex.Message);
            }
        }
    }
}
