using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using ChatApplication.Migrations;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ChatApplication.Models
{
   
    public class ChatContext : IdentityDbContext<AccountModelBind>
    {

        public ChatContext()
        {
            //Database.SetInitializer(new MigrateDatabaseToLatestVersion<ChatContext, ChatApplication.Migrations.Configuration>("ChatApplicationDemo"));

        }
        

        public DbSet<UserDetail> UserDetails { get; set; }
        public DbSet<ChatGroup> ChatGroups { get; set; }
        public DbSet<ChatGroupUser> ChatGroupUsers { get; set; }
        public DbSet<ChatGroupDetail> ChatGroupDetails { get; set; }
        public DbSet<Chat> Chats { get; set; }          

    }
}