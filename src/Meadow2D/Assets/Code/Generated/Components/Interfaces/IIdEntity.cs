//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by KSyndicate.CustomGenerators.Plugins.SingleValueComponentEntityApiInterfaceGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial interface IIdEntity<TEntity> : Entitas.IEntity where TEntity : Entitas.IEntity  {

    int Id { get; }
    Code.Gameplay.Common.Id id { get; }
    bool hasId { get; }

    TEntity AddId(int newValue);
    TEntity ReplaceId(int newValue);
    TEntity RemoveId();
}

public interface IIdEntity : IIdEntity<Entitas.IEntity> {}