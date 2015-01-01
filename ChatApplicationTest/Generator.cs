using ChatApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatApplicationTest
{
    public class Generator
    {
        private static readonly Random Random = new Random();
        public static string Name()
        {
            var names = new List<string>
                                 {
                                     "Nipun",
                                     "Sanket",
                                     "Darshil",
                                     "Ansh",
                                     "Pratik",
                                     "Dev",
                                     "Bhavesh",
                                     "Gaurav",
                                     "Harsh",
                                     "Ritesh"
                                 };

            return names[Random.Next(0, 9)];
        }
        public static UserDetail Userdetails(int?id =null,string emailid ="nipun@promactinfo.com",string password="promact",string gender="Male",DateTime dob =default(DateTime),int? number=5656,bool isdeleted =false)
        {
            string name = Name();
            return new UserDetail
                       {
                           Id = id.HasValue?id.Value:Random.Next(1,100),
                           FullName = name,
                           EmailId = emailid,
                           Password = password,
                           Dob = dob,
                           Gender = gender,
                           Contactno = number,
                           IsDeleted = isdeleted

                       };
        }
        public static ChatGroup ChatGroup(UserDetail user,int?id = null, string name = "New Group",bool isdeleted =false)
        {
            DateTime currentDate = Date();
            
            return new ChatGroup
            {
                Id = id.HasValue ? id.Value : Random.Next(1,100),
                CreateDate = currentDate,           
                GroupName  = name,
                UserId = user.Id,
                IsDeleted = isdeleted
                
            };
        }

        public static ChatGroupUser Chatgroupuser(ChatGroup chatgroup,UserDetail user,int?id=null,bool isdeleted =false)
        {
            DateTime currentdate = Date();
            return new ChatGroupUser
                       {
                           Id =id.HasValue?id.Value:Random.Next(1,100),
                           UserId = user.Id,
                           GroupId = chatgroup.Id,
                           CreateDate = currentdate,
                           IsDeleted = isdeleted
                       };
        }

        public static ChatGroupDetail Chatgroupdetails(ChatGroupUser chatGroupUser,int ?id=null,string message="Text Message",bool isdeleted =false)
        {
            DateTime currentdate = Date();
            return new ChatGroupDetail
                       {
                           Id = id.HasValue?id.Value:Random.Next(1,100),
                           Chatgroupid = chatGroupUser.Id,
                           Message = message,
                           CreateDate = currentdate,
                           IsDeleted = isdeleted
                       };
        }

        public static Chat Chat(UserDetail user,int ?id =null,string message ="Text Message",bool isdeleted=false)
        {
            DateTime currentdate = Date();
            return new Chat()
                       {
                           Id = id.HasValue?id.Value:Random.Next(1,100),
                           To = user.Id,
                           From = user.Id,
                           Message = message,
                           CreateDate = currentdate,
                           IsDeleted = isdeleted
                       };
        }
        public static DateTime Date(int offsetInDays = 0)
        {
            return DateTime.UtcNow.AddDays(offsetInDays);
        }
    }
}
