
using Paint.Command.ActionInterface;
using Paint.Command.Actions;
using Paint.UI.Frame;
using System;
using System.Drawing;
using PluginInterface;
using Paint.Managers;

namespace Paint.Command
{
    public class XCommand : ICommand
    {       
        public IAction SaveAs { get; }
        public IAction Open { get; }
        public IAction Status { get; }
        public IAction Save { get; }

        public IAction AddPage { get; }
        public IAction RemovePage { get; }
        public IAction RenamePage { get; }

        public IAction SelectPage { get; }
        public IAction RemoveAllPages { get; }

        public IAction ChangeLanguage { get; }

        public IAction LoadCloud { get; }
        public IAction SaveCloud { get; }

        public IAction AddPlugin { get; }
        public IAction RemovePlugin { get; }

        public IAction ChangeSkin { get; }

        public IAction SetActivePlugin { get; }
      
        Point _point;
        public Point Point
        {
            get
            {
                return _point;
            }
            set
            {
                _point = value;
                OnPointChange(_point);
            }
        }

        public IPluginContext ActivePluginContext { get; set; }
        public IPlugin ActivePlugin { get; set; }      

        public Action<Point> OnPointChange;

        public Frame Frame { get; set; }
        public PluginManager PluginManager => PluginManager.GetInstance();

        public XCommand()
        {
            SaveAs = new FrameActions.ActionSaveAs(this);
            Open = new FrameActions.ActionOpen(this);
            Status = new FrameActions.ActionStatus(this);
            Save = new FrameActions.ActionSave(this);

            AddPage = new TabActions.ActionAddPage(this);
            RemovePage = new TabActions.ActionRemovePage(this);
            RenamePage = new TabActions.ActionRenamePage(this);
            SelectPage = new TabActions.ActionSelectPage(this);
            RemoveAllPages = new TabActions.ActionRemoveAllPages(this);

            ChangeLanguage = new LanguageActions.ActionChangeLanguage(this);

            LoadCloud = new CloudActions.ActionLoadCloud(this);
            SaveCloud = new  CloudActions.ActionSaveCloud(this);

            AddPlugin = new PluginActions.ActionAddPlugin(this);
            RemovePlugin = new PluginActions.ActionRemovePlugin(this);
            SetActivePlugin = new PluginActions.ActionSetActivePlugin(this);

            ChangeSkin = new SkinActions.ActionChangeSkin(this);
        }      

    }
}
