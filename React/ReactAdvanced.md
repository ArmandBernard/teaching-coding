# Purpose

To explain the more advanced hooks and behaviour of React.

# Contents

- [Purpose](#purpose)
- [Contents](#contents)
- [`useEffect`](#useeffect)
  - [Anatomy](#anatomy)
  - [The effect](#the-effect)
  - [Dependencies](#dependencies)
  - [Caveats](#caveats)
    - [Effect not triggering when expected / triggering every refresh](#effect-not-triggering-when-expected--triggering-every-refresh)
    - [Double triggers on load](#double-triggers-on-load)
- [`useMemo`](#usememo)
  - [When to use](#when-to-use)
  - [Anatomy](#anatomy-1)
  - [Example](#example)
- [Mounting and unmounting](#mounting-and-unmounting)
  - [Example](#example-1)
  - [How do I avoid unmounting?](#how-do-i-avoid-unmounting)
    - [Prop drilling](#prop-drilling)
    - [Hiding with CSS](#hiding-with-css)

# `useEffect`

`useEffect` is a hook that allows you to run a piece of code only when specified pieces of **state or props change**.

For example, perhaps you only want to fetch data on component load. Or maybe you want to load in a library or set up some resources.

## Anatomy

The useEffect call is one of the hardest ones to understand because it has many different parts that aren't particularly clear.

```jsx
useEffect(
  () => {
    // The code to run when the effect is triggered

    return () => {
      /// Clean-up code to run when the component is unmounted (optional)
    };
  },
  [a, b, c] // dependencies that will trigger the effect
);
```

## The effect

The effect is the main body of code provided in the first argument.

It is the code you intend to run when the dependencies require it to.

## Dependencies

Dependencies are what will trigger the effect. They are provided as the second argument of the hook.

If left empty, `useEffect` will only trigger once on [mount](#mounting-and-unmounting).

Not providing a second argument at all is not recommended, as it will cause the affect to trigger on every render, which is usually not the intended use-case.

## Caveats

### Effect not triggering when expected / triggering every refresh

Because dependencies use `Object.is()` for comparison, a reference change will trigger it.
To understand this better, look up _reference types in JavaScript_.

The gist of it is that you may have an array with the same items inside or an object with the same properties, but if it isn't **the same object or array** because (for example, it has been reconstructed) it will be considered changed.

### Double triggers on load

React Strict Mode will mount, unmount and remount your component on page load. This is a test to see if you are correctly cleaning things up, so make sure you do so!

Your logic should not rely on something only being called only once. If it does, it should ensure that any resources that were created are correctly disposed of in the clean-up function.

For example, say that you load a script into the page on component mount. You should remove it on component unmount or undo its effects so that when the component is remounted it does result in duplicated effects!

See also [mounting and unmounting](#mounting-and-unmounting).

# `useMemo`

The `useMemo` hook is used to prevent expensive recalculations from being frequently and unnecessarily repeated by caching their results.

It works by performing the calculation only when the dependencies change.

## When to use

This hook is best used when:

- there are multiple reasons the component may rerender
- there is an expensive calculation to perform, perhaps a bunch of array operations including sorts
- prop changes often don't require the calculation to be redone

## Anatomy

```js
const calculatedValue = useMemo(
  () => {
    // The calculations, ultimately returning the calculated value
    return a + b;
  },
  [a, b] // dependencies
);
```

The arrow function above will only be performed if `a` or `b` changes.

## Example

The below example demonstrates how useMemo can be useful.

Imagine in this case that a + b is a slow calculation.

Every character typed into the first input will cause the component to rerender and therefore all code to re-run.
This includes the a + b calculation, that has nothing to do with the first input and does not need to be recalculated.

```jsx
const Example = () => {
  const [a, setA] = useState(0);
  const [b, setB] = useState(0);

  // "heavy" calculation
  const c = a + b;
  console.log(`c was recalculated as ${c}`);

  return (
    <div style={{ display: "flex", flexDirection: "column" }}>
      <label>
        Text input that causes component rerender but does not relate to the
        calculation <input type="text" />
      </label>
      <label>
        a{" "}
        <input
          type="number"
          value={a}
          onChange={(e) => setA(e.target.valueAsNumber)}
        />
      </label>
      <label>
        b{" "}
        <input
          type="number"
          value={b}
          onChange={(e) => setB(e.target.valueAsNumber)}
        />
      </label>
      Sum: {c}
    </div>
  );
};
```

By using useMemo, we can ensure that c is only recalculated when needed, i.e. when a or b (its dependencies) change.

```jsx
const Example = () => {
  const [a, setA] = useState(0);
  const [b, setB] = useState(0);

  const c = useMemo(() => {
    // "heavy" calculation
    const calcC = a + b;
    console.log(`c was recalculated as ${calcC}`);

    return calcC;
  }, [a, b]);

  return (...); // unchanged render code omitted for brevity
};
```

You can check all this by opening your browser's dev console and seeing when the recalculation message is logged.

# Mounting and unmounting

The concepts of mounting and unmounting components is somewhat important when it comes to state management, component life-cycle and clean-up.

Mounting occurs when a component is loaded into a page or parent component.

Unmounting happens when changing pages or when conditionally un-rendered.

The next time it is conditionally rendered, it will be mounted again.

Unmounting will dispose of a component and its **state will be lost**.

## Example

The below code demonstrates mounting and unmounting. You can increment the counter, but if you unmount the component its state will be lost.

```jsx
const ParentComponent = () => {
  const [showChild, setShowChild] = useState(true);

  return (
    <div>
      <div>Counter</div>
      {showChild && <Counter />}
      <button onClick={() => setShowChild(!showChild)}>Toggle mount</button>
    </div>
  );
};

const Counter = () => {
  const [counterValue, setCounterValue] = useState(0);

  return (
    <div>
      <div>Counter is at {counterValue}</div>
      <button
        onClick={() => {
          setCounterValue(counterValue + 1);
        }}
      >
        Add 1
      </button>
    </div>
  );
};
```

## How do I avoid unmounting?

Unmounting components is a common way to hide them. Say for example that you want to switch between in-app tabs but want to keep a hold of user selections.

However, unmounting means losing state. Is there a way of hiding components without losing state?

Yes. In fact there are several.

### Prop drilling

Firstly, you could hold the important state in the parent, and pass it down using prop drilling. If the parent manages all the state, there is no state to lose in the child.

While this can be effective, it can also result in overly weighty components and non-idiomatic code. The child should manage it's own state if it affects nothing else.

### Hiding with CSS

You can always visually hide elements using CSS.

I would avoid some methods people use like making components one pixel tall, as they are bad for accessibility and can still be interacted with with keyboard navigation. It will just be confusing!

Instead, I would probably use the CSS property `display: none`. That will make any tag its applied to and its children invisible to users and screen readers and impossible to normally interact with. It won't stop scripts seeing it though, and you can see it with a web inspector.
