# 1 Manipulate a list

Create an app that ask for names, until the user write quit. Then sort the list and after that removes the first and last element in the list: 

![40](Images/40.png)


## Hint

Install **ConsoleUtilities** to simplify the interaction with the user

    PM> Install-Package happybits.ConsoleUtilities 

Example of usage:

    https://github.com/happy-bits/ConsoleUtilities

Use **RemoveAt** to remove a element:

    list.RemoveAt(3)

To sort a list:

    list.Sort()


