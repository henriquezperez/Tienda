using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Entities;

namespace Tienda.DataAccess
{
    public class BrandDAL
    {
        //Patron singleton

        private static BrandDAL _instance;

        public static BrandDAL Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new BrandDAL();
                }
                return _instance;
            }
        }

        public List<Brand> SelectAll()
        {
            List<Brand> result = null;

            using(TiendaDBContext _repo = new TiendaDBContext())
            {
                result = _repo.Brands.ToList();
            }

            return result;
        }

        public Brand SelectById(int id)
        {
            Brand result = null;

            using(TiendaDBContext _repo = new TiendaDBContext())
            {
                result = _repo.Brands.FirstOrDefault(x => x.Brandid.Equals(id));
            }

            return result;
        }


        //Metodo de la clase producto
        //Muestre los productos corrspondiente a la marca x
        public List<Product> SelectByBrandId(int brandId)
        {
            List <Product> result = null;

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


        public bool Create (Brand entity)
        {
            bool result = false;

            using (TiendaDBContext _repo = new TiendaDBContext())
            {
                Brand b = _repo.Brands.FirstOrDefault(x => x.Nombre.ToLower() == entity.Nombre);

                if(b == null)
                {
                    _repo.Brands.Add(entity);
                    result = _repo.SaveChanges() >0;
                }
            }

            
            return result;
        }

        public bool Update (Brand entity)
        {
            bool result = false;

            using (TiendaDBContext _repo = new TiendaDBContext())
            {
                Brand b = _repo.Brands.FirstOrDefault(x => x.Nombre.ToLower() == entity.Nombre);

                if (b == null)
                {
                    _repo.Brands.Attach(entity);
                    _repo.Entry(entity).State = EntityState.Modified;
                    result = _repo.SaveChanges() > 0;
                }
            }

            return result;
        }

        public bool Delete(Brand entity)
        {
            bool result = false;

            using (TiendaDBContext _repo = new TiendaDBContext())
            {
                Brand b = _repo.Brands.FirstOrDefault(x => x.Nombre.ToLower() == entity.Nombre);

                
                _repo.Brands.Attach(entity);
                _repo.Brands.Remove(entity);
                result = _repo.SaveChanges() > 0;
                
            }

            return result;
        }
    }
}
