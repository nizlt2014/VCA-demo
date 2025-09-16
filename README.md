🏗 VCA Software Migration – Classic ASP → .NET Microservices
📌 Overview

VCA Software is a claims management platform serving insurance carriers, TPAs, self-insureds, and adjusters. It provides:

Claims lifecycle management (FNOL → resolution)

Mobile & web access for policyholders and adjusters

Digital payments & claim tracking

API integrations with underwriting, billing, and third-party systems

Low-code/no-code customization for workflows and rules

The original platform was built on Classic ASP monolithic code, which created challenges in scalability, maintainability, and deployment speed.

🚀 My Role in the Migration

I led the modernization effort to migrate VCA’s platform from Classic ASP into a .NET microservices architecture, deployed in the cloud.

🔹 Migration Highlights

Monolithic → Microservices
Decoupled core modules (Claims, FNOL Intake, Payments, Client Portal, Notifications) into independent .NET microservices.

Modern API Layer
Rebuilt APIs for real-time bi-directional integrations with external platforms like underwriting, policy admin, and accounting systems.

Workflow Customization
Enabled flexible low-code/no-code workflows so non-technical users could modify claims rules, forms, and layouts without code changes.

Performance & Scale
Introduced containerization and orchestration (Docker, Kubernetes/AKS) for high availability and scalability.

DevOps & CI/CD
Built pipelines (Azure DevOps / GitHub Actions) for automated testing, builds, and deployments → enabling faster release cycles.

Security & Compliance
Ensured data compliance (SOC II, Lloyd’s reporting), enhanced logging, monitoring, and improved uptime (99.9%).

🛠 Tech Stack

Backend: .NET Core Microservices, C#, Dapper

Messaging: RabbitMQ / Azure Service Bus

Database: Azure SQL (per service)

Infrastructure: Docker, Azure Kubernetes Service (AKS)

CI/CD: Azure DevOps / GitHub Actions

Integrations: QuickBooks, Bill.com, XactAnalysis, Hover, Encircle, CoreLogic (via APIs)

🎯 Business Outcomes

Reduced deployment time from weeks to hours with CI/CD.

Improved system scalability to handle growing claim volumes.

Increased maintainability by isolating services → less regression risk.

Reduced claims journey costs (up to 30% efficiency improvement).

Enabled faster client onboarding (deployments in 2–3 weeks, with minimal training needs).

📈 Impact

This migration transformed VCA into a cloud-native, scalable, and modern claims platform, positioning the business for growth while improving user experience and operational efficiency.

⚡ NDA Note: This is a case study based on my migration work. All sensitive client data and proprietary logic are excluded. The repo and description use dummy/demo code for demonstration.
