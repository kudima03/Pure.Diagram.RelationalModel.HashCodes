# Changelog

All notable changes to Pure.Diagram.RelationalModel.HashCodes are documented here.

Format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).

---

## [0.1.0-preview.1.0.0] — 2026-04-19

### Changed

- **Breaking:** `SeriesRelationalModelHash` renamed to `DiagramSeriesRelationalModelHash`,
  with its model constructor now accepting `IDiagramSeriesRelationalModel`.

## [0.1.0-preview.0.2.0] — 2026-04-06

### Added

- Additional constructor overloads on `DiagramRelationalModelHash`,
  `DiagramTypeRelationalModelHash`, and `SeriesRelationalModelHash` accepting any
  combination of raw field values and pre-computed `IDeterminedHash` instances.

### Changed

- The all-hashes constructors on `DiagramRelationalModelHash` and
  `DiagramTypeRelationalModelHash` are now public (previously private).

## [0.1.0-preview.0.1.0] — 2026-03-23

Initial release.

### Added

- `DiagramRelationalModelHash` — deterministic hash for a diagram entity
  (`Id`, `Title`, `Description`, `TypeId`), implementing `IDeterminedHash`.
- `DiagramTypeRelationalModelHash` — deterministic hash for a diagram type
  entity (`Id`, `Name`).
- `SeriesRelationalModelHash` — deterministic hash for a diagram series
  entity (`Id`, `DiagramId`, `Label`, `Source`).
