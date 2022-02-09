using CityBusManagement.DAL.Data;
using CityBusManagement.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CityBusManagement.DAL.Repository
{
    public class AdminInfoRepository : IAdminInfoRepository
    {
        RouteDetailsDbContext _admininfoDbContext;
        public AdminInfoRepository(RouteDetailsDbContext admininfoDbContext)
        {
            _admininfoDbContext = admininfoDbContext;
        }
        public AdminInfo Login(AdminInfo user)
        {
            AdminInfo userInfo = null;
            var result = _admininfoDbContext.adminInfo.Where(obj => obj.AdminId == user.AdminId && obj.Password == user.Password).ToList();
            if (result.Count > 0)
            {
                userInfo = result[0];
            }
            return userInfo;
        }
    }
}
    

