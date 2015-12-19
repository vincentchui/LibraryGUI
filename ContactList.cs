using System;
using System.Collections;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddressBook
{
    [Serializable]
    public partial class ContactList : ISerializable
    {
        public ArrayList _NameList;

        public ContactList()
        {
            _NameList = new ArrayList();
        }

        public ContactList(SerializationInfo info, StreamingContext ctext)
        {
            _NameList = (ArrayList)info.GetValue("List", typeof(ArrayList));
        }

        public void GetObjectData(SerializationInfo info, StreamingContext ctxt)
        {
            info.AddValue("List", _NameList);
        }

        public void AddBook(Book book)
        {
            _NameList.Add(book);
        }

        public ArrayList SearchBySubject(string s)
        {
            ArrayList resultList = new ArrayList();
            foreach(Book b in _NameList)
            {
                if(b.Subject.Contains(s))
                {
                    resultList.Add(b);
                }
            }
            return resultList;
        }

        public int Count()
        {
            return _NameList.Count;
        }
    }
}
