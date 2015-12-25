using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollector
{
    public class DatabaseConnector : IDisposable
    {
        public void Dispose()
        {
            // close accesss to database...
        }

        public void OpenAccessToDatabase()
        {
            // opens access to database without closing it
        }
    }
}
