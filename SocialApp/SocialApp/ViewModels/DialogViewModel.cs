using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.AppModel;
using Prism.Services.Dialogs;

namespace SocialApp.ViewModels
{
    public class DialogViewModel : BindableBase, IDialogAware, IAutoInitialize
    {
        public DialogViewModel()
        {
            CloseCommand = new DelegateCommand(() => RequestClose(null));
        }

        private string title = "Alert";
        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }

        private string message;
        [AutoInitialize(true)]
        public string Message
        {
            get => message;
            set => SetProperty(ref message, value);
        }

        public DelegateCommand CloseCommand { get; }

        public event Action<IDialogParameters> RequestClose;

        public bool CanCloseDialog() => true;

        public void OnDialogClosed()
        {
            Console.WriteLine("The Demo Dialog has been closed...");
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
            // If not using IAutoInitialize you would need to set the Message property here.
            // Message = parameters.GetValue<string>("message");
        }
    }
}
