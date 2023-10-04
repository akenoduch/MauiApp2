using System;
using System.ComponentModel;

namespace MauiApp2.Services
{
    public class UserService : INotifyPropertyChanged
    {
        private UserInfo currentUser;

        public UserInfo CurrentUser
        {
            get { return currentUser; }
            set
            {
                if (currentUser != value)
                {
                    currentUser = value;
                    OnPropertyChanged(nameof(CurrentUser));
                }
            }
        }

        // Singleton Instance
        private static readonly UserService instance = new UserService();

        private UserService() { }

        public static UserService Instance
        {
            get { return instance; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
