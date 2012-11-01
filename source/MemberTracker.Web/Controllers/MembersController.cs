using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MemberTracker.Web.Controllers
{
	public class Member
	{
		public Guid id { get; set; }
		public string firstName { get; set; }
		public string lastName { get; set; }
		public DateTime startDate { get; set; }
		public int numDrinks { get; set; }
	}

	public class MembersController : ApiController
	{
		private List<Member> buildList()
		{
			var members = new List<Member>();

			members.Add(new Member() { id = new Guid("52789726-3b65-43b6-a1b0-8be69ea28ffb"), firstName = "Justin", lastName = "Kohnen", startDate = new DateTime(2012, 6, 15), numDrinks = 129 });
			members.Add(new Member() { id = new Guid("62789726-3b65-43b6-a1b0-8be69ea28ffb"), firstName = "Doug", lastName = "McSwiggen", startDate = new DateTime(2012, 7, 15), numDrinks = 193 });
			members.Add(new Member() { id = new Guid("72789726-3b65-43b6-a1b0-8be69ea28ffb"), firstName = "Jane", lastName = "Doe", startDate = new DateTime(2102, 8, 15), numDrinks = 5 });
			members.Add(new Member() { id = new Guid("82789726-3b65-43b6-a1b0-8be69ea28ffb"), firstName = "Santa", lastName = "Clause", startDate = new DateTime(2012, 9, 15), numDrinks = 0 });
			members.Add(new Member() { id = new Guid("92789726-3b65-43b6-a1b0-8be69ea28ffb"), firstName = "Easter", lastName = "Bunny", startDate = new DateTime(2012, 9, 15), numDrinks = 42 });

			return members;
		}

		// GET api/values
		public IEnumerable<Member> Get()
		{
			return buildList();
		}

		// GET api/values/5
		public Member Get(Guid id)
		{
			var found = buildList().FirstOrDefault(member => member.id == id);
			if(found == null)
			{
				throw new HttpResponseException(HttpStatusCode.NotFound);
			}

			return found;
		}

		// POST api/values
		public void Post([FromBody]string value)
		{
		}

		// PUT api/values/5
		public void Put(int id, [FromBody]string value)
		{
		}

		// DELETE api/values/5
		public void Delete(int id)
		{
		}
	}
}