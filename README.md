######################################################################

Coding Assignment

######################################################################


Instructions: 
======================================================================
1. There are 3 tasks in this assignment

2. Use C#, .NET 7, net core

3. Solutions to be posted in your own github account

4. To walkthrough the solution & demo it (For Senior, live demo during interview and for Junior, screen capture video to submit demo with candidate name by 07/Jul/2023 6PM SGT to email austinchua@smu.edu.sg)

5. Where possible to host the working solution in azure app service, free account





Tasks
======================================================================


1. Write a net core web api, "draw" for simple shape drawings.
----------------------------------------------------------------------


Input: { "shape": "square", size : 1 }
Output:
*

Input: { "shape": "square", size : 2 }
Output:
**
**

Input: { "shape": "square", size : 3 }
Output:
***
***
***

Constraints:
Input  : http post, json body
output : plain text
shape  : square only
size   : 0 <= size <= 100, whole number


2. Enhance api written in part 1, to draw a right-angled triangle
----------------------------------------------------------------------
Input: { "shape": "triangle", size : 1 }
Output:
*

Input: { "shape": "triangle", size : 2 }
Output:
*
**

Input: { "shape": "triangle", size : 3 }
Output:
*
**
***

Input: { "shape": "triangle", size : 4 }
Output:
*
**
***
****

Constraints:
Input  : http post, json body
output : plain text
shape  : square OR triangle only
size   : 0 <= size <= 100, whole number


3. Enhance api written, to accept character to be used in text drawings
----------------------------------------------------------------------
Input: { "shape": "triangle", size : 4, char: "*" }
Output:
*
**
***
****

Input: { "shape": "triangle", size : 4, char: "-" }
Output:
-
--
---
----

Input: { "shape": "square", size : 4, char: "-" }
Output:
----
----
----
----

Constraints:
Input  : http post, json body
output : plain text
shape  : square OR triangle only
size   : 0 <= size <= 100, whole number

