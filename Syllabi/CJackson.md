# Purpose

This is the syllabus for Cameron Jackson.

# Student Background

Previous dev experience is some Matlab and Python. Knows types, loops and functions. Interested in learning C#.

# Syllabus

## The basics of development

- The basics of Git and GitHub
  - [How to navigate GitHub](/Git/NavigatingGitHub.md)
  - What is Git and GitHub?
  - [Git Concepts](/Git/GitConcepts.md)
  - [Pull Requests](../Git/PullRequests.md)
- How to use VS Code
  - [Download and install](https://code.visualstudio.com/)
  - General interface tour
  - [Useful extensions](VSCode/UsefulExtensions.md)

## C# Language

- Getting started with C#
  - [What is C# and .NET?](../CSharp/WhatIsCSharpAndDotNet.md)
  - [Making and running a console app](../CSharp/ConsoleApp.md)
  - Variables and data types
  - Printing to the console
  - Working with strings
    - Concatenation
    - Interpolation
    - Replace
  - Reading from the Console.
  - Error Handling
  - Comments
  - **Challenge**: Tell users their age (classic)
  - Arithmetic
  - If statements
  - Arrays and Lists
  - Loops
  - Methods (aka functions)
  - **Challenge**: [build exponent method](../CSharp/Exponent/ExponentQuestion.md)
- C# as an Object Oriented Language
  - Classes
    - Constructors
    - Properties vs Fields
    - Static vs dynamic
    - Extensions
  - **Challenge**: [Circle](../CSharp/Circle/CircleQuestion.md)
  - [Inheritance (scary)](../CSharp/InheritanceExample.cs)
    - Override vs new
    - base
  - Interfaces
  - **Challenge**: [Shapes with interfaces](../CSharp/Shapes/ShapesQuestion.md)
- Lambda's, Actions and LINQ
  - Lambda Expressions
    - ForEach extension
  - **Challenge**: [Even numbers](../CSharp/EvenNumbers/EvenNumbersQuestion.md) (Exercise 1)
  - LINQ
    - Select, Where
    - IEnumerable
  - **Challenge**: [Even numbers](../CSharp/EvenNumbers/EvenNumbersQuestion.md) (Exercise 2 & 3)

## My first GUI: WinForms

- My first GUI: WinForms
  - Using the designer
  - Positioning Controls inside others
  - Events
  - **Challenge**: Make the button list the contents of a text box
  - _OPTIONAL_ Programmatically changing controls
  - _OPTIONAL_ **Challenge**: Programmatically add controls to a TableLayoutPanel.

## Web Basics

- The basics of the Web
  - What is HTML?
  - What is CSS?
  - What is JavaScript
  - What is Node?
- HTML basics
  - Using the inspector
  - Tags
  - Properties
  - Events
  - Scripts
    - [What are scripts?](../HtmlCssJs/WhatAreScripts.md)
    - [Adding scripts](../HtmlCssJs/AddingScripts.md)
    - Document selectors
- Styling with CSS
  - Inline vs style tag vs file
  - Colours
  - Spacing
  - Display
    - Block
    - Inline-block
    - Flex
  - Font
- Javascript vs TypeScript

## Web APIs

- A basic Web API app using ASP.NET Core
  - Making a Controller
  - Using Postman (or similar)
    - HTTP Requests and their types
    - Response codes
  - Services through Dependency Injection
    - A config reader
    - **Challenge**: Logger interface with DI

## Web Apps

- Node.js basics
  - [Modules and Packages](../Node/ModulesAndPackages.md)
  - [Working with files](../Node/WorkingWithFiles.md)
- React
  - What is React?
  - useState
  - Components and props
  - useEffect
