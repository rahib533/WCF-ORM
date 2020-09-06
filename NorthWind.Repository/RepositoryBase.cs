using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Repository
{
    using Entity.Model;
    public class RepositoryBase<TT> : IRepository<TT> where TT : class
    {

        private static NorthwindEntities context;

        public static NorthwindEntities Context
        {
            get
            {
                if (context == null)
                {
                    context = new NorthwindEntities();
                }
                return context;
            }
            set { context = value; }
        }


        public bool Insert(TT entity)
        {
            Context.Set<TT>().Add(entity);
            try
            {   
                return Context.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            } 
        }

        public bool Update(TT entity)
        {
            try
            {
                return Context.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<TT> SelectAll()
        {
            try
            {
                return Context.Set<TT>().ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool Delete(TT entity)
        {
            Context.Set<TT>().Remove(entity);
            try
            {
                return Context.SaveChanges() > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
