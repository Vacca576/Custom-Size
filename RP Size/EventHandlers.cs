using Exiled.Events.EventArgs.Player;
using UnityEngine;
using System.Linq;
using Exiled.API.Enums;


namespace RPSize
{
    public class EventHandlers
    {
        public void OnPlayerSpawned(SpawnedEventArgs ev)
        {
            if (ev.Player.Role.Side == Side.Scp) return;
            float[] sizes = Plugin.Instance.Config.Size.ToArray();

            int index = UnityEngine.Random.Range(0, sizes.Length);
            float selectedSize = sizes[index];

            ev.Player.Scale = new Vector3(selectedSize, selectedSize, selectedSize);
        }
    }
}
