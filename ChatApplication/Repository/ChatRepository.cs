using ChatApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics.Contracts;
using System.Linq;

namespace ChatApplication.Repository
{

    public class ChatRepository :IChatRepository
    {
        private ChatContext db = new ChatContext();
        private List<ChatGroup> chatgroups = new List<ChatGroup>();     

        public ChatGroup CreatenewChatGroup(ChatGroup chatgroup)
        {
            db.ChatGroups.Add(chatgroup);
            db.SaveChanges();
            return chatgroup;
        }

        public ChatGroup UpdateChatGroup(ChatGroup chatgroup)
        {
            db.Entry(chatgroup).State = EntityState.Modified;
            db.SaveChanges();
            return chatgroup;
        }

        public void RemoveChatGroup(int id)
        {
            ChatGroup chat = db.ChatGroups.FirstOrDefault(a => a.Id == id);
            db.ChatGroups.Remove(chat);
            db.SaveChanges(); 
        }
  
        public IEnumerable<ChatGroup> GetAllChatGroup()
        {
            var chat= db.ChatGroups.ToList();
            return chat;
        }

        public ChatGroup GetById(int groupid)
        {
            IQueryable<ChatGroup> groups = db.ChatGroups.Where(a=>a.Id==groupid);
            return groups.FirstOrDefault();
        }
        public IEnumerable<ChatGroupUser> AddUserToChatGroup(ChatGroupUser chatGroupUsers, List<UserDetail> userdetail, ChatGroup chatgroup)
        {
            throw new NotImplementedException();
        }

        public ChatGroupUser RemoveChatGroupUser(ChatGroupUser chatgroupusre, UserDetail userDetail)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ChatGroupUser> GetAllChatGroupUser()
        {
            var getChatUser = db.ChatGroupUsers.ToList();
            return getChatUser;
        }

        public IEnumerable<ChatGroupUser> GetChatGroupUser(ChatGroup chatgroup, UserDetail userdetails)
        {
            throw new NotImplementedException();
        }

        public ChatGroupDetail SendGroupMessage(ChatGroupDetail chatgroupdetails, UserDetail userdetails, ChatGroupUser chatgroupuser)
        {
            throw new NotImplementedException();
        }

        public ChatGroupDetail RemoveChatGroupMessage(UserDetail userdetails, ChatGroupDetail chatgroupdetails)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ChatGroupDetail> GetAllChatGroupMessage()
        {
            throw new NotImplementedException();
        }

        public Chat CreatenewChat(Chat chat, UserDetail userdetails)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Chat> GetAllChat()
        {
            throw new NotImplementedException();
        }

        public Chat RemoveChatMessage(Chat chat, UserDetail userdetails)
        {
            throw new NotImplementedException();
        }   
    }
}