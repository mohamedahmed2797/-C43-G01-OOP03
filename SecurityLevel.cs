using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_oop_3
{
    [Flags]
    internal enum SecurityLevel
    {
        Delete = 1,
        Execute = 2,
        Read = 4,
        Write = 8,
        FullAccess = Read | Write | Delete | Execute
    }
}
