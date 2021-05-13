using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Entities;
using Tienda.DataAccess;

namespace Tienda.BusinessLogic
{
    public class ProductBL
    {

        private static ProductBL _instance;

        public static ProductBL Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ProductBL();
                }

                return _instance;
            }
        }

        public List<Product> SelectAll()
        {
            List<Product> result = null;
            try
            {
                result = ProductDAL.Instance.SelectAll();

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
