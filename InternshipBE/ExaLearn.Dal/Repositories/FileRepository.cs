using ExaLearn.Dal.Database;
using ExaLearn.Dal.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Repositories
{
    public class FileRepository : IFileRepository
    {
        private ExaLearnDbContext appDbContext;
        public FileRepository(ExaLearnDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<List<FileEntry>> GetAllFilesAsync()
        {
            return await appDbContext.FileEntry.ToListAsync();
        }

        public async Task<FileEntry> GetFileByIdAsync(int id)
        {
            return await appDbContext.FileEntry.FirstOrDefaultAsync(file => file.Id == id);
        }

        public async Task<FileEntry> AddAsync(FileEntry fileEntry)
        {
            await appDbContext.FileEntry.AddAsync(fileEntry);
            await appDbContext.SaveChangesAsync();
            return fileEntry;
        }
    }
}
