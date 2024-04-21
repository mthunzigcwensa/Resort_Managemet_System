using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using resortManagemetSystem.Application.Common.Interfaces;
using resortManagemetSystem.Domain.Entities;
using resortManagemetSystem.Infrastrcture.Data;

namespace resortManagemetSystem.Infrastructure.Repository
{
    public class AmenityRepository : Repository<Amenity>, IAmenityRepository
    {
        private readonly ApplicationDbContext _db;

        public AmenityRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Amenity entity)
        {
            _db.Amenities.Update(entity);
        }
    }
}
