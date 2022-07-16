namespace platfromServices.Models
{
    public interface IPlatformRepo
    {
        bool SaveChanges();
        IEnumerable<Platform> GetAll();
        Platform GetById(int id);
        void createPlatform(Platform platform);
    }
}