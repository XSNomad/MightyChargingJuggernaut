using BattleTech;

namespace MightyChargingJuggernaut.Extensions
{
    public static class PilotExtensions
    {
        public static bool IsJuggernaut(this Pilot pilot)
        {
            return pilot.PassiveAbilities.Find((Ability a) => a.Def.Description.Name == "JUGGERNAUT") != null;
        }
    }
}
