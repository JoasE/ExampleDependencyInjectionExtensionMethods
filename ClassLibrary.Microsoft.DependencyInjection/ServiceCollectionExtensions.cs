using Microsoft.Extensions.DependencyInjection;

namespace ClassLibrary.Microsoft.DependencyInjection
{
    public static class ServiceCollectionExtensions
    {
        public static void AddClassLibrary(this IServiceCollection serviceCollection, ServiceLifetime serviceLifetime = ServiceLifetime.Scoped)
        {
            serviceCollection.Add(new ServiceDescriptor(typeof(IClass2), typeof(Class2), serviceLifetime));
            serviceCollection.Add(new ServiceDescriptor(typeof(IClass1), typeof(Class1), serviceLifetime));
        }
    }
}
