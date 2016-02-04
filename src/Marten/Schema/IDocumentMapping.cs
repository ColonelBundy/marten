using System;
using System.Collections.Generic;
using System.Reflection;
using Marten.Generation;

namespace Marten.Schema
{
    public interface IDocumentMapping
    {
        string UpsertName { get; }
        Type DocumentType { get; }
        string TableName { get; }
        PropertySearching PropertySearching { get; }
        IIdGeneration IdStrategy { get; }
        IEnumerable<DuplicatedField> DuplicatedFields { get; }
        MemberInfo IdMember { get; }
        IList<IndexDefinition> Indexes { get; }
        string SelectFields(string tableAlias);

        TableDefinition ToTable(IDocumentSchema schema);

        IField FieldFor(IEnumerable<MemberInfo> members);

        string ToResolveMethod(string typeName);
    }
}