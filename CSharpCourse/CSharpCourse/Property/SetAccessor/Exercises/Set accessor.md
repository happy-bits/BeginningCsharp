﻿# Set accessor

Add a method *SetZipCode* that only change the zipcode if the zipcode is valid.

If someone want to change the zipcode to 234 56, it is okey. But if he/she tries to change the zipcode to 23X 45 or 23456 it shouldn’t be allowed. The only valid pattern is

    NNN NN
  
Where N is a number. 

Create an instance of Address and set the value of zipcode to different values:

![26](Images/26.png)

Create a method *GetZipCode* that returns the zipcode.

Next, create a property *ZipCode* with setters and getters, so you don't need the methods *GetZipCode* and *SetZipCode*

## Extra

1. What are the advantages of using a setter?

2. Use *regular expression* to test if the zipcode is valid

3. Use *regular expression* to test if the zipcode is valid and at the same time fetch the first and second pair of numbers (in the zipcode)

4. Create a new class with some properties where one of the properies is a setter.

## Hint

A normal class method:

    public void SetZippyCode(string newvalue)
    {
        ...
    }

A setter:

    public string ZipCode
    {
        set
        {
            ...
        }
    }