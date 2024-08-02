﻿using System;
using Exiled.API.Features;
using Exiled.Events;
using Exiled.Events.Features;

namespace RPSize
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "RPSize";
        public override string Author => "Vacca";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(8, 11, 0);

        public static Plugin Instance;
        public EventHandlers eventHandlers;
        public Random RNG = new Random();

        public override void OnEnabled()
        {
            Instance = this;
            this.eventHandlers = new EventHandlers();
            Exiled.Events.Handlers.Player.Spawned += new CustomEventHandler<Exiled.Events.EventArgs.Player.SpawnedEventArgs>(eventHandlers.OnPlayerSpawned);

            Log.Debug("Random Size is Enabled.");
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Spawned -= new CustomEventHandler<Exiled.Events.EventArgs.Player.SpawnedEventArgs>(eventHandlers.OnPlayerSpawned);
            Instance = null;
            this.eventHandlers = null;

            Log.Debug("Random Size disabled.");
            base.OnDisabled();
        }
    }
}
