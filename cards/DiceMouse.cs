using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;

namespace lifeSigils.cards
{
	public static class DiceMouse
	{
		public static void AddCard()
		{
			string name = "lifepack_Dice_Mouse";
			string displayName = "Dice Mouse";
			string description = "Will you take a chance and roll it's dice?";
			int baseAttack = 0;
			int baseHealth = 1;
			int bloodCost = 0;
			int boneCost = 0;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			metaCategories.Add(CardMetaCategory.Rare);

			List<Tribe> Tribes = new List<Tribe>();

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(SigilUtils.GetCustomAbility("extraVoid.inscryption.LifeCost", "Die Roll"));

			List<Trait> Traits = new List<Trait>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/lifecost_dice_mouse.png");

			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/lifecost_dice_mouse_e.png");

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
			newCard.SetRare();
			newCard.SetExtendedProperty("LifeMoneyCost", 2);
			CardManager.Add("lifepack", newCard);
		}
	}
}
