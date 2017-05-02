# Project Eliminator Document


## Elevator Dispatch System
### Project Eliminator
#### Product Name: Eliminator Elevator Dispatch System
#### Product Version: Alpha
#
### Product Development History
#### 2017/4/30:
v0.1: basic C# testing demo launched by Yaxuan LANYU;
v0.2: project created by Yaxuan LANYU;
v0.3: basic class of elevator dispatch designed by Yaxuan LANYU after looking up meterials about multi-threading and elevator dispatch;
v0.4: basic classes implemented by Yaxuan LANYU;

#### 2017/5/1:
v0.5: basic UI designed by Yaxuan LANYU;
v0.6: UIControl functionality implemented by Yaxuan LANYU;
v0.7: logic relationship between UI contents and classes implemented by Yaxuan LANYU;
v0.8 patches: several logic bugs fixed by Yaxuan LANYU;
v0.9 patches: several optimization functionalities added by Yaxuan LANYU;

#### 2017/5/2:
Alpha: project’s final development procedure finished, adding icons and form name, etc. By Yaxuan LANYU;


## Introduction to Product
### Open the Application
#### 1.Execute Eliminator.exe with 1.ico in the same folder. 
NOTE: If 1.ico does not exist, an error message box will be presented. Should the message box appear, click continue to ignore it. Nothing will be influenced except for the icon shown on the top-left corner of the form.

#### 2.Open Eliminator.sln in the Course Project’s VS2015 Solution folder with Visual Studio 2015 or later version of Visual Studio and do the run operation.
NOTE: Using later version of Visual Studio may cause unpredictable errors and warnings, user may need to optimize the code and fix the bugs himself.

#
### About the Codes
#### 1.Elevator.cs:
Declaration and Defination of class Elevator were implemented here. Elevator mainly deals with the status of an elevator.

#### 2.ElevatorController.cs:
Declaration and Defination of class ElevatorController were implemented here. ElevatorController deals with all the operations about the elevators and optimize their status.

#### 3.FloorController.cs:
Declaration and Defination of class FloorController were implemented here. FloorController is a class storing information representing the panels’ status at all floors.

#### 4.MainView.cs:
Codes implemented the interaction between the form and classes were written here. Also the UIControl method is implemented here.

#### 5.MainView.Designer.cs & Program.cs:
System automatically created codes to optimize the form and its content or set the program entrance.

#
### Application’s Display and Operations
On the leftmost of the form, the total elevator status view is presented, showing the dispatch of each elevator. The square represents an entrance of an elevator on a floor. When the square’s color is white, the elevator is absent. When it is blue, the elevator is present but its door is closed. When it is green, the elevator is present and its door is open.

On the rightmost of the form, a panel with tab is displayed. Click on the tab to choose the elevator to be optimized. Then on the optimization panel, click on the buttons which are the delegates of floor-choosing controller to release a task to the chosen elevator. On top of the buttons is a label showing the elevator’s status. By clicking the alert button, an alert will be sent in the form of message box, meaning that an alert is sent to the relevant individuals. Click on the gate control buttons to open or close the door when the elevator stops at one floor.

To the right of the total elevator dispatch view, between it and elevator optimization panel, is the panel representing the buttons’ status on each floor outside of the elevators. Upon clicking on it, tasks are released to elevators.

All the operations done on the panels will be displayed graphically.

#
### Solution to the Problem
#### 1.Problem Analysis:
Finish a demo imitating the real elevator’s working procedure. Use whatever method to implement it. Make a visualized presentation to show the result.

#### 2.Logic Solution:
a)First, by analysing the problem, we split the whole solution to three stages.
b)At stage one, we make clear the relations between elevators, elevators’ interior control panel, control panels on each floor exterior to the elevetors and the elements to display their status and control. We find that the elevators and whatsever interior to them can be intergrated into the same kind of entity. While the control panels on each floor exterior the the elevators are intergrated into another kind of entity. And that we need a third kind of entity to handle them and everything related to them. Apart from them we also need a independent graphic handler. Upon defining such handler, a relation between so said handler and the total control entity needs to be established.
c)At stage two, we implement the entities. With Elevator controlling the elevators and all the elements included in them while FloorController controlling the elements excluded from them. Then we create the graphic view of the application, relating them to codes. We create a third class named ElevatorController to intergrate Elevator and FloorController. With it we handle all the requests and status-changings of elements relevant to elevators. Meanwhile, we implement the detailed display of elements in the form by linking every individual element of it to a status of elevators. After all things above done, we implement a method to dynamically optimize the form.
d)At stage three, we finish all other work as icon making, process terminating, etc., making the product more efficient, and also, more user-friendly. Then we write the document about the project and the product.

#### 3.Technical Solution:
As we need to handle all the elevators seperatedly, we need the thought of multi-threading. At a point where a request is made, we search for an unused elevator, creating a thread for it, and dispatching it with work.
For every elevator working in its own thread, it check on the global status of the tasks and optimize its own tasks.
To display the form and information dynamically, we also create another thread to do the UI Control. This UI Control optimize elements in the graphic view with data the ElevatorController object provides.
Because the rendering thread, id est, UIControl thread, is in an infinite loop, we must terminate all the process relevant to the program upon exiting the application.

#### 4.Detailed Solution:
THIS PART OF THE SOLUTION WILL BE PRESENTED IN CODES ATTACHED.
