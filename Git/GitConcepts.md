# Purpose
This file outlines common git concepts, and how it is used in a day to day basis.

# Commands

## Committing

TODO

## Pushing and pulling

TODO

## Branches
A branch is a way of contributing code without affecting other people's work.

You will always have a main branch, usually called **main**. You can commit directly to main, but you often don't want to do that. A unit of work you are doing will usually take several commits, and you usually want main to have only stable code in it, so it can be deployed to customers etc.

![A branch](/Git/images/OpenBranch.png)

To avoid doing everything in one commit or breaking main, you will usually create a **branch**, which will contain the commits for a piece of work, then once the work is complete and stable, you will **merge** it back into main.

![A merged branch](images/MergedBranch.png)

## Rebasing

TODO