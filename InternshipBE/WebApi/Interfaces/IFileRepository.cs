using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Model;

namespace WebApi.Repositories
{
    public interface IFileRepository
    {
        Task<List<FileDetail>> GetAllFiles();
        Task<FileDetail> GetFileById(int id);
        Task<FileDetail> Add(FileDetail fileDetail);
    }
}
