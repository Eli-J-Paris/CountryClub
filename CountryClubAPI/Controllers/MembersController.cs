using CountryClubAPI.DataAccess;
using CountryClubAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CountryClubAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MembersController : ControllerBase
    {
        private readonly CountryClubContext _context;

        public MembersController(CountryClubContext context)
        {
            _context = context;
        }

        public IActionResult AllMembers()
        {
            var members = _context.Members;

            return new JsonResult(members);
        }

        [HttpGet("{id}")]
        public IActionResult ReturnOneMember(int id)
        {
            var member = _context.Members.Find(id);
            return new JsonResult(member);
        }

        [HttpPost]
        public IActionResult CreateMember(Member member)
        {
            
            _context.Members.Add(member);
            _context.SaveChanges();
            return new JsonResult(member);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateMember(int id, Member member)
        {
            member.Id = id; 
            _context.Members.Update(member);
            _context.SaveChanges();

            return new JsonResult(member);

        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMember(int id)
        {
            var members = _context.Members;

            var member = _context.Members.Find(id);
            _context.Members.Remove(member);
            _context.SaveChanges();

            return new JsonResult(members);

        }
    }
}
