using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhanMemQLNS.LQTOSQL;


namespace PhanMemQLNS
{
    class Class_connect
    {
        DataClasses_NSDataContext data;
        public Class_connect()
        {
            data = new DataClasses_NSDataContext();
        }

        public DataClasses_NSDataContext database()
        {
            return data;
        }
    }
}
