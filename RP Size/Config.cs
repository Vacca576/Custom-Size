using System.ComponentModel;
using Exiled.API.Interfaces;

namespace RPSize
{
    public class Config : IConfig
    {
        [Description("Plugin is Enabled?")]
        public bool IsEnabled { get; set; } = true;

        [Description("Debug is Enabled?")]
        public bool Debug { get; set; } = false;

        [Description("First possible size of the player.")]
        public float Size1 { get; set; } = 1.0f;

        [Description("Second possible size of the player.")]
        public float Size2 { get; set; } = 0.9f;

        [Description("Third possible size of the player.")]
        public float Size3 { get; set; } = 1.1f;
    }
}
