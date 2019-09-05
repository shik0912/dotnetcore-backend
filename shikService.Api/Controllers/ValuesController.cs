using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using shikService.Infrastructure.Ef;
using Microsoft.AspNetCore.Mvc;
using shikService.Infrastructure.Model;
using Microsoft.EntityFrameworkCore;

namespace shikService.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly shikServiceDbContext _dbContext;

        public ValuesController(shikServiceDbContext dbContext) 
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            // curl -X GET https://localhost:5001/api/values/ --insecure
            object result = await this._dbContext.userEntitys
                .Include(o => o.Actions)
                .ToListAsync().ConfigureAwait(false);
            return Ok(result);
        }

        // POST api/values
        [HttpPost]
        public async Task Post([FromBody]string pw)
        {
            // curl -X POST https://localhost:5001/api/values/ --insecure
            var ue = new userEntity()
            {
                Pw = pw,
                Detail = new userDetailEntity() { Name = "MINSIK", Address = "Seoul" },
                Actions = new List<actionEntity>() { new actionEntity() { With = "MyFriend" } }
            };
            this._dbContext.userEntitys.Add(ue);
            await this._dbContext.SaveChangesAsync().ConfigureAwait(false);
        }

        [HttpPut("{id}")]
        public async Task Put(string id, [FromBody] string value)
        {
            // curl -H "Content-Type: application/json" -d "@TEST.txt" -X PUT https://localhost:5001/api/values/025d3d06-fc2b-4105-a7cb-8600190740e4 --insecure
            // TEST.txt에 숫자만 정상
            userEntity UserEntity = await this._dbContext.userEntitys.FirstOrDefaultAsync(o => o.Id == id).ConfigureAwait(false);

            UserEntity.Detail.Name = value;
            await this._dbContext.SaveChangesAsync().ConfigureAwait(false);
        }

        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            // curl -H "Content-Type: application/json" -X DELETE https://localhost:5001/api/values/f61c2fb8-48d7-4cc0-8b72-bd4e800480b2 --insecure
            // FK 때문인지 500에러
            userEntity UserEntity = await this._dbContext.userEntitys.FirstOrDefaultAsync(o => o.Id == id).ConfigureAwait(false);

            this._dbContext.userEntitys.Remove(UserEntity);
            await this._dbContext.SaveChangesAsync().ConfigureAwait(false);
        }
    }
}
