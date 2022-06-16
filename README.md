# InfiniteLearn - Student Enrollment System - Windows Forms Application
Please Note: This is not about database integration with CRUD operations and real login/registration features.

Suppose now 'Infinite Learn' Foundation is going to facilitate students to develop their skills in Information Technology related areas. They are going to let the student and non-student users enroll in provided training courses. So, we are going to develop an enrolment application for them.

### 1.	Main Form (Unregistered)

When the user first runs the application, the main form should be loaded but all the enrolment features should be disabled. In the user section in the top-right corner, it should be displayed as ‘Unregistered User’. To make use of this enrolment application, the user should be registered first. This main form should be as shown in the following figure. To register, the user should click on the ‘Register’ button. After that, the main form should be disappeared and the registration form should be shown.

![image](https://user-images.githubusercontent.com/49782156/174098478-1237cf91-3e26-4bd5-9ba3-ba7cc7b15641.png)


### 2.	Registration Form

To register, the user should enter the details in respective fields.

![image](https://user-images.githubusercontent.com/49782156/174098551-78182690-74ea-4767-b591-d59cfdd24cf0.png)

The user should select whether he/she is an ‘Undergraduate Student’, ‘Graduate Student’ or ‘Non Student’ from the drop-down. If the user clicks on the link ‘Already Registered? Login’, then it should be navigated to the ‘Login’ form. When entering user details, the following conditions should be applied:
•	All the fields are required to fill.
•	Password should have at least 8 characters.
•	Passwords should be matched in the ‘Password’ and ‘Confirm Password’ fields.
•	Email should be valid with only one ‘@’ symbol and one or more ‘.’ symbols.

If the user is not following one or more above-mentioned conditions, then an error message should be displayed.

![image](https://user-images.githubusercontent.com/49782156/174098781-424bcd9b-452c-4576-8c98-1e7a838fd3fa.png)

### 3.	Main Form (Registered)

After the user has entered valid details on the registration form and clicked on the register button, then the main form should be shown again, disappearing the registration form.

![image](https://user-images.githubusercontent.com/49782156/174098952-306a5bdf-072c-465e-8a4c-1715290858c7.png)

In the user section, it should welcome the user with the user’s name (‘Hello John Smith’). The ‘Login’ button should be changed to ‘Logout’. Now all the features are enabled. Firstly, the user should select his/her level. Then the user should select a category. Each category has a different set of courses. When the user selects a particular category, a set of available courses should be displayed in alphabetical order, according to the pre-selected level.

![image](https://user-images.githubusercontent.com/49782156/174099152-ea855a49-cc18-41ec-a4c8-7c5381dad833.png)

The user can enroll in multiple courses but limiting to only one level and one category at a time. Each course costs 5,000 LKR. For the Undergraduate Students, 40% of discount is given, and for the Graduate Students, 20% of discount is given from courses.

To enroll in courses, firstly, the user should select the courses to be enrolled in from the list of available courses. If the user wants, he/she can have additional materials as well, by ticking. Each additional material costs only 100 LKR. Then click on the button ‘Enroll Now’.

![image](https://user-images.githubusercontent.com/49782156/174099438-33691d78-01ce-4c90-a629-4a9927e4c66e.png)

After that, a message box should be shown asking about the user’s willingness to checkout based on the total cost to pay.

![image](https://user-images.githubusercontent.com/49782156/174099545-7dfbf6ad-ebbd-42ed-a84d-1695c5210544.png)

If the user wants to cancel checkout, the Cancel button should be clicked and then the message box should be closed, letting the user reconsider selecting courses and additional materials. If the user is satisfied with the cost, then he/she can proceed by clicking on the OK button.

![image](https://user-images.githubusercontent.com/49782156/174099683-de784be1-c955-419d-aaac-91c89b67c8c0.png)

### 4.	Enrolment Details Form

After clicking on the OK button, the enrolment details form should be shown including enrolled courses, additional materials (only if any are selected), and total cost.

![image](https://user-images.githubusercontent.com/49782156/174099890-092c75f3-6db1-4145-b9bb-5deb536c4d4b.png)

After the user clicks on the Okay button, the details form should be disappeared. To logout from the application, the user should click on the Logout button.

![image](https://user-images.githubusercontent.com/49782156/174099994-907b8281-6a6c-444a-9e0e-bed40c68ae77.png)

Then all the features should be disabled. To use the features, the user has to login.

![image](https://user-images.githubusercontent.com/49782156/174100090-7f9ad1f8-9bbb-49e8-83e1-6c6c4a6d23dc.png)

The Logout/Login button should have a toggle action. When clicking on the Login button, the main form should be disappeared and the login form should be shown.

### 5.	Login Form

In the login, form user should enter the same credentials given in registration. If the user has entered a wrong email or password an error message should be displayed via a message box.

![image](https://user-images.githubusercontent.com/49782156/174100327-22064902-3c0b-4458-8b42-6e2460fd363e.png)

If only the user has entered the correct credentials, the main form should be shown enabling the features.

![image](https://user-images.githubusercontent.com/49782156/174100433-3e5a5f1b-0c7e-4bd3-a64c-b375560740ac.png)
