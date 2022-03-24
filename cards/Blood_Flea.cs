using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace lifeSigils.cards
{
	public static class Blood_Flea
	{
		public static readonly CardMetaCategory SIDE_DECK_CATEGORY = GuidManager.GetEnumValue<CardMetaCategory>("zorro.inscryption.infiniscryption.sidedecks", "SideDeck");

		public static void AddCard()
		{
			string name = "lifepack_Blood_Fea";
			string displayName = "Blood Flea";
			string description = "A flea that spreads disease to canines, weakening them.";
			int baseAttack = 1;
			int baseHealth = 1;
			int bloodCost = 0;
			int boneCost = 0;
			int energyCost = 0;
			int lifeCost = 4;


			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Insect);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(SigilUtils.GetCustomAbility("extraVoid.inscryption.voidSigils", "Agile"));
			Abilities.Add(SigilUtils.GetCustomAbility("extraVoid.inscryption.voidSigils", "Draw Blood"));

			List<Trait> Traits = new List<Trait>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/lifecost_flea.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/lifecost_flea_e.png");
			Texture2D pTexture = SigilUtils.GetTextureFromPath("Artwork/pixelportrait_flea.png");

			CardInfo newCard = SigilUtils.CreateCardWithDefaultSettings(
				InternalName: name,
				DisplayName: displayName,
				attack: baseAttack,
				health: baseHealth,
				texture_base: DefaultTexture,
				texture_emission: eTexture,
				texture_pixel: pTexture,
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
			CardManager.Add("lifepack", newCard);
		}
	}
}
