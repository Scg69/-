using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая_работа
{
    [Serializable]
    public class Nick
    {
        public string Name { get; set; }

        public string Fname { get; set; }

        public string Oname { get; set; }

        public Phone phone { get; set; }

        public string Adres { get; set; }
        public string  Email { get; set; }
        public string Notes { get; set; }
        public Categoriy categoriy { get; set; }

        public Group group { get; set; }
    }
}
