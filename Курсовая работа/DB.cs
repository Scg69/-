using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    public class DB
    {
        public List<Nick> nicks = new List<Nick>();
        public List<User> users = new List<User>();
        public List<Categoriy> categoriys = new List<Categoriy>();
        public List<Group> groups = new List<Group>();

        string filename = "Phone book";
        public void Save()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write))
            {
                
                binaryFormatter.Serialize(fs, nicks);
                binaryFormatter.Serialize(fs, users);
                binaryFormatter.Serialize(fs, categoriys);
                binaryFormatter.Serialize(fs, groups);


            }
        }
        public DB()
        {
            if (!File.Exists(filename))
            {
                return;
            }
            else
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
                {
                    nicks = ((List<Nick>)binaryFormatter.Deserialize(fs));
                    users = ((List<User>)binaryFormatter.Deserialize(fs));
                    categoriys =((List<Categoriy>)binaryFormatter.Deserialize(fs));
                    groups = ((List<Group>)binaryFormatter.Deserialize(fs));


                }
            }
        }
    }
}

