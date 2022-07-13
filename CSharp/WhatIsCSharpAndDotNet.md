# Purpose

To Explain what C# and .NET is.

# C#

## What is it?

C#, pronounced "see sharp" 👀, is a language designed to be used with .NET.

It is not the only language that works with .NET, namely **Visual Basic** (usually abbreviated to VB) also supports it. Which one you use is a preference thing, but almost everyone uses C# over VB.

## Properties of C#

C# has few features as a language that may not be true in other languages. I will outline them below.

### Strongly Typed

C# is strongly typed.

This can mean a few different things based on who you ask, but here's how it works in C#.

Data types, for example `int`, `string`, and other custom types of `object` known as `classes` are unambiguously applied at **compile time** (before you can run the code).

There are ways of overriding this on a case-by-case basis, but they are highly discouraged.

In addition, types are checked at **run time**. So if data comes in from external code that doesn't match what you were expecting, errors will be thrown.

### Object Oriented

C# is Object-oriented. This means it is designed around the use of objects and classes.

It is how you are meant to pass data around, and how you are to organise code.

The other two types of programming are **Procedural** and **Functional** programming.

**Procedural programming** is what is used in more scripting-oriented languages, where all the code is run start to end, with perhaps global functions. If you come from languages like MATLAB, you were likely writing in a procedural manner.
It scales poorly, and is mostly good for very small projects.

**Functional programming**
Functional programming is structured around functions rather than objects, as you'd expect from the name.
It usually involves stacking multiple functions to transform data.
Common focuses in functional programming languages are immutable data structures, lack of side-effects in functions etc.
It usually reduces bugs, but is not necessarily suitable for every application.

What you will find is that C# can do **ALL 3** types of programming, as they are programming styles.

However, a language is usually designed around one. F# and Haskell, for example, are languages that only support Functional programming, and are designed around it, so they are better at making sure you do things write in the context of Functional Programming.

Similarly, C# is very well designed around Objects, and therefore is very good at checking you are doing things correctly within that context and working with those structures.

We can take inspiration from other styles of programming to get some of their benefits too.

### Garbage Collection

C# has garbage collection.

This means that memory held by variables that is not explicitly cleared will be cleared automatically later.

This can have the downside that memory leaks can happen in some scenarios if good coding practices are not followed.

Other languages may require you to explicitly dispose of objects or clear memory or cause memory leaks (C) or prevent you from compiling at all if you have missing memory clearing calls (Rust).

The scenarios in C# where you have to manually clear memory usually involve when you are using an external resource, such as storage and network.
At a junior level, the guidance is that if an object has a `.Dispose()`, call it when you are done or use it with a `using` statement. This will cover you 95% of the time. I may write more on this at a later date.

### LINQ

LINQ, or Language Integrated Query (LINQ) is a language feature that is effectively a neater way of doing loops. I will discuss in more detail at a later date.

### Mostly synchronous, with asynchronous capability

C# is synchronous by default, which means that it will run linearly through the code without any parallel processing.

However, there are several ways that code can be run across multiple threads and CPU Cores. You will likely need to use .NET classes for this though, so I'm not sure if this is technically a language feature.
