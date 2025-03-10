# Blood Donation

The mobile application for blood donors is an innovative project that aims to facilitate the process of donating blood through technology. This application is intended for blood donors as well as blood collection organizations to create better communication, increase awareness of the importance of blood donation and improve the overall donation process.
## Application logo
<p align="center">
  <img src="https://raw.githubusercontent.com/nejrariizviic/Blood-Donation/refs/heads/main/Uploads/logo.png" alt="Logo">
</p>

## Login and registration
<p align="center">
  <img src="https://raw.githubusercontent.com/nejrariizviic/Blood-Donation/refs/heads/main/Uploads/loginregistration.png" alt="Login">
</p>

## List of institutions for blood donation
<p align="center">
  <img src="https://raw.githubusercontent.com/nejrariizviic/Blood-Donation/refs/heads/main/Uploads/donator.png" alt="List">
</p>


## Table of Contents
- [Project Overview](#project-overview)
- [User Flow Overview](#user-flow-overview)
- [Technologies](#technologies)
- [Key Features](#key-features)
- [Usage Guidelines](#usage-guidelines)
- [Future Improvements](#future-improvements)

## Project Overview
The design and development of the Blood Donation app focused on simplicity, clarity, and accessibility. The application was built to be lightweight, without excessive or overly complex features, ensuring that users of all technical skill levels can easily navigate and use it. The interface is intuitive, with clear instructions and minimal steps required for registration, donation scheduling, and receiving notifications. The goal was to create an app that is not only functional but also approachable for individuals who may not be very tech-savvy, making it accessible to a wide range of users.

### User Roles
- Donor: The primary user role, allowing individuals to register, schedule donations, receive notifications, and track their donation history.
- Blood Collection Organization: These users manage donation campaigns, publish real-time donation needs, and track donor availability.
- Admin: Oversees the overall operation of the app, including managing user roles, monitoring activity, and ensuring smooth functionality.

## User Flow Overview

- The donor begins by registering, creating a profile with personal details, blood type, donation history, and availability for future donations.
- Upon registration, the donor receives notifications about urgent donation needs published by blood collection organizations.
- The app utilizes GPS functionality to identify nearby donors and sends real-time notifications regarding critical donation needs in the surrounding area.
- The donor then schedules an appointment for blood donation, selecting an available time slot within the app.
- Automated reminders are sent to the donor, informing them about their upcoming donation appointments.
- After completing the donation, the donor can track their donation history and receive feedback on how their blood was utilized.
- Additionally, the donor can access educational content provided within the app, which includes information on the health benefits of blood donation, as well as resources to help raise awareness and alleviate concerns surrounding the donation process.

This overview illustrates the comprehensive journey a donor takes within the app, ensuring a streamlined, user-friendly experience throughout their engagement with the platform.

## Technologies
- .NET MAUI - used to develop a cross-platform mobile application, 
- SQLite - used for local data storage, allowing efficient management of user data such as donation history and registration details
- Adobe Photoshop - used for designing and editing images and assets


## Key Features
- Donor:
  - Register and create a user profile with personal details, blood type, and donation history.
  - Schedule future blood donations.
  - Receive real-time notifications about urgent donation needs and local donation events.
  - Track donation history and see how their blood has been used.
  - Get reminders for upcoming donation appointments.
  - Access educational content about blood donation and health tips.

- Blood Collection Organization:
  - Publish real-time notifications about urgent donation needs in the area.
  - Organize and manage donation events.
  - Track the availability of registered donors.
  - Send notifications to users regarding local donation events or emergencies.
  - Monitor donor history and engagement for better campaign management.

- Admin:
  - Manage user roles (donors, organizations).
  - Oversee the overall operation and functionality of the app.
  - Ensure smooth operation of donation scheduling, notifications, and data management.
  - Monitor app performance and user engagement.
  - Review and approve donation events and notifications.

## Usage Guidelines
Follow these steps to download and run the application:
 1. Clone the Repository
 2. Open the .sln project file in Visual Studio 2022
 3. If you are using SQLite, ensure that the Microsoft.Data.Sqlite package is installed via NuGet Package Manager
 4. In Visual Studio, select the target platform (Android, Windows, iOS)
 5. Click "Run" or press F5 to start the application.


## Future Improvements
Some of the key future improvements include:

- Integration with Health Systems - connecting the app with national or regional health databases to allow real-time tracking of donation eligibility and to streamline the process for both donors and blood collection organizations.
- In-App Blood Donation Tracking - enabling users to track not only their donation history but also the impact of their donations on patients, including success stories and updates from hospitals.
- Multi-Language Support - expanding the app's accessibility by incorporating multiple languages to cater to a broader audience, ensuring that non-native speakers can easily use the app.
- Gamification and Rewards - introducing a gamified system with badges, milestones, and rewards for donors based on their donation frequency and impact, which can encourage more people to donate regularly.

These improvements aim to make the app more efficient, engaging, and inclusive, while continuing to serve as a valuable tool in promoting blood donation and ensuring that urgent needs are met.

