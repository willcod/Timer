using System;
using System.Windows.Threading;
using Prism.Mvvm;

namespace Timer.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private string _content;

        private DateTime _startTime;

        public MainViewModel()
        {
            _startTime = DateTime.Now;

            var timer = new DispatcherTimer(DispatcherPriority.Normal);
            timer.Interval = TimeSpan.FromMilliseconds(5);
            timer.Tick += (sender, args) =>
            {
                Content = (DateTime.Now - _startTime).ToString(@"hh\:mm\:ss\.fff");
            };
            timer.Start();
        }

        public string Content
        {
            get { return _content; }
            set { SetProperty(ref _content, value); }
        }
    }
}