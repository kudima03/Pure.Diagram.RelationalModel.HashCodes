using System.Collections;
using Pure.Diagram.RelationalModel.Abstractions;
using Pure.HashCodes;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.Random.String;
using Guid = Pure.Primitives.Guid.Guid;

namespace Pure.Diagram.RelationalModel.HashCodes.Tests;

public sealed record DiagramTypeRelationalModelHashTests
{
    private readonly byte[] _typePrefix =
    [
        199,
        25,
        157,
        1,
        217,
        41,
        153,
        115,
        188,
        62,
        126,
        170,
        109,
        210,
        255,
        28,
    ];

    [Fact]
    public void ProduceCorrectHashFromModel()
    {
        IGuid id = new Guid();
        IString name = new RandomString();

        IDiagramTypeRelationalModel model = new DiagramTypeRelationalModel(
            id,
            name
        );

        DiagramTypeRelationalModelHash expected = new DiagramTypeRelationalModelHash(model);
        DiagramTypeRelationalModelHash actual = new DiagramTypeRelationalModelHash(model);

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromValues()
    {
        IGuid id = new Guid();
        IString name = new RandomString();

        IDiagramTypeRelationalModel model = new DiagramTypeRelationalModel(
            id,
            name
        );

        DiagramTypeRelationalModelHash expected = new DiagramTypeRelationalModelHash(model);
        DiagramTypeRelationalModelHash actual = new DiagramTypeRelationalModelHash(
            id,
            name
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHash()
    {
        IGuid id = new Guid();
        IString name = new RandomString();

        IDiagramTypeRelationalModel model = new DiagramTypeRelationalModel(
            id,
            name
        );

        DiagramTypeRelationalModelHash expected = new DiagramTypeRelationalModelHash(model);
        DiagramTypeRelationalModelHash actual = new DiagramTypeRelationalModelHash(
            new DeterminedHash(id),
            name
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromNameHash()
    {
        IGuid id = new Guid();
        IString name = new RandomString();

        IDiagramTypeRelationalModel model = new DiagramTypeRelationalModel(
            id,
            name
        );

        DiagramTypeRelationalModelHash expected = new DiagramTypeRelationalModelHash(model);
        DiagramTypeRelationalModelHash actual = new DiagramTypeRelationalModelHash(
            id,
            new DeterminedHash(name)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromHashes()
    {
        IGuid id = new Guid();
        IString name = new RandomString();

        IDiagramTypeRelationalModel model = new DiagramTypeRelationalModel(
            id,
            name
        );

        DiagramTypeRelationalModelHash expected = new DiagramTypeRelationalModelHash(model);
        DiagramTypeRelationalModelHash actual = new DiagramTypeRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(name)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void EnumeratesAsUntyped()
    {
        IGuid id = new Guid();
        IString name = new RandomString();

        IDiagramTypeRelationalModel model = new DiagramTypeRelationalModel(
            id,
            name
        );

        IEnumerable hashEnumerable = new DiagramTypeRelationalModelHash(model);
        IEnumerator<byte> expectedHash = new DeterminedHash(
            _typePrefix
                .Concat(new DeterminedHash(model.Id))
                .Concat(new DeterminedHash(model.Name))
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
        IString name = new RandomString();

        IDiagramTypeRelationalModel model = new DiagramTypeRelationalModel(
            id,
            name
        );

        IEnumerable<byte> expectedHash = new DeterminedHash(
            _typePrefix
                .Concat(new DeterminedHash(model.Id))
                .Concat(new DeterminedHash(model.Name))
        );

        Assert.Equal(expectedHash, new DiagramTypeRelationalModelHash(model));
    }
}
