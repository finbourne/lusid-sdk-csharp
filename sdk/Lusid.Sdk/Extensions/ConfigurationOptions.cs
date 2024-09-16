using System;
using System.Threading;

namespace Lusid.Sdk.Extensions;

/// <summary>
/// Overriding configuration
/// </summary>
public class ConfigurationOptions
{
    private int? _rateLimitRetries;
    private int? _timeoutMs;
    
    /// <summary/>
    public ConfigurationOptions()
    {
    }
    
    /// <summary/>
    /// <param name="timeoutMs"></param>
    public ConfigurationOptions(int? timeoutMs, int? rateLimitRetries)
    {
        RateLimitRetries = rateLimitRetries;
        TimeoutMs = timeoutMs;
    }

    /// <summary>
    /// The client timeout in milliseconds. Set to a non null value to override
    /// </summary>
    public int? TimeoutMs
    {
        get => _timeoutMs;
        set
        {
            if (value < 1)
            {
                throw new ArgumentException($"{nameof(TimeoutMs)} must be a positive integer between 1 and {int.MaxValue}");
            }
            _timeoutMs = value;
        }
    }
    
    /// <summary>
    /// The number of retries when being rate limited. Set to a non null value to override
    /// </summary>
    public int? RateLimitRetries
    {
        get => _rateLimitRetries;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException($"{nameof(RateLimitRetries)} must be a positive integer between 0 and {int.MaxValue}");
            }
            _rateLimitRetries = value;
        }
    }
}