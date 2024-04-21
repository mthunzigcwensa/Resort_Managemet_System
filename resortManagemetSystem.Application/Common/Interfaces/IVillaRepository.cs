using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using resortManagemetSystem.Domain.Entities;

namespace resortManagemetSystem.Application.Common.Interfaces
{
    public interface IVillaRepository : IRepository<Villa>
    {

        void Update(Villa entity);


    }
}
