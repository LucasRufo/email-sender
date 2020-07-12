using EmailSender.Data.Context;

namespace EmailSender.Biz.Base
{
    public abstract class BaseContext
    {
        protected Context _context;

        protected BaseContext()
        {
            if (_context == null)
                _context = new Context();
        }

        protected int Commit()  => _context.SaveChanges();
        
        protected void Dispose() => _context.Dispose();
        
    }
}
