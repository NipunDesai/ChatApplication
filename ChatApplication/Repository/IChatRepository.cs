using ChatApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplication.Repository
{
   public interface IChatRepository
    {
       /// <summary>
       /// This method is can be used to Create a New ChatGroup.
       /// </summary>
       /// <param name="chatgroup"></param>
       /// <param name="userdetail"> </param>
       ChatGroup CreatenewChatGroup(ChatGroup chatgroup);

       /// <summary>
       /// This method is can be used to Update ChatGroup Detail.
       /// </summary>
       /// <param name="chatgroup"></param>
       /// <param name="userdetail"> </param>
       ChatGroup UpdateChatGroup(ChatGroup chatgroup);

       /// <summary>
       /// This method is can be used to Remove ChatGroup
       /// </summary>
       /// <param name="chatgroup"></param>
       /// <param name="userdetail"> </param>
       void RemoveChatGroup(int id);

        /// <summary>
        /// This method is for Fatching all chatgroup.
        /// </summary>
        IEnumerable<ChatGroup> GetAllChatGroup();
       /// <summary>
       /// chatgroup getbyid
       /// </summary>
       /// <param name="groupid"></param>
       /// <returns></returns>
       ChatGroup GetById(int groupid);

       /// <summary>
       /// add member to chat group
       /// </summary>
       ///<param name="chatGroupUsers"></param>
       ///<param name="userdetail"> </param>
       ///<param name="chatgroup"> </param>
       IEnumerable<ChatGroupUser> AddUserToChatGroup(ChatGroupUser chatGroupUsers, List<UserDetail> userdetail, ChatGroup chatgroup);

       /// <summary>
       /// This method is can be used to Remove ChatGroup User.
       /// </summary>
       ///<param name="chatgroupusre"></param>
       ///<param name="userDetail"> </param>
       ChatGroupUser RemoveChatGroupUser(ChatGroupUser chatgroupusre, UserDetail userDetail);

       /// <summary>
       /// This method is for fatching all chatgroup user.
       /// </summary>
      
       IEnumerable<ChatGroupUser> GetAllChatGroupUser();

        /// <summary>
        /// This method is for fatching chatgroup user.
        /// </summary>
        /// <param name="chatgroup"></param>
        /// <param name="userdetails"></param>
        IEnumerable<ChatGroupUser> GetChatGroupUser(ChatGroup chatgroup, UserDetail userdetails);

       /// <summary>
       /// This method is can be used to Create a new chatgroup details.
       /// </summary>
       /// <param name="chatgroupdetails"></param>
       /// <param name="chatgroupuser"> </param>
       /// <param name="userdetails"> </param>
       ChatGroupDetail SendGroupMessage(ChatGroupDetail chatgroupdetails, UserDetail userdetails, ChatGroupUser chatgroupuser);

       /// <summary>
       /// This method is can be used to remove chat groupdetails.
       /// </summary>
       /// <param name="userdetails"> </param>
       /// <param name="chatgroupdetails"></param>
       ChatGroupDetail  RemoveChatGroupMessage(UserDetail userdetails,ChatGroupDetail chatgroupdetails);

        /// <summary>
        /// This method is for fatching all chatgroup details.
        /// </summary>
      
        IEnumerable<ChatGroupDetail> GetAllChatGroupMessage();

        /// <summary>
        /// This method is can be used to Create a new chat.
        /// </summary>
        /// <param name="chat"></param>
        /// <param name="userdetails"></param>
        Chat CreatenewChat(Chat chat, UserDetail userdetails);

        /// <summary>
        /// This method is for fatching all chat.
        /// </summary>
        IEnumerable<Chat> GetAllChat();


       /// <summary>
       /// This method is can be used to remove chat.
       /// </summary>
       /// <param name="chat"></param>
       /// <param name="userdetails"></param>
       Chat RemoveChatMessage(Chat chat, UserDetail userdetails);


      
    }
}
