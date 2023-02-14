using System;

namespace BusinessLayer.BusinessLayerClass
{
    [Serializable]
    public abstract class DomainObject
    {
        public abstract object GetId();
        public abstract void SetId(object id);

        protected void MarkNew()
        {
            UnitOfWork.UnitOfWork.Instance.RegisterNewObj(this);
        }
        protected void MarkDirty()
        {
            UnitOfWork.UnitOfWork.Instance.RegisterDirtyObj(this);
        }

        protected void MarkDelete()
        {
            UnitOfWork.UnitOfWork.Instance.RegisterDeletedObj(this);
        }

    }
}
