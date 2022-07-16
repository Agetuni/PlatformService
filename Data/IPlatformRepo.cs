using platfromServices.Models;

namespace platfromServices.Data
{
    public interface IPlatformRepo
    {
        bool SaveChanges();
        IEnumerable<Platform> GetAll();
        Platform GetById(int id);
        void createPlatform(Platform platform);
    }
}