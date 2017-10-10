using Paint.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Managers
{
    class LanguageManager
    {
        public enum Language { Russian, English, Ukrainian}

        private static LanguageManager instance = new LanguageManager();
        private Language _currentLanguage = Language.English;
        private ResourceManager _resourceManager;

        private LanguageManager()
        {
            _resourceManager = new ResourceManager(GetResourcePath(_currentLanguage), Assembly.GetExecutingAssembly());
        }

        public static LanguageManager GetInstance()
        {
            return instance;
        }

        public void SetLanguage(Language language)
        {
            _currentLanguage = language;
        }

        private string GetResourcePath(Language language)
        {
            switch(language)
            {
                case Language.English: return "Paint.Resources.Localization.EnglishLanguage";
                default: return "Paint.Resources.Localization.EnglishLanguage";
            }
        }

        public string GetValue(string key)
        {
            return _resourceManager.GetString(key);
        }
    }
}
