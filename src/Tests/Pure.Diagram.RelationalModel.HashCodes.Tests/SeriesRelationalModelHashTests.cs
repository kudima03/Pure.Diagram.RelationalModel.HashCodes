using System.Collections;
using Pure.Diagram.RelationalModel.Abstractions;
using Pure.HashCodes;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.Random.String;
using Guid = Pure.Primitives.Guid.Guid;

namespace Pure.Diagram.RelationalModel.HashCodes.Tests;

public sealed record SeriesRelationalModelHashTests
{
    private readonly byte[] _typePrefix =
    [
        201,
        25,
        157,
        1,
        204,
        13,
        106,
        123,
        136,
        91,
        21,
        239,
        183,
        107,
        218,
        55,
    ];

    [Fact]
    public void ProduceCorrectHashFromModel()
    {
        IGuid id = new Guid();
        IGuid diagramId = new Guid();
        IString label = new RandomString();
        IString source = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            diagramId,
            label,
            source
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(model);

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromValues()
    {
        IGuid id = new Guid();
        IGuid diagramId = new Guid();
        IString label = new RandomString();
        IString source = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            diagramId,
            label,
            source
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            id,
            diagramId,
            label,
            source
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHash()
    {
        IGuid id = new Guid();
        IGuid diagramId = new Guid();
        IString label = new RandomString();
        IString source = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            diagramId,
            label,
            source
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            new DeterminedHash(id),
            diagramId,
            label,
            source
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDiagramIdHash()
    {
        IGuid id = new Guid();
        IGuid diagramId = new Guid();
        IString label = new RandomString();
        IString source = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            diagramId,
            label,
            source
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            id,
            new DeterminedHash(diagramId),
            label,
            source
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashDiagramIdHash()
    {
        IGuid id = new Guid();
        IGuid diagramId = new Guid();
        IString label = new RandomString();
        IString source = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            diagramId,
            label,
            source
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(diagramId),
            label,
            source
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromLabelHash()
    {
        IGuid id = new Guid();
        IGuid diagramId = new Guid();
        IString label = new RandomString();
        IString source = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            diagramId,
            label,
            source
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            id,
            diagramId,
            new DeterminedHash(label),
            source
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashLabelHash()
    {
        IGuid id = new Guid();
        IGuid diagramId = new Guid();
        IString label = new RandomString();
        IString source = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            diagramId,
            label,
            source
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            new DeterminedHash(id),
            diagramId,
            new DeterminedHash(label),
            source
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDiagramIdHashLabelHash()
    {
        IGuid id = new Guid();
        IGuid diagramId = new Guid();
        IString label = new RandomString();
        IString source = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            diagramId,
            label,
            source
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            id,
            new DeterminedHash(diagramId),
            new DeterminedHash(label),
            source
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashDiagramIdHashLabelHash()
    {
        IGuid id = new Guid();
        IGuid diagramId = new Guid();
        IString label = new RandomString();
        IString source = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            diagramId,
            label,
            source
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(diagramId),
            new DeterminedHash(label),
            source
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromSourceHash()
    {
        IGuid id = new Guid();
        IGuid diagramId = new Guid();
        IString label = new RandomString();
        IString source = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            diagramId,
            label,
            source
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            id,
            diagramId,
            label,
            new DeterminedHash(source)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashSourceHash()
    {
        IGuid id = new Guid();
        IGuid diagramId = new Guid();
        IString label = new RandomString();
        IString source = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            diagramId,
            label,
            source
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            new DeterminedHash(id),
            diagramId,
            label,
            new DeterminedHash(source)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDiagramIdHashSourceHash()
    {
        IGuid id = new Guid();
        IGuid diagramId = new Guid();
        IString label = new RandomString();
        IString source = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            diagramId,
            label,
            source
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            id,
            new DeterminedHash(diagramId),
            label,
            new DeterminedHash(source)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashDiagramIdHashSourceHash()
    {
        IGuid id = new Guid();
        IGuid diagramId = new Guid();
        IString label = new RandomString();
        IString source = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            diagramId,
            label,
            source
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(diagramId),
            label,
            new DeterminedHash(source)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromLabelHashSourceHash()
    {
        IGuid id = new Guid();
        IGuid diagramId = new Guid();
        IString label = new RandomString();
        IString source = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            diagramId,
            label,
            source
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            id,
            diagramId,
            new DeterminedHash(label),
            new DeterminedHash(source)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashLabelHashSourceHash()
    {
        IGuid id = new Guid();
        IGuid diagramId = new Guid();
        IString label = new RandomString();
        IString source = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            diagramId,
            label,
            source
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            new DeterminedHash(id),
            diagramId,
            new DeterminedHash(label),
            new DeterminedHash(source)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDiagramIdHashLabelHashSourceHash()
    {
        IGuid id = new Guid();
        IGuid diagramId = new Guid();
        IString label = new RandomString();
        IString source = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            diagramId,
            label,
            source
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            id,
            new DeterminedHash(diagramId),
            new DeterminedHash(label),
            new DeterminedHash(source)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromHashes()
    {
        IGuid id = new Guid();
        IGuid diagramId = new Guid();
        IString label = new RandomString();
        IString source = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            diagramId,
            label,
            source
        );

        SeriesRelationalModelHash expected = new SeriesRelationalModelHash(model);
        SeriesRelationalModelHash actual = new SeriesRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(diagramId),
            new DeterminedHash(label),
            new DeterminedHash(source)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void EnumeratesAsUntyped()
    {
        IGuid id = new Guid();
        IGuid diagramId = new Guid();
        IString label = new RandomString();
        IString source = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            diagramId,
            label,
            source
        );

        IEnumerable hashEnumerable = new SeriesRelationalModelHash(model);
        IEnumerator<byte> expectedHash = new DeterminedHash(
            _typePrefix
                .Concat(new DeterminedHash(model.Id))
                .Concat(new DeterminedHash(model.DiagramId))
                .Concat(new DeterminedHash(model.Label))
                .Concat(new DeterminedHash(model.Source))
        ).GetEnumerator();

        bool equal = true;

        foreach (object item in hashEnumerable)
        {
            _ = expectedHash.MoveNext();
            if ((byte)item != expectedHash.Current)
            {
                equal = false;
                break;
            }
        }

        Assert.True(equal);
    }

    [Fact]
    public void ProducesCorrectHash()
    {
        IGuid id = new Guid();
        IGuid diagramId = new Guid();
        IString label = new RandomString();
        IString source = new RandomString();

        ISeriesRelationalModel model = new SeriesRelationalModel(
            id,
            diagramId,
            label,
            source
        );

        IEnumerable<byte> expectedHash = new DeterminedHash(
            _typePrefix
                .Concat(new DeterminedHash(model.Id))
                .Concat(new DeterminedHash(model.DiagramId))
                .Concat(new DeterminedHash(model.Label))
                .Concat(new DeterminedHash(model.Source))
        );

        Assert.Equal(expectedHash, new SeriesRelationalModelHash(model));
    }
}
