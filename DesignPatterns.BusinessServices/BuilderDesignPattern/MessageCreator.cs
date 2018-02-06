using DesignPatterns.BusinessServices.ABL;
using DesignPatterns.Model;

namespace DesignPatterns.BusinessServices
{
    public class MessageCreator
    {
        public Message Create(MessageBuilder builder)
        {
            builder.CreateMessageHeader();
            builder.CreateMessageContent();
            builder.CreateMessageSignature();

            return builder.m_Message;
        }
    }
}
