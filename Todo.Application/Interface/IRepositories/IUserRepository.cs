﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Domain.Entities;

namespace Todo.Application.Interface.IRepositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
    }
}
