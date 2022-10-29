using Autofac;
using MultipleDBContextApp.Repository;

namespace MultipleDBContextApp.Data
{
    public class AutoFacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DbOneContext>().As<BaseContext>();
            builder.RegisterType<DbTwoContext>().As<BaseContext>();
            builder.Register(ctx =>
            {
                var allContext = new Dictionary<string, BaseContext>();
                allContext.Add("DbOneContext", ctx.Resolve<DbOneContext>());
                allContext.Add("DbTwoContext", ctx.Resolve<DbTwoContext>());
                return new DbContextFactory(allContext);

            });
            builder.RegisterType<BookRepository>().As<IBookRepository>();

        }
    }
}
