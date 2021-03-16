using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace IPMS_KLK.Services
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
