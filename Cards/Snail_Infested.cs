using DiskCardGame;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;
using lifeSigils.Managers;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace lifeSigils.Cards
{
    internal class Snail_Infested
    { 
        public static void AddCard()
        {
            string name = "lifepack_snail_infested";
            string displayName = "Infested Snail";
            string description = "The Infested Snail tries to get killed.";
            int baseAttack = 1;
            int baseHealth = 3;
            int bloodCost = 0;
            int boneCost = 0;
            int energyCost = 0;
        
            List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
            metaCategories.Add(CardMetaCategory.TraderOffer);
            metaCategories.Add(CardMetaCategory.ChoiceNode);
            metaCategories.Add(CardMetaCategory.GBCPlayable);
            metaCategories.Add(CardMetaCategory.GBCPack);

            List<Tribe> Tribes = new List<Tribe>();
            Tribes.Add(Tribe.Insect);
        
            List<Ability> Abilities = new List<Ability>();
            Abilities.Add(Ability.Reach);
            Abilities.Add(InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>(Plugin.SigilGUID, "Bait"));
        
            List<Trait> Traits = new List<Trait>();
            Traits.Add(Trait.KillsSurvivors);
        
            Texture2D DefaultTexture = SigilUtils.Texture_Helper("lifepack_snail_infested.png");
            Texture2D eTexture = SigilUtils.Texture_Helper("lifepack_snail_infested_e.png");
            Texture2D pTexture = SigilUtils.Texture_Helper("pixelportrait_snail.png");

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
            newCard.SetExtendedProperty("LifeMoneyCost", 3);
            newCard.SetExtendedProperty("LifeCost", 1);
            CardManager.Add("lifepack", newCard);
        }
    }
}

