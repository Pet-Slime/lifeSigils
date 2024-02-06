using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;
using lifeSigils.Managers;

namespace lifeSigils.cards
{
    public static class fungal_ant
	{
		public static void AddCard()
		{
			string name = "lifepack_Fungal_Ant";
			string displayName = "Fungal Ant";
			string description = "Be careful, the fungus will spread to all ants.";
			int baseAttack = 0;
			int baseHealth = 2;
			int bloodCost = 0;
			int boneCost = 0;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.TraderOffer);
			metaCategories.Add(CardMetaCategory.ChoiceNode);

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Insect);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(ability_FungalInfection.ability);
			Abilities.Add(InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Possessor"));

			List<Trait> Traits = new List<Trait>();
			Traits.Add(Trait.Ant);

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();
			specialAbilities.Add(SpecialTriggeredAbility.Ant);


			Texture2D DefaultTexture = SigilUtils.LoadTextureFromResource(lifeSigils.Artwork.Artwork.lifecost_fungal_ant);

			Texture2D eTexture = SigilUtils.LoadTextureFromResource(lifeSigils.Artwork.Artwork.lifecost_fungal_ant_e);


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
			newCard.AddSpecialAbilities(SpecialTriggeredAbility.Ant);
			newCard.SetStatIcon(SpecialStatIcon.Ants);
			newCard.SetExtendedProperty("LifeMoneyCost", 4);
			CardManager.Add("lifepack", newCard);
		}
	}
}
