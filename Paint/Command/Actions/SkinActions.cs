﻿using Paint.Command.ActionInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Command.Actions
{
    public class SkinActions
    {
        public class ActionChangeSkin : IAction
        {
            ICommand cmd;
            public ActionChangeSkin(ICommand cmd)
            {
                this.cmd = cmd;
            }
            public void Action(object sender, EventArgs e)
            {
            }
        }
    }
}
