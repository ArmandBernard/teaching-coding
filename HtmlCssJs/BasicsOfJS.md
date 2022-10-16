# Purpose

To explain the basics of JavaScript to someone who has never coded.

# Contents

- [Purpose](#purpose)
- [Contents](#contents)
- [What is JavaScript?](#what-is-javascript)
- [Variables](#variables)
  - [Setting variables](#setting-variables)
  - [Getting variables](#getting-variables)
  - [Difference between `const` and `let`](#difference-between-const-and-let)
- [Types](#types)
  - [Strings](#strings)
  - [Numbers](#numbers)
    - [Arithmetic](#arithmetic)
    - [Behaviours of numbers in JS](#behaviours-of-numbers-in-js)

# What is JavaScript?

JavaScript is a scripted language designed for the web. It started off pretty basic, but has changed a lot since its original introduction, gaining more of the features present in languages traditionally used to write full-fledged applications.

You can run JavaScript in all normal browsers, and nowadays you can also run it standalone as a console application with Node.js.

# Variables

Variables are what you use to store values you want to use later. Whether that's performing a calculation, getting text from a user etc.

There are two recommended ways to store use variables in JavaScript: `let` and `const`. You may also see `var` around in legacy (i.e. old) code, but it is not recommended to use it.

For now, I'll use const, as its what you should use by default. I'll go over the differences later.

## Setting variables

Say that you want to store the number `3` in a variable called `a`. This is how you would do it:

```js
const a = 3;
```

In programmer speak, you are **setting** `a` to `3`. The opposite would be `getting`, which is reading the value back out.

Breaking down the above syntax:

- `const` is the keyword indicating you are declaring a variable
- `a` is the name of the variable
- `=` is to indicate you want to set the thing on the left to be the value on the right (the order matters).
- `3` is the value to set the variable to.
- `;` is an indicator that this is the end of the command.

## Getting variables

So you've stored a value in a variable. What now?

Well, you'll have to `get` its value. To do that, you simply have to `call` its name.:

```js
const a = 3; // set a to 3
const b = a; // set b to the value of a (3)
```

is equivalent to

```js
const b = 3;
```

The important part here is that you just need to say its name and it will be like calling the value.

## Difference between `const` and `let`

You can use both let and const to store variables:

```js
const a = 3;
let b = 5;
```

So, what is the difference between using const and let?

`let` allows you to `set` a variable more than once.

i.e.

```js
let a = 3; // a is 3
a = 5; // a is now 5
```

Note a small detail here: you only need to say `let` or `const` when you declare a variable, i.e. the first time it is used.

You cannot set a variable to another value if it is declared with const:

```js
const a = 3; // a is 3
a = 5; // ❌ error!
```

So why use `const` at all, if it is more restrictive?

Well, its about good coding practice.

If you have a lot of code between setting a variable and using it, it may not be obvious what the value is at any given time.

```js
let a = 3;

... /// (lots of code here)

a = 5;

... /// (lots more code)

const b = a; // we may not know what the value is of a here!

```

By using `const`, you are saying that the value of a variable will not change. This means that when it comes to use the value you don't need to check all your code to see if it might have changed partway along.

This is called **immutability**. (The variable cannot mutate i.e. change)

This sort of thing makes your life a lot easier when the code gets longer and more complicated, multiple people work on the same code or you haven't seen you own code in a while!

# Types

Although JavaScript is not a strongly typed language, it does have type of data you'll have to interact with.

## Strings

Strings are what you store text in. It's called that probably because you are stringing together characters.

Characters are numbers, letters spaces, anything you can type.

For example, the following is a string.

```js
const words = "Hello World";
```

When declaring a string (i.e. saying what its contents are), you generally use double quotes. This is to make clear where the borders of the string are. For example:

`" Hello World"` and `"Hello World"` are not the same string, as the former has a space at the start. The space is a part of the string, so if you were to print it in a console or show or send it in a message, it would be shown.

## Numbers

`number` is the type you use when you want to store a numeric value you want to do calculations on, for example addition, counting etc.

```js
const a = 3;
```

### Arithmetic

Numbers support all the basic arithmetic you can do in a basic calculator.

```js
const a = 2 + 3; // 5
const b = 4 - 1; // 3
const c = 3 * 2; // 2 times 3 => 6
const d = 9 / 3; // 9 divided by 3 => 3
```

Of course, the same operations will work with stored numbers:

```js
const a = 2;
const b = 3;
const c = a * b; // 6
```

### Behaviours of numbers in JS

Numbers in JavaScript are somewhat ambiguous in their implementation. They can act like integers or floating point numbers depending on what you do to them and how you declare them.

I won't go into the intricacies of floating point and integers and how they act here, but for those who don't know what they are:

- integers are whole numbers e.g. `2, 5, 13, 16`
- floating point numbers are typically numbers that have a decimal place e.g. `0.1, 12.3, 6000.0`

This distinction is usually not very important in JavaScript at a beginner level, so I wouldn't worry about it too much.
