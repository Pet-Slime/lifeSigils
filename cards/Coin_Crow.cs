using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;

namespace lifeSigils.cards
{
	public static class Coin_Crow
	{
		public static void AddCard()
		{
			string name = "lifepack_Coin_Crow";
			string displayName = "Thieving Crow";
			string description = "This thieving crow will strike at your foes, if you pay it to...";
			int baseAttack = 1;
			int baseHealth = 2;
			int bloodCost = 0;
			int boneCost = 0;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.Rare);

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Bird);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(SigilUtils.GetCustomAbility("extraVoid.inscryption.LifeCost", "Cash Converter"));
			Abilities.Add(SigilUtils.GetCustomAbility("extraVoid.inscryption.voidSigils", "Thief"));

			List<Trait> Traits = new List<Trait>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/lifecost_coin_crow.png");

			Texture2D pixelTexture = SigilUtils.GetTextureFromPath("Artwork/pixelportrait_coin_crow.png");

			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/lifecost_coin_crow_e.png");

			CardInfo newCard = SigilUtils.CreateCardWithDefaultSettings(
				InternalName: name,
				DisplayName: displayName,
				attack: baseAttack,
				health: baseHealth,
				texture_base: DefaultTexture,
				texture_emission: eTexture,
				texture_pixel: pixelTexture,
				cardMetaCategories: metaCategories,
				tribes: Tribes,
				traits: Traits,
				abilities: Abilities,
				bloodCost: bloodCost,
				boneCost: boneCost,
				energyCost: energyCost
				);
			newCard.description = description;
			newCard.SetRare();
			newCard.SetExtendedProperty("LifeMoneyCost", 4);
			CardManager.Add("lifepack", newCard);
		}
	}
}
