using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Entities;

namespace Tienda.DataAccess
{
    public class CategoryDAL
    {
        private static CategoryDAL _instance;

        public static CategoryDAL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CategoryDAL();
                }
                return _instance;
            }
        }


        public List<Category> SelectAll()
        {
            List<Category> result = null;

            using (TiendaDBContext _repo = new TiendaDBContext())
            {
                result = _repo.Categories.ToList();
            }

            return result;
        }

        public Category SelectById(int id)
        {
            Category result = null;

            using (TiendaDBContext _repo = new TiendaDBContext())
            {
                result = _repo.Categories.FirstOrDefault(x => x.CategoryId.Equals(id));
            }

            return result;
        }

        //Metodo de la clase producto
        //Muestre los productos corrspondiente a la marca x
     
        public bool Create(Category entity)
        {
            bool result = false;

            using (TiendaDBContext _repo = new TiendaDBContext())
            {
                Category c = _repo.Categories.FirstOrDefault(x => x.Nombre.ToLower() == entity.Nombre);

                if (c == null)
                {
                    _repo.Categories.Add(entity);
                    result = _repo.SaveChanges() > 0;
                }
            }


            return result;
        }

        public bool Update(Category entity)
        {
            bool result = false;

            using (TiendaDBContext _repo = new TiendaDBContext())
            {
                Category c = _repo.Categories.FirstOrDefault(x => x.Nombre.ToLower() == entity.Nombre);

                if (c == null)
                {
                    _repo.Categories.Attach(entity);
                    _repo.Entry(entity).State = EntityState.Modified;
                    result = _repo.SaveChanges() > 0;
                }
            }

            return result;
        }

        public bool Delete(Category entity)
        {
            bool result = false;

            using (TiendaDBContext _repo = new TiendaDBContext())
            {
                Category c = _repo.Categories.FirstOrDefault(x => x.Nombre.ToLower() == entity.Nombre);


                _repo.Categories.Attach(entity);
                _repo.Categories.Remove(entity);
                result = _repo.SaveChanges() > 0;

            }

            return result;
        }
    }
}
