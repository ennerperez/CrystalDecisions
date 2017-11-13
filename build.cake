#tool nuget:?package=NUnit.ConsoleRunner&version=3.4.0
//////////////////////////////////////////////////////////////////////
// ARGUMENTS
//////////////////////////////////////////////////////////////////////

var target = Argument("target", "Default");
var configuration = Argument("configuration", "Release");

//////////////////////////////////////////////////////////////////////
// PREPARATION
//////////////////////////////////////////////////////////////////////

// Define directories.
var buildDir = Directory("./build") + Directory(configuration);

// Define solutions.
var solutions = new Dictionary<string, string>();

// Define CR Version
var crVersion = System.IO.File.ReadAllText("VERSION");

// Define version.
var version = EnvironmentVariable("APPVEYOR_BUILD_VERSION") ?? Argument("version", crVersion);

//////////////////////////////////////////////////////////////////////
// TASKS
//////////////////////////////////////////////////////////////////////

Task("Clean")
    .Does(() =>
{
    CleanDirectory(buildDir);
    CleanDirectories("./**/bin");
    CleanDirectories("./**/obj");
});

Task("Build-NuGet-Packages")
    .IsDependentOn("Clean")
    .Does(() =>
    {
            foreach (var file in new System.IO.DirectoryInfo(@".").GetFiles("*.nuspec"))
            {
				var path = file.Directory;
                var nuGetPackSettings = new NuGetPackSettings()
                {
                    OutputDirectory = buildDir,
                    IncludeReferencedProjects = false,
                    Version = version,
                    Properties = new Dictionary<string, string>()
                    {{ "Configuration", configuration }}
                };
                NuGetPack(file.FullName, nuGetPackSettings);
            }
});

//////////////////////////////////////////////////////////////////////
// TASK TARGETS
//////////////////////////////////////////////////////////////////////

Task("Default")
	.IsDependentOn("Build-NuGet-Packages");

//////////////////////////////////////////////////////////////////////
// EXECUTION
//////////////////////////////////////////////////////////////////////

RunTarget(target);