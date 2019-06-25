using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    class EnableComponent
    {
        public delegate void MyEvent(int userRole);
        public static MyEvent EventHandler;
    }
    
}
