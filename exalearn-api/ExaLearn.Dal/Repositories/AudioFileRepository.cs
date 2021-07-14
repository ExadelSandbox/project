using ExaLearn.Dal.Database;
using ExaLearn.Dal.Interfaces;
using ExaLearn.Dal.Model;

namespace ExaLearn.Dal.Repositories
{
    public class AudioFileRepository : GenericRepository<AudioFile>, IAudioFileRepository
    {
        public AudioFileRepository(ExaLearnDbContext appDbContext) : base(appDbContext)
        {

        }
    }
}
