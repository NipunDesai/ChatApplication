using ChatApplication.Models;
using ChatApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ChatApplication.Controllers
{
    public class ChatController : ApiController
    {
        IChatRepository _chatRepository;

        public ChatController(IChatRepository chatRepository)
        {
            _chatRepository = chatRepository;
        }

        // GET api/chat     
        [HttpGet]
        public IHttpActionResult GetAllChatGroup()
        {
            var chat =_chatRepository.GetAllChatGroup();
            return Ok(chat);
        }
        // GET api/chat/5

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
           ChatGroup chatgroup =_chatRepository.GetById(id);
           return Ok(chatgroup);
        }        
        // POST api/chat
        [HttpPost]
        public async Task<IHttpActionResult> Create(ChatGroup chatGroup)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _chatRepository.CreatenewChatGroup(chatGroup);         
            return Ok(chatGroup);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _chatRepository.RemoveChatGroup(id);
        }

        [HttpPut]
        public IHttpActionResult Put(ChatGroup chatgroup)
        {
            _chatRepository.UpdateChatGroup(chatgroup);
            return Ok(chatgroup);
        }
    }
}
