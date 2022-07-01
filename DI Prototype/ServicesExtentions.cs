
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DI_Prototype
{
    public static class ServicesExtentions
    {
        public static void AddDepencencyInjection(this IServiceCollection services) {
            var dataProvider = new DataProvider();
            services.AddSingleton(dataProvider);
            services.AddTransient<DataProvider>();
        }
    }
}
