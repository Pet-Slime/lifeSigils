using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;
using lifeSigils.Managers;
using InscryptionAPI.Guid;

namespace lifeSigils.Cards
{
    public static class Fish_Candiru
	{
		public static void AddCard()
		{
			string name = "lifepack_fish_candiru";
			string displayName = "Candiru Fish";
			string description = "A parasitic fish that feasts on blood.";
			int baseAttack = 1;
			int baseHealth = 1;
			int bloodCost = 0;
			int boneCost = 0;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.TraderOffer);
			metaCategories.Add(CardMetaCategory.ChoiceNode);

			List<Tribe> Tribes = new List<Tribe>();
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(Plugin.TotemGUID))
            {
                Plugin.Log.LogMessage("Lily Totems found, Candiru Fish is now aquatic");
                Tribes.Add(GuidManager.GetEnumValue<Tribe>("Lily.BOT", "aquatic"));
            }

            List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.Submerge);
			Abilities.Add(InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>(Plugin.SigilGUID, "Schooling"));

			List<Trait> Traits = new List<Trait>();

			Texture2D DefaultTexture = SigilUtils.Texture_Helper("lifepack_fish_candiru.png");
			Texture2D eTexture = SigilUtils.Texture_Helper("lifepack_fish_candiru_e.png");

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
			newCard.SetExtendedProperty("LifeMoneyCost", 4);
			CardManager.Add("lifepack", newCard);
		}
	}
}
