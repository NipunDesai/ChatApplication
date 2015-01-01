using System;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace ChatApplicationTest
{
    using NUnit.Framework;
    using ChatApplication.Repository;
    using ChatApplication.Models;
    using System.Collections.Generic;
    
    [TestFixture]
    public class UserRepositoryTest 
    {
        private  ChatContext  _chatContext;
        [SetUp]
        public void Setup()
        {
            _chatContext = new ChatContext();
        }

        [TearDown]
        public void TearDown()
        {
            _chatContext = null;
        }

        [Test]
        public void CreateUserSuccessfullyTest()
        {
            UserDetail userDetail = new UserDetail
           {             
               UserName = "Nipun",
               EmailId = "nipun@promact.com",
               Password = "nnn",
               Dob = new DateTime(1990,11,18),
               Gender = "Male",
               Contactno = 98985,
               IsDeleted = false
           };
            _chatContext.UserDetails.Add(userDetail);
            _chatContext.SaveChanges();
            Assert.Greater(userDetail.Id, 0);
       }

        [Test]
        public void GetAllUser()
        {
            var getalluser = _chatContext.UserDetails.ToList();
            Assert.IsInstanceOf<List<UserDetail>>(getalluser);
        }
       
        [Test]
        public void UpdateUserDetailTest()
        {
            UserDetail userDetail = new UserDetail
            {
                UserName = "Nipun",
                EmailId = "nipun@promact.com",
                Password = "nnn",
                Dob = new DateTime(1990, 11, 18),
                Gender = "Male",
                Contactno = 96014,
                IsDeleted = false
            };

             _chatContext.UserDetails.Add(userDetail);
             userDetail.UserName = "Desai";
             _chatContext.UserDetails.Add(userDetail);
            _chatContext.SaveChanges();
            Assert.Greater(userDetail.Id, 0);
        }
        [Test]
        public void CreateUsertWithNullFullName()
        {
            UserDetail user = new UserDetail
            {
                UserName = null,
                EmailId ="Krutik@gmail.com",
                Password="nnn",
                Gender="Male",
                Dob =new DateTime(1990,3,11),
                Contactno =59859
            };
            _chatContext.UserDetails.Add(user);
            _chatContext.SaveChanges();
            Assert.Greater(user.Id,0);
        }
        [Test]
        public void CreateUserWithNullContactNo()
        {
            UserDetail user = new UserDetail
            {
                UserName = "sanket",
                EmailId ="sanket@gmail.com",
                Password ="ss",
                Gender ="Male",
                Dob =new DateTime(1984,12,16),
                Contactno=null
            };
            _chatContext.UserDetails.Add(user);
            _chatContext.SaveChanges();
            Assert.Greater(user.Id,0);
        }
        [Test]
        public void RemoveUserTest()
        {
            UserDetail user = new UserDetail
            {
                UserName = "Krutik",
                EmailId = "Krutik@promact.com",
                Password = "nnn",
                Dob = new DateTime(1990, 3, 18),
                Gender = "Male",
                Contactno = 9898,
                IsDeleted = false
            };

            _chatContext.UserDetails.Add(user);
            _chatContext.SaveChanges();
            _chatContext.UserDetails.Remove(user);
            var s=_chatContext.SaveChanges();
            Assert.AreEqual(s,1);
        }
       
    }
}
