using Microsoft.Extensions.Localization;
using System.Reflection;

namespace Google__Auth_Demo.Servies
{
    public class SharedResource
    {

    }
    public class LanguagesServices
    {
        private readonly IStringLocalizer _localizer;

        public LanguagesServices(IStringLocalizerFactory factory)
        {
            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _localizer = factory.Create("SharedResource", assemblyName.Name);
        }
        public LocalizedString Getkey(string key)
        {
            return _localizer[key];
        }
    }
}
