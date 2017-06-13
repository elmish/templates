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
dotnet new fable-elmish-react -n awesome

# Move into your new project directory
cd awesome
# Install npm dependencies
yarn install
# Install dotnet dependencies
dotnet restore
# Start Fable server and Webpack dev server
dotnet fable shell-run "yarn start"
# In your browser, open: http://localhost:8080/
```
