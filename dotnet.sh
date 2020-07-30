#!/usr/bin/env bash
# Script to generate a new csharp project.
if [ "$#" -ne 1 ]; then
    echo "$0: needs one argument (project name)"
    exit
fi
replace="<\/PropertyGroup>"
replaceWith="\t<DocumentationFile>bin\\\\\$(Configuration)\\\\\$(TargetFramework)\\\\\$(AssemblyName).xml<\/DocumentationFile>\n"
dotnet new console -o $1 && mv $1/*.cs $1/$1.cs
sed -i "s/$replace/$replaceWith$replace/g" $1/$1.csproj