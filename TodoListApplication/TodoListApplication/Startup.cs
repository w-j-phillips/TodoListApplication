using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TodoListApplication.Startup))]
namespace TodoListApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
