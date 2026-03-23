using System.Collections;
using Pure.Diagram.RelationalModel.Abstractions;
using Pure.HashCodes;
using Pure.HashCodes.Abstractions;
using Pure.Primitives.Abstractions.Guid;
using Pure.Primitives.Abstractions.String;

namespace Pure.Diagram.RelationalModel.HashCodes;

public sealed record SeriesRelationalModelHash : IDeterminedHash
{
    private static readonly byte[] TypePrefix =
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

    private readonly IDeterminedHash _idHash;

    private readonly IDeterminedHash _diagramIdHash;

    private readonly IDeterminedHash _labelHash;

    private readonly IDeterminedHash _sourceHash;

    public SeriesRelationalModelHash(ISeriesRelationalModel model)
        : this(model.Id, model.DiagramId, model.Label, model.Source) { }

    public SeriesRelationalModelHash(
        IGuid id,
        IGuid diagramId,
        IString label,
        IString source
    )
        : this(
            new DeterminedHash(id),
            new DeterminedHash(diagramId),
            new DeterminedHash(label),
            new DeterminedHash(source)
        )
    { }

    public SeriesRelationalModelHash(
        IDeterminedHash idHash,
        IDeterminedHash diagramIdHash,
        IDeterminedHash labelHash,
        IDeterminedHash sourceHash
    )
    {
        _idHash = idHash;
        _diagramIdHash = diagramIdHash;
        _labelHash = labelHash;
        _sourceHash = sourceHash;
    }

    public IEnumerator<byte> GetEnumerator()
    {
        return new DeterminedHash(
            TypePrefix
                .Concat(_idHash)
                .Concat(_diagramIdHash)
                .Concat(_labelHash)
                .Concat(_sourceHash)
        ).GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
