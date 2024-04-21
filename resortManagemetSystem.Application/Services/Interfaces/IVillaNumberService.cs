using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using resortManagemetSystem.Domain.Entities;

namespace resortManagemetSystem.Application.Services.Interfaces
{
    public interface IVillaNumberService
    {
        IEnumerable<VillaNumber> GetAllVillaNumbers();
        VillaNumber GetVillaNumberById(int id);
        void CreateVillaNumber(VillaNumber villaNumber);
        void UpdateVillaNumber(VillaNumber villaNumber);
        bool DeleteVillaNumber(int id);

        bool CheckVillaNumberExists(int villa_Number);
    }
}
