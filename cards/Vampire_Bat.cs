using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;

namespace lifeSigils.cards
{
	public static class Vampire_Bat
	{
		public static void AddCard()
		{
			string name = "lifepack_Vampire_Bat";
			string displayName = "Vampire Bat";
			string description = "Vampire Bat";
			int baseAttack = 1;
			int baseHealth = 3;
			int bloodCost = 0;
			int boneCost = 0;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.ChoiceNode);
			metaCategories.Add(CardMetaCategory.TraderOffer);

			List<Tribe> Tribes = new List<Tribe>();

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(ability_BloodBoost.ability);

			List<Trait> Traits = new List<Trait>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/lifecost_Vampire_Bat.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/lifecost_Vampire_Bat_e.png");

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
			newCard.SetExtendedProperty("LifeMoneyCost", 8);
			CardManager.Add("lifepack", newCard);
		}
	}
}
