using System;
using System.Collections.Generic;
using System.Text;
using Fernando.TesteCouchBase.Data.Repositories;
using Fernando.TesteCouchBase.Domain.Interfaces.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Fernando.TesteCouchBase.IoC
{
    public static class NativeInjectorConfig
    {
        public static void RegisterServices(this IServiceCollection services)
        {

            services.AddScoped<IUserRepository, UserRepository>();
            

            
        }
    }
}
