using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Entities;

namespace Tienda.DataAccess
{
    public class ProductDAL
    {
        private static ProductDAL _instance;

        public static ProductDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ProductDAL();
                }
                return _instance;
            }
        }


        public List<Product> SelectAll()
        {
            List<Product> result = null;

            using (TiendaDBContext _repo = new TiendaDBContext())
            {
                result = _repo.Products.ToList();
            }

            return result;
        }

        public Product SelectById(int id)
        {
            Product result = null;

            using (TiendaDBContext _repo = new TiendaDBContext())
            {
                result = _repo.Products.FirstOrDefault(x => x.ProductId.Equals(id));
            }

            return result;
        }


        //Metodo de la clase producto
        //Muestre los productos corrspondiente a la marca x
        public List<Product> SelectByBrandId(int brandId)
        {
            List<Product> result = null;

            using (TiendaDBContext _repo = new TiendaDBContext())
            {
                result = _repo.Products.Where(x => x.BrandId.Equals(brandId)).ToList();
            }

            return result;
        }

        public List<Product> SelectByCategoryId(int categoryId)
        {
            List<Product> result = null;

            using (TiendaDBContext _repo = new TiendaDBContext())
            {
                result = _repo.Products.Where(x => x.CategoryId.Equals(categoryId)).ToList();
            }

            return result;
        }


        public bool Create(Product entity)
        {
            bool result = false;

            using (TiendaDBContext _repo = new TiendaDBContext())
            {
                Product p = _repo.Products.FirstOrDefault(x => x.Nombre.ToLower() == entity.Nombre);

                if (p == null)
                {
                    _repo.Products.Add(entity);
                    result = _repo.SaveChanges() > 0;
                }
            }


            return result;
        }

        public bool Update(Product entity)
        {
            bool result = false;

            using (TiendaDBContext _repo = new TiendaDBContext())
            {
                Product p = _repo.Products.FirstOrDefault(x => x.Nombre.ToLower() == entity.Nombre);

                if (p == null)
                {
                    _repo.Products.Attach(entity);
                    _repo.Entry(entity).State = EntityState.Modified;
                    result = _repo.SaveChanges() > 0;
                }
            }

            return result;
        }

        public bool Delete(Product entity)
        {
            bool result = false;

            using (TiendaDBContext _repo = new TiendaDBContext())
            {
                Product p = _repo.Products.FirstOrDefault(x => x.Nombre.ToLower() == entity.Nombre);


                _repo.Products.Attach(entity);
                _repo.Products.Remove(entity);
                result = _repo.SaveChanges() > 0;

            }

            return result;
        }
    }
}
