# Elmish templates

## Templates

This repository contains the following templates:

| Name  | Short Name | Description  |
|---|---|---|
| Fable.Template.Elmish.React | fable-elmish-react | This template will help set up a minimal elmish application to start a new project |

## How to use ?

:warning: You can't use `.` or `-` in your project name. We are already tracking [this issue](https://github.com/fable-elmish/templates/issues/7) and wait for a fix in [dotnet template](https://github.com/dotnet/templating/issues/402) :warning:

```bash
# First we install the template using the is Name
# For dotnet 1.x
dotnet new -i Fable.Template.Elmish.React::*
# For dotnet 2.x
dotnet new -i Fable.Template.Elmish.React

# Create a project called "awesome" using the Short Name of the template
# If you want to use yarn instead of npm add --yarn at the end of the command
dotnet new fable-elmish-react -n awesome -lang f#

# Move into your new project directory
cd awesome
```

### Maintainers

To release a new version:

1. Update the Release Notes
2. Update the version in `src/react/Fable.Template.Elmish.React.proj`
3. Run `dotnet fsi build.fsx`