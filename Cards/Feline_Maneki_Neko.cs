using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;
using lifeSigils.Managers;

namespace lifeSigils.Cards
{
    public static class Feline_Maneki_Neko
    {

		public static void AddCard()
		{
			string name = "lifepack_maneki_neko";
			string displayName = "Maneki-neko";
			string description = "It brings fortune in the way of gold.";
			int baseAttack = 0;
			int baseHealth = 3;
			int bloodCost = 0;
			int boneCost = 0;
			int energyCost = 0;
			int lifeCost = 4;


			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();

			List<Tribe> Tribes = new List<Tribe>();
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(Plugin.TotemGUID))
            {
                Plugin.Log.LogMessage("Lily Totems found, Maneki-neko is now feline");
                Tribes.Add(GuidManager.GetEnumValue<Tribe>("Lily.BOT", "feline"));
            }

            List<Ability> Abilities = new List<Ability>();
			Abilities.Add(InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>(Plugin.SigilGUID, "Toothpuller"));

			List<Trait> Traits = new List<Trait>();

			Texture2D DefaultTexture = SigilUtils.Texture_Helper("lifepack_maneki_neko.png");
			Texture2D eTexture = SigilUtils.Texture_Helper("lifepack_maneki_neko_e.png");

			CardInfo newCard = SigilUtils.CreateCardWithDefaultSettings(
				InternalName: name,
				DisplayName: displayName,
				attack: baseAttack,
				health: baseHealth,
				texture_base: DefaultTexture,
				texture_emission: eTexture,
				texture_pixel: null,
				cardMetaCategories: metaCategories,
				tribes: Tribes,
				traits: Traits,
				abilities: Abilities,
				bloodCost: bloodCost,
				boneCost: boneCost,
				energyCost: energyCost
				);
			newCard.description = description;
			newCard.SetExtendedProperty("LifeMoneyCost", lifeCost);
			newCard.SetRare();
			newCard.AddAppearances(CardAppearanceBehaviour.Appearance.GoldEmission);
			CardManager.Add("lifepack", newCard);
		}
	}
}
