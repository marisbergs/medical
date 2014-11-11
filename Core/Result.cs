using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public enum MessageSeverity
    {
        Info = 0,
        Warning = 1,
        Error = 2
    }

    public struct Message
    {
        public Message(MessageSeverity severity, string code, params object [] parameters)
        {
            Severity = severity;
            Code = code;
            Text = Localization.Instance[code, parameters];
        }

        public Message(MessageSeverity severity, Err errMsg, params object[] parameters)
        {
            Severity = severity;
            Code = ErrMsg.GetCode(errMsg);
            Text = ErrMsg.GetText(errMsg, parameters);
        }

        public Message(MessageSeverity severity, Msg infoMsg, params object[] parameters)
        {
            Severity = severity;
            Code = ErrMsg.GetCode(infoMsg);
            Text = ErrMsg.GetText(infoMsg, parameters);
        }

        public string Text;
        public string Code;
        public MessageSeverity Severity;

    }

    public class Result
    {
        public Result() : this ( false )
        {            
        }

        public Result ( bool hasErrors )
        {
            Messages = new List<Message>();
            HasErrors = hasErrors;
        }
        public List<Message> Messages;
        public bool HasErrors;

        public string ErrorString
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (Message message in Messages)
                {
                    sb.Append(message.Text).Append(' ');
                }
                return sb.ToString();
            }
        }

        
        
        public static Result operator +(Result op1, Result op2)
        {
            op1.HasErrors |= op2.HasErrors;
            op1.Messages.AddRange(op2.Messages);
            return op1;
        }

    }
}
