﻿using Microsoft.JSInterop;

namespace Buddy.Interop.TeamsSDK;

public class MicrosoftTeams : InteropModuleBase
{
    protected override string ModulePath => "./js/TeamsJsBlazorInterop.js";

    public MicrosoftTeams(IJSRuntime jsRuntime) : base(jsRuntime) { }

    public Task InitializeAsync()
    {
        return InvokeVoidAsync("initializeAsync");
    }

    public Task<TeamsContext> GetTeamsContextAsync()
    {
        return InvokeAsync<TeamsContext>("getContextAsync");
    }

    public Task RegisterOnSaveHandlerAsync(TeamsInstanceSettings settings)
    {
        return InvokeVoidAsync("registerOnSaveHandler", settings);
    }

    public Task<bool> IsInTeams()
    {
        try
        {
            return InvokeAsync<bool>("inTeams");
        }
        catch (JSException)
        {
            return Task.FromResult(false);
        }
    }
}