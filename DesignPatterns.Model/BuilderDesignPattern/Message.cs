namespace DesignPatterns.Model
{
    public class Message
    {
        public string m_MessageHeader { get; set; }
        public string m_MessageContent { get; set; }
        public string m_MessageSignature { get; set; }
        private MessageType m_MessageType { get; set; }
        public Message(MessageType messageType)
        {
            this.m_MessageType = messageType;
        }
    }
}
