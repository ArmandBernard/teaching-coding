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

# .NET

## What is .NET?

.NET is a name for a few different things, but they are similar. .NET is a set of Frameworks around C# that allow you to do most things without using externally sourced libraries.

They extend language features and allow you to do things you'd usually need to hunt down libraries for in other languages.
It is maintained by **Microsoft**. You may, in fact, never need to use anything outside of .NET.

Things like: Building different types of applications (console, web, mobile, desktop); Storage Access; Network Access; Accessing specific Windows functionality or information; Game design (see Unity)...

These are just a few.

## .NET Versions

.NET has a few variations.
They globally all have the same things, but may be older or supported on different platforms.

### .NET Framework

The .NET Framework is Windows only. It's the OG, dating back to the late 90's. It is still supported, but most companies now use .NET Core for new projects.

One advantage of the .NET Framework over the others is that it is always installed on Windows machines and Windows update keeps it up to date. This means that if you are working at a company where most PCs you are going to install your applications run Windows, its a little easier to deploy as you don't need to make sure the machines have a runtime installed.

The downside is that the .NET Framework cannot normally run on other OS's like Mac OS or linux.

There is a caveat in that [Mono](https://www.mono-project.com/) exists. It's third party reimplementation of the .NET Framework to be used on other platforms. This, in theory, allows .NET Framework applications to run on other platforms without further modification.

It is however slow and buggy. It is **not** the recommended way of doing cross-platform any more. If you don't have a massive legacy codebase to migrate, it's much better to use .NET Core.

### .NET (Core)

The new, proper way to write .NET applications. It is cross platform and the best supported. Many new features are only being written for .NET Core.

It is open source, unlike the Framework.

For a bit, WinForms and WPF were not supported. Only ASP.NET. They are both supported now, but not cross-platform.

Note that from .NET 5.0, the "Core" branding has been somewhat dropped. Many people still call it .NET Core though, to differentiate with the still somewhat supported .NET Framework.

### .NET Standard

Apparently a way to write applications for the .NET Framework, Mono and .NET Core at the same time. It's more of a spec than anything I wouldn't bother with this.

## UI Frameworks

### Console

This is literally a console / terminal app. There's not much to say here. You can read and write to the console but not much else.

### WinForms

WinForms is one of the OG GUI Frameworks. It is very old, performs badly and looks ugly. That said, it is pretty darn simple to use. For that reason, it's not a bad starting point for many devs.

### WPF (Windows Presentation Foundation)

WPF is a little more modern, using code called XAML (similar to XML and HTML) to specify how components are arranged.

While it is a solid choice for more feature-filled applications and performs fine, its binding system is very difficult to use imo.

### Xamarin.Forms

This is used for building Android, iOS and Windows apps. It seems to be built a bit like WPF.

### MAUI (Multi-platform App UI)

This is the new thing apparently. It's still in preview, but its ready to use apparently.
It's a cross-platform GUI framework, designed to work not only with Desktop OS's like macOS and Windows, but iOS and Android. Doesn't seem like there's no _official_ linux support, sadly.

It's an evolution of Xamarin.Forms.
