# SM.Serialization

A serialization utility that can be injected into classes. (my FIRST GitHub package)

## Creating a GitHub NuGet Package

Once you have a dotnet project class library, make sure that all of the NuGet attributes are set.

### `dotnet` Command Line steps to publish the pacakge

[Obtain a GitHub Personal Access Token](https://help.github.com/en/github/authenticating-to-github/creating-a-personal-access-token-for-the-command-line)

**DO NOT LEAVE YOUR PAT IN THE `nuget.config` FILE**

1) Add attributes the `.csproj` file. [Learn More](https://help.github.com/en/packages/using-github-packages-with-your-projects-ecosystem/configuring-dotnet-cli-for-use-with-github-packages)

2) Add a `nuget.config` file.

3) Pack

        dotnet pack --configuration Release

4) Publish

        dotnet nuget push "bin/Release/SM.Serialization.1.0.0.nupkg" --source "github"
