using Autofac;

namespace ClassLibrary.Autofac
{
    public static class ContainerBuilderExtensions
    {
        public static void RegisterClassLibrary(this ContainerBuilder builder)
        {
            builder.RegisterType<Class2>()
                    .As<IClass2>();
            builder.RegisterType<Class1>()
                   .As<IClass2>();
        }
    }
}
