using Exiled.Events.EventArgs.Player;
using UnityEngine;

namespace RPSize
{
    public class EventHandlers
    {
        public void OnPlayerSpawned(SpawnedEventArgs ev)
        {
            float[] sizes = new float[]
            {
                Plugin.Instance.Config.Size1,
                Plugin.Instance.Config.Size2,
                Plugin.Instance.Config.Size3
            };

            int index = Plugin.Instance.RNG.Next(sizes.Length);
            float selectedSize = sizes[index];

            ev.Player.Scale = new Vector3(selectedSize, selectedSize, selectedSize);
        }
    }
}
