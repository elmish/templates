# Elmish templates

## Templates

This repository contains the following templates:

| Name  | Short Name | Description  |
|---|---|---|
| Fable.Template.Elmish.React | fable-elmish-react | This template will help set up a minimal elmish application to start a new project |
| Fable.Template.Elmish.React.Demo | fable-elmish-react-demo | This template contains a demo apps (usefull to test or explain elmish) |

## How to use ?

```bash
# First we install the template using the is Name
# For dotnet 1.x
dotnet new -i Fable.Template.Elmish.React::*
# For dotnet 2.x
dotnet new -i Fable.Template.Elmish.React

# Create a project called "awesome" using the Short Name of the template
# If you want to use yarn instead of npm add --yarn at the end of the command
dotnet new fable-elmish-react -n awesome

# Move into your new project directory
cd awesome
```
## If you choose to use yarn
```bash
# Install yarn dependencies
yarn install
# Install dotnet dependencies
dotnet restore
# Move into the source directory
cd src
# Start Fable server and Webpack dev server
dotnet fable yarn-start
```
## If you choose to use npm
```bash
# Install npm dependencies
npm install
# Install dotnet dependencies
dotnet restore
# Move into the source directory
cd src
# Start Fable server and Webpack dev server
dotnet fable npm-start
# In your browser, open: http://localhost:8080/
```
