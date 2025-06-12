# CatalogNote

## Overview

CatalogNote is a Windows Forms application targeting **.NET Framework 4.7.2**. The solution currently contains only the default `Form1` with no additional logic. Running the application simply opens this blank form.

## Building on Windows

1. Restore NuGet packages using MSBuild:
   ```
   msbuild CatalogNote.sln /t:Restore
   ```
2. Build the solution in `Debug` configuration:
   ```
   msbuild CatalogNote.sln /p:Configuration=Debug
   ```

The solution file `CatalogNote.sln` is located in the repository root.

## Building on Non‑Windows Platforms

The project targets the classic .NET Framework. Building on platforms other than Windows requires the reference assemblies for .NET Framework 4.7.2 to be installed or the project updated to multi‑target .NET Core/5+ in addition to .NET Framework.

