using Nancy;

namespace Modulos
{
    public class IndexModule : NancyModule
    {
        public IndexModule()
        {
            Get("/", args => "IndexModule!!!");
        }
    }
}