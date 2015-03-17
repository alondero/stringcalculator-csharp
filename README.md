# String Calculator
TDD Kata to introduce unit testing and how making small steps and refactoring give you confidence in changing logic.

## Before you start: 
Try not to read ahead.
Do one task at a time. The trick is to learn to work incrementally.
Make sure you only test for correct inputs. there is no need to test for invalid inputs for this kata

## Steps

1. The calculator should return 0 when it is passed an empty string
2. The calculator should return the number when it is passed in as a string
3. The calculator should return the addition of two numbers when provided like "1,2". The response here should be 3
4. The calculator should be able to add an unlimited amount of numbers
5. The calculator should also be able to add numbers if they are line separated eg: "2\n2". The response here should be 4
6. The calculator should be able to support custom delimiters if they are specified in the input first. They should look like this: “//[delimiter]\n[numbers…]” for example “//;\n1;2” should return three where the default delimiter is ‘;’ . This line is optional.
7. The calculator should throw an exception of "Negatives Not Allowed" - if the input contained a negative number
8. The exception message should contain the negative number
9. The exception message should contain all negative numbers that are contained in the input