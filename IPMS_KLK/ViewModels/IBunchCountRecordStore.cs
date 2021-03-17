using IPMS_KLK.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IPMS_KLK.ViewModels
{
    public interface IBunchCountRecordStore
    {
        Task<IEnumerable<BunchCountRecord>> GetBunchCountRecordAsync();
        Task<BunchCountRecord> GetBunchCountRecord(int transNo);
        Task AddBunchCountRecord(BunchCountRecord bunchCountRecord);
        Task UpdateBunchCountRecord(BunchCountRecord bunchCountRecord);
        Task DeleteBunchCountRecord(BunchCountRecord bunchCountRecord);
    }
}
