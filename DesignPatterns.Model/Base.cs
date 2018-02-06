using System;
using System.Runtime.Serialization;

namespace DesignPatterns.Model
{
    public class Base : ICloneable, ISerializable, IDisposable
    {
        public Base()
        {
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public void Dispose()
        {
            this.Dispose();
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
