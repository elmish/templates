# Fable.Elmish.React Template

This template can be used to generate a simple web app with [Fable](http://fable.io/) and [Elmish](https://fable-elmish.github.io/).
You can find more templates by searching `Fable.Template` packages in [Nuget](https://www.nuget.org).

## Requirements

* [dotnet SDK](https://www.microsoft.com/net/download/core) 1.0.4 or higher
* [node.js](https://nodejs.org) 4.8.2 or higher
//#if (yarn)
* [yarn](https://yarnpkg.com): JS package manager
//#else
* npm5: JS package manager
//#endif
Although is not a Fable requirement, on macOS and Linux you'll need [Mono](http://www.mono-project.com/) for other F# tooling like Paket or editor support.

## Building and running the app

//#if (yarn)
1. Install JS dependencies: `yarn install`
//#else
1. Install JS dependencies: `npm install`
//#endif
2. Install F# dependencies: `dotnet restore`
//#if (yarn)
3. Start Fable daemon and [Webpack](https://webpack.js.org/) dev server: `dotnet fable yarn-start`
//#else
3. Start Fable daemon and [Webpack](https://webpack.js.org/) dev server: `dotnet fable npm-start`
//#endif
4. In your browser, open: http://localhost:8080/

Any modification you do to the F# code will be reflected in the web page after saving.

## Project structure

### Paket

[Paket](https://fsprojects.github.io/Paket/) is the package manager used for F# dependencies. It doesn't need a global installation, the binary is included in the `.paket` folder. Other Paket related files are:

- **paket.dependencies**: contains all the dependencies in the repository.
- **paket.references**: there should be one such a file next to each `.fsproj` file.
- **paket.lock**: automatically generated, but should committed to source control, [see why](https://fsprojects.github.io/Paket/faq.html#Why-should-I-commit-the-lock-file).
- **Nuget.Config**: prevents conflicts with Paket in machines with some Nuget configuration.

> Paket dependencies will be installed in the `packages` directory. See [Paket website](https://fsprojects.github.io/Paket/) for more info.

//#if (yarn)
### yarn

- **package.json**: contains the JS dependencies together with other info, like development scripts.
- **yarn.lock**: is the lock file created by yarn.

> JS dependencies will be installed in `node_modules`. See [yarn](https://yarnpkg.com) website for more info.
//#else
### npm

- **package.json**: contains the JS dependencies together with other info, like development scripts.
- **package-lock.json**: is the lock file created by npm5.

> JS dependencies will be installed in `node_modules`. See [npm](https://www.npmjs.com/) website for more info.
//#endif

### Webpack

[Webpack](https://webpack.js.org) is a bundler, which links different JS sources into a single file making deployment much easier. It also offers other features, like a static dev server that can automatically refresh the browser upon changes in your code or a minifier for production release. Fable interacts with Webpack through the `fable-loader`.

- **webpack.config.js**: is the configuration file for Webpack. It allows you to set many things: like the path of the bundle, the port for the development server or [Babel](https://babeljs.io/) options. See [Webpack website](https://webpack.js.org) for more info.

### F# source files

The template only contains two F# source files: the project (.fsproj) and a source file (.fs) in `src` folder. Note Fable is a local dotnet CLI tool that is downloaded by the project file.
