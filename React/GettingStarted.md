# Purpose

To explain how to get a React project up and running.

# Contents

- [Purpose](#purpose)
- [Contents](#contents)
- [Options](#options)
- [Guide for Vite](#guide-for-vite)
  - [Why Vite?](#why-vite)
  - [Setup Node](#setup-node)
  - [Vite setup](#vite-setup)
    - [Wizard](#wizard)
  - [Created files](#created-files)
  - [Installing packages](#installing-packages)
  - [Running the project](#running-the-project)

# Options

There are many ways to run React.

You can run it with many different back-ends. However, you will usually need Node.js at some point in the process.

The main difference in how it will be **packaged**, **bundled** and **rendered**.

Rendering-wise, you can use Server-Side Rendering, partial hydration, or a front-end rendered Single Page Application.

Packaging-wise You can run React apps on the web, or as **desktop applications** using tools like React Native and Electron.

Bundling is the process of combining JavaScript libraries for a given webpage or application and shipping it out with HTML and CSS.
There are many popular tools for bundling including: Webpack, Vite and Rollup.

Do some research and find out which is best for your application!

# Guide for Vite

## Why Vite?

In this document, I'm going to detail how to set up a React application using [Vite](https://vitejs.dev).

Why Vite? Well:

- Changes you make in code are immediately and quickly updated in the browser on file save using Hot Module Reload.
- It's very easy to set up as long as you are writing a Single Page Application.
- It works well with TypeScript

To me, it's the easiest way to set up a basic project when you want to quickly write front-end code.

## Setup Node

We're going to start from nothing, an empty directory.

First, [set up Node](../Node/GettingStarted.md#node-setup).

## Vite setup

Once you've done the above, you can setup vite for your project.

You can use a wizard, or [specify a template](https://vitejs.dev/guide/#scaffolding-your-first-vite-project).

If you aren't sure, just use the wizard as described below.

### Wizard

First, ensure your command line's current directory is where you want to set up your new project.

Then, run the Vite wizard:

```sh
npm create vite@latest
```

This will ask you some questions.

You will be asked if you want to install `create-vite`. You can answer yes (`y`).

You will then be asked your desired project name. Leave it at default or type one then continue.

Next, you will be asked about your front-end framework.

```
? Select a framework: » - Use arrow-keys. Return to submit.
>   Vanilla
    Vue
    React
    Preact
    Lit
    Svelte
    Others
```

Here, we want to select React.

You will then be asked if you want to use JavaScript or TypeScript.

You're probably better off choosing TypeScript, as its better and it doesn't stop you from writing JavaScript if you really want to.

If you see an option for SWC... I'm not sure what that is, some [Rust-based accelerator apparently](https://swc.rs/), probably best to leave it off for simplicity's sake.

After these options, Vite should create a project folder in the current directory, named after your project.

## Created files

The files created by Vite may change as the template does, but your project structure should look something like this:

```
│   .gitignore
│   index.html
│   package.json
│   tsconfig.json
│   tsconfig.node.json
│   vite.config.ts
│
├───public
│       vite.svg
│
└───src
    │   App.css
    │   App.tsx
    │   index.css
    │   main.tsx
    │   vite-env.d.ts
    │
    └───assets
            react.svg
```

Vite creates a very basic project that shows Vite working.

Once you've seen it working once, you will likely want to remove most of the contents of `App.tsx`; all of `App.css` and `index.css`; and the asset `react.svg`.

I'll leave that to you, though. If you're reading this, you should probably know how HTML, CSS and JS works, so you should be able to remove the broken imports etc that comes with those deletions.

## Installing packages

Although Vite has set up the project, you still need to install the packages specified in `packages.json` by running `npm install`.

## Running the project

You can see the npm scripts Vite has created, in `package.json`:

```json
  ...
  "scripts": {
    "dev": "vite",
    "build": "tsc && vite build",
    "preview": "vite preview"
  },
  ...
```

The development script dev will allow you to run your code in such a way that your code is updated live in the browser as you change your files.

You can run the dev script using `npm run dev`.

Your console output will look something like this:

```
 VITE v4.0.1  ready in 417 ms

  ➜  Local:   http://127.0.0.1:5174/
  ➜  Network: use --host to expose
  ➜  press h to show help
```

Your project is now running, and the link provided will open your app in your browser!

To stop Vite, simply close the terminal or close the process (Ctrl + C in most shells).
