﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CustomViewCell
{
    #region Model

    public class BookInfo : INotifyPropertyChanged
    {
        private string bookName;
        private string bookDesc;

        public string BookName
        {
            get { return bookName; }
            set
            {
                bookName = value;
                OnPropertyChanged("BookName");
            }
        }

        public string BookDescription
        {
            get { return bookDesc; }
            set
            {
                bookDesc = value;
                OnPropertyChanged("BookDescription");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
    #endregion
}
