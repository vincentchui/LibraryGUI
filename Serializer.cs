using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Serializer
    {
        public Serializer()
        {

        }

        public void CreateNewFile(string fileName)
        {
            Stream stream = File.Create(fileName);
            stream.Close();
        }

        public void SerializeObject(string fileName, ContactList contactList)
        {
            Stream stream = File.Open(fileName, FileMode.OpenOrCreate);
            BinaryFormatter bFormatter = new BinaryFormatter();
            bFormatter.Serialize(stream, contactList);
            stream.Close();
        }

        public ContactList DeSerializeObject(string fileName)
        {
            ContactList contactList;
            Stream stream = File.Open(fileName, FileMode.Open);
            BinaryFormatter bFormatter = new BinaryFormatter();
            contactList = (ContactList)bFormatter.Deserialize(stream);
            stream.Close();
            return contactList;
        }
    }
}