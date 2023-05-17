#r "nuget: Fun.Build, 0.3.8"
#r "nuget: Fake.IO.FileSystem, 5.23.1"
#r "nuget: FsToolkit.ErrorHandling, 4.6.0"

open Fun.Build
open Fake.IO
open Fake.IO.Globbing.Operators
open Fake.IO.FileSystemOperators
open FsToolkit.ErrorHandling
open System.Text.RegularExpressions

pipeline "Release" {

    stage "Clean artifacts" {
        paralle

        run(fun _ ->
            [ 
                "src/react/bin/"
                "src/react/obj/"
            ]
            |> Shell.cleanDirs
        )

    }

    stage "Package: Fable.Template.Elmish.React" {
        workingDir "src/react"

        whenAll {
            envVar "NUGET_KEY"
        }

        run (fun ctx -> 
            asyncResult {
                let! dotnetPackOutput = ctx.RunCommandCaptureOutput "dotnet pack"

                let m = Regex.Match(dotnetPackOutput, ".*'(?<nupkg_path>.*\.(?<version>.*\..*\..*)\.nupkg)'")

                if not m.Success then
                    failwithf "Couldn't find NuGet package in output: %s" dotnetPackOutput

                let nupkgPath = m.Groups.["nupkg_path"].Value
                let nugetKey = ctx.GetEnvVar "NUGET_KEY"

                do! ctx.RunSensitiveCommand $"dotnet nuget push {nupkgPath} -k {nugetKey} -s https://api.nuget.org/v3/index.json"
            }
        )
    }

    runIfOnlySpecified false
}

tryPrintPipelineCommandHelp()
