## Build and running the app
//#if (yarn)
1. Install npm dependencies: `yarn install`
//#else
1. Install npm dependencies: `npm install`
//#endif
2. Install dotnet dependencies: `dotnet restore`
3. Move into the `src` directory: `cd`src
//#if (yarn)
4. Start Fable server and Webpack dev server: `dotnet fable yarn-start`
//#else
4. Start Fable server and Webpack dev server: `dotnet fable npm-start`
//#endif
5. In your browser, open: [http://localhost:8080/](http://localhost:8080/)

Any modification you do to the F# code will be reflected in the web page after saving.
