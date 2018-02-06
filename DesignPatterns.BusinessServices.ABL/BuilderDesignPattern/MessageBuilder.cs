using DesignPatterns.Model;

namespace DesignPatterns.BusinessServices.ABL
{
    public abstract class MessageBuilder
    {
        public abstract void CreateMessageHeader();

        public abstract void CreateMessageContent();

        public abstract void CreateMessageSignature();

        private Message message;

        public Message m_Message { get { return message; } }

        public MessageBuilder(MessageType messageType)
        {
            this.message = new Message(messageType);
        }

        public Message Display()
        {
            return this.message;
        }
    }
}
