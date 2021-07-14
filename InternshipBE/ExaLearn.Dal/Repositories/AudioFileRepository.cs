using ExaLearn.Dal.Database;
using ExaLearn.Dal.Interfaces;
using ExaLearn.Dal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExaLearn.Dal.Repositories
{
    public class AudioFileRepository : GenericRepository<AudioFile>, IAudioFileRepository
    {
        public AudioFileRepository(ExaLearnDbContext appDbContext) : base(appDbContext)
        {

        }


    }
}
