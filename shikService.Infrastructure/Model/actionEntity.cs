using System;
namespace shikService.Infrastructure.Model
{
    public class actionEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string With { get; set; }
    }
}
