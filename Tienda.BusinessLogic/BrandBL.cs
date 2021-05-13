using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tienda.Entities;
using Tienda.DataAccess;

namespace Tienda.BusinessLogic
{
    public class BrandBL
    {
        private static BrandBL _instance;

        public static BrandBL Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new BrandBL();
                }

                return _instance;
            }
        }

        public List<Brand> SelectAll()
        {
            List<Brand> result = null;
            try
            {
                result = BrandDAL.Instance.SelectAll();

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

        public Brand SelectById(int id)
        {
            Brand result = null;
            try
            {
                result = BrandDAL.Instance.SelectById(id);

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

        public bool Create (Brand entity)
        {
            bool result = false;

            try
            {
                result = BrandDAL.Instance.Create(entity);

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

        public bool Update (Brand entity)
        {
            bool result = false;

            try
            {
                result = BrandDAL.Instance.Update(entity);

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

        public bool Delete(Brand entity)
        {
            bool result = false;

            try
            {
                result = BrandDAL.Instance.Delete(entity);

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
