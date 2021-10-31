# 3ShapeTest

By Oscar Niles . 

This is my solution to the exercise that was given to me. 

Requires dotnet SDK (5.0.402) to be installed. Then the app can be run by opening the myapp application in the Application Folder.


## Functionality: 

FibonacciRequisition(n): Get the n'th Fibonacci Number

FindNPrimeNumber(n): Get the n'th Prime Number

CountWords(path): Count the words in the text file specified by path. Creates output file in the same directory. 

SocialDistance(string, k): How many more tables can be occupied without breaking the distance rule. The string is the initial configuration of occupied tables and k is the distance between occupied tables.

Quit(): closes the program

## Notes: 

For the CountWords exercise. The txt file is read into a string. I then strip all punctuation by iterating to the string and only adding non punctuation to a new string. 
This string is read into a dictionary word for word. The dictionary nicely fulfills the exercise requirements as we can use it to map words to the number of occurences of a word.
It is checked if a word already is in the dictionary, if yes: add +1 to number of occurences, else add the new word to the dictionary with 1 occurence.





