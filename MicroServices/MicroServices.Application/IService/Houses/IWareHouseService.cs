using MicroServices.Models.Dtos.House;
using MricoServices.Shared.ApiResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServices.Application.IService.Houses
{
	public interface IWareHouseService
	{
        //新增仓库
        Task<ApiResult> AddWareHouseAsync(CreateUpdateWareHouseDto wareHouseDto);

		//获取仓库列表
        Task<ApiResult<ApiPaging<List<WareHouseDto>>>> GetWareHouseListAsync(WareHouseSearch wareHouseSearch);

		//删除仓库
        Task<ApiResult> DeleteWareHouseAsync(int wareHouseId);

		//更新仓库信息
        Task<ApiResult<WareHouseDto>> UpdateWareHouseAsync(int wareHouseId,CreateUpdateWareHouseDto wareHouseDto);
	}
}
