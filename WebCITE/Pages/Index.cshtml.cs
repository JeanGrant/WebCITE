using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebCITE.Models;

namespace WebCITE.Pages
{
    public class IndexModel : PageModel
    {
        public List<Something> somethings = new List<Something>()
        {
            new Something()
            {
                Id=0,
                Title="Project C.L.A.P",
                Subtitle="The CITE Load Assistance Program aims to assist selected CITE students who have poor or no signal at home and have difficulties with having data services.",
                RedirectURL="~/About",
                BTNText="Sign Up for Assistance"
            },
            new Something()
            {
                Id=1,
                Title="Your Voice Matters",
                Subtitle="The Student Government CITE Council aims to resolve your concerns to ensure the quality education you deserve.",
                RedirectURL="https://docs.google.com/forms/d/e/1FAIpQLSfYAdyldq-L4l4Lt0KNT2ehqVyWw5K8eUGqgWQ8mznjDLaL7Q/viewform",
                BTNText="Let Us Help"
            }
        };

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}