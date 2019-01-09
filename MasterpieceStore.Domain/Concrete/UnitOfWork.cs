using MasterpieceStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterpieceStore.Domain.Concrete
{
    public class UnitOfWork : IDisposable
    {
        private AppDbContext context = new AppDbContext();
        private GenericRepository<Product> productRepository;
        private GenericRepository<Author> authorRepository;

        public GenericRepository<Author> AuthorRepository
        {
            get
            {

                if (this.authorRepository == null)
                {
                    this.authorRepository = new GenericRepository<Author>(context);
                }
                return authorRepository;
            }
        }

        public GenericRepository<Product> ProductRepository
        {
            get
            {

                if (this.productRepository == null)
                {
                    this.productRepository = new GenericRepository<Product>(context);
                }
                return productRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
