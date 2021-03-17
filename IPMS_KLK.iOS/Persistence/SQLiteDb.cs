using IPMS_KLK.iOS.Persistence;
using SQLite;
using System;
using System.IO;
using Xamarin.Forms;

[assembly:Dependency(typeof(SQLiteDb))]

namespace IPMS_KLK.iOS.Persistence
{
    public class SQLiteDb
    {
        public SQLiteAsyncConnection GetConnection()
        {
            var documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            var path = Path.Combine(documentsPath, "KLK_MobileApp.db3");
            return new SQLiteAsyncConnection(path);
        }
    }
}