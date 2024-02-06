using System.Collections.Generic;
using DiskCardGame;
using UnityEngine;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;
using lifeSigils.Managers;

namespace lifeSigils.Cards
{
    public static class Flea_Blood
	{

		public static void AddCard()
		{
			string name = "lifepack_fea_blood";
			string displayName = "Blood Flea";
			string description = "A flea that spreads disease to canines, weakening them.";
			int baseAttack = 1;
			int baseHealth = 1;
			int bloodCost = 0;
			int boneCost = 0;
			int energyCost = 0;
			int lifeCost = 4;


			List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
            metaCategories.Add(CardMetaCategory.GBCPlayable);
            metaCategories.Add(CardMetaCategory.GBCPack);


            List<Tribe> Tribes = new List<Tribe>();
			Tribes.Add(Tribe.Insect);

			List<Ability> Abilities = new List<Ability>();
			Abilities.Add(InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>(Plugin.SigilGUID, "Agile"));
			Abilities.Add(InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>(Plugin.SigilGUID, "Draw Blood"));

			List<Trait> Traits = new List<Trait>();

			Texture2D DefaultTexture = SigilUtils.Texture_Helper("lifepack_fea_blood.png");
			Texture2D eTexture = SigilUtils.Texture_Helper("lifepack_fea_blood_e.png");
			Texture2D pTexture = SigilUtils.Texture_Helper("pixelportrait_flea.png");

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
