# CatalogNote

## Overview

CatalogNote is a Windows Forms application targeting **.NET Framework 4.7.2**. The application manages students, disciplines and grades using a local JSON file.

Features include:

- CRUD operations for students, disciplines and notes;
- Viewing statistics such as averages and pass/fail status;
- Exporting the catalog to CSV.

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

The project targets the classic .NET Framework. On Linux, Mono's `xbuild` can be used to build the project after installing the `mono-complete` package.

