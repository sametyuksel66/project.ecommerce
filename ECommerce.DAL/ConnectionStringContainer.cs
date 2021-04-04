using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.DAL
{
    class ConnectionStringContainer
    {
        internal static string ConnectionString
        {
            get
            {
                return "Server=.;Database=E-CommerceDB;  Integrated Security=true";
            }
        }
    }
}
