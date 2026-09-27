# Problem 1 — Task Execution

## Problem

We need a system that can execute different kinds of tasks
through a single TaskRunner.

## Initial thought

Each task could have its own function.

## Problem with that approach

TaskRunner would need to know about every task type.

## Design

Introduce an ITask contract.

TaskA and TaskB implement ITask.

TaskRunner accepts ITask.

## Important concept

Runtime polymorphism.

The parameter is ITask, but the actual object determines
which Run() implementation executes.

