using Crisis.Messages;

namespace Crisis.Model
{
    public interface IMessageSender
    {
        void Send(Message msg);
    }
}
