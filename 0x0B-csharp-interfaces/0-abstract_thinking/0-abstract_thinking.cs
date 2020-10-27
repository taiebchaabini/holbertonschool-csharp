using System;

/// <summary>
/// Base class
/// </summary>
abstract class Base{
    /// <summary>
    /// Name property
    /// </summary>
    public string name;
    /// <summary>
    /// Overrides ToString Method
    /// </summary>
    public override string ToString(){
        return $"{name} is a {this.GetType()}";
    }
}