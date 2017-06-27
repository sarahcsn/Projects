using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ModelSalarie
{
    class SalarieExceptions : ApplicationException, ISerializable
    {
        private string _idMessage = string.Empty;

        /// <summary>
        /// Identifiant du Message
        /// </summary>
        public string IdMessage
        {
            get
            {
                return _idMessage;
            }

            set
            {
                _idMessage = value;
            }
        }

        public SalarieExceptions()
            : base()
        { }

        public SalarieExceptions(string IdMessage, string message) : base (message)
        {
            _idMessage = IdMessage;
        }

        public SalarieExceptions(string IdMessage, string message, Exception inner) : base(message, inner)
        {
            _idMessage = IdMessage;
        }

        protected SalarieExceptions(SerializationInfo info, StreamingContext context) : base(info, context)
        { }
    }
}
