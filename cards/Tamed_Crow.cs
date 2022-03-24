using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;

namespace lifeSigils.cards
{
	public static class Tamed_Crow
	{
		public static readonly CardMetaCategory SIDE_DECK_CATEGORY = GuidManager.GetEnumValue<CardMetaCategory>("zorro.inscryption.infiniscryption.sidedecks", "SideDeck");

		public static void AddCard()
		{
			string name = "lifepack_Tamed_Crow";
			string displayName = "Tamed Crow";
			string description = "A crow, tamed to find gold.";
			int baseAttack = 0;
			int baseHealth = 1;
			int bloodCost = 0;
			int boneCost = 0;
			int energyCost = 0;
			int lifeCost = 2;


			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
			if (!BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(Plugin.StarterdeckGUID))
            {
				Plugin.Log.LogMessage("Did not find side decks, adding Tamed Crow to the default pools");
				metaCategories.Add(CardMetaCategory.ChoiceNode);
				metaCategories.Add(CardMetaCategory.TraderOffer);
			}
			else
			{
				Plugin.Log.LogMessage("Found side decks, removing Tamed Crow from the default pools");
				metaCategories.Add(SIDE_DECK_CATEGORY);
				lifeCost = 0;
			}

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Bird);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(Ability.Flying);
			Abilities.Add(SigilUtils.GetCustomAbility("extraVoid.inscryption.voidSigils", "Coin Finder"));

			List<Trait> Traits = new List<Trait>();

			Texture2D DefaultTexture = SigilUtils.GetTextureFromPath("Artwork/lifecost_tamed_crow.png");
			Texture2D pixelTexture = SigilUtils.GetTextureFromPath("Artwork/pixelportrait_tamed_crow.png");
			Texture2D eTexture = SigilUtils.GetTextureFromPath("Artwork/lifecost_tamed_crow_e.png");

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
			newCard.SetExtendedProperty("SideDeckValue", 5);
			newCard.SetExtendedProperty("LifeMoneyCost", lifeCost);
			CardManager.Add("lifepack", newCard);
		}
	}
}
