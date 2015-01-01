using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace ChatApplicationTest
{
    using NUnit.Framework;
    using ChatApplication.Repository;
    using ChatApplication.Models;
    using System.Collections.Generic;
    using ChatApplication;
    
    [TestFixture]
    public class ChatRepositoryTest
    {
        private ChatContext _chatContext;       
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
        public void CreatechatGroupTest()
        {
            ChatGroup chatgroup = new ChatGroup
            {
                GroupName ="Promact",
                UserId =1,
                CreateDate =new DateTime(2014,3,10)
            };
            _chatContext.ChatGroups.Add(chatgroup);
            _chatContext.SaveChanges();
            Assert.Greater(chatgroup.Id, 0);
        }
        
        [Test]
        public void RemoveChatGroup()
        {
            ChatGroup chatgroup = new ChatGroup
            {
                GroupName = "PromactGroup",
                UserId = 1,
                CreateDate = new DateTime(2014, 3, 10)
            };
            _chatContext.ChatGroups.Add(chatgroup);
            _chatContext.SaveChanges();
            var removechatgroup =_chatContext.ChatGroups.Remove(chatgroup);
            var savechatgroup=_chatContext.SaveChanges();
            Assert.AreEqual(savechatgroup ,1);
        }

        [Test]
        public void UpdateChatGroupName()
        {
            ChatGroup chatgroup = new ChatGroup
            {
                GroupName ="PromactGroup",
                UserId =1,
                CreateDate =new DateTime(2014,3,11)
            };
            _chatContext.ChatGroups.Add(chatgroup);
            chatgroup.GroupName = "Promact";
            _chatContext.SaveChanges();
            Assert.Greater(chatgroup.Id, 0);
        }

        [Test]
        public void GetAllChatGroup()
        {
            var chatgroup = _chatContext.ChatGroups.ToList();
            Assert.IsInstanceOf<List<ChatGroup>>(chatgroup);
        }
     
        [Test]
        public void AddUserToChatgroupSuccessfullyTest()
        {
            ChatGroupUser chatgroupuser = new ChatGroupUser
            {
                UserId =1,
                GroupId =1,
                CreateDate =new DateTime(2014,3,10)
            };
            _chatContext.ChatGroupUsers.Add(chatgroupuser);
            _chatContext.SaveChanges();
            Assert.Greater(chatgroupuser.Id, 0);
        }

        [Test]
        public void RemoveUserToChatgroupTest()
        {
            ChatGroupUser chat = new ChatGroupUser
            {
                UserId =2,
                GroupId =1,
                CreateDate =new DateTime(2014,3,11)
            };
            _chatContext.ChatGroupUsers.Add(chat);
            _chatContext.SaveChanges();
           var removechatgroupuser= _chatContext.ChatGroupUsers.Remove(chat);
           var savechatgroupuser= _chatContext.SaveChanges();
           Assert.AreEqual(savechatgroupuser, 1);
        }

        [Test]
        public void GetAllChatGroupUser()
        {
            var getallchatgroupuser = _chatContext.ChatGroupUsers.ToList();
            Assert.IsInstanceOf<List<ChatGroupUser>>(getallchatgroupuser);
        }
    
        [Test]
        public void SendGroupMessageSuccessfullyTest()
        {
            ChatGroupDetail chatgroupdetail = new ChatGroupDetail
            {
                Chatgroupid =1,
                UserId=6,
                Message ="hi",
                CreateDate=new DateTime(2014,3,10),
                IsDeleted=false
            };
            _chatContext.ChatGroupDetails.Add(chatgroupdetail);
            _chatContext.SaveChanges();
            Assert.Greater(chatgroupdetail.Id,0);
        }

        [Test]
        public void GetAllGroupMessage()
        {
            var getallgroupmessage = _chatContext.ChatGroupDetails.ToList();
            Assert.IsInstanceOf<List<ChatGroupDetail>>(getallgroupmessage);
        }

        [Test]       
        public void SendPrivateMessageSuccessfullyTest()
        {
            Chat chat = new Chat
            {
                To =1,
                From =2,
                Message ="hi",
                CreateDate= new DateTime(2014,3,10)
            };
            _chatContext.Chats.Add(chat);
            _chatContext.SaveChanges();
            Assert.Greater(chat.Id,0);
        }

        [Test]
        public void GetPrivateMessage()
        {
            var getprivatemessage = _chatContext.Chats.ToList();
            Assert.IsInstanceOf<List<Chat>>(getprivatemessage);
        }

        [Test]     
        public void RemovePrivateMessage()
        {
            Chat chat = new Chat
            {
                To =2,
                From=1,
                Message ="hi",
                CreateDate =new DateTime(2014,3,11)
            };
            _chatContext.Chats.Add(chat);
            _chatContext.SaveChanges();
            var chatremove = _chatContext.Chats.Remove(chat);
            var chatsave=_chatContext.SaveChanges();
            Assert.AreEqual(chatsave, 1);
        }
        
        [Test]  
        public void RemoveGroupMessage()
        {
            ChatGroupDetail chatgroupdetail = new ChatGroupDetail
            {
                Chatgroupid = 1,
                UserId = 5,
                Message = "hi",
                CreateDate = new DateTime(2014, 3, 11)
            };
            _chatContext.ChatGroupDetails.Add(chatgroupdetail);
            _chatContext.SaveChanges();
            var removegroupmessage = _chatContext.ChatGroupDetails.Remove(chatgroupdetail);
            var savegroupmessage = _chatContext.SaveChanges();
            Assert.AreEqual(savegroupmessage, 1);
        }
       

    }
}
