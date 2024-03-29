﻿using DiskCardGame;
using InscryptionAPI.Card;
using InscryptionAPI.Guid;
using lifeSigils.Managers;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace lifeSigils.Cards
{
    internal class Dog_Starving
    { 
        public static void AddCard()
        {
            string name = "lifepack_dog_starving";
            string displayName = "Starving Dog";
            string description = "It attacks randomly, hoping for food.";
            int baseAttack = 1;
            int baseHealth = 2;
            int bloodCost = 0;
            int boneCost = 0;
            int energyCost = 0;
        
            List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
            metaCategories.Add(CardMetaCategory.TraderOffer);
            metaCategories.Add(CardMetaCategory.ChoiceNode);
            metaCategories.Add(CardMetaCategory.GBCPlayable);
            metaCategories.Add(CardMetaCategory.GBCPack);

            List<Tribe> Tribes = new List<Tribe>();
            Tribes.Add(Tribe.Canine);
        
            List<Ability> Abilities = new List<Ability>();
            Abilities.Add(InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>(Plugin.SigilGUID, "Random Strike"));
        
            List<Trait> Traits = new List<Trait>();
        
            Texture2D DefaultTexture = SigilUtils.Texture_Helper("lifepack_dog_starving.png");
            Texture2D eTexture = SigilUtils.Texture_Helper("lifepack_dog_starving_e.png");
            Texture2D pTexture = SigilUtils.Texture_Helper("pixelportrait_starving_dog.png");

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
            CardManager.Add("lifepack", newCard);
        }
    }
}

