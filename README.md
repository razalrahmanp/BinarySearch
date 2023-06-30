# BinarySearch

The code is a simple implementation of binary search algorithm. It takes an array of integers and a target number as input, and searches for the target number within the array using binary search. 
 Here is a step-by-step explanation of the code:
 1. The code starts by defining a class named "Program" with a Main method as the entry point of the program.
 2. Inside the Main method, an example usage of the binary search algorithm is shown. An array of integers named "array" is defined with some values. The target number is obtained from user input using the GetUserInput method.
 3. The BinarySearch method is called with the array and target number as arguments, and the result is stored in the "result" variable.
 4. If the result is not -1 (indicating that the target element was found), a message is printed to the console indicating the index at which the target element was found. Otherwise, a message indicating that the target element was not found is printed.
 5. The program waits for the user to press the Enter key before exiting.
 6. The BinarySearch method is defined. It takes an array of integers and a target number as input.
 7. Two variables, "left" and "right", are initialized to represent the left and right boundaries of the search range within the array.
 8. The method enters a while loop that continues as long as the left boundary is less than or equal to the right boundary.
 9. Inside the loop, the middle index is calculated as the average of the left and right boundaries.
 10. If the element at the middle index is equal to the target number, the method returns the middle index as the result.
 11. If the element at the middle index is less than the target number, the left boundary is updated to be the middle index + 1.
 12. If the element at the middle index is greater than the target number, the right boundary is updated to be the middle index - 1.
 13. If the loop completes without finding the target element, the method returns -1 to indicate that the target element was not found.
 14. The GetUserInput method is defined. It takes a string message as input, prints the message to the console, reads a line of user input, converts it to an integer, and returns the integer value.
