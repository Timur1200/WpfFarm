using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfFarm
{
    partial class EFContext
    {
        private static EFContext _context;
        public static EFContext Context
        {
            get
            {
                if (_context == null) _context = new EFContext();
                return _context;
            }
           
        }
    }
}
