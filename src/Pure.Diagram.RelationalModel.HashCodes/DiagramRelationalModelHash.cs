using System.Collections;
using Pure.Diagram.RelationalModel.Abstractions;
using Pure.HashCodes;
using Pure.HashCodes.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Diagram.RelationalModel.HashCodes;

public sealed record DiagramRelationalModelHash : IDeterminedHash
{
    private static readonly byte[] TypePrefix =
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

    private readonly IDeterminedHash _idHash;

    private readonly IDeterminedHash _titleHash;

    private readonly IDeterminedHash _descriptionHash;

    private readonly IDeterminedHash _typeIdHash;

    public DiagramRelationalModelHash(IDiagramRelationalModel model)
        : this(model.Id, model.Title, model.Description, model.TypeId) { }

    public DiagramRelationalModelHash(
        IGuid id,
        IString title,
        IString description,
        IGuid typeId
    )
        : this(new DeterminedHash(id), title, description, typeId) { }

    public DiagramRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IString description,
        IGuid typeId
    )
        : this(idHash, new DeterminedHash(title), description, typeId) { }

    public DiagramRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IString description,
        IGuid typeId
    )
        : this(new DeterminedHash(id), titleHash, description, typeId) { }

    public DiagramRelationalModelHash(
        IGuid id,
        IString title,
        IDeterminedHash descriptionHash,
        IGuid typeId
    )
        : this(new DeterminedHash(id), title, descriptionHash, typeId) { }

    public DiagramRelationalModelHash(
        IGuid id,
        IString title,
        IString description,
        IDeterminedHash typeIdHash
    )
        : this(new DeterminedHash(id), title, description, typeIdHash) { }

    public DiagramRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IString description,
        IGuid typeId
    )
        : this(idHash, titleHash, new DeterminedHash(description), typeId) { }

    public DiagramRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IDeterminedHash descriptionHash,
        IGuid typeId
    )
        : this(idHash, new DeterminedHash(title), descriptionHash, typeId) { }

    public DiagramRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IDeterminedHash descriptionHash,
        IGuid typeId
    )
        : this(new DeterminedHash(id), titleHash, descriptionHash, typeId) { }

    public DiagramRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IString description,
        IDeterminedHash typeIdHash
    )
        : this(idHash, new DeterminedHash(title), description, typeIdHash) { }

    public DiagramRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IString description,
        IDeterminedHash typeIdHash
    )
        : this(new DeterminedHash(id), titleHash, description, typeIdHash) { }

    public DiagramRelationalModelHash(
        IGuid id,
        IString title,
        IDeterminedHash descriptionHash,
        IDeterminedHash typeIdHash
    )
        : this(new DeterminedHash(id), title, descriptionHash, typeIdHash) { }

    public DiagramRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IDeterminedHash descriptionHash,
        IGuid typeId
    )
        : this(idHash, titleHash, descriptionHash, new DeterminedHash(typeId)) { }

    public DiagramRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IString description,
        IDeterminedHash typeIdHash
    )
        : this(idHash, titleHash, new DeterminedHash(description), typeIdHash) { }

    public DiagramRelationalModelHash(
        IDeterminedHash idHash,
        IString title,
        IDeterminedHash descriptionHash,
        IDeterminedHash typeIdHash
    )
        : this(idHash, new DeterminedHash(title), descriptionHash, typeIdHash) { }

    public DiagramRelationalModelHash(
        IGuid id,
        IDeterminedHash titleHash,
        IDeterminedHash descriptionHash,
        IDeterminedHash typeIdHash
    )
        : this(new DeterminedHash(id), titleHash, descriptionHash, typeIdHash) { }

    public DiagramRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash titleHash,
        IDeterminedHash descriptionHash,
        IDeterminedHash typeIdHash
    )
    {
        _idHash = idHash;
        _titleHash = titleHash;
        _descriptionHash = descriptionHash;
        _typeIdHash = typeIdHash;
    }

    public IEnumerator<byte> GetEnumerator()
    {
        return new DeterminedHash(
            TypePrefix
                .Concat(_idHash)
                .Concat(_titleHash)
                .Concat(_descriptionHash)
                .Concat(_typeIdHash)
        ).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
