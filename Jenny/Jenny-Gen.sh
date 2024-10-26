#!/bin/bash
dir="/Users/rimurutempest/RimuruDev/UnityProjects/Internal/Meadow2D/Jenny"
cd $dir
dotnet "$dir/Jenny.Generator.Cli.dll" gen "$dir/JennyRoslyn.properties" -v
