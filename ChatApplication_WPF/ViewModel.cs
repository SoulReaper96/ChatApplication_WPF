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
        public ObservableCollection<StatusDataModel> StatusThumbs { get; set; }

        public ViewModel() 
        {
            StatusThumbs =
            [
                new() 
                {
                    IsMeAddStatus = true
                },
                new() 
                {
                    ContactName = "Mike",
                    ContactPhoto = new Uri("G:/Studies/ChatApplication_WPF/ChatApplication_WPF/Images/user1.jpg", UriKind.RelativeOrAbsolute),
                    StatusImage = new Uri("G:/Studies/ChatApplication_WPF/ChatApplication_WPF/Images/status1.jpg", UriKind.RelativeOrAbsolute),
                    IsMeAddStatus = false
                },
                new()
                {
                    ContactName = "Jane",
                    ContactPhoto = new Uri("G:/Studies/ChatApplication_WPF/ChatApplication_WPF/Images/user4.jpg", UriKind.RelativeOrAbsolute),
                    StatusImage = new Uri("G:/Studies/ChatApplication_WPF/ChatApplication_WPF/Images/status2.jpg", UriKind.RelativeOrAbsolute),
                    IsMeAddStatus = false
                },
                new()
                {
                    ContactName = "Stella",
                    ContactPhoto = new Uri("G:/Studies/ChatApplication_WPF/ChatApplication_WPF/Images/user0.jpg", UriKind.RelativeOrAbsolute),
                    StatusImage = new Uri("G:/Studies/ChatApplication_WPF/ChatApplication_WPF/Images/status3.jpg", UriKind.RelativeOrAbsolute),
                    IsMeAddStatus = false
                },
                new()
                {
                    ContactName = "Joe",
                    ContactPhoto = new Uri("G:/Studies/ChatApplication_WPF/ChatApplication_WPF/Images/user3.jpg", UriKind.RelativeOrAbsolute),
                    StatusImage = new Uri("G:/Studies/ChatApplication_WPF/ChatApplication_WPF/Images/status4.jpg", UriKind.RelativeOrAbsolute),
                    IsMeAddStatus = false
                },
            ];

            OnPropertyChanged(nameof(StatusThumbs));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
