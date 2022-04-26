using CovidApi.Application.Dto;
using CovidApi.Application.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly ChatRepository _chat;
        public ChatController(ChatRepository chat)
        {
            _chat = chat;
        }
        [HttpGet]
        public async Task<IActionResult> GetChat()
        {
            var result = _chat.GetChat();
            return Ok(new ResponseDto
            {
                IsSccees = true,
                DisplayMessage = "عملیات با موفقیت انجام شد",
                Result = result,
                linksDtos = new List<LinksDto>
                {
                    new LinksDto
                    {
                        Href="",
                        Method="GET",
                        Rel="GETALL"
                    }
                }
            });
        }
        [HttpPost]
        public async Task<IActionResult> PostChat([FromBody]ItemsChatDto items)
        {
            if (ModelState.IsValid)
            {
                var result = _chat.PostChat(new AddChatDto 
                { 
                    ChatDto=new ChatDto
                    {
                        Text=items.Text,
                        UserName=items.UserName
                    }
                });
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
