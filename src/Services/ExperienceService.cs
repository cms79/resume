using Resume.Models;

namespace Resume.Services;

public interface IExperienceService
{
    IEnumerable<Company> GetCompaniesWithExperience();
}

public class ExperienceService : IExperienceService
{
    // Hard coded for now. Ideally, this would be retrieved from a REST API, Azure Function, or other data source.
    public IEnumerable<Company> GetCompaniesWithExperience() => 
    [
        new() // Quisitive
        {
            ImageLink = "/images/quisitive-logo.jpg",
            CompanyName = "Quisitive",
            Location = "Dallas, Texas",
            Summary = "Quisitive is a technology consulting firm focused on Microsoft-based cloud solutions, data analytics, and digital transformation. Headquartered in Toronto, it serves various industries with expertise in Microsoft Azure, Dynamics 365, and offers payment processing solutions through its PayiQ platform.",
            ExternalLink = "https://quisitive.com",
            Experiences =
            [
                new()
                {
                    Title = "Senior Lead Consultant",
                    Date = "2021 - Present",
                    Summary =
                    [
                        "Currently, I provide consultation and support to the Cinemark development team, offering recommendations, implementing features, conducting research, fixing bugs, and performing code reviews for www.cinemark.com. Tech stack: Azure, .NET 4.8/C#, MVC, TypeScript, HTML/CSS, and SQL Server.",
                        "Previously, led a team in developing and delivering the TA Dashboard application for the Texas Education Agency (TEA). Began with initial design and delivered MVP within 10 months, including integration with 3rd party systems. Helped gather requirements from clients, conducted countless demos and training sessions with stakeholders and end users, setup deploy pipelines, migrated the application from Azure to TEA’s on-prem environment, and collaborated with TEA on multiple fronts, helping to maintain excellent client relations. Tech stack: .NET 7, Blazor, Mudblazor, REST API, EF Core, SQL Server."
                    ]
                }
            ]
        },
        new() // Elbit
        {
            ImageLink = "/images/elbit-logo.jpg",
            CompanyName = "Elbit Systems of America",
            Location = "Fort Worth, Texas",
            Summary = "Elbit Systems of America, based in Fort Worth, Texas, is a subsidiary of Elbit Systems Ltd. It provides advanced technology solutions for defense, homeland security, and aviation, specializing in products like avionics, night vision, and unmanned systems to support U.S. national security and allied defense needs.",
            ExternalLink = "https://www.elbitamerica.com",
            Experiences =
            [
                new()
                {
                    Title = "Principal Software Engineer",
                    Date = "2021 - 2021",
                    Summary = 
                    [
                        "Develop and deploy software in support of the Dept. of Homeland Security contract. Development includes standalone applications and microservices/distributed systems using Docker/containerization. Projects include live video processing, GPS/GIS, REST API, SQL Server, messaging/NetMQ, and .NET Core."
                    ]
                }
            ]
        },
        new() // Brierley
        {
            ImageLink = "/images/brierley-logo.jpg",
            CompanyName = "Brierley",
            Location = "Frisco, Texas",
            Summary = "Brierley is a customer loyalty and CRM solutions company that helps brands build and manage loyalty programs. Based in Frisco, Texas, Brierley offers services in loyalty strategy, technology platforms, data analytics, and marketing to improve customer engagement and drive growth for clients across various industries.",
            ExternalLink = "https://www.brierley.com",
            Experiences =
            [
                new()
                {
                    Title = "Team Lead/Anchor",
                    Date = "2019 - 2021",
                    Summary = 
                    [
                        "I led an agile team of four engineers, a product owner, and product manager and delivered loyalty software to the world’s largest provider of ophthalmic lenses. I was assigned this challenging role where the client was on the verge of canceling the contract due to repeated missed deliveries. After six months of successful releases, the team secured a contract renewal. In addition to facilitating the team’s agile/SCRUM ceremonies, I led the conversion from TortoiseSVN to GitHub and transitioned the team to CI/CD practices in addition to leading design sessions and ensuring that client-focused, maintainable solutions are adopted. Maintained client-facing website at https://rewards.essilorusa.com."
                    ]
                },
                new()
                {
                    Title = "Senior Software Engineer",
                    Date = "2018 - 2019",
                    Summary = 
                    [
                        "Implemented Brierley’s LoyaltyOnDemand software for The Children’s Place. Maintained existing core REST endpoints in addition to creating new custom endpoints that successfully processes millions of transactions per month. Developed in the C#/.NET environment in Visual Studio. Validated APIs and wrote test scripts in Postman. Created ad-hoc Oracle SQL queries for research, testing, and data cleanup. Wrote unit/integration tests."
                    ]
                }
            ]
        },
        new() // Tyler
        {
            ImageLink = "/images/tyler-logo.jpg",
            CompanyName = "Tyler Technologies",
            Location = "Plano, Texas",
            Summary = "Tyler Technologies is a software and services company focused on providing technology solutions for the public sector. Headquartered in Plano, Texas, Tyler offers software for government operations, including public safety, tax, finance, and civic management, helping local, state, and federal agencies enhance efficiency and transparency in their services.",
            ExternalLink = "https://www.tylertech.com",
            Experiences =
            [
                new()
                {
                    Title = "Senior Software Engineer",
                    Date = "2016 - 2018",
                    Summary = 
                    [
                        "Developed and maintained the industry-leading Odyssey File & Serve product suite, which allows attorneys and self-represented litigants to e-file into court management systems across the country. Created and maintained SOAP APIs with C#/.NET and SQL Server on the backend. Used SOAP UI for testing and validation."
                    ]
                },
                new()
                {
                    Title = "Business Analyst",
                    Date = "2014 - 2016",
                    Summary =
                    [
                        "Work directly with clients and developers to ensure clients receive quality software solutions that meet their business needs. Visit clients and cultivate lasting customer relationships. Gather and elicit requirements. Groom stories in collaboration with development team. Act as liaison between development and support teams. Investigate possible defects, data issues, and setup problems when support cannot resolve. Apply data fixes to production data in SQL. Coordinate client software updates. Manage early adoption for each software release."
                    ]
                },
                new()
                {
                    Title = "Software Developer",
                    Date = "2011 - 2014",
                    Summary =
                    [
                        "Create enterprise software applications for municipal courts across the United States. Analyze design requirements for new features and enhancements, fix defects, perform testing, and support product implementation. Develop & maintain stored procedures, table-valued functions, and scalar functions. Use SQL Profiler to troubleshoot database issues. Visit client sites to analyze business processes and develop customer relationships. Use Agile/SCRUM process."
                    ]
                }
            ]
        },
        new() // Mantech
        {
            ImageLink = "/images/mantech-logo.jpg",
            CompanyName = "Mantech, International",
            Location = "Fort Hood, Texas",
            Summary = "ManTech International is a U.S.-based defense contracting firm specializing in technology solutions for national security, intelligence, and federal agencies. Headquartered in Herndon, Virginia, ManTech provides services in cybersecurity, data analytics, IT modernization, and mission support, with a focus on enhancing security and operational capabilities for government clients.",
            ExternalLink = "https://www.mantech.com",
            Experiences =
            [
                new()
                {
                    Title = "Computer Systems Analyst II",
                    Date = "2008 - 2011",
                    Summary =
                    [
                        "Developed applications for the US Army that parsed classified and non-classified data in real-time from tactical networks, including TCP/IP packets. Possessed a Top-Secret Security Clearance."
                    ]
                }
            ]
        },
        new() // Army
        {
            ImageLink = "/images/army-logo.jpg",
            CompanyName = "United States Army",
            Location = "Fort Hood, Texas",
            Summary = "The United States Army is the primary land-based branch of the U.S. Armed Forces, responsible for national defense, land warfare, and security operations. Established in 1775, it trains, equips, and deploys soldiers to protect U.S. interests, support allies, and respond to global crises. The Army plays a critical role in defense strategy, peacekeeping missions, and disaster relief, operating under the Department of Defense.",
            ExternalLink = "https://www.goarmy.com",
            Experiences =
            [
                new()
                {
                    Title = "Sergeant/Team Chief",
                    Date = "1999 - 2005",
                    Summary =
                    [
                        "Supervised small communications team in support of Operation Iraqi Freedom. Deployed tactical radio network to support over 200 users in Baghdad, Iraq. Served as liaison for Brigade staff and supporting units. Installed and diagnosed communication systems including FBCB2, EPLRS, and SINCGARS. Trained soldiers in the operation of Army communication systems. Stored, used, and properly destroyed sensitive equipment and documents without incident in accordance with SOP. Possessed a Secret Security Clearance."
                    ]
                }
            ]
        }
    ];
}