using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KyhWebDemo1.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        public string Namn { get; set; }

        public List<HockeyPlayerViewModel> Players { get; set; }
            = new List<HockeyPlayerViewModel>();

        public class HockeyPlayerViewModel
        {
            public int Id { get; set; }
            public string Namn { get; set; }
            public int Jersey { get; set; }
        }

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            // hämta från databas - beräkning osv
            // sätta publika properties på oss själva
            //dvs publika properties som ska vara "dynamiska" på sidan
            var vardet = "Stefan";
            Namn = vardet;

            Players.Add(new HockeyPlayerViewModel
            {
                Namn = "Stefan", Id=1, Jersey = 2
            });
            Players.Add(new HockeyPlayerViewModel
            {
                Namn = "Mats",
                Id = 2,
                Jersey = 13
            });



        }
    }
}