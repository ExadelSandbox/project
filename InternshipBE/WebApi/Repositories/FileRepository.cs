using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Database;
using WebApi.Model;

namespace WebApi.Repositories
{
    public class FileRepository : IFileRepository
    {
        private AppDbContext appDbContext;
        public FileRepository(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public async Task<List<FileDetail>> GetAllFiles()
        {
            return await appDbContext.FileDetails.ToListAsync();
        }

        public async Task<FileDetail> GetFileById(int id)
        {
            return await appDbContext.FileDetails.FirstOrDefaultAsync(file => file.Id == id);
        }

        public async Task<FileDetail> Add(FileDetail fileDetail)
        {
            await appDbContext.FileDetails.AddAsync(fileDetail);
            await appDbContext.SaveChangesAsync();
            return fileDetail;
        }
    }
}
