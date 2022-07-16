using PlatformService.Data;
using platfromServices.Models;

namespace platfromServices.Data 
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _context;
        public PlatformRepo(AppDbContext context) => _context = context;
        
        public void createPlatform(Platform platform)
        {
            if(platform is null)
                throw new ArgumentNullException();
            _context.Platforms.Add(platform);

        }

        public IEnumerable<Platform> GetAll()
        {
           return  _context.Platforms.ToList();
        }

        public Platform GetById(int id)
        {
            return  _context.Platforms.FirstOrDefault(x=>x.Id==id);
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges()>=0;
        }
    }
}