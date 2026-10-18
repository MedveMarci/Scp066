using System.ComponentModel;
using System.IO;
using LabApi.Loader.Features.Paths;
using Scp066.Features;

namespace Scp066;

public class Config
{
    public bool Debug { get; set; } = false;

    public float Damage { get; set; } = 8f;

    public float MaxDistance { get; set; } = 8f;

    public string CustomDeathText { get; set; } = "<color=red>The subject expired after exposure to a loud sound by SCP-066</color>";

    [Description("Where the audio directory is located. The built-in sounds are saved here on startup. Replace a file with your own .ogg while keeping its name to customize it.")]
    public string AudioDirectoryPath { get; set; } = Path.Combine(PathManager.Configs.FullName, "Scp066", "Audio");

    public Scp066Role Scp066Role { get; set; } = new();
}