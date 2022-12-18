﻿//HintName: Person.Generator.Equals.g.cs

#nullable enable
#pragma warning disable CS0612,CS0618

partial class Person : global::System.IEquatable<Person>
{
    /// <summary>
    /// Indicates whether the object on the left is equal to the object on the right.
    /// </summary>
    /// <param name="left">The left object</param>
    /// <param name="right">The right object</param>
    /// <returns>true if the objects are equal; otherwise, false.</returns>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
    public static bool operator ==(
        global::Person? left,
        global::Person? right) =>
        global::System.Collections.Generic.EqualityComparer<global::Person?>.Default
            .Equals(left, right);
    
    /// <summary>
    /// Indicates whether the object on the left is not equal to the object on the right.
    /// </summary>
    /// <param name="left">The left object</param>
    /// <param name="right">The right object</param>
    /// <returns>true if the objects are not equal; otherwise, false.</returns>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
    public static bool operator !=(global::Person? left, global::Person? right) =>
        !(left == right);
    
    /// <inheritdoc/>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
    public override bool Equals(object? obj) =>
        Equals(obj as global::Person);
    
    /// <inheritdoc/>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
    public bool Equals(global::Person? other)
    {
        return
            !ReferenceEquals(other, null) && this.GetType() == other.GetType()
            && global::System.Collections.Generic.EqualityComparer<global::System.String>.Default.Equals(this.Name!, other.Name!)
            && global::System.Collections.Generic.EqualityComparer<global::System.Int32>.Default.Equals(this.Age!, other.Age!)
            ;
    }
    
    /// <inheritdoc/>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Generator.Equals", "1.0.0.0")]
    public override int GetHashCode()
    {
        var hashCode = new global::System.HashCode();
        
        hashCode.Add(this.GetType());
        hashCode.Add(
            this.Name!,
            global::System.Collections.Generic.EqualityComparer<global::System.String>.Default);
        hashCode.Add(
            this.Age!,
            global::System.Collections.Generic.EqualityComparer<global::System.Int32>.Default);
        
        return hashCode.ToHashCode();
    }
}