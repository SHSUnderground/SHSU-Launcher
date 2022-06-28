# The following parameters should be passed from Visual Studio

param (
    [string]$Name,
    [string]$ProjectDir,
    [string]$TargetDir,
    [string]$TargetPath
)

# Names of files that will be added to zip file

[array]$fileNames = Get-ChildItem *.* -Name

# Version

$assembly = [System.Reflection.Assembly]::LoadFile($TargetPath)
$v = $assembly.GetName().Version;
$version = [string]::Format("{0}.{1}.{2}",$v.Major, $v.Minor, $v.Build)

# Load Ionic.Zip

$pathToAssembly = Join-Path -path $TargetDir -childpath "Ionic.Zip.Reduced.dll"
[System.Reflection.Assembly]::LoadFrom($pathToAssembly)

$archive = new-object Ionic.Zip.ZipFile

#  Add all files

foreach ($f in $fileNames)
{
    Write-Host "adding to zip file: " $f
    $archive.AddFile($f, "")
}

# Save to .zip file

$zipfile = $TargetDir + "Releases\SHSO_Launcher_Update_" + $version + ".zip"
Write-Host "path to zip file: " $zipfile

$archive.Save($zipfile)
$archive.Dispose()

