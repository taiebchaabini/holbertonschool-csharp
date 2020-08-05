#!/usr/bin/env bash
# Script to generate a new csharp project.
if [ "$#" -ne 2 ]; then
    echo "$0: needs two argument (dir name) and (namespace)"
    exit
fi
replace="<\/PropertyGroup>"
replaceWith="\t<DocumentationFile>bin\\\\\$(Configuration)\\\\\$(TargetFramework)\\\\\$(AssemblyName).xml<\/DocumentationFile>\n"
mkdir $1 && cd $1 && dotnet new sln && cd ..
mkdir $1/$2 && cd $1/$2 && dotnet new classlib && mv Class1.cs $2.cs && sed -i "s/$replace/$replaceWith$replace/g" $2.csproj && cd ..
dotnet sln add $2/$2.csproj
mkdir $2.Tests && cd $2.Tests && dotnet new nunit && mv UnitTest1.cs $2.Tests.cs && dotnet add reference ../$2/$2.csproj && cd ..
dotnet sln add $2.Tests/$2.Tests.csproj