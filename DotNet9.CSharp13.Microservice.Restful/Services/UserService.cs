using DotNet9.CSharp13.Microservice.Restful.Models;
using DotNet9.CSharp13.Microservice.Restful.Repositories;

namespace DotNet9.CSharp13.Microservice.Restful.Services
{
    /**
     *  UserService.cs
     * 
     *  Author   Hume Cristian
     *  Version  1.0.0
     *  Created  2024-11-18
     *  Modified 2024-11-18
     */
    public class UserService
    {
        #region [PRIVATE_FIELDS]
        private readonly UserRepository _userRepository;
        #endregion [PRIVATE_FIELDS]

        #region [PUBLIC_CONSTRUCTORS]
        public UserService()
        {
            _userRepository = new UserRepository();
        }
        #endregion [PUBLIC_CONSTRUCTORS]

        #region [PUBLIC_METHODS]
        public Int32 Create(UserModel userModel)
        {
            return _userRepository.Create(userModel);
        }

        public List<UserModel> FindAll()
        {
            return _userRepository.FindAll();
        }

        public UserModel? FindById(Int128 id)
        {
            return _userRepository.FindById(id);
        }

        public void Update(Int32 id, UserModel userModel)
        {
            _userRepository.Update(id, userModel);
        }

        public void Delete(Int32 id)
        {
            _userRepository.Delete(id);
        }
        #endregion [PUBLIC_METHODS]
    }

}
