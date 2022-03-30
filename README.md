# lab1_hotel_zhuoli
We will be creating a database to keep track of rooms and clients for a hotel. Because our employer has very specific requirements for their database, including naming conventions, we will have to use a number of preselected property names for our entities and data annotations.

For the sake of simplicity, we will not be using authorization and authentication for this project.


Part 1

Begin by creating the Hotel models.

 You will need to make extensive use of data annotations.

The Client will require:

An ID (int will be sufficient here)

A FirstName and LastName. The last name is required, and both have a minimum length of three characters and a max of 25.

PhoneNumber, a string which must represent a phone number and have an appropriate validation message. It is also required in order to register a Client. Search for a way to validate phone numbers in C#.

A Room:

Must have a RoomNumber, which serves as its Primary Key. 

Capacity

Section, an Enum (First, Second, Third) 

Once these models have been implemented,  be sure to migrate them into a new database.
