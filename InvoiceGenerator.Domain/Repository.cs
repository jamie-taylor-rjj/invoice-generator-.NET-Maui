using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceGenerator.Domain
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly InvoiceDbContext dbContext;
        private DbSet<T> entities;

        public Repository(InvoiceDbContext invoiceDbContext)
        {
            dbContext = invoiceDbContext;
            entities = dbContext.Set<T>();
        }

        public int Add(T item)
        {
            entities.Add(item);
            return dbContext.SaveChanges();
        }

        public List<T> GetAll()
        {
            return entities.ToList();
        }
    }
}
