

function buildVS
{

    process
    {

            Write-Host "Cleaning $PSScriptRoot" -foregroundcolor green
            & dotnet clean $PSScriptRoot
			
			Write-Host "Building $PSScriptRoot\ReuseLibrary" -foregroundcolor green
        & dotnet msbuild $PSScriptRoot
        

        Write-Host "Running Unit Tests at $PSScriptRoot\ReuseLibraryTest" -foregroundcolor green
        & dotnet test $PSScriptRoot\UnitTestProject
    }
}


buildVS












