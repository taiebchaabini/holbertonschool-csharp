using System;

/// <summary>
/// Base class
/// </summary>
abstract class Base{
    /// <summary>
    /// Name property
    /// </summary>
    public String name;
    /// <summary>
    /// Overrides ToString Method
    /// </summary>
    public override string ToString(){
        return String.Format("{0} is a {1}", name, this.GetType());
    }
}