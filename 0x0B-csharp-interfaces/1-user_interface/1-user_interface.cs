using System;

/// <summary>
/// Base class
/// </summary>
abstract class Base{
    /// <summary>
    /// Name property
    /// </summary>
    public string name {get; set;}
    /// <summary>
    /// Overrides ToString Method
    /// </summary>
    public override string ToString(){
        return $"{name} is a {this.GetType()}";
    }
}

/// <summary>
/// Interactive interface
/// </summary>
interface IInteractive{
    void Interact();
}
/// <summary>
/// IBreakable interface
/// </summary>
interface IBreakable{
    int durability { get; set; }
    void Break();
}
/// <summary>
/// ICollectable interface
/// </summary>
interface ICollectable{
    bool isCollected { get; set; }
    void Collect();  
}
/// <summary>
/// Used for test purpose
/// </summary>
class TestObject : Base, IInteractive, IBreakable, ICollectable{
    /// <summary>
    /// Used for interaction
    /// </summary>
    public void Interact(){

    }
    /// <summary>
    /// Used for item durability
    /// </summary>
    /// <value>Getter and setter</value>
    public int durability { get; set; }
    /// <summary>
    /// Used to break item
    /// </summary>
    public void Break(){

    }
    /// <summary>
    /// Used for collection
    /// </summary>
    /// <value></value>
    public bool isCollected { get; set; }
    /// <summary>
    /// Used to collect something
    /// </summary>
    public void Collect(){

    }
} 