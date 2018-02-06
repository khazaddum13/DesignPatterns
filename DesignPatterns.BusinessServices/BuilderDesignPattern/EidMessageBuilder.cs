using DesignPatterns.BusinessServices.ABL;
using DesignPatterns.Model;

namespace DesignPatterns.BusinessServices
{
    public class EidMessageBuilder : MessageBuilder
    {
        public EidMessageBuilder() : base(MessageType.EidMessage)
        {
        }

        public override void CreateMessageContent()
        {
            this.m_Message.m_MessageContent = "Happy Holidays!";
        }

        public override void CreateMessageHeader()
        {
            this.m_Message.m_MessageHeader = "Eid Message";
        }

        public override void CreateMessageSignature()
        {
            this.m_Message.m_MessageSignature = "Özgür Yapıcı";
        }
    }
}
