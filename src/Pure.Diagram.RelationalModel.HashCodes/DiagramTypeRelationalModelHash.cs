using System.Collections;
using Pure.Diagram.RelationalModel.Abstractions;
using Pure.HashCodes;
using Pure.HashCodes.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Diagram.RelationalModel.HashCodes;

public sealed record DiagramTypeRelationalModelHash : IDeterminedHash
{
    private static readonly byte[] TypePrefix =
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

    private readonly IDeterminedHash _idHash;

    private readonly IDeterminedHash _nameHash;

    public DiagramTypeRelationalModelHash(IDiagramTypeRelationalModel model)
        : this(model.Id, model.Name) { }

    public DiagramTypeRelationalModelHash(IGuid id, IString name)
        : this(new DeterminedHash(id), name) { }

    public DiagramTypeRelationalModelHash(IDeterminedHash idHash, IString name)
        : this(idHash, new DeterminedHash(name)) { }

    public DiagramTypeRelationalModelHash(IGuid id, IDeterminedHash nameHash)
        : this(new DeterminedHash(id), nameHash) { }

    public DiagramTypeRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash nameHash
    )
    {
        _idHash = idHash;
        _nameHash = nameHash;
    }

    public IEnumerator<byte> GetEnumerator()
    {
        return new DeterminedHash(
            TypePrefix.Concat(_idHash).Concat(_nameHash)
        ).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
