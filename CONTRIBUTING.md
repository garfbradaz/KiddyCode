# Contributing to KiddyCode

Welcome! We're excited that you want to contribute to KiddyCode. This document will help you get started.

## Code of Conduct

This project is meant to be a welcoming and inclusive space. We expect all contributors to:
- Be respectful and kind to others
- Help create a positive environment for learning
- Focus on constructive feedback
- Be patient with new contributors

## Getting Started

1. Fork the repository
2. Clone your fork
3. Create a new branch for your feature
4. Make your changes
5. Write or update tests
6. Run the test suite
7. Submit a Pull Request

## Development Setup

1. Install .NET 9.0 SDK
2. Clone the repository
3. Build the solution:
```
dotnet build
```
4. Run the tests:
```
dotnet test
```

## Project Structure

- `src/KiddyCode.Compiler/` - The main compiler project
- `tests/KiddyCode.Compiler.Tests/` - Unit tests
- `examples/` - Example KiddyCode programs
- `docs/` - Documentation

## Pull Request Process

1. Update the README.md with details of changes if needed
2. Update the examples if you've added new language features
3. Add tests for any new features
4. Update documentation as needed
5. The PR will be merged once you have the sign-off of at least one maintainer

## Writing Good Commit Messages

- Use the present tense ("Add feature" not "Added feature")
- Use the imperative mood ("Move cursor to..." not "Moves cursor to...")
- Limit the first line to 72 characters or less
- Reference issues and pull requests liberally after the first line

## Running Tests

```bash
dotnet test
```

## Style Guidelines

- Use clear, descriptive names for variables and functions
- Add comments to explain complex logic
- Follow C# coding conventions
- Keep methods focused and small
- Write unit tests for new features

Thank you for contributing to KiddyCode! 🚀