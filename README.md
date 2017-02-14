# Test_Triangles

## Week 1
###Test cases for the triangle program
| Input 1 | Input 2 | Input 3 | Output |
|---|---|---|---|
|10|2|2|"Not a triangle|
|2|10|2|"Not a triangle|
|2|2|10|"Not a triangle|
|3|3|3|"Equilateral triangle"|
|6|4|4|"Isosceles triangle"|
|4|6|4|"Isosceles triangle"|
|4|4|6|"Isosceles triangle"|
|3|4|5|"Scalene triangle"|
|0|2|2|"Invalid input"|
|2|0|2|"Invalid input"|
|2|2|0|"Invalid input"|
|-1|2|2|"Invalid input"|
|2|-1|2|"Invalid input"|
|2|2|-1|"Invalid input"|
|"Test"|2|3|"Invalid input"|
|2|"Test"|3|"Invalid input"|
|2|3|"Test"|"Invalid input"|
|0.5|1|1|"Invalid input"|
|1|0.5|1|"Invalid input"|
|1|1|0.5|"Invalid input"|
|0x7FFFFFFF + 1|5|5|"Invalid input"|
|5|0x7FFFFFFF + 1|5|"Invalid input"|
|5|5|0x7FFFFFFF + 1|"Invalid input"|

## Week 2
### 1. Static Code Analysis of triangle program
#### a) Install Metrics software in your IDE (see tool examples in slides)
Done
#### b) Check coding standards in your Triangle program
![alt text](http://i68.tinypic.com/30j5yci.png)
#### c) Calculate central metrics in your Triangle program
![alt text](http://i64.tinypic.com/mjabk3.png)
#### d) Find out what CC variation that your metrics tool uses
Visual studio 2015 enterprise edition uses CC2. This can be seen in the method isTriangle method which has a CC complexity of 10.
#### e) Possibly refactor your code based on static testing results
See latest commit

### 2. Peer Review of your Triangle program
I have reviewed [This project](https://github.com/tjaydk/TriangleTestAsp4) from Dennis Rønnebæk

I klassen Program.cs
* I method getInput()
 - Fjern usings der ikke bliver brugt.
 - Fjern input variable, og læg den direkte ned i tryParse metoden.
 - Lad være med at instantiere val, da 1 ikke er den rigtige værdi der skal returneres. Retuner i if statementet istedet.
 - Fjern val = int.Parse(input); i if statementet da val allerede er sat i din tryParse metode.
 - I stedet for tryParse kan du eventuelt bruge en try catch til at fange format og overflow exceptions
 
 I klassen Triangle.cs
 * I method calculateType(int{} values)
 - Skift nummer 2 if statement ud med en if else {}, og slut med en else i stedet for bare at returnere
 
 - Fjern usings der ikke bliver brugt
 - Istedet for at variablerne hedder orderedVal[0], OrderedVal[1] og OrderedVal[2] og brug navnene a,b og c da det er de navne man ville bruge på siderne i en trekant
 
### 3. Coding Standard Document
- Use XML Docs on all public methods
- Use indent to have staments parameters and declarations to be lined up under each other 
- Statements with long multiple conditions should be broken down to different lines and lined up
- Method and variable names should be humanly readable
- Remove unused using dependencies from classes
- Global variables should be declared in beginning of class file
- Local variables should be declared in the beginning of methods
