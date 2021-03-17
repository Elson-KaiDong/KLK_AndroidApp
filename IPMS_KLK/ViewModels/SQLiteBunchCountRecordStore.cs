using IPMS_KLK.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using IPMS_KLK.Persistence;

namespace IPMS_KLK.ViewModels
{
    public class SQLiteBunchCountRecordStore : IBunchCountRecordStore
    {
        private SQLiteAsyncConnection _connection;
        public SQLiteBunchCountRecordStore(ISQLiteDb db)
        {
            _connection = db.GetConnection();
            _connection.CreateTableAsync<BunchCountRecord>();
        }

        public async Task AddBunchCountRecord(BunchCountRecord bunchCountRecord)
        {
            await _connection.InsertAsync(bunchCountRecord);
        }

        public async Task DeleteBunchCountRecord(BunchCountRecord bunchCountRecord)
        {
            await _connection.DeleteAsync(bunchCountRecord);
        }

        public async Task<BunchCountRecord> GetBunchCountRecord(int transNo)
        {
            return await _connection.FindAsync<BunchCountRecord>(transNo);
        }

        public async Task<IEnumerable<BunchCountRecord>> GetBunchCountRecordAsync()
        {
            return await _connection.Table<BunchCountRecord>().ToListAsync();
        }

        public async Task UpdateBunchCountRecord(BunchCountRecord bunchCountRecord)
        {
            await _connection.UpdateAsync(bunchCountRecord);
        }
    }
}
