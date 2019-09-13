using Fernando.TesteCouchBase.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fernando.TesteCouchBase.Domain.Interfaces.Repository
{
    public interface IUserRepository
    {
        User FindById(string id);
        void Save(User user);
    }
}
