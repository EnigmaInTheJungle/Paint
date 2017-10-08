using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Plugins.PluginManager
{
    class PluginLoader
    {
        private static List<string> GetListOfPlugin(string path)
        {
            List<string> dllFileNames = new List<string>();

            if (Directory.Exists(path))
                dllFileNames.AddRange(Directory.GetFiles(path, "*.dll"));

            return dllFileNames;
        }

        private static ICollection<Assembly> GetPluginAsDLL(List<string> dllFileNames)
        {
            ICollection<Assembly> assemblies = new List<Assembly>(dllFileNames.Count);
            foreach (string dllFile in dllFileNames)
            {
                AssemblyName an = AssemblyName.GetAssemblyName(dllFile);
                Assembly assembly = Assembly.Load(an);
                assemblies.Add(assembly);
            }
            return assemblies;
        }

        public static List<IPlugin> LoadPlugins(string path)
        {
            Type pluginType = typeof(IPlugin);
            ICollection<Assembly> assemblies = GetPluginAsDLL(GetListOfPlugin(path));
            ICollection<Type> pluginTypes = new List<Type>();
            foreach (Assembly assembly in assemblies)
            {
                if (assembly != null)
                {
                    Type[] types = assembly.GetTypes();
                    foreach (Type type in types)
                    {
                        if (type.IsInterface || type.IsAbstract)
                            continue;
                        else
                            if (type.GetInterface(pluginType.FullName) != null)
                                pluginTypes.Add(type);
                    }
                }
            }

            List<IPlugin>  plugins = new List<IPlugin>(pluginTypes.Count);
            foreach (Type type in pluginTypes)
            {
                IPlugin plugin = (IPlugin)Activator.CreateInstance(type);
                plugins.Add(plugin);
            }
            return plugins;
        }
    }
}
