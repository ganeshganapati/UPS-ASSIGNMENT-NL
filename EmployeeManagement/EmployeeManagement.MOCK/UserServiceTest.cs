using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using DomainModel.Models;
using DomainModel.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModelingAPI.APIHelpers;
using ModelingAPI.Services;
using Moq;
using NUnit.Framework;

namespace EmployeeManagement.MOQ
{
    [TestClass]
    public class UserServiceTest
    {
       
        private readonly UserManagementServices _sout;
        private Mock<IUserServices> _mockIUserServices;
        private readonly APIClientHelperFactory _httpClientFactory;

        public UserServiceTest() 
        {
            _httpClientFactory = new APIClientHelperFactory("fa114107311259f5f33e70a5d85de34a2499b4401da069af0b1d835cd5ec0d56", "https://gorest.co.in/public-api/");
             _sout = new UserManagementServices(_httpClientFactory);

        }
        [SetUp]
        public void SetUp()
        {
            _mockIUserServices = new Mock<IUserServices>();

            
        }
        [TestMethod]
        public async Task GetUserByID_ShouldReturnUser_WhenUserExists()
        {
            //Arrange
            var id=111;
            var name ="Ganesh";
            var email ="ganesh@gmail.com";
            var gender ="Male";
            var status ="Active";
            var created_at =DateTime.Now;
            var updated_at = DateTime.Now;
            UsersResponse[] UserResponseDto = new UsersResponse[]
            {
                new UsersResponse{
                id = id,
                name= name,
                email= email,
                gender= gender,
                status= status,
                created_at = created_at,
                updated_at= updated_at
                }
            };
            var enumerableUser = (IEnumerable<UsersResponse>)UserResponseDto;
            //_mockIUserServices.Setup(s => s.GetUserByID(It.IsAny<int>())).Returns((Task<IEnumerable<UsersResponse>>)enumerableUser);
            //Act
            var user = await _sout.GetUserByID(id);
            //Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(expected:id, actual: user.Select(item => item.id).FirstOrDefault());
            
        }
    }
}
