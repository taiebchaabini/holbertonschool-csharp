#!/usr/bin/env bash
# Bash script that initializes, build and run a new C# project 
<<<<<<< HEAD
dotnet new console -o 2-new_project
dotnet build 2-new_project 
dotnet run --project 2-new_project/2-new_project.csproj
=======
dotnet new console -o 2-new_project && cd 2-new_project && dotnet build && dotnet run && cd ..
>>>>>>> 9037856c1e59e27871c166f24f0ba22dfe618d85
