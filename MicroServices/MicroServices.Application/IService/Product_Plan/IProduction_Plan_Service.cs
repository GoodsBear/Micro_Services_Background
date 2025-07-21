using MricoServices.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MicroServices.Domain.Product_Plan;
using AutoMapper;

namespace MicroServices.Application.IService.Product_Plan
{
    public class IProduction_Plan_Service
    {
        private readonly IBaseRepository<Production_Planning> productionplanning;
        private readonly IMapper mapper;

        public IProduction_Plan_Service(IBaseRepository<Production_Planning>productionplanning,IMapper mapper)
        {
            this.productionplanning = productionplanning;
            this.mapper = mapper;
        }
    }
}
