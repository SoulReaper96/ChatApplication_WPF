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
        #region Status Thumbs

        #region Properties
        public ObservableCollection<StatusDataModel> StatusThumbs { get; set; }
        #endregion

        private void LoadStatusThumbs()
        {
            try
            {
                StatusThumbs =
            [
            new StatusDataModel
            {
                IsMeAddStatus = true
            },
            new StatusDataModel
            {
                ContactName = "Mike",
                ContactPhoto = new Uri("G:/Studies/ChatApplication_WPF/ChatApplication_WPF/Images/user1.jpg", UriKind.RelativeOrAbsolute),
                StatusImage = new Uri("G:/Studies/ChatApplication_WPF/ChatApplication_WPF/Images/status1.jpg", UriKind.RelativeOrAbsolute),
                IsMeAddStatus = false
            },
            new StatusDataModel
            {
                ContactName = "Jane",
                ContactPhoto = new Uri("G:/Studies/ChatApplication_WPF/ChatApplication_WPF/Images/user4.jpg", UriKind.RelativeOrAbsolute),
                StatusImage = new Uri("G:/Studies/ChatApplication_WPF/ChatApplication_WPF/Images/status2.jpg", UriKind.RelativeOrAbsolute),
                IsMeAddStatus = false
            },
            new StatusDataModel
            {
                ContactName = "Stella",
                ContactPhoto = new Uri("G:/Studies/ChatApplication_WPF/ChatApplication_WPF/Images/user0.jpg", UriKind.RelativeOrAbsolute),
                StatusImage = new Uri("G:/Studies/ChatApplication_WPF/ChatApplication_WPF/Images/status3.jpg", UriKind.RelativeOrAbsolute),
                IsMeAddStatus = false
            },
            new StatusDataModel
            {
                ContactName = "Joe",
                ContactPhoto = new Uri("G:/Studies/ChatApplication_WPF/ChatApplication_WPF/Images/user3.jpg", UriKind.RelativeOrAbsolute),
                StatusImage = new Uri("G:/Studies/ChatApplication_WPF/ChatApplication_WPF/Images/status4.jpg", UriKind.RelativeOrAbsolute),
                IsMeAddStatus = false
            }
            ];

                OnPropertyChanged(nameof(StatusThumbs));
            }
            catch (Exception ex)
            {
                // Handle the exception here or log it for debugging
                Console.WriteLine($"An error occurred in LoadStatusThumbs method: {ex.Message}");
                throw;
            }
        }
        #endregion

        #region Chat List

        #region Properties
        public ObservableCollection<ChatListData> Chats { get; set; }
        #endregion

        private void LoadChats()
        {
            try
            {
                Chats =
            [
            new ChatListData
            {
                ContactName = "Stella",
                ContactPhoto = new Uri("G:/Studies/ChatApplication_WPF/ChatApplication_WPF/Images/user0.jpg", UriKind.RelativeOrAbsolute),
                Message = "Hello, how are you?",
                LastMessageTime = "Tue, 11:30 AM",
                ChatIsSelected = true
            },
            new ChatListData
            {
                ContactName = "Joe",
                ContactPhoto = new Uri("G:/Studies/ChatApplication_WPF/ChatApplication_WPF/Images/user3.jpg", UriKind.RelativeOrAbsolute),
                Message = "I haven't seen you in a long time, how are you?",
                LastMessageTime = "Sun, 10:21 AM",
                ChatIsSelected = true
            },
            new ChatListData
            {
                ContactName = "Mike",
                ContactPhoto = new Uri("G:/Studies/ChatApplication_WPF/ChatApplication_WPF/Images/user1.jpg", UriKind.RelativeOrAbsolute),
                Message = "Where are you? I am in the city.",
                LastMessageTime = "Fri, 17:20 PM",
                ChatIsSelected = true
            },
            new ChatListData
            {
                ContactName = "Jane",
                ContactPhoto = new Uri("G:/Studies/ChatApplication_WPF/ChatApplication_WPF/Images/user4.jpg", UriKind.RelativeOrAbsolute),
                Message = "I'm so glad you are doing well!",
                LastMessageTime = "Thurs, 15:00 PM",
                ChatIsSelected = true
            }
            ];

                OnPropertyChanged(nameof(Chats));
            }
            catch (Exception ex)
            {
                // Handle the exception here or log it for debugging
                Console.WriteLine($"An error occurred in LoadStatusThumbs method: {ex.Message}");
                throw;
            }
        }
        #endregion

        public ViewModel() 
        {
            LoadStatusThumbs();
            LoadChats();
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
