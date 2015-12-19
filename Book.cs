using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace AddressBook
{
    [Serializable]
    public class Book : ISerializable
    {
        private string _Title;
        private string _Author;
        private int _LCCN;
        private string _Subject;
        private string _Publisher;
        private string _Year;
        private string _Circulation;
        private static int _NextLCCN = 1001;

        public Book(string title, string author, string subject,
            string publisher, string year, string circulation)
        {
            _Title = title;
            _Author = author;
            _LCCN = _NextLCCN;
            _Subject = subject;
            _Publisher = publisher;
            _Year = year;
            _Circulation = circulation;
            _NextLCCN++;
        }

        public Book(SerializationInfo info, StreamingContext ctext)
        {
            _Title = (string)info.GetValue("Title", typeof(string));
            _Author = (string)info.GetValue("Author", typeof(string));
            _LCCN = (int)info.GetValue("LCCN", typeof(int));
            _Subject = (string)info.GetValue("Subject", typeof(string));
            _Publisher = (string)info.GetValue("Publisher", typeof(string));
            _Year = (string)info.GetValue("Year", typeof(string));
            _Circulation = (string)info.GetValue("Circulation", typeof(string));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("Title", _Title);
            info.AddValue("Author", _Author);
            info.AddValue("LCCN", _LCCN);
            info.AddValue("Subject", _Subject);
            info.AddValue("Publisher", _Publisher);
            info.AddValue("Year", _Year);
            info.AddValue("Circulation", _Circulation);
        }

        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                _Title = value;
            }
        }

        public string Author
        {
            get
            {
                return _Author;
            }
            set
            {
                _Author = value;
            }
        }

        public int LCCN
        {
            get
            {
                return _LCCN;
            }
            set
            {
                _LCCN = value;
            }
        }

        public string Subject
        {
            get
            {
                return _Subject;
            }
            set
            {
                _Subject = value;
            }
        }

        public string Publisher
        {
            get
            {
                return _Publisher;
            }
            set
            {
                _Publisher = value;
            }
        }

        public string Year
        {
            get
            {
                return _Year;
            }
            set
            {
                _Year = value;
            }
        }

        public string Circulation
        {
            get
            {
                return _Circulation;
            }
            set
            {
                _Circulation = value;
            }
        }
    }
}
