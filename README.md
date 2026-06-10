# Pure.Diagram.RelationalModel.HashCodes

Deterministic hash code implementations for diagram relational model entities in the **Pure** ecosystem.

[![.NET build & test](https://github.com/kudima03/Pure.Diagram.RelationalModel.HashCodes/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Diagram.RelationalModel.HashCodes/actions/workflows/build-and-test.yml)
[![Build and Deploy](https://github.com/kudima03/Pure.Diagram.RelationalModel.HashCodes/actions/workflows/publish-nuget.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Diagram.RelationalModel.HashCodes/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/Pure.Diagram.RelationalModel.HashCodes)](https://www.nuget.org/packages/Pure.Diagram.RelationalModel.HashCodes)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

## Overview

`Pure.Diagram.RelationalModel.HashCodes` provides sealed record types, each producing a deterministic byte-sequence hash for a diagram domain entity. Every type implements `IDeterminedHash` and prepends a unique 16-byte type prefix before concatenating field hashes, ensuring no collisions across entity types.

## Hash Types

| Type | Hashed Fields |
|------|--------------|
| `DiagramRelationalModelHash` | Id, Title, Description, TypeId |
| `DiagramTypeRelationalModelHash` | Id, Name |
| `DiagramSeriesRelationalModelHash` | Id, DiagramId, Label, Source |

## Dependencies

- [`Pure.Diagram.RelationalModel.Abstractions`](https://github.com/kudima03/Pure.Diagram.RelationalModel.Abstractions) — diagram relational model interfaces
- [`Pure.HashCodes`](https://github.com/kudima03/Pure.HashCodes) — deterministic hash computation
