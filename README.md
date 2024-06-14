## Contact Manager
# Overview
This project consists of a simple console-based Contact Manager application written in C#. The application allows users to add, remove, and view contacts. It also includes unit tests written using the xUnit testing framework to ensure the functionality of the Contact Manager.

# Code Breakdown
# Contact_Manager Namespace
The Contact_Manager namespace contains the core functionality of the application.

Program Class
The Program class is the main class of the application. It contains the following key methods:

Main(string[] args): The entry point of the application. It calls the ContactsManager method to demonstrate the functionality.

ContactsManager(): A method that showcases the adding and removing of contacts, as well as viewing the current list of contacts. It includes basic exception handling to capture and display any errors that occur during execution.

AddContact(string contact): Adds a new contact to the list. It performs the following validations:

Ensures the contact name is not null or empty.
Ensures the contact does not already exist in the list.
If these conditions are met, the contact is added to the list.
RemoveContact(string contact): Removes an existing contact from the list. It performs the following validations:

Ensures the contact name is not null or empty.
Ensures the contact exists in the list.
If these conditions are met, the contact is removed from the list.
ViewAllContacts(): Returns the current list of contacts.

## ContactManagerTests Namespace
The ContactManagerTests namespace contains unit tests for the Contact_Manager namespace, ensuring the correctness of the application.

# UnitTest1 Class
The UnitTest1 class contains the following test methods:

AddCase(): Tests the AddContact method by:

Adding a contact named "ibrahem".
Verifying that the contact is successfully added to the list.
RemoveCase(): Tests the RemoveContact method by:

Adding a contact named "ibrahem".
Removing the contact.
Re-adding the contact to check if the removal was successful.
Verifying that the contact is successfully re-added to the list.
ViewAllContactsCase(): Tests the ViewAllContacts method by:S

Adding two contacts named "ibrahem" and "Abed".
Verifying that both contacts are present in the list.
# Conclusion
This project demonstrates a simple Contact Manager application with basic functionalities such as adding, removing, and viewing contacts. The application includes unit tests to validate these functionalities. This serves as a good starting point