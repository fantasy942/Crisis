using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Crisis.Messages
{
    [Serializable]
    public abstract class Message
    {
        private static readonly BinaryFormatter formatter = new BinaryFormatter();

        public byte[] Serialize()
        {
            var stream = new MemoryStream();
            formatter.Serialize(stream, this);
            return stream.ToArray();
        }

        /// <summary>
        /// Attempts to infer the message type from bytes.
        /// </summary>
        public static bool TryInfer<T>(byte[] input, out T msg) where T : Message
        {
            try
            {
                msg = (T)formatter.Deserialize(new MemoryStream(input));
                return true;
            }
            catch
            {
                msg = null;
                return false;
            }
        }
    }
}
