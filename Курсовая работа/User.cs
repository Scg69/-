using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    [Serializable]
    public class User
    {
        public string Name { get; set; }
        public string Parol { get; set; }
        public Phone phone { get; set; }
    }
}
