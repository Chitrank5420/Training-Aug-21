using FarmPe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FarmPe.Services
{
    public interface IAuthenticateService
    {
        Users Authenticate(string username, string password);
    }
}
