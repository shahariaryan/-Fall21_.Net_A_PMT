using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IRepo<T>
    {
        void Add(T e);
        void Edit(T e);
        void Delete(T e);
        List<T> Get();
    }

    public interface IRepo<IDx, IDy>
    {
        void Add(IDx pId, IDy mId);
        void Confirm(IDy eId);
        void Decline(IDx eId);
    }

    public interface IRepo<T, ID, Status>
    {
        void Add(T e);
        void Edit(T e);
        void StatusProgress(ID pId);
        void StatusCompleted(ID pId);
        void Delete(T e);
        List<T> GetAll();
        T GetById(ID id);
        List<T> GetByStatus(Status status);
        List<T> GetByMIdStatus(ID id, Status status);
        List<T> GetByMIdApplied(ID id);
    }


    

}