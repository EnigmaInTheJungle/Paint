
using Paint.Command.Actions;
using Paint.Data;
using Paint.UI.Frame;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Command
{
    public class XCommand
    {
        public FrameActions.ActionSaveAs SaveAs;
        public FrameActions.ActionOpen Open;
        public FrameActions.ActionStatus Status;
        public FrameActions.ActionSave Save;

        public TabActions.ActionAddPage AddPage;
        public TabActions.ActionRemovePage RemovePage;
        public TabActions.ActionRenamePage RenamePage;
        public TabActions.ActionActiveFigure ActiveFigure;
        public TabActions.ActionSelectPage SelectPage;
        public TabActions.ActionRemoveAllPages RemoveAllPages;

        public LanguageActions.ActionChangeLanguage ChangeLanguage;

        public CloudActions.ActionLoadCloud LoadCloud;
        public CloudActions.ActionSaveCloud SaveCloud;

        public PluginActions.ActionAddPlugin AddPlugin;
        public PluginActions.ActionRemovePlugin RemovePluginPlugin;

        public SkinActions.ActionChangeSkin ChangeSkin;


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

        public XData Data { get; set; }

        public Frame Frame { get; set; }

        public Action<Point> OnPointChange;

        public XCommand()
        {
            SaveAs = new FrameActions.ActionSaveAs(this);
            Open = new FrameActions.ActionOpen(this);
            Status = new FrameActions.ActionStatus(this);
            Save = new FrameActions.ActionSave(this);

            AddPage = new TabActions.ActionAddPage(this);
            RemovePage = new TabActions.ActionRemovePage(this);
            RenamePage = new TabActions.ActionRenamePage(this);
            ActiveFigure = new TabActions.ActionActiveFigure(this);
            SelectPage = new TabActions.ActionSelectPage(this);
            RemoveAllPages = new TabActions.ActionRemoveAllPages(this);

            ChangeLanguage = new LanguageActions.ActionChangeLanguage(this);

            LoadCloud = new CloudActions.ActionLoadCloud(this);
            SaveCloud = new  CloudActions.ActionSaveCloud(this);

            AddPlugin = new PluginActions.ActionAddPlugin(this);
            RemovePluginPlugin = new PluginActions.ActionRemovePlugin(this);

            ChangeSkin = new SkinActions.ActionChangeSkin(this);
        }      

    }
}
