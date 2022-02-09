using CityBusManagement.Entity.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityBusManagement.DAL.Repository
{
    public interface IAdminInfoRepository
    {
        AdminInfo Login(AdminInfo user);
    }
}
