using System.Web.Mvc;
using EmpleoDotNet.AppServices;
using EmpleoDotNet.ViewModel;

namespace EmpleoDotNet.Controllers
{
    public class UserProfileController : Controller
    {
        private readonly IJobOpportunityService _jobOpportunityService;

        public UserProfileController(IJobOpportunityService jobOpportunityService)
        {
            _jobOpportunityService = jobOpportunityService;
        }

        // GET: UserProfile
        public ActionResult Index(int? id)
        {
            var viewModel = new UserProfileViewModel
            {
                Name = "Megsoft Consulting, INC.",
                Description = "We are a team of tech-savvy individuals with a passion for mobile devices and what they empower you to do. Our primary focus is building native cross-platform applications for iOS, Android and Windows Phone.",
                WebSiteUrl = "http://megsoftconsulting.com",
                Email = "info@megsofconsulting.com",
                ImageUrl = "http://megsoftconsulting.com/newwpsite/wp-content/uploads/2015/12/logoretina.png"
            };

            viewModel.Jobs = _jobOpportunityService.GetCompanyRelatedJobs(0, "Megsoft Consulting, INC.");

            return View(viewModel);
        }

        public ActionResult Edit(int? id)
        {
            var viewModel = new UserProfileViewModel
            {
                Name = "Megsoft Consulting, INC.",
                Description = "We are a team of tech-savvy individuals with a passion for mobile devices and what they empower you to do. Our primary focus is building native cross-platform applications for iOS, Android and Windows Phone.",
                WebSiteUrl = "http://megsoftconsulting.com",
                Email = "info@megsofconsulting.com",
                ImageUrl = "http://megsoftconsulting.com/newwpsite/wp-content/uploads/2015/12/logoretina.png"
            };

            return View(viewModel);
        }
    }
}