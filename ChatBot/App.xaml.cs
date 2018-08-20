using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ChatBot.Models;

namespace ChatBot
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public System.Collections.ObjectModel.ObservableCollection<ChatBubble> _chatBubbleData = new System.Collections.ObjectModel.ObservableCollection<ChatBubble>();
    }
}
