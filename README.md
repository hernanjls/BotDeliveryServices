BotDeliveryServices
Accepts as input a text file that will include the name of each drone and the maximum weight it can carry, 
along with a number of locations and the total weight that needs to be delivered to that specific location. 
The program finds the most efficient way to perform the deliveries for each drone on each trip made.

The client should be able to run the project and have the results displayed.

Given Input 

Line 1: [Drone #1 Name], [#1 Maximum Weight], [Drone #2 Name], [#2 Maximum Weight], etc. 
Line 2: [Location #1 Name], [Location #1 Package Weight] 
Line 3: [Location #2 Name], [Location #2 Package Weight] 
Line 4: [Location #3 Name], [Location #3 Package Weight] Etc. 

Expected Output [Drone #1 Name] Trip #1 [Location #2 Name], [Location #3 Name] Trip #2

[Location #1 Name]

[Drone #2 Name] Trip #1 [Location #4 Name], [Location #7 Name] Trip #2 [Location #5 Name], [Location #6 Name]

Requirements 🔧

Need install SDK for .Net CLI, .NET 6.0 SDK or later:

Instalation 🔧

download the repository in THE local machine, install .NET CLI SDK

Use cmd in the clone directory for execute the solution:

For restore use the following commands

dotnet --version

dotnet restore

In order to restore all projects dependencies,

Command to Run the project

dotnet run

Once the program is running it reads the input file "InputFile.txt" located in the Sources folder which should automatically be copied to the bin directory 
where the application executables are generated, for this verify if use Visual studio IDE, that the "InputFile.txt" has the attribute "copy to output directory" marked as "Copy always"

