﻿using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;
using lifeSigils.Managers;

namespace lifeSigils.Cards
{
    public static class Snallygaster
	{
		public static void AddCard()
		{
			string name = "lifepack_snallygaster";
			string displayName = "Snallygaster";
			string description = "It comes from the shadows, attacking all, sucking all the blood out of them.";
			int baseAttack = 1;
			int baseHealth = 2;
			int bloodCost = 0;
			int boneCost = 0;
			int energyCost = 0;

			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();

            List<Tribe> Tribes = new List<Tribe>
            {
                Tribe.Bird,
                Tribe.Reptile
            };

            List<Ability> Abilities = new List<Ability>
            {
                InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>(Plugin.SigilGUID, "BloodGuzzler")
            };

            List<Trait> Traits = new List<Trait>();

            List<SpecialTriggeredAbility> specialAbilities = new List<SpecialTriggeredAbility>
            {
                GainAllstrikeOnDraw.specialAbility
            };

            Texture2D DefaultTexture = SigilUtils.Texture_Helper("lifepack_snallygaster.png");
			Texture2D eTexture = SigilUtils.Texture_Helper("lifepack_snallygaster_e.png");

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
            newCard.AddSpecialAbilities(GainAllstrikeOnDraw.specialAbility);
			newCard.SetRare();
			newCard.SetExtendedProperty("LifeMoneyCost", 11);
			CardManager.Add("lifepack", newCard);
		}
	}
}
