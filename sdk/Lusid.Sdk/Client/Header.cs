namespace Lusid.Sdk.Client;

/// <summary>
/// Used to represent all headers
/// </summary>
public class Header
{
    /// <summary/>
    public Header(string name, string value)
    {
        Name = name;
        Value = value;
    }

    /// <summary>
    /// Header name
    /// </summary>
    public string Name { get; }
        
    /// <summary>
    /// Header value
    /// </summary>
    public string Value { get; }
}