using System;
using System.Windows.Input;
using Prism.Commands;

namespace MvvmAppClassRef.ViewModels
{
	internal class MainViewModel : Prism.Mvvm.BindableBase
	{
		public int _count = 0;
		public int Count
		{
			get => _count;
			set => SetProperty(ref _count, value, nameof(Count));
		}
		public ICommand OnButtonClicked { get; private set; }

		public MainViewModel()
		{
			OnButtonClicked = new DelegateCommand(CountUp);
		}

		private void CountUp()
		{
			this.Count++;
		}
	}
}

