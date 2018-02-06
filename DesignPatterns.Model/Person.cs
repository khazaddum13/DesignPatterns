namespace DesignPatterns.Model
{
    public class Person : Base
    {
        public string Name
        {
            get
            {
                return m_Name;
            }
            set
            {
                m_Name = value;
            }
        }

        public string Surname
        {
            get
            {
                return m_Surname;
            }
            set
            {
                m_Surname = value;
            }
        }

        public int Age
        {
            get
            {
                return m_Age;
            }
            set
            {
                m_Age = value;
            }
        }

        private string m_Name;

        private string m_Surname;

        private int m_Age;
    }
}
