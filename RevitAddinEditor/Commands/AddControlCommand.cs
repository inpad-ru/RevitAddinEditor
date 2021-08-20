﻿using CustomRevitControls;
using RevitAddinEditor.ViewModels;
using RevitAddinEditor.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RevitAddinEditor.Commands
{
    public class AddControlCommand : CommandBase
    {
        private PanelViewModel viewModel;

        public AddControlCommand(PanelViewModel vm) => viewModel = vm;

        public override void Execute(object parameter)
        {
            Control control = null;

            switch (viewModel.ControlType)
            {
                case ControlType.Regular:
                    control = new RegularButton();
                    break;
                case ControlType.Pulldown:
                    control = new PulldownButton();
                    break;
                case ControlType.SplitButton:
                    control = new SplitItem();
                    break;
                case ControlType.StackButton:
                    control = new StackButton();
                    break;
                case ControlType.StackedPulldown:
                    control = new StackedPulldown();
                    break;
                case ControlType.StackedSplitItem:
                    control = new StackedSplitItem();
                    break;
                case ControlType.StackedItem:
                    control = new StackItem();
                    break;
                case ControlType.TextBox:
                    control = new TextBoxItem();
                    break;
                default:
                    break;
            }

            viewModel.Controls.Add(control);
        }
    }
}
