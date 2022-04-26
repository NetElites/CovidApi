using CovidApi.Application.Dto;
using CovidApi.Application.Repository;
using CovidApi.Domain.ChatModel;
using CovidApi.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovidApi.Application.Services
{
    public class ChatServices : ChatRepository
    {
        private readonly ApplicationDbContext _context;
        public ChatServices(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<List<ChatDto>> GetChat()
        {
            var result = _context.chats.Select(chat => new ChatDto
            {
                ChatId=chat.ChatId,
                UserName=chat.UserName,
                Text=chat.Text,
                Insert=chat.Insert
            }).ToList();
            return result;
        }

        public async Task<AddChatDto> PostChat(AddChatDto addChatDto)
        {
            Chat newChat = new Chat
            {
                UserName=addChatDto.ChatDto.UserName,
                Text=addChatDto.ChatDto.Text,
                Insert=DateTime.Now
            };
            await _context.chats.AddAsync(newChat);
            await _context.SaveChangesAsync();
            return new AddChatDto
            {
                ChatDto = new ChatDto
                {
                    UserName = addChatDto.ChatDto.UserName,
                    Text = addChatDto.ChatDto.Text,
                    Insert = DateTime.Now
                }
            };
        }
    }
}
