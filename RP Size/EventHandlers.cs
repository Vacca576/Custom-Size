using Exiled.Events.EventArgs.Player;
using UnityEngine;
using System.Linq;

namespace RPSize
{
    public class EventHandlers
    {
        public void OnPlayerSpawned(SpawnedEventArgs ev)
        {
            float[] sizes = Plugin.Instance.Config.Size.ToArray();

            int index = Plugin.Instance.RNG.Next(sizes.Length);
            float selectedSize = sizes[index];

            ev.Player.Scale = new Vector3(selectedSize, selectedSize, selectedSize);
        }
    }
}
