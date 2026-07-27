# C# Object-Oriented Programming (OOP) 
## Overview
This repository contains a comprehensive, progressively built C# project. It demonstrates the practical implementation of core Object-Oriented Programming (OOP) concepts. The project was developed as a single cohesive solution, evolving day by day to integrate advanced C# features.

## Key Concepts Applied
*   **Encapsulation:** Proper use of access modifiers, properties (`{ get; set; }`), and constructor chaining.
*   **Inheritance & Polymorphism:** Creating a class hierarchy (`Shape`, `Line`, `Rectangle`, `Circle`) with `virtual` and `override` methods.
*   **Composition:** Building complex objects from simpler ones (e.g., `Picture` HAS-A `Shape`).
*   **Operator Overloading:** Customizing operators (`+`, `==`) for custom classes like `Fraction` and `Point3D`.
*   **Type Casting Operators:** Implementing `implicit` and `explicit` conversion operators for seamless type safety and data manipulation.

## Project Structure (Classes)
*   `Point3D`: A 3-dimensional point class focusing on operator overloading and constructor chaining.
*   `Fraction`: A mathematical fraction class handling arithmetic operations and custom implicit/explicit casting.
*   `Shape` (Base Class): Defines common properties and abstract/virtual behaviors for geometric shapes.
*   `Line`, `Rectangle`, `Circle`: Derived classes implementing specific behaviors.
*   `Picture`: A container class managing a collection of shapes, demonstrating composition and array processing.

## Technologies Used
*   C#
*   .NET