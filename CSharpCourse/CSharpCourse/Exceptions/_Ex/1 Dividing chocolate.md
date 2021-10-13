# 1 Dividing chocolate

Create an app that tells how many pieces each person get:

![29](Images/29.png)

Don’t validate the input. If the user enters zero an exception should be generated:

![30](Images/30.png)

Now, modify the program so you catch this exception. Use **try-catch** to solve this. If someone enters zero, it should now look like this:

![31](Images/31.png)

## Hint

Use **decimal** instead of **double**

To set a decimal value write an **M** at the end:

    decimal mydecimal = 123M

Format a number to two decimals:

    Console.WriteLine($"Text text {mynumber:.##} text text");

