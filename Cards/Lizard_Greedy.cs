﻿using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;
using lifeSigils.Managers;

namespace lifeSigils.Cards
{
    public static class Lizard_Greedy
	{
		public static void AddCard()
		{
			string name = "lifepack_lizard_greedy";
			string displayName = "Hoarding Lizard";
			string description = "It will bring you wealth if you can pay it's price.";
			int baseAttack = 2;
			int baseHealth = 2;
			int bloodCost = 0;
			int boneCost = 0;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();

			List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Reptile);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.LifeCost", "Life Converter"));

			List<Trait> Traits = new List<Trait>();


			Texture2D DefaultTexture = SigilUtils.Texture_Helper("lifepack_lizard_greedy.png");
			Texture2D eTexture = SigilUtils.Texture_Helper("lifepack_lizard_greedy_e.png");

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
			newCard.SetExtendedProperty("MoneyCost", 5);
			CardManager.Add("lifepack", newCard);
		}
	}
}
