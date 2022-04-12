using Business.Interfaces;
using DataAccess.Repositories;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class GroupServices : IGroup
    {

        public static int Count { get; set; }
        private GroupRepository _groupRepository;

        public GroupServices()
        {
            _groupRepository= new GroupRepository();
        }



        public Group Creat(Group group)
        {
            group.Id=Count;
            _groupRepository.Create(group);
            Count++;
            return group;
            
        }

        public Group Delete(int Id)
        {
            Group IsExsist = _groupRepository.GetOne(g => g.Id==Id);
            if (IsExsist == null)
            {
                return null;
            }
            _groupRepository.Delete(IsExsist);
            return IsExsist;
        }

        public Group GetGroup(string name)
        {
            return _groupRepository.GetOne(g=>g.Name==name);
        }
        public Group GetGroup(int id)
        {
            return _groupRepository.GetOne(g => g.Id==id);
        }
        public Group Update(int Id, Group group)
        {
            throw new NotImplementedException();
        }

        public List<Group> GetAll(string name=null)
        {
          return  _groupRepository.GetAll(g=>g.Name==name);
        }

       
    }
}
