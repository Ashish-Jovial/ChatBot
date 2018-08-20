using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ChatBot.Models
{
    public class ChatDiscussion : NotificationBase
    {
        private bool _isSendByUserBubble;
        public bool IsSendByUserBubble
        {
            get { return _isSendByUserBubble; }
            set
            {
                _isSendByUserBubble = value;
                NotifyChange(nameof(IsSendByUserBubble));
            }
        }

        private string _chatDataBubble { get; set; }
        public string ChatDataBubble
        {
            get { return _chatDataBubble; }
            set
            {
                _chatDataBubble = value;
                NotifyChange(nameof(ChatDataBubble));
            }
        }

        private string _horizontalAlignmentsBubble { get; set; }
        public string HorizontalAlignmentsBubble
        {
            get { return _horizontalAlignmentsBubble; }
            set
            {
                if (IsSendByUserBubble)
                    _horizontalAlignmentsBubble = "Left";
                else
                    _horizontalAlignmentsBubble = "Right";
                _horizontalAlignmentsBubble = value;
                NotifyChange(nameof(HorizontalAlignmentsBubble));
            }
        }

        private Brush _bubbleBackgroundBubble { get; set; }
        public Brush BubbleBackgroundBubble
        {
            get
            {
                return _bubbleBackgroundBubble;
            }
            set
            {
                _bubbleBackgroundBubble = value;
            }
        }

        private DateTime _chatTimeBubble { get; set; }
        public DateTime ChatTimeBubble
        {
            get
            {
                return _chatTimeBubble;
            }
            set
            {
                _chatTimeBubble = value;
                NotifyChange(nameof(ChatTimeBubble));
            }
        }
    }
}
