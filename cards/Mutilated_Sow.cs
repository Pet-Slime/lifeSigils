using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;

namespace lifeSigils.cards
{
	public static class mutilated_sow
	{
		public static void AddCard()
		{
			string name = "lifepack_Mutilated_Sow";
			string displayName = "Mutilated Sow";
			string description = "The poor sow, damaged, hurt, broken.";
			int baseAttack = 0;
			int baseHealth = 3;
			int bloodCost = 0;
			int boneCost = 0;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.TraderOffer);
			metaCategories.Add(CardMetaCategory.ChoiceNode);

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Hooved);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.CorpseEater);
			Abilities.Add(Ability.ExplodeOnDeath);

			List<Trait> Traits = new List<Trait>();
			Traits.Add(Trait.Goat);

			List<CardAppearanceBehaviour.Appearance> appearanceBehaviour = new List<CardAppearanceBehaviour.Appearance>();
			appearanceBehaviour.Add(CardAppearanceBehaviour.Appearance.SexyGoat);

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/lifecost_mutilated_sow.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/lifecost_mutilated_sow_e.png");
			Texture2D altTexture = SigilUtils.GetTextureFromPath("Artwork/lifecost_mutilated_sow_e.png");

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
			newCard.SetAltPortrait(altTexture);
			newCard.SetExtendedProperty("LifeMoneyCost", 3);
			CardManager.Add("lifepack", newCard);
		}
	}
}
