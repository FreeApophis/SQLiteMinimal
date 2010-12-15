Minimal SQLite / DBLinq example:

This is a working example which runs on .NET(Windows) and Linux (Mono). The documentation of DbLinq is a bit sparse, and its difficult to get it right in the first run.

This small solution is a simple start for Programs which want to have SQLite backend with the Power of LINQ in C#.

The setup is minimal and therfore very simple, There is a simple Singleton to use the same Databse Connection, this could be done differently and without a singleton. However this makes the usage very simple.

All Manual written code is in the namespace "SQLiteMinimal", the Database is in the Namespace "Database".

This project should compile on Visual Studio 2010 / MonoDevelop 2.4+ / SharpDevelop 3.0+

