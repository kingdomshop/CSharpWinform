using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppTest
{
    class SerializerDemo
    {
        public Person Serializer()
        {
            BinaryFormatter serializer = new BinaryFormatter();

            Person xiaoMing = new Person("战鹰",8,"meale","美团骑手");

            MemoryStream memoryStream = new MemoryStream();

            serializer.Serialize(memoryStream, xiaoMing);

            Person xiaoWang = new Person();
            memoryStream.Position = 0;
            xiaoWang = serializer.Deserialize(memoryStream) as Person;


            memoryStream.Close();

            return xiaoWang;
        }
    }
}
