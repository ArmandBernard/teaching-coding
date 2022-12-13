# Purpose

To explain the more advanced hooks and behaviour of React.

# Contents

- [Purpose](#purpose)
- [Contents](#contents)
- [`useEffect`](#useeffect)
  - [Anatomy](#anatomy)
  - [Dependencies](#dependencies)
- [Mounting and unmounting](#mounting-and-unmounting)
  - [Example](#example)
  - [How do I avoid unmounting?](#how-do-i-avoid-unmounting)
    - [Prop drilling](#prop-drilling)
    - [Hiding with CSS](#hiding-with-css)

# `useEffect`

`useEffect` is a hook that can be used to trigger code in components when **state or props change**.

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

## Dependencies

Dependencies are what will trigger. If left empty, useEffect will only trigger once on [mount](#mounting-and-unmounting).

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
