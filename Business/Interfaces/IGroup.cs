using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IGroup
    {
        Group Creat(Group group);
        Group Update(int Id, Group group);
        Group Delete(int Id);

        Group GetGroup(string name);
        Group GetGroup(int id);

        List<Group> GetAll(string name=null);
    }
}
