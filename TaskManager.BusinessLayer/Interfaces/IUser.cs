using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManager.Entities.Entity;

namespace TaskManager.BusinessLayer.Interfaces
{
   public interface IUser
    {
        Tasks SearchTask(Tasks task, User user);
        Tasks EditTask(int Id);
        List<Tasks> ViewTask(User users);
        void EndTask(int Id);
    }
}
