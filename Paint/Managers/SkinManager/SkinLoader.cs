using SkinInterface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Managers
{
    class SkinLoader
    {
        private static List<string> GetListOfSkin(string path)
        {
            List<string> dllFileNames = new List<string>();

            if (Directory.Exists(path))
                dllFileNames.AddRange(Directory.GetFiles(path, "*.dll"));

            return dllFileNames;
        }

        private static ICollection<Assembly> GetSkinAsDLL(List<string> dllFileNames)
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

        public static List<ISkin> LoadSkins(string path)
        {
            Type skinType = typeof(ISkin);
            ICollection<Assembly> assemblies = GetSkinAsDLL(GetListOfSkin(path));
            ICollection<Type> skinsTypes = new List<Type>();
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
                            if (type.GetInterface(skinType.FullName) != null)
                            skinsTypes.Add(type);
                    }
                }
            }

            List<ISkin> skins = new List<ISkin>(skinsTypes.Count);
            foreach (Type type in skinsTypes)
            {
                ISkin skin = (ISkin)Activator.CreateInstance(type);
                skins.Add(skin);
            }
            return skins;
        }
    }
}
