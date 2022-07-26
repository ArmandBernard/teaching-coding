# Purpose

A set of exercises designed to test your understanding of interfaces.

# Exercises

## Exercise 1

Build an interface called `IShape` that has a `Perimeter` and `Area` methods. Both should be parameterless and return a `double`.

Then, apply that interface to your [Circle](../Circle/CircleQuestion.md) class.

## Exercise 2

Create a new class also implementing the `IShape` interface called `Rectangle`.

As you'd expect, it should return valid values for its `Perimeter` and `Area` using its two dimensions, `Height` and `Width`.

`Height` and `Width`, just like in Circle, should be get-only properties.

## Exercise 3

Create an array of `IShape` with one `Circle` and one `Rectangle`.

Loop over the array and calculate the total `Area` covered by all shapes in the array.
