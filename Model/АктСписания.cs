using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfFarm
{
    partial class АктСписанияКормов
    {
        public string Sum
        {
            get
            {
                return $"{Количество * Корм.Цена}";
            }
        }
    }
}
