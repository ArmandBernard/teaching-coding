# Purpose

To explain how modules and packages work in Node.js.

# What are modules?

Modules are bits of code that can be exported and imported.

Importing allows you to use code from other files inside your file, allowing you to organise your code and use externally sourced code.

# Import/Export Syntax

Importing and exporting can be done in one of two syntaxes.

## Import

CommonJS:

```js
const { myFunction } = require("myFile");
```

NOTE: For TypeScript files, use

```ts
import { myFunction } = require("myFile");
```

ESModules:

```js
import { myFunction } from "myFile";
```

## Export

Both of these would be in "myFile.js"

CommonJS:

```
module.exports = {
    myFunction : function() {
        console.log("this is my function")
    }
}

or

exports.myFunction = function () {
  console.log("this is my function");
};

```

ESModules:

```
export function myFunction() {
    console.log("this is my function")
}
```

## Syntax info

In both cases here, the module name is `myFile` and the exported/imported item (usually a function or class) is `myFunction`.

The CommonJS approach, and is the traditional way of doing it.

The ESModules approach is more recent. To use this, you must set `"type": "module"` inside package.json.

# NPM and External Packages

You can install packages published by others using NPM.

NPM stands for Node Package Manager, and is used to manage installed packages.

## Initializing

Initialize a new directory using

`npm init`

This will ask you for the values for a few fields. If you can't be bothered, use `npm init -y` to use the defaults.

It will then create a `package.json` file.

This has information about your project including any installed packages.

The name, description and version number are also included in case you ever want to publish your code as a package yourself.

## Installing, upgrading and removing packages

Packages can be be managed using npm commands. Installed packages will be listed in the `package.json` file.

### Install

To install a package, run

`npm install <package-name>`

or

`npm i <package-name>`

for example, to install `express`, a web framework:

`npm install express`

#### Global install

Adding `-g` will install globally. This should be done for stuff you don't need in your project but is useful for you in your dev work.

I would generally recommend against this unless you know what you're doing, as you may ship project people can't run.

#### Specific version install

If you want to install an alpha, beta or older version of a package, you can do so by running

`npm install <package-name>@<version>`

### Upgrade

To upgrade a package, simply run an install command again.

### Remove

To remove a package, run

`npm uninstall <package-name>`

or

`npm rm <package-name>`

## After installing

After installing a package, it will be added to the dependency list in `package.json`.

```
...
  "license": "MIT",
  "dependencies": {
    "express": "^4.18.1"
  }
}
```

The package files themselves will live in a folder called `node_modules`.
You should never have to interact with the files in this folder directly, except perhaps deleting the folder itself to fix issues.

You should also never commit the contents of this folder to git. The reason is that this folder can be MASSIVE, and _what_ modules are installed is much more important than the module contents themselves.

It is easy to reinstall dependencies given that they are specified in `package.json`. See [Restoring](#restoring) for more information.

## Restoring

When you check out a project from GitHub or similar, the modules will be specified in `package.json` but not installed on your local machine.

This will prevent your program from running correctly.

To ensure that all installed modules match what is specified in `package.json`, simply run:

`npm install`

This will install all packages specified and upgrade any that need to be upgraded.

You should ideally do this whenever you pull changes or change branches, especially if you aren't sure if a package was added or removed by someone.
