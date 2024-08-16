using System.Collections.Generic;
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

        [Description("List of RP Size")]
        public List<float> Size { get; private set; } = new()
        {
          1f,
          1.2f,
        };
    }
}
