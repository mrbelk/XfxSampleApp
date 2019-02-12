using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XfxSampleApp.ViewModels
{
	public class MainPageViewModel : ViewModelBase
	{
		public MainPageViewModel(INavigationService navigationService)
			: base(navigationService)
		{
			Title = "Main Page";
		}

        private string _testText;
        public string TestText
        {
            get { return _testText; }
            set { SetProperty(ref _testText, value); }
        }
    }
}
