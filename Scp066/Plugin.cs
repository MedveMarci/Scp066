using System;
using LabApi.Events.CustomHandlers;
using LabApi.Features;
using LabApi.Loader.Features.Plugins;
using RoleAPI;
using Scp066.Features;

namespace Scp066;

public class Scp066 : Plugin<Config>
{
    private readonly EventHandler _eventHandler = new();
    public string githubRepo = "MedveMarci/Scp066";
    public override string Name => "Scp066";

    public override string Description =>
        "Adds SCP-066, the noise maker, as a custom role with unique abilities and features.";

    public override string Author => "RisottoMan, LabApi version: MedveMarci";
    public override Version Version => new(1, 1, 2);
    public override Version RequiredApiVersion { get; } = new(LabApiProperties.CompiledVersion);
    public static Scp066 Singleton { get; private set; }
    private Scp066Role Role { get; set; }

    public override void Enable()
    {
        Singleton = this;
        Startup.SetupAPI(Name);
        Startup.RegisterCustomRole(Role);
        CustomHandlersManager.RegisterEventsHandler(_eventHandler);
    }

    public override void LoadConfigs()
    {
        base.LoadConfigs();
        Role = Config.Scp066Role;
    }

    public override void Disable()
    {
        Singleton = null;
        Startup.UnRegisterCustomRole(Role);
        CustomHandlersManager.UnregisterEventsHandler(_eventHandler);
    }
}