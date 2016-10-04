"Refer to the Git_Procedure_Step_By_Step document, which contains detailed instructions for accessing code stubs and submitting completed work from/to GitHub." 

QA Automation challenge 1 (go to a site and verify title)  

Part A: Automation

Write a class that automates the following tasks:

Automatically opens a web page,
Validates that the correct page was opened, by comparing the web page's title to an expected validation string,
Return boolen value, indicating the result of the comparison.

You are encouraged to use your imagination, and there is no "wrong" way to complete the challenge. However, your code does need to contain the following:

A publicly accessible class called "Automation1" which can be instantiated, with a no argument constructor. 

Inside the class, create a publicly accesible method called "GoToPage", which accepts two String arguments:

The first String argument must consist of a properly formed URL. This is the page that the method will open or navigate to. 

The second string argument represents the expected "title" value of the page, i.e. "Ski Utah home page."

The method GoToPage method must return a boolean, indicating whether or not title matches the second String argument.

You can use any other methods, classes, or other libraries you wish. 

Helpful Hint: The Selenium Webdriver library is quickly emerging as the de-facto standard for testing user interfaces on websites and web applications. As it's name infers, WebDriver opens a web browser and "drives" the interaction with the application, exactly as a user would. It's not necessarily required to use WebDriver for this challenge, but it is recommended: Not only will it save you a lot of coding, but it will give you valuable experience that is relevant in the current job market. If you're not familiar with WebDriver, you can learn more at the following web site: 

http://toolsqa.com/selenium-tutorial/

Part B: Exercise your class.

Write code that instantiates and exercises your Automation1 class. This can be done as a main method, unit tests, or any process you choose. If you use a Main method, it can not be in the "Automation1" class. 

The URL for the website is "http://www.skiutah.com" and the validation string for the title is "Ski Utah - Ski Utah."    

The result of the GoToPage method should somehow be displayed to the user. (Console message, dialogue box, playing a sound or video clip, flashing lights and bells- whatever you want.)

When you commit your project to the repository, PLEASE include a comment with any important information about your project.

