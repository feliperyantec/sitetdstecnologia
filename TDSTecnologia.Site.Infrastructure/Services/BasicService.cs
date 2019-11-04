using TDSTecnologia.Site.Infrastructure.Data;

namespace TDSTecnologia.Site.Infrastructure.Services
{
    public class BasicService
    {
        protected readonly AppContexto _context;

        public BasicService(AppContexto context)
        {
            _context = context;
        }

        protected bool SaveChangesApp()
        {
          return _context.SaveChanges() == 1;
        }
    }
}
