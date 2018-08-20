using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ChatBot.Models
{
    public class ChatBubble: NotificationBase
    {
        private bool _isSendByUser { get; set; }

        public bool IsSendByUser
        {
            get { return _isSendByUser; }
            set
            {
                _isSendByUser = value;
                NotifyChange(nameof(IsSendByUser));
            }
        }
        private string _chatData { get; set; }

        public string ChatData
        {
            get { return _chatData; }
            set { _chatData = value;
                NotifyChange(nameof(ChatData));
            }
        }
        private string _horizontalAlignments { get; set; }

        public string HorizontalAlignments
        {
            get { return _horizontalAlignments; }
            set
            {
                if (IsSendByUser)
                    _horizontalAlignments = "Left";
                else
                    _horizontalAlignments = "Right";
                _horizontalAlignments = value;
                NotifyChange(nameof(HorizontalAlignments));
            }
        }
        private Brush _bubbleBackground { get; set; }

        public Brush BubbleBackground
        {
            get
            {
                return _bubbleBackground;
            }
            set
            {
                _bubbleBackground = value;
            }
        }
        private DateTime _chatTime { get; set; }

        public DateTime ChatTime
        {
            get
            {
                return _chatTime;
            }
            set
            {
                _chatTime = value;
                NotifyChange(nameof(ChatTime));
            }
        }
    }
}
