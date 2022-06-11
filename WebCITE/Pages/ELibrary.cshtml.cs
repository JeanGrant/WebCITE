using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebCITE.Models;

namespace WebCITE.Pages
{
    public class ELibraryModel : PageModel
    {
        public List<eLibContent> eLib = new List<eLibContent>()
        {
            new eLibContent() {
                idDiv = "compEng",
                Title = "Computer Engineering" ,
                Contributor = "DLSL - ACES",
                link1 = "https://drive.google.com/drive/folders/1nfoxRgm-FbYOI1R9kdUDZ5-nP1JQHk7b",
                link2 = "https://drive.google.com/drive/folders/107j5SjK6HopcmFPT0KOaGr6IuT1RgvPJ",
                link3 = "https://drive.google.com/drive/folders/1s2AEJm5AeM8bZQ8y2KpnmNmB1nqeYWD8",
                link4 = "https://drive.google.com/drive/folders/1eUpn8xdVr7uRP7NJ6VkMpTDZugYpwlT9",
                ProgDesc = "The BS Computer Engineering program focuses on conceptualization, design, assembly, maintenance, and integration of hardware and software components in modern computing systems and computer-controlled equipment, strengthened with the utilization of CISCO networking technology and certification. Students are trained to be experts in areas of computer architecture, electrical circuits and devices, communication system, hardware, and software design.",
                CareerOp = "Career Oppotunities: Engineer / Designer, Maintenance Engineer, Database Administrator, Network Administrator, Systems Administrator, Network Support Specialist, Robotics Engineer, Software Engineer, Hardware Engineer, Project Engineer, Educator, Technopreneur, and CAD Operator.",
                imgLink = "/images/ELib/CpE.png"
            },
            new eLibContent() {
                idDiv = "compSci",
                Title = "Computer Science" ,
                Contributor = "DLSL - JPCS",
                link1 = "https://drive.google.com/drive/folders/1ppmAv2V-OsFvaZjlAlyqhUBB_MpcH8OF",
                link2 = "https://drive.google.com/drive/folders/1D6UML60d8Ca_Do2s3PjAje_PYtfyf9_n",
                link3 = "https://drive.google.com/drive/folders/1AdTjfEWOnMGl_F3FHQzbNZBQkWL4xoBl",
                link4 = "https://drive.google.com/drive/folders/1qIqitc4BaO7o6m3Ww9FXAK5p7nTxLDrQ",
                ProgDesc = "The BS Computer Science program educates the students with computing theories and its applications to address real world problems. The curriculum is embedded with an array of courses specifically, software eng​ineering, web and mobile systems development, technopreneurship and information security; the track electives are focused on either game development or internet of things. Students are assured of industry-based competencies through industry partnerships and certifications. The program ensures that graduates of the program are socially responsive and innovative in developing software solutions that are ethical and human centered.",
                CareerOp = "Career Oppotunities: Applications Developer, Big Data Engineer Blockchain Developer, Data Analyst, Data Architect, Data Manager, Data Scientist, Ethical Hacker, Forensic Computer Analyst, Game Designer, Games Developer, Information Systems Manager, IT Consultant, Mobile Applications Developer, Software Engineer, Systems Analyst, System Designer Engineer, Technopreneur, UX Designer, Web Designer, and Web Developer",
                imgLink = "/images/ELib/CS.png"
            },
            new eLibContent() {
                idDiv = "elecEng",
                Title = "Electrical Engineering" ,
                Contributor = "DLSL - JPIEE",
                link1 = "https://drive.google.com/drive/folders/1yFLygvF-L6NT1pcNW6jb0jwcnXx8zVZn",
                link2 = "https://drive.google.com/drive/folders/1yFLygvF-L6NT1pcNW6jb0jwcnXx8zVZn",
                link3 = "https://drive.google.com/drive/folders/1yFLygvF-L6NT1pcNW6jb0jwcnXx8zVZn",
                link4 = "https://drive.google.com/drive/folders/1yFLygvF-L6NT1pcNW6jb0jwcnXx8zVZn",
                ProgDesc = "The BS Electrical Engineering program deals with the study and use of latest trends in technology for real-life application of existing scientific knowledge in the following areas: generation, transmission, distribution, and utilization of electrical energy. The program provides students an industry-based curriculum grounded on the foundation courses in thefields of mathematical analysis, applied sciences, and humanities. The curriculum expands into specialized courses in machine automation and process control and power system protection. It integrates social innovation elements in wide spectrum of curricular courses, most especially on the research projects or capstone design projects.",
                CareerOp = "Career Opportunities: Power Engineer, Design Engineer, Illumination Engineer, Entrepreneur, Sales Engineer, Distribution Engineer, Engineering Educators and Researchers, Instrumentation and Control Engineer, Safety Engineer, Maintenance Engineer, Construction and Project Engineer, Mechatronics Engineer, and Electrical Design Inspector.",
                imgLink = "/images/ELib/EE.png"
            },
            new eLibContent() {
                idDiv = "elexEng",
                Title = "Electronics Engineering" ,
                Contributor = "DLSL - IECEP",
                link1 = "https://sites.google.com/view/iecep-dlslsc/",
                link2 = "https://sites.google.com/view/iecep-dlslsc/",
                link3 = "https://sites.google.com/view/iecep-dlslsc/",
                link4 = "https://sites.google.com/view/iecep-dlslsc/",
                ProgDesc = "The BS Electronics Engineering program develops technical skills of students with interest in electronics and electronic systems and technologies. It aims to produce Electronics Engineers that can apply engineering sciences and/or principles to the investigation, analysis, synthesis, planning, design, specification, research and development, provision, procurement, marketing and sales, manufacture and production, construction and installation, tests/measurements/control, operation, repair, servicing, technical support and maintenance of electronic components, devices, products, apparatus, instruments, equipment, systems, networks, and operations and processes in the field of Electronics Engineering.",
                CareerOp = "Career Oppotunities: Broadcast Engineering, Telecommunications, Semiconductor Device Fabrication / Manufacturing Engineering, Electronics Design, Computers Systems, Data Science and Artificial Intelligence, Data Engineering, Electronics Ancillary Systems, Instrumentation and Telemetry, Automation, Feedback, Process Control, Robotics, and Mechatronics, Industrial Electronics, Signal Processing, Optics, and Medical/Biomedical Electronics.",
                imgLink = "/images/ELib/ECE.png"
            },
            new eLibContent() {
                idDiv = "indEng",
                Title = "Industrial Engineering" ,
                Contributor = "DLSL - JPIIE",
                link1 = "https://drive.google.com/drive/folders/1jAL9_DfdyGkK6YGrzY82KjmtkDn63iZl",
                link2 = "https://drive.google.com/drive/folders/1Jsvr784UusxJKkqWaEdVUv-D-mhYWhXx",
                link3 = "https://drive.google.com/drive/folders/14ufUbmdwnTeWw5EIY6uk7wsHJ_v9xkyE",
                link4 = "https://drive.google.com/drive/folders/12QM7VPrSUhMGhYToC4hBRTInXUNtW0wu",
                ProgDesc = "The BS Industrial Engineering program is intended to prepare students for a professional Industrial Engineering career including a leading role in the design, improvement, and installation of integrated systems of people, materials, information equipment, and energy. Graduates of the program must have specialized knowledge and skills in the mathematical, physical, and social sciences together with the principles and methods of engineering analysis and design to specify, predict, and evaluates the results to be obtained from such systems.",
                CareerOp = "Career Oppotunities: Management Systems Engineer / Consultant, Manufacturing Engineer / Manager, Logistics / Supply Chain Manager, Operations Engineer / Manager, Project Engineer / Manager, Quality Assurance Engineer / Manager, Customer Service Engineer / Manager, Operations Research Analyst, Systems Analyst / Engineer Designer, Methods Engineer, Research Engineer, Planning Engineer, Ergonomist, Educator Technopreneur.",
                imgLink = "/images/ELib/IE.png"
            },
            new eLibContent() {
                idDiv = "infTech",
                Title = "Information Technology" ,
                Contributor = "DLSL - JPCS",
                link1 = "https://drive.google.com/drive/folders/1ppmAv2V-OsFvaZjlAlyqhUBB_MpcH8OF",
                link2 = "https://drive.google.com/drive/folders/1D6UML60d8Ca_Do2s3PjAje_PYtfyf9_n",
                link3 = "https://drive.google.com/drive/folders/1AdTjfEWOnMGl_F3FHQzbNZBQkWL4xoBl",
                link4 = "https://drive.google.com/drive/folders/1qIqitc4BaO7o6m3Ww9FXAK5p7nTxLDrQ",
                ProgDesc = "The BS Information Technology program trains students on the application of hardware and software technologies to support and manage the information technology infrastructure of organizations. It includes courses on it fundamentals, computer programming, information assurance and securitym system integration, service management, system administration, and network technologies. Students are prepared thru IT certification opportunities and exposure to technologies and best practices of our industry partners.",
                CareerOp = "Career Oppotunities: Web and Applications Developer, Junior Database and Administrator, Systems Administrator, Network Engineer, Junior Information Security Administrator, Systems Integration Personnel, IT Audit Assistant, Technical Support Specialist, Quality Assurance Specialist, Systems Analyst, and Computer Programmer.",
                imgLink = "/images/ELib/IT.png"
            }
        };

        public void OnGet()
        {
        }
    }
}
