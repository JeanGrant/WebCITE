using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebCITE.Models;

namespace WebCITE.Pages
{
    public class HotlinesModel : PageModel
    {
        public List<hotlineContacts> offices = new List<hotlineContacts>()
        {
            new hotlineContacts()
            {
                Email = "records.college@dlsl.edu.ph",
                Description = "for college record concerns"
            },
            new hotlineContacts()
            {
                Email = "enrollment.college@dlsl.edu.ph",
                Description = "for college enrollment concerns"
            },
            new hotlineContacts()
            {
                Email = "verification.college@dlsl.edu.ph",
                Description = "for college grades concerns"
            },
            new hotlineContacts()
            {
                Email = "admissions.office@dlsl.edu.ph",
                Description = "for admission concerns"
            },
            new hotlineContacts()
            {
                Email = "lamp@dlsl.edu.ph",
                Description = "for scholarship concerns"
            },
            new hotlineContacts()
            {
                Email = "cashier@dlsl.edu.ph",
                Description = "for tuition fee and refund concerns"
            },
            new hotlineContacts()
            {
                Email = "support.ictc@dlsl.edu.ph",
                Description = "for DCampus concerns"
            },
            new hotlineContacts()
            {
                Email = "helpdesk@dlsl.edu.ph",
                Description = "for other concerns"
            }
        };
        public List<hotlineContacts> admin = new List<hotlineContacts>()
        {
            new hotlineContacts()
            {
                Email = "ramon.flores.iv@dlsl.edu.ph",
                Name = "Engr. Ramon Flores IV",
                Position = "Dean / Electrical Engineering Program Chair"
            },
            new hotlineContacts()
            {
                Email = "cite.ce@dlsl.edu.ph",
                Name = "Engr. Mary Lou Teñoso",
                Position = "Computer Engineering Program Chair"
            },
            new hotlineContacts()
            {
                Email = "cite.cs@dlsl.edu.ph",
                Name = "Ms. Nelia Rocamora",
                Position = "Computer Science Program Chair"
            },
            new hotlineContacts()
            {
                Email = "cite.ece@dlsl.edu.ph",
                Name = "Engr. Aileen Villamonte",
                Position = "Electronics Engineering Program Chair"
            },
            new hotlineContacts()
            {
                Email = "cite.ie@dlsl.edu.ph",
                Name = "Engr. Gilbert Calosa",
                Position = "Industrial Engineering Program Chair"
            },
            new hotlineContacts()
            {
                Email = "cite.it@dlsl.edu.ph",
                Name = "Mr. Rodante Chavez",
                Position = "Information Technology Program Chair"
            },
            new hotlineContacts()
            {
                Email = "cite.ge@dlsl.edu.ph",
                Name = "Ms. Melanie Lugo",
                Position = "Learning Area Chair"
            },
            new hotlineContacts()
            {
                Email = "cherrie.villafuerte@dlsl.edu.ph",
                Name = "Engr. Cherrie Villafuerte",
                Position = "CITE Laboratory Head"
            }
        };
        public List<hotlineContacts> enrol = new List<hotlineContacts>()
        {
            new hotlineContacts()
            {
                Question = "Where can I access the Assessment Form (AF)?",
                Answer = "You may access your Assessment Form (AF) through the MyDCampus Portal (mydcampus.dlsl.edu.ph)."
            },
            new hotlineContacts()
            {
                Question = "There is no Assessment Form available on my DCampus Account",
                Answer = "If the window displays a message suggesting that you should contact enrollment and evaluation in-charge, kindly send an email to: enrollment.college@dlsl.edu.ph\n\nIf the window displays a message saying that your Assessment Form is not available at the moment, try refreshing the page. If the problem persists, send an email to: support.ictc@dlsl.edu.ph"
            },
            new hotlineContacts()
            {
                Question = "If I can already view my Assessment Form before the enrollment schedule, can I now pay my tuition and fees?",
                Answer = "For non-scholars, you may proceed with your payment.\nFor scholars, you should wait for your scholarship to be 'tagged' before proceeding with your payment."
            },
            new hotlineContacts()
            {
                Question = "What should I write in the Reference Number and/or Account Name?",
                Answer = "When asked for a reference number and/or account name, kindly write your Student Number and/or De La Salle Lipa Inc., respectively. "
            },
            new hotlineContacts()
            {
                Question = "How will I know if I'm officially enrolled?",
                Answer = "Banks and Payment centers follow specific working days. You should  receive a confirmation via SMS or email from the payment center or bank that your payment is received. Once your payment is received by our school, you will receive your Certificate of Registration (COR) through MyDCampus Portal.\n\n" +
                "NOTE: You must only pay to the partner banks or payment centers of our school"
            },
            new hotlineContacts()
            {
                Question = "I received a confirmation via SMS/Email that my payment has been received, but my COR is not yet available in myDCampus Account.",
                Answer = "Once your payment is received from the bank/payment center by our school,  the cashier's staff would still need to verify the transaction/details of payment before posting your COR.\n" +
                "If the COR is still not available after a significant amount of time, send an email to the office of the ICTC: support.ictc@dlsl.edu.ph"
            },
            new hotlineContacts()
            {
                Question = "I still have a balance from the past semester. Will I be able to enroll for the next sem?",
                Answer = "We suggest you to pay your remaining balance from the past semester/s, before you enroll for the next semester."
            },
            new hotlineContacts()
            {
                Question = "I cannot find my question in the FAQs.",
                Answer = "You may contact us at our FB page DLSL SG CITE for any of your questions and concerns."
            }
        };
        public void OnGet()
        {
        }
    }
}
