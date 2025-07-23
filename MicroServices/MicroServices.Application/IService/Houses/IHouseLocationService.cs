using MicroServices.Models.Dtos.House;
using MricoServices.Shared.ApiResult;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServices.Application.IService.Houses
{
	public interface IHouseLocationService
	{
		//新增库位
        Task<ApiResult> AddHouseLocationAsync(CreateUpdateHouseLocationDto houseLocationDto);

		//修改库位
        Task<ApiResult<HouseLocationDto>> UpdateHouseLocationAsync(int HouseLocationId,CreateUpdateHouseLocationDto houseLocationDto);

		//删除库位
        Task<ApiResult> DeleteHouseLocationAsync(int houseLocationId);

		//获取库位列表
        Task<ApiResult<ApiPaging<List<HouseLocationDto>>>> GetHouseLocationListAsync(HouseLocationSearch houseLocationSearch);
	}
}
