using SkinInterface;
using System.Collections.Generic;
using System.Linq;

namespace Paint.Managers
{
    class SkinManager
    {
        private static SkinManager instance = new SkinManager();
        public ISkin _currentSkin;

        public List<ISkin> Skins { get; private set; }
        public ISkin Skin => _currentSkin;

        private SkinManager()
        {

        }

        public void LoadSkins(string path = @"E:\ORT_1708\Team\Paint\Skins")
        {
            Skins = SkinLoader.LoadSkins(path);
            _currentSkin = GetSkinByName("Light");
        }

        public static SkinManager GetInstance()
        {
            return instance;
        }

        public void ChangeSkin(string skinName)
        {
            _currentSkin = GetSkinByName(skinName);
        }

        private ISkin GetSkinByName(string name)
        {
            return Skins.First(x => x.Name == name);
        }
    }
}
