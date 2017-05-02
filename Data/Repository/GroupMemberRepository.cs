﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Data.Entities;
using System.Data.Entity;

namespace Data.Repository
{
    public class GroupMemberRepository :IGroupMemberRepository
    {
        private ApplicationDbContext _context = null;

        public GroupMemberRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddUserToGroup(GroupMember entity)
        {
            _context.GroupMembers.Add(entity);
            _context.SaveChanges();
        }

        public IQueryable<GroupMember> Get(Expression<Func<GroupMember, bool>> predicate)
        {
            return _context.GroupMembers.Where(predicate).AsQueryable();
        }

        public bool Has(Expression<Func<GroupMember, bool>> predicate)
        {
            return _context.GroupMembers.Any(predicate);
        }

        public void RemoveUserFromGroup(int groupId, int userId)
        {
            var groupMember = _context.GroupMembers.Single(u => u.UserId == userId && u.GroupId == groupId);

            _context.GroupMembers.Remove(groupMember);
            _context.SaveChanges();
        }

        public bool Update(GroupMember entity)
        {
            if (entity == null) return false;

            if (entity.UserId == 0 || entity.GroupId == 0 || entity.RoleId == 0) return false;
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return true;
        }

    }
}
