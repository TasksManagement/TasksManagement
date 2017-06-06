﻿using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public class IssueRepository : BaseRepository<Issue>, IIssueRepository
    {
        private readonly ApplicationDbContext _context = null;
        public IssueRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
