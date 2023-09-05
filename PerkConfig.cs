using System.ComponentModel;
using Terraria.ModLoader.Config;

namespace EquipPerks
{
	public class PerksConfig : ModConfig
	{
		public override ConfigScope Mode => ConfigScope.ClientSide;

		[DefaultValue(true)]
		public bool perkDefault;

		[DefaultValue(true)]
		public bool petTooltips;

		[DefaultValue(true)]
		public bool lightTooltips;

		[DefaultValue(true)]
		public bool cartTooltips;

		[DefaultValue(true)]
		public bool wingTooltips;
	}
}
