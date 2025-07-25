using MicroServices.Domain.ProcessInfo;
using MicroServices.Repository.IRepository.I_Process_Repository;
using MricoServices.Repository.Repository;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicroServices.Repository.Repository.Process_Repository
{
    public class ProcessRouteRepository : BaseRepository<ProcessRoute>, IProcessRouteRepository
    {
        public ProcessRouteRepository(ISqlSugarClient db) : base(db)
        {
        }
    }
}
