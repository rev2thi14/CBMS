using CityBusManagement.DAL.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace CityBusManagement.BAL.services
{
    public class AdminInfoService
    {
        private IAdminInfoRepository _adminInfoRepository;
        public AdminInfoService(IAdminInfoRepository adminInfoRepository)
        {
            _adminInfoRepository = adminInfoRepository;
        }
    }
}
