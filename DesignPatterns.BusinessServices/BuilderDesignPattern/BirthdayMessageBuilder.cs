using DesignPatterns.BusinessServices.ABL;
using DesignPatterns.Model;

namespace DesignPatterns.BusinessServices
{
    public class BirthdayMessageBuilder : MessageBuilder
    {
        public BirthdayMessageBuilder() : base(MessageType.BirthdayMessage)
        {
        }

        public override void CreateMessageContent()
        {
            this.m_Message.m_MessageContent = "Happy birthday!";
        }

        public override void CreateMessageHeader()
        {
            this.m_Message.m_MessageHeader = "Birthday Message";
        }

        public override void CreateMessageSignature()
        {
            this.m_Message.m_MessageSignature = "Özgür Yapıcı";
            Message m= Display();
        }
    }
}
