using Couchbase.Core;
using Couchbase.Extensions.DependencyInjection;
using Fernando.TesteCouchBase.Domain;
using Fernando.TesteCouchBase.Domain.Entities;
using Fernando.TesteCouchBase.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fernando.TesteCouchBase.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly IBucket _bucket;

        public UserRepository(IBucketProvider bucketProvider)
        {
            _bucket = bucketProvider.GetBucket("user_profile");
        }

        public User FindById(string id)
        {   
            var result = _bucket.Get<User>(id);
            var user = result.Value;
            user.Id = id;
            return user;
        }

        public void Save(User user)
        {
            _bucket.Upsert(user.Id, new
            {
                user.CountryCode,
                user.Password,
                user.UserName
            });
        }
    }
}
