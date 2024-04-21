﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using resortManagemetSystem.Application.Common.Interfaces;
using resortManagemetSystem.Domain.Entities;
using resortManagemetSystem.Infrastrcture.Data;

namespace resortManagemetSystem.Infrastructure.Repository
{
    public class VillaRepository : Repository<Villa>, IVillaRepository
    {
        private readonly ApplicationDbContext _db;

        public VillaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Villa entity)
        {
            _db.Villas.Update(entity);
        }
    }
}
