using System;

namespace Anthropic.SDK.Messaging;

/// <summary>
/// Prompt Cache Type Definitions. 
/// </summary>
[Flags]
public enum PromptCacheType
{
    /// <summary>
    /// No Prompt Caching
    /// </summary>
    None = 0,
    /// <summary>
    /// Use the cache-control instructions from each message for fine-grained control
    /// </summary>
    FineGrained = 1,
    /// <summary>
    /// Use the cache-control instructions from the system messages for automatic tools and system message caching
    /// </summary>
    AutomaticToolsAndSystem = 2,
    /// <summary>
    /// Automatically manage a single cache-control breakpoint at the top level of the request. Anthropic
    /// slides this breakpoint forward on every call, so the growing conversation - including tool_use/tool_result
    /// content from earlier turns - stays cached without having to place per-message breakpoints by hand. Combine
    /// with <see cref="FineGrained"/> to keep manual breakpoints (e.g. on documents) alongside this one.
    /// </summary>
    AutomaticMessages = 4,
}