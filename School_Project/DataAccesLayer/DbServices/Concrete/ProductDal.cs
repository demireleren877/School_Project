using Microsoft.EntityFrameworkCore;
using School_Project.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School_Project.DataAccesLayer
{
    public class ProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            using (Context c = new Context())
            {
                var added = c.Entry(entity);
                added.State = EntityState.Added;
                c.SaveChanges();
            }
        }

        public Product Get(int id)
        {
            using (Context c = new Context())
            {
                return c.Set<Product>().FirstOrDefault(p => p.ID == id);
            }
        }

        public List<Product> GetList()
        {
            using (Context c = new Context())
            {
                var list = c.Products.ToList();
                return list;
            }
        }

        public void Remove(Product entity)
        {
            using (Context c = new Context())
            {
                var removed = c.Remove(entity);
                removed.State = EntityState.Deleted;
                c.SaveChanges();
            }
        }

        public void Update(Product entity)
        {
            using (Context c = new Context())
            {
                var updated = c.Update(entity);
                updated.State = EntityState.Modified;
                c.SaveChanges();
            }
        }
    }
}
