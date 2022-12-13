# Purpose

Get you up and running with Node.js! Running through the below steps will create a new Node.js application which can load a html file.

# Contents

- [Purpose](#purpose)
- [Contents](#contents)
- [Creating and serving a basic website](#creating-and-serving-a-basic-website)
  - [Node Setup](#node-setup)
  - [Add a .gitignore](#add-a-gitignore)
  - [Create a basic homepage](#create-a-basic-homepage)
    - [Add express](#add-express)
    - [HTML](#html)
    - [CSS](#css)
  - [Serve up the page](#serve-up-the-page)
  - [Add a VS Code run task](#add-a-vs-code-run-task)
  - [Run the application!](#run-the-application)

# Creating and serving a basic website

## Node Setup

Initialise node

`npm init`

Optionally, add ` -y` to the above go with defaults.

Enable ESModule syntax by adding
`"type": "module"` to package.json.

## Add a .gitignore

The following steps will add a lot of files to the project we don't want to add to git, so add a `.gitignore` at the root of the project with the following contents:

```
/node_modules

package-lock.json
```

## Create a basic homepage

### Add express

To host a basic homepage, start by installing [express](https://expressjs.com/) and its types:

`npm install express`

`npm install --save-dev @types/express`

### HTML

Create a new folder called `public` in the root directory.

Then create a basic HTML file in `public` called `index.html`:

```html
<!DOCTYPE html>
<html lang="en">
  <head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0" />
  </head>
  <body>
    Hello World
  </body>
</html>
```

### CSS

Styles are essential to making a good looking website!

Create a new file called `index.css` inside `./public/css`, then add the following contents to make the text red!

```css
body {
  color: red;
}
```

Add the following line inside the html file's `<head>` tag to include the css file:

```html
<link rel="stylesheet" href="css/index.css" />
```

## Serve up the page

To server the file to the user, we need to make a web server and endpoint.

To do this, create a new file called `index.js` in the root directory and add the following contents:

```js
import express from "express";
import { promises as fsp } from "fs";

// port to host on
const port = process.env.PORT || 3000;
const app = express();

// create a page endpoint for the index.html file
app.get("/", async (_, res) => {
  // send the index.html file to the client
  res.sendFile(path.join(__dirname, "public", "index.html"));
});

// get express to listen on the port, and tell the user what port we're using
app.listen(port, () =>
  console.log(`Go to http://localhost:${port} to see the webpage!`)
);
```

## Add a VS Code run task

We can create VS Code action to allow us to run code from VSCode easier.

Create a new folder called `.vscode` then add a file called `launch.json` with these contents:

```json
{
  // Use IntelliSense to learn about possible attributes.
  // Hover to view descriptions of existing attributes.
  // For more information, visit: https://go.microsoft.com/fwlink/?linkid=830387
  "version": "0.2.0",
  "configurations": [
    {
      "type": "node",
      "request": "launch",
      "name": "Launch Program",
      "skipFiles": ["<node_internals>/**"],
      "program": "${workspaceFolder}\\index.js"
    }
  ]
}
```

## Run the application!

At this point, your project folder should now look something like this:

![Folder Contents](images/GettingStartedFolderContents.png)

You should now be able to run your app either by running

```
node .
```

or by using VSCode UI

![Run Application](images/LaunchProgram.png)

Once it's running, you will see this in the console:

![Program running in Debug Console](images/RunningInDebugConsole.png)

Ctrl + click on the link to go to the webpage your site is being hosted on, and you should see the words "Hello World!".

![Basic website running in the browser](images/BasicWebsiteInBrowser.png)

Congrats! You just created a basic website!

When you want to stop the program, either press the stop in the control bar (if run through VS Code)...

![Program Control Bar](images/VSCodeControlBar.png)

...or press Ctrl+C to in the terminal (if you ran it from there).
