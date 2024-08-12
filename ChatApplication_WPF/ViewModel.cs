using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication_WPF
{
    public class ViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<StatusDataModel> statusThumbs { get; set; }

        public ViewModel() 
        {
            statusThumbs =
            [
                new() 
                {
                    IsMeAddStatus = true
                },
                new() 
                {
                    ContactName = "Mike",
                    ContactImage = new Uri("G:/Studies/ChatApplication_WPF/ChatApplication_WPF/Images/user1.png", UriKind.RelativeOrAbsolute),
                    StatusImage = new Uri("G:/Studies/ChatApplication_WPF/ChatApplication_WPF/Images/status1.jpg", UriKind.RelativeOrAbsolute),
                    IsMeAddStatus = false
                },
                new()
                {
                    ContactName = "Stella",
                    ContactImage = new Uri("G:/Studies/ChatApplication_WPF/ChatApplication_WPF/Images/user2.png", UriKind.RelativeOrAbsolute),
                    StatusImage = new Uri("G:/Studies/ChatApplication_WPF/ChatApplication_WPF/Images/status2.jpg", UriKind.RelativeOrAbsolute),
                    IsMeAddStatus = false
                },
                new()
                {
                    ContactName = "John",
                    ContactImage = new Uri("G:/Studies/ChatApplication_WPF/ChatApplication_WPF/Images/user3.png", UriKind.RelativeOrAbsolute),
                    StatusImage = new Uri("G:/Studies/ChatApplication_WPF/ChatApplication_WPF/Images/status3.jpg", UriKind.RelativeOrAbsolute),
                    IsMeAddStatus = false
                },
            ];

            OnPropertyChanged(nameof(statusThumbs));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
