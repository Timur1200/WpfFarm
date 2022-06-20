using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfFarm
{
    partial class АктСписанияКормов
    {
        public string Date
        {
            get
            {
                if (Дата == null) return string.Empty;
                return Дата.Value.ToString("D");
            }
        }
    }
}
