# SM.Serialization

A serialization utility that can be injected into classes. (my FIRST GitHub package)

## Creating a GitHub NuGet Package

Once you have a dotnet project class library, make sure that all of the NuGet attributes are set.

### `dotnet` Command Line steps to publish the pacakge

You may need Git Bash

[Check for existing ssh key](https://help.github.com/en/github/authenticating-to-github/checking-for-existing-ssh-keys)

[Generate a new ssh key](https://help.github.com/en/github/authenticating-to-github/generating-a-new-ssh-key-and-adding-it-to-the-ssh-agent)

Add the ssh key (public) to the deploy keys in the settings of the GitHub repo.

1) Add attributes the `.csproj` file. [Learn More](https://help.github.com/en/packages/using-github-packages-with-your-projects-ecosystem/configuring-dotnet-cli-for-use-with-github-packages)

2) Add a `nuget.config` file.

3) Pack

        dotnet pack --configuration Release

4) Publish

        dotnet nuget push "bin/Release/SM.Serialization.1.0.0.nupkg" --source "github"
