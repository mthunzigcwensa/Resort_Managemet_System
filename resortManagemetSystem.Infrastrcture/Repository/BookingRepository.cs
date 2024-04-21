using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using resortManagemetSystem.Application.Common.Interfaces;
using resortManagemetSystem.Application.Common.Utility;
using resortManagemetSystem.Domain.Entities;
using resortManagemetSystem.Infrastrcture.Data;

namespace resortManagemetSystem.Infrastructure.Repository
{
    public class BookingRepository : Repository<Booking>, IBookingRepository
    {
        private readonly ApplicationDbContext _db;

        public BookingRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Booking entity)
        {
            _db.Bookings.Update(entity);
        }


    }
}
