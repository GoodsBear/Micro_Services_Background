using MicroServices.Models.Dtos.House;
using MricoServices.Shared.ApiResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServices.Application.IService.Houses
{
	/// <summary>
	/// 库区服务接口
	/// </summary>
	public interface IHouseAreaService
	{
		//新增库区
        Task<ApiResult> AddHouseAreaAsync(CreateUpdateWareHouseAreaDto houseAreaDto);

		//获取仓库列表
		Task<ApiResult<ApiPaging<List<WareHouseAreaDto>>>> GetHouseAreaListAsync(WareHouseAreaSearch houseAreaSearch);

		//更新库区
		Task<ApiResult<WareHouseAreaDto>> UpdateHouseAreaAsync(int houseAreaId,CreateUpdateWareHouseAreaDto houseAreaDto);

		//删除库区
        Task<ApiResult> DeleteHouseAreaAsync(int houseAreaId);
	}
}
