using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp04.EntityFramework.Logic
{
    public interface ILogic <T> 
    {
        List<T> GetAll();
        void Add(T newItem);
        void Remove(int id); 

        void Update(T Item);
    }





}
