using MainApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Service;

public class UserService
{
    private List<User> _users = [];
    public ServiceResponse CreateUser(User user)
    {
        {
            try
            {
                if (string.IsNullOrEmpty(user.Email))
                {
                    return new ServiceResponse { Succeeded = false, Message = "No e-Mail adress was provided" };
                }
                if (string.IsNullOrEmpty(user.FirstName) || string.IsNullOrEmpty(user.LastName))
                {
                    return new ServiceResponse { Succeeded = false, Message = "No name was provided" };
                }
                if (_users.Any(x => x.Email == user.Email))
                {
                    return new ServiceResponse { Succeeded = false, Message = "User with the same email adress already exists." };
                }
                _users.Add(user);
                return new ServiceResponse { Succeeded = true, Message = "User was created. " };
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return new ServiceResponse { Succeeded = false, Message = ex.Message };
            }
        }
    }

}



