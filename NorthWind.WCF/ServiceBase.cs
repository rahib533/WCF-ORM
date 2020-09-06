using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NorthWind.WCF
{
    using DTO;
    using Entity;
    using Repository;
    using Extension;
    public class ServiceBase<Rep, Entity, DTO> : IService<DTO> where DTO : class
        where Rep : RepositoryBase<Entity>
        where Entity : class
    {

        private Rep repository;

        public Rep Repository
        {
            get
            {
                if (repository == null)
                {
                    repository = Activator.CreateInstance<Rep>();
                }
                return repository;
            }
            set { repository = value; }
        }


        public bool Delete(DTO dto)
        {
            return Repository.Delete(dto.Changer<Entity>());
        }

        public bool Insert(DTO dto)
        {
            return Repository.Insert(dto.Changer<Entity>());
        }

        public List<DTO> SelectAll()
        {
            return Repository.SelectAll().Select(x => x.Changer<DTO>()).ToList();
        }

        public bool Update(DTO dto)
        {
            return Repository.Update(dto.Changer<Entity>());
        }
    }
}