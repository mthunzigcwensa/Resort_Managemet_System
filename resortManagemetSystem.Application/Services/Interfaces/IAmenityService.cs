using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using resortManagemetSystem.Domain.Entities;

namespace resortManagemetSystem.Application.Services.Interfaces
{
    public interface IAmenityService
    {
        IEnumerable<Amenity> GetAllAmenities();
        void CreateAmenity(Amenity amenity);
        void UpdateAmenity(Amenity amenity);
        Amenity GetAmenityById(int id);
        bool DeleteAmenity(int id);
    }
}
