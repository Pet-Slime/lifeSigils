using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;
using lifeSigils.Managers;

namespace lifeSigils.Cards
{
    public static class Bird_Caladrius
	{
		public static void AddCard()
		{
			string name = "lifepack_bird_caladrius";
			string displayName = "Caladrius";
			string description = "It will take in the pain of others to heal them.";
			int baseAttack = 1;
			int baseHealth = 2;
			int bloodCost = 0;
			int boneCost = 0;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.TraderOffer);
			metaCategories.Add(CardMetaCategory.ChoiceNode);

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Bird);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.Flying);
			Abilities.Add(InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>(Plugin.SigilGUID, "Disease Absorbtion"));

			List<Trait> Traits = new List<Trait>();

			Texture2D DefaultTexture = SigilUtils.Texture_Helper("lifepack_bird_caladrius.png");
			Texture2D eTexture = SigilUtils.Texture_Helper("lifepack_bird_caladrius_e.png");

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
