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
        : this(
            new DeterminedHash(id),
            new DeterminedHash(title),
            new DeterminedHash(description),
            new DeterminedHash(typeId)
        )
    { }

    private DiagramRelationalModelHash(
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
