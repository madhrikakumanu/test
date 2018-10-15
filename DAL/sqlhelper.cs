using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    class sqlhelper
    {
        const string CONNECTION_STRING = @"Data Source =localhost ;Intial Catalog=HRMS;User ID=sa; Password=Esrigis01";
        internal static DataTable ExecuteSelectCommand(string CommandName , CommandType cmdType)
    {

    }
    }
}
