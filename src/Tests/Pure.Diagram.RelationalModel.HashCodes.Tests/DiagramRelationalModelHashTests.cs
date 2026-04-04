using System.Collections;
using Pure.Diagram.RelationalModel.Abstractions;
using Pure.HashCodes;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;
using Pure.Primitives.Random.String;
using Guid = Pure.Primitives.Guid.Guid;

namespace Pure.Diagram.RelationalModel.HashCodes.Tests;

public sealed record DiagramRelationalModelHashTests
{
    private readonly byte[] _typePrefix =
    [
        197,
        25,
        157,
        1,
        33,
        2,
        39,
        123,
        145,
        170,
        130,
        225,
        122,
        110,
        20,
        123,
    ];

    [Fact]
    public void ProduceCorrectHashFromModel()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();

        IDiagramRelationalModel model = new DiagramRelationalModel(
            id,
            title,
            description,
            typeId
        );

        DiagramRelationalModelHash expected = new DiagramRelationalModelHash(model);
        DiagramRelationalModelHash actual = new DiagramRelationalModelHash(model);

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromValues()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();

        IDiagramRelationalModel model = new DiagramRelationalModel(
            id,
            title,
            description,
            typeId
        );

        DiagramRelationalModelHash expected = new DiagramRelationalModelHash(model);
        DiagramRelationalModelHash actual = new DiagramRelationalModelHash(
            id,
            title,
            description,
            typeId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();

        IDiagramRelationalModel model = new DiagramRelationalModel(
            id,
            title,
            description,
            typeId
        );

        DiagramRelationalModelHash expected = new DiagramRelationalModelHash(model);
        DiagramRelationalModelHash actual = new DiagramRelationalModelHash(
            new DeterminedHash(id),
            title,
            description,
            typeId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();

        IDiagramRelationalModel model = new DiagramRelationalModel(
            id,
            title,
            description,
            typeId
        );

        DiagramRelationalModelHash expected = new DiagramRelationalModelHash(model);
        DiagramRelationalModelHash actual = new DiagramRelationalModelHash(
            id,
            new DeterminedHash(title),
            description,
            typeId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();

        IDiagramRelationalModel model = new DiagramRelationalModel(
            id,
            title,
            description,
            typeId
        );

        DiagramRelationalModelHash expected = new DiagramRelationalModelHash(model);
        DiagramRelationalModelHash actual = new DiagramRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            description,
            typeId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDescriptionHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();

        IDiagramRelationalModel model = new DiagramRelationalModel(
            id,
            title,
            description,
            typeId
        );

        DiagramRelationalModelHash expected = new DiagramRelationalModelHash(model);
        DiagramRelationalModelHash actual = new DiagramRelationalModelHash(
            id,
            title,
            new DeterminedHash(description),
            typeId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashDescriptionHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();

        IDiagramRelationalModel model = new DiagramRelationalModel(
            id,
            title,
            description,
            typeId
        );

        DiagramRelationalModelHash expected = new DiagramRelationalModelHash(model);
        DiagramRelationalModelHash actual = new DiagramRelationalModelHash(
            new DeterminedHash(id),
            title,
            new DeterminedHash(description),
            typeId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashDescriptionHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();

        IDiagramRelationalModel model = new DiagramRelationalModel(
            id,
            title,
            description,
            typeId
        );

        DiagramRelationalModelHash expected = new DiagramRelationalModelHash(model);
        DiagramRelationalModelHash actual = new DiagramRelationalModelHash(
            id,
            new DeterminedHash(title),
            new DeterminedHash(description),
            typeId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashDescriptionHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();

        IDiagramRelationalModel model = new DiagramRelationalModel(
            id,
            title,
            description,
            typeId
        );

        DiagramRelationalModelHash expected = new DiagramRelationalModelHash(model);
        DiagramRelationalModelHash actual = new DiagramRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            new DeterminedHash(description),
            typeId
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTypeIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();

        IDiagramRelationalModel model = new DiagramRelationalModel(
            id,
            title,
            description,
            typeId
        );

        DiagramRelationalModelHash expected = new DiagramRelationalModelHash(model);
        DiagramRelationalModelHash actual = new DiagramRelationalModelHash(
            id,
            title,
            description,
            new DeterminedHash(typeId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTypeIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();

        IDiagramRelationalModel model = new DiagramRelationalModel(
            id,
            title,
            description,
            typeId
        );

        DiagramRelationalModelHash expected = new DiagramRelationalModelHash(model);
        DiagramRelationalModelHash actual = new DiagramRelationalModelHash(
            new DeterminedHash(id),
            title,
            description,
            new DeterminedHash(typeId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashTypeIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();

        IDiagramRelationalModel model = new DiagramRelationalModel(
            id,
            title,
            description,
            typeId
        );

        DiagramRelationalModelHash expected = new DiagramRelationalModelHash(model);
        DiagramRelationalModelHash actual = new DiagramRelationalModelHash(
            id,
            new DeterminedHash(title),
            description,
            new DeterminedHash(typeId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashTitleHashTypeIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();

        IDiagramRelationalModel model = new DiagramRelationalModel(
            id,
            title,
            description,
            typeId
        );

        DiagramRelationalModelHash expected = new DiagramRelationalModelHash(model);
        DiagramRelationalModelHash actual = new DiagramRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            description,
            new DeterminedHash(typeId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromDescriptionHashTypeIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();

        IDiagramRelationalModel model = new DiagramRelationalModel(
            id,
            title,
            description,
            typeId
        );

        DiagramRelationalModelHash expected = new DiagramRelationalModelHash(model);
        DiagramRelationalModelHash actual = new DiagramRelationalModelHash(
            id,
            title,
            new DeterminedHash(description),
            new DeterminedHash(typeId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromIdHashDescriptionHashTypeIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();

        IDiagramRelationalModel model = new DiagramRelationalModel(
            id,
            title,
            description,
            typeId
        );

        DiagramRelationalModelHash expected = new DiagramRelationalModelHash(model);
        DiagramRelationalModelHash actual = new DiagramRelationalModelHash(
            new DeterminedHash(id),
            title,
            new DeterminedHash(description),
            new DeterminedHash(typeId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromTitleHashDescriptionHashTypeIdHash()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();

        IDiagramRelationalModel model = new DiagramRelationalModel(
            id,
            title,
            description,
            typeId
        );

        DiagramRelationalModelHash expected = new DiagramRelationalModelHash(model);
        DiagramRelationalModelHash actual = new DiagramRelationalModelHash(
            id,
            new DeterminedHash(title),
            new DeterminedHash(description),
            new DeterminedHash(typeId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void ProduceCorrectHashFromHashes()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();

        IDiagramRelationalModel model = new DiagramRelationalModel(
            id,
            title,
            description,
            typeId
        );

        DiagramRelationalModelHash expected = new DiagramRelationalModelHash(model);
        DiagramRelationalModelHash actual = new DiagramRelationalModelHash(
            new DeterminedHash(id),
            new DeterminedHash(title),
            new DeterminedHash(description),
            new DeterminedHash(typeId)
        );

        Assert.True(expected.SequenceEqual(actual));
    }

    [Fact]
    public void EnumeratesAsUntyped()
    {
        IGuid id = new Guid();
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();

        IDiagramRelationalModel model = new DiagramRelationalModel(
            id,
            title,
            description,
            typeId
        );

        IEnumerable hashEnumerable = new DiagramRelationalModelHash(model);
        IEnumerator<byte> expectedHash = new DeterminedHash(
            _typePrefix
                .Concat(new DeterminedHash(model.Id))
                .Concat(new DeterminedHash(model.Title))
                .Concat(new DeterminedHash(model.Description))
                .Concat(new DeterminedHash(model.TypeId))
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
        IString title = new RandomString();
        IString description = new RandomString();
        IGuid typeId = new Guid();

        IDiagramRelationalModel model = new DiagramRelationalModel(
            id,
            title,
            description,
            typeId
        );

        IEnumerable<byte> expectedHash = new DeterminedHash(
            _typePrefix
                .Concat(new DeterminedHash(model.Id))
                .Concat(new DeterminedHash(model.Title))
                .Concat(new DeterminedHash(model.Description))
                .Concat(new DeterminedHash(model.TypeId))
        );

        Assert.Equal(expectedHash, new DiagramRelationalModelHash(model));
    }
}
