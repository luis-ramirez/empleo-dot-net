using System.Collections.Generic;

namespace EmpleoDotNet.ViewModel
{
    public class UserProfileViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Email { get; set; }
        public string WebSiteUrl { get; set; }
        public string ImageUrl { get; set; }

        public List<Core.Domain.JobOpportunity> Jobs { get; set; } = new List<Core.Domain.JobOpportunity>();
    }
}