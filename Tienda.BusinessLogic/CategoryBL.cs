using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Entities;
using Tienda.DataAccess;

namespace Tienda.BusinessLogic
{
    public class CategoryBL
    {
        private static CategoryBL _instance;

        public static CategoryBL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CategoryBL();
                }

                return _instance;
            }
        }

        public List<Category> SelectAll()
        {
            List<Category> result = null;
            try
            {
                result = CategoryDAL.Instance.SelectAll();

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {

            }

            return result;
        }

        public Product SelectById(int id)
        {
            Product result = null;
            try
            {
                result = ProductDAL.Instance.SelectById(id);

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {

            }

            return result;

        }

        public bool Create(Product entity)
        {
            bool result = false;

            try
            {
                result = ProductDAL.Instance.Create(entity);

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {

            }

            return result;

        }

        public bool Update(Product entity)
        {
            bool result = false;

            try
            {
                result = ProductDAL.Instance.Update(entity);

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {

            }

            return result;
        }

        public bool Delete(Product entity)
        {
            bool result = false;

            try
            {
                result = ProductDAL.Instance.Delete(entity);

            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {

            }

            return result;
        }
    }
}
