using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.BusinessLayerClass;
using BusinessLayer.map;

namespace BusinessLayer.UnitOfWork
{
    public class UnitOfWork
    {
        private static UnitOfWork instance;
        private HashSet<DomainObject> newObj = new HashSet<DomainObject>();
        private HashSet<DomainObject> dirtyObj = new HashSet<DomainObject>();
        private HashSet<DomainObject> deletedObj = new HashSet<DomainObject>();
        private HashSet<DomainObject> cleaned = new HashSet<DomainObject>();
        public static UnitOfWork Instance
        {
            get { return instance ?? (instance = new UnitOfWork()); }
        }

        public void RegisterNewObj(DomainObject domainObject)
        {
            newObj.Add(domainObject);
        }
        public void RegisterDirtyObj(DomainObject domainObject)
        {
            dirtyObj.Add(domainObject);
        }
        public void RegisterDeletedObj(DomainObject domainObject)
        {
            deletedObj.Add(domainObject);
        }

        private void InsertNew()
        {
            foreach (var domainObject in newObj)
            {
                Mapper.Mapper.Instance.GetMapper(domainObject).Insert(domainObject);
            }

        }

        private void UpdateDirty()
        {
            foreach (var domainObject in dirtyObj)
            {
                Mapper.Mapper.Instance.GetMapper(domainObject).Update(domainObject);
            }
        }

        private void DeleteRemoved()
        {
            foreach (var domainObject in deletedObj)
            {
                Mapper.Mapper.Instance.GetMapper(domainObject).Delete(domainObject);
                cleaned.Add(domainObject);
            }
        }

        private void CleanMemory()
        {
            foreach (var deleteIt in cleaned)
            {
                IdentifyMap.Instance.Remove(deleteIt);
            }
        }

        public void Clear()
        {
            newObj.Clear();
            dirtyObj.Clear();
            deletedObj.Clear();
            cleaned.Clear();
        }

        public void Commit()
        {
            InsertNew();
            UpdateDirty();
            DeleteRemoved();
            CleanMemory();

            Clear();
        }
    }
}
