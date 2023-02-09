# Set the path to the "C#" directory in your GitHub repository
$basePath = 'C#'

# Get all the subdirectories in the base path
$directories = Get-ChildItem -Path $basePath -Directory

# Loop through each subdirectory
foreach ($directory in $directories)
{
    # Get all .cs files in the subdirectory
    $files = Get-ChildItem -Path $directory.FullName -Filter *.cs

    # Loop through each file
    foreach ($file in $files)
    {
        # Get the name of the file without the extension
        $projectName = $file.BaseName

        # Create a new folder with the project name in the subdirectory
        New-Item -ItemType Directory -Path "$($directory.FullName)/$projectName"

        # Copy the .cs file to the new folder
        Copy-Item $file.FullName "$($directory.FullName)/$projectName/$($file.Name)"

        # Navigate to the new folder
        Push-Location "$($directory.FullName)/$projectName"

        # Check if a .csproj file already exists in the folder
        if (!(Test-Path "$projectName.csproj"))
        {
            # Create a new .NET Core Console Application
            dotnet new console
        }

        # Build the project
        dotnet build

        # Pop back to the parent directory
        Pop-Location
    }
}