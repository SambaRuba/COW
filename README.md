[Production]

# Covid on Wheels #

Covid On Wheels, a uniquely South African-based company, aims to provide mobile COVID-19 testing facilities to event organizers for hire. Ultimately, by reducing the spread of the coronavirus, Covid On Wheels endeavors to increase event safety. These facilities record detailed information about events and the individuals that attend them.

## Key Contributers ##

* [Marius Dreyer] (https://github.com/MariusDreyer)
* [Sean Meyer] (https://github.com/Sean7771)
* [Mighty Hlungwane] (https://github.com/Sgumbaza)
* [Siyabonga Ngele] (https://github.com/Siyabonga-Ngele)
* [Ruben Hendricks] (https://github.com/SambaRuba)

## Problem Scenario Identified ##

The company has identified substantial drawbacks to the existing pen-and-paper systems for capturing and storing data. Additionally, since employees manually have to shift through numerous data entries, further strain is placed on these business assets. Consequentially this leads to the relaying of unstable information to managers and supervisors.

Henceforth, the following processes need to be automated:

* Capturing and manipulation of employee details
* Capturing and manipulation of event details
* Capturing and manipulation of attendee details
  
Furthermore, the system should also be able to use company data to generate reports on the following:

* Event name, date and location
* Employees that worked at an event, along with how many hours they worked
* Total attendance of an event, along with average attendee temperature (to calculate outlier attendees previously 
  in contact with covid-19)

The feedback generated from these reports allows event organizers to predict possible health risks related to potential events. Notifying all related personnel and attendees commences afterwards to curb the spread of covid-19.

## Problem-Solving Approach: ##

The ultimate goal of this project is to provide Covid on Wheels with an easy-to-use computerized system, where the objective is to automate daily processes, i.e. the manipulation of customer and employee data, to create a reporting system that will support company decisions.

Likewise, system data should be secured and inaccessible to those outside of the organization. The system should also be able to import previous data from Excel spreadsheets or digital .txt files and store them in SQL databases for usage by system users during and after business operations.

Project planning follows the FAST methodology, where tasks, responsibilities and inputs can be distributed amongst different team members. Accordingly, this descales the complete project into smaller achievable tasks that can be put together piece by piece in order to accomplish the whole project. Essentially, this enables the team to revisit and optimize smaller sections of the project if necessary.

The system must satisfy the following functional requirements:
* Maintenance of clients/attendees
* Maintenance of events
* Maintenance of employees
* Maintenance of threshold (outlier flags)
* Calculation of employee work hours (login/log out capability)
* Backup of data
* Reporting through GUI, excel spreadsheet or condensed printable document:
  *  Event details (name, date, location, attendance)
  *  At-risk clients (name, ID number, medical history, temperature, contact details)
  *  At-risk employees (name, employee number, medical history, temperature, contact details)
  *  Employee remuneration (employee number, total hours, payment due)
  *  Overall event “rating” to indicate health threat value.
 
Non-functional requirements of the system:
* Provide unique identifiers for system users (employee number and password)
* The database should hold approximately 25 total events for the year, with a max attendance of 2500 individuals. 
* Queries on the database should not take longer than 3 seconds.
* The system should be accessible to two types of users. Namely, the system owner/administrator, who should have access to the databases and the reporting system. Secondly, an employee user who only has access to   input functionality. 
* The GUI should be easy to use and prompt the user to fill in any empty fields. The GUI should also validate data    input upon attendee data submission.
