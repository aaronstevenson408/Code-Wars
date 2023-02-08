# Get the list of folders in the /Github/C#/ directory
$folders = Get-ChildItem -Path "/Github/C#/" -Directory

# Loop through each folder
foreach ($folder in $folders) {
    # Create a new console application project
    dotnet new console -n $folder.Name

    # Change the current directory to the new project folder
    cd $folder.FullName

    # Get the list of .cs files in the current folder
    $csFiles = Get-ChildItem -Path "../$folder.Name" -Filter *.cs

    # Loop through each .cs file
    foreach ($csFile in $csFiles) {
        # Copy the .cs file into the project folder
        Copy-Item $csFile.FullName .

        # Add the .cs file to the project
        Add-Content .\$folder.Name.csproj "<Compile Include='$csFile.Name' />"
    }

    # Build the project
    dotnet build

    # Change the current directory back to the /Github/C#/ folder
    cd ..
}