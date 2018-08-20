using ChatBot.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace ChatBot.ViewModel
{
    public class ChatDiscussionViewModel : NotificationBase
    {
        private readonly string chatDetail = "";
        public ChatDiscussionViewModel(string chatDetails)
        {
            chatDetail = chatDetails;
        }
        public ChatDiscussionViewModel()
        {
            if (!string.IsNullOrEmpty(chatDetail))
            {
                var record = new ChatDiscussion()
                {
                    ChatDataBubble = chatDetail,
                    ChatTimeBubble = DateTime.Now,
                    IsSendByUserBubble = true,
                };
                if (record.IsSendByUserBubble)
                {
                    record.BubbleBackgroundBubble = (SolidColorBrush)(new BrushConverter().ConvertFrom("#FFFFFF"));
                    record.HorizontalAlignmentsBubble = "Right";
                }
                else
                {
                    record.BubbleBackgroundBubble = (SolidColorBrush)(new BrushConverter().ConvertFrom("#F9F9F9"));
                    record.HorizontalAlignmentsBubble = "Left";
                }
            }
        }
    }
}