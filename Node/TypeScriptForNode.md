# Purpose

Explain how to set up TypeScript to use in Node.js (Node.ts? 🤔).

# Install ts-node

First step is to install `ts-node`.

```
npm i -D ts-node
```

If you want something like nodemon (to monitor changes), also add `ts-node-dev`.

Note however that `ts-node-dev` does not support ESModules, so you'll need to use the

```ts
import express = require("express");
```

syntax for imports.

Also remove `"type": "module"` from your `package.json`.

# Update scripts

Update your watch scripts to look something like this:

```json
  "scripts": {
    "start": "ts-node src/index.ts",
    "watch": "ts-node-dev src/index.ts"
  },
```

# Create a TypeScript configuration

Create a TypeScript config file in the root folder called `tsconfig.json`.

How you configure it is up to you. However here is a decent, strict starting point:

```json
{
  "compilerOptions": {
    "target": "es2015",
    "lib": ["dom"],
    "module": "CommonJS",
    "moduleResolution": "node",
    "allowJs": true,
    "esModuleInterop": true,
    "forceConsistentCasingInFileNames": true,
    "strict": true,
    "noImplicitThis": true,
    "noFallthroughCasesInSwitch": true
  }
}
```
