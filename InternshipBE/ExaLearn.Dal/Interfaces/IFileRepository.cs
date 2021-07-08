using ExaLearn.Dal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Repositories
{
    public interface IFileRepository
    {
        Task<List<FileEntry>> GetAllFilesAsync();
        Task<FileEntry> GetFileByIdAsync(int id);
        Task<FileEntry> AddAsync(FileEntry fileEntry);
    }
}
