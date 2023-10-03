using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using QrCodeMenu.DataAccessLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QrCodeMenu.DataAccessLayer.Extensions
{
    public static class DataAccessLayerExtension
    {
        public static IServiceCollection LoadDataAccessLayerExtensions(this IServiceCollection services,IConfiguration config)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            return services;
        }
    }
}
