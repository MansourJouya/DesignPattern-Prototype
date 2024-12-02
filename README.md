# Design Patterns - Prototype

This repository showcases an implementation of the Prototype design pattern in C#. The code demonstrates how to create new objects by copying existing ones, which is useful for efficiently duplicating objects that are resource-intensive to create from scratch. This pattern ensures that cloned objects can be modified independently of the original object.

## Table of Contents
1. Introduction
2. Implementation Overview
3. Installation
4. Usage
5. Contributing
6. License
7. Contact

## Introduction
The Prototype design pattern is a creational pattern that involves creating a new object by copying an existing object, thus providing a way to create complex objects without needing to initialize them from scratch. This pattern is particularly useful when object creation is costly or when multiple variations of an object need to be created based on a similar structure.

## Implementation Overview
This repository provides a C# implementation of the Prototype design pattern for creating and cloning `Product` objects. Key components of the code include:

- **IPrototype Interface**: Defines the contract for objects that can be cloned.
- **Product Class**: A concrete class implementing the `IPrototype` interface with properties `Name` and `Price`. It includes a `Clone()` method for creating deep copies of the product.
- **Program Class**: Demonstrates how to create an original `Product`, clone it, modify the clone, and verify that the original and cloned objects remain distinct.

## Installation
To get started with this project, clone the repository to your local machine:

```bash
git clone https://github.com/MansourJouya/DesignPattern-Prototype.git
```

Navigate into the project directory:

```bash
cd DesignPattern-Prototype
```

Open the solution in Visual Studio or your preferred C# development environment to explore the implementation.

## Usage
1. Open the solution file (.sln) in your C# development environment.
2. Run the `Program` class to see the Prototype pattern in action.
3. Modify the `Product` class or the `Main()` method to customize the demonstration or create other types of products.

## Contributing
Contributions are welcome! If you would like to contribute to this project, please follow these steps:

1. Fork the repository.
2. Create a new branch (e.g., `git checkout -b feature/YourFeature`).
3. Make your changes and commit them (e.g., `git commit -m "Add some feature"`).
4. Push to the branch (e.g., `git push origin feature/YourFeature`).
5. Open a pull request.

## License
This project is licensed under the MIT License. See the [LICENSE file](LICENSE.txt) for details.

## Contact
For any inquiries, feel free to reach out at jouya.m@gmail.com.

