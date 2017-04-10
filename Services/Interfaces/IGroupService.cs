﻿using System;
using System.Collections.Generic;
using Data.Entities;
using Services.Models;

namespace Services.Interfaces
{
    public interface IGroupService: IDisposable
    {
        ICollection<GroupViewModel> GetAll(int useId);

        Group Get(int groupId);

        GroupViewModel GetViewModel(int groupId, int userId);

        void CreateGroup(GroupViewModel newGroup, int userId);

        void CreateOrUpdate(GroupViewModel groupViewModel, int userId);

        bool UpdateGroup(GroupViewModel groupViewModel, int userId);

        void RemoveGroup(int groupId, int userId);
    }
}