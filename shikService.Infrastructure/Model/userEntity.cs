using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace shikService.Infrastructure.Model
{
    public class userEntity
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Pw { get; set; }
        public userDetailEntity Detail { get; set; }
        public List<actionEntity> Actions { get; set; }
    }
}
