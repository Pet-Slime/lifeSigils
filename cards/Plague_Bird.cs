using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;
using lifeSigils.Managers;

namespace lifeSigils.cards
{
    public static class plague_bird
	{
		public static void AddCard()
		{
			string name = "lifepack_Plague_Bird";
			string displayName = "Plague Bird";
			string description = "What better laboratory than the blood-soaked battlefield?";
			int baseAttack = 1;
			int baseHealth = 7;
			int bloodCost = 0;
			int boneCost = 4;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.Rare);

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Bird);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.Flying);
			Abilities.Add(Ability.ExplodeOnDeath);

			List<Trait> Traits = new List<Trait>();

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();
			specialAbilities.Add(CureAllNegativeSpecialAbility.specialAbility);

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/lifecost_plague_bird.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/lifecost_plague_bird_e.png");

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
			newCard.specialAbilities = specialAbilities;
			newCard.SetRare();
			newCard.SetExtendedProperty("LifeMoneyCost", 4);
			CardManager.Add("lifepack", newCard);
		}
	}
}
