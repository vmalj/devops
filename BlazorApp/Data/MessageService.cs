using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorApp.Data.DTOs;
using BlazorApp.Data.Entities;

namespace BlazorApp.Data
{
    public class MessageService
    {
        private readonly BlazorDbContext context;

        public MessageService(BlazorDbContext dbContext)
        {
            context = dbContext;
        }

        public async Task<MessageItemDTO> GetMessage()
        {
            MessageItem item = await context.Messages.FirstOrDefaultAsync();
            
            if (item == null)
            {
                return null;
            }

            return new MessageItemDTO
            {
                Message = item.Message
            };
        }
    }
}
