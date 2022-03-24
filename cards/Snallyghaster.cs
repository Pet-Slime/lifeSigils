using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;

namespace lifeSigils.cards
{
	public static class Snallygaster
	{
		public static void AddCard()
		{
			string name = "lifepack_Snallygaster";
			string displayName = "Snallygaster";
			string description = "It comes from the shadows, attacking all, sucking all the blood out of them.";
			int baseAttack = 1;
			int baseHealth = 2;
			int bloodCost = 0;
			int boneCost = 0;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.Rare);

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Bird);
			Tribes.Add(Tribe.Reptile);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(SigilUtils.GetCustomAbility("extraVoid.inscryption.voidSigils", "BloodGuzzler"));

			List<Trait> Traits = new List<Trait>();

			List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>();
			specialAbilities.Add(GainAllstrikeOnDraw.specialAbility);

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/lifecost_Snallygaster.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/lifecost_Snallygaster_e.png");

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
			newCard.SetExtendedProperty("LifeMoneyCost", 11);
			CardManager.Add("lifepack", newCard);
		}
	}
}
