﻿
using Paint.Command;
using Paint.Command.ActionInterface;
using PaintTests.UnitTest.Actions;
using System;
using PluginInterface;
using Paint.Managers;
using Paint.UI.Frame;

namespace PaintTests.UnitTest.Command
{
    public class UCommand : ICommand
    {
        public IAction SaveAs { get; }
        public IAction Open { get; }
        public IAction Status { get; }
        public IAction Save { get; }

        public IAction AddPage { get; }
        public IAction RemovePage { get; }
        public IAction RenamePage { get; }
        public IAction ActiveFigure { get; }
        public IAction SelectPage { get; }
        public IAction RemoveAllPages { get; }

        public IAction ChangeLanguage { get; }

        public IAction LoadCloud { get; }
        public IAction SaveCloud { get; }

        public IAction AddPlugin { get; }
        public IAction RemovePlugin { get; }

        public IAction ChangeSkin { get; }
    
        public IPlugin ActivePlugin { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        public IPluginContext ActivePluginContext { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
        
        public IAction SetActivePlugin
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        IPluginContext ICommand.ActivePluginContext
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        IPlugin ICommand.ActivePlugin
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public Frame Frame
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public PluginManager PluginManager
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string Result;

        public UCommand()
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
            SaveCloud = new CloudActions.ActionSaveCloud(this);

            AddPlugin = new PluginActions.ActionAddPlugin(this);
            RemovePlugin = new PluginActions.ActionRemovePlugin(this);

            ChangeSkin = new SkinActions.ActionChangeSkin(this);
        }
    }
}
