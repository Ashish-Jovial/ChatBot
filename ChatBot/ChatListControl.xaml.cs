using ChatBot.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ChatBot.ViewModel;
namespace ChatBot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class ChatListControl : UserControl
    {
        private string chatText = "";
        public ChatListControl()
        {
            InitializeComponent();
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter && !string.IsNullOrEmpty(txtChatBox.Text))
            {
                GetData();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtChatBox.Text))
            {
                GetData();
            }
        }

        private void GetData()
        {
            chatText = txtChatBox.Text;
            ChatDiscussionViewModel discussion = new ChatDiscussionViewModel(chatText);
            txtChatBox.Text = string.Empty;
        }
    }
}
