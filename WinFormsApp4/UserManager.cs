using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp4
{
    public class UserManager : IBaseOperation<User>, IUserOperation
    {
        public bool Add(User entity)
        {
            if (entity == null)
                return false;

            DataBASE.Instance.Users.Add(entity);
            return true;
        }

        public bool Delete(int id)
        {
            var deletedEntity = DataBASE.Instance.Users.Find(x => x.ID == id);
            if (deletedEntity == null)
                return false;

            DataBASE.Instance.Users.Remove(deletedEntity);
            return true;
        }

        public List<User> GetAll()
        {
            var allUsers = DataBASE.Instance.Users;
            return allUsers;
        }

        public User GetById(int id)
        {
            var foundEntity = DataBASE.Instance.Users.Find(x => x.ID == id);
            return foundEntity;
        }

        public bool HasUser(User user, out User outUser)
        {
            var isUser = DataBASE.Instance.Users
                .Find(
                x => x.Login == user.Login &&
                x.Password == user.Password
                );
            outUser = isUser;
            if (isUser == null)
                return false;

            return true;
        }

        public bool Update(User entity)
        {
            var oldEntity = DataBASE.Instance.Users.Find(x => x.ID == entity.ID);

            if (oldEntity == null)
                return false;

            oldEntity.Login = entity.Login;
            oldEntity.Email = entity.Email;
            oldEntity.Password = entity.Password;
            return true;
        }
    }
}
