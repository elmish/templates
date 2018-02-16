# Elmish templates

## Templates

This repository contains the following templates:

| Name  | Short Name | Description  |
|---|---|---|
| Fable.Template.Elmish.React | fable-elmish-react | This template will help set up a minimal elmish application to start a new project |
| Fable.Template.Elmish.React.Demo | fable-elmish-react-demo | This template contains a demo apps (usefull to test or explain elmish) |

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

## If you choose to use yarn
```bash
# Install yarn dependencies
yarn install
# Move into the source directory
cd src
# Install dotnet dependencies
dotnet restore
# Start Fable server and Webpack dev server
dotnet fable yarn-start
# In your browser, open: http://localhost:8080/
```

Note that yarn may emit a warning ``info fsevents@1.1.2: The platform "win32" is incompatible with this module``.  
You can safely ignore this.

## If you choose to use npm
```bash
# Install npm dependencies
npm install
# Move into the source directory
cd src
# Install dotnet dependencies
dotnet restore
# Start Fable server and Webpack dev server
dotnet fable npm-start
# In your browser, open: http://localhost:8080/
```
