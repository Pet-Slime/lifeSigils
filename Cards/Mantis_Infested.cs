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
    internal class Mantis_Infested
    { 
        public static void AddCard()
        {
            string name = "lifepack_mantis_infested";
            string displayName = "Mantis?";
            string description = "A ghostly dog of pure black, said to haunt various castles.";
            int baseAttack = 1;
            int baseHealth = 1;
            int bloodCost = 0;
            int boneCost = 0;
            int energyCost = 0;
        
            List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
            metaCategories.Add(CardMetaCategory.TraderOffer);
            metaCategories.Add(CardMetaCategory.ChoiceNode);
        
            List<Tribe> Tribes = new List<Tribe>();
            Tribes.Add(Tribe.Insect);
        
            List<Ability> Abilities = new List<Ability>();
            Abilities.Add(Ability.SplitStrike);
            Abilities.Add(Ability.IceCube);
        
            List<Trait> Traits = new List<Trait>();
        
            Texture2D DefaultTexture = SigilUtils.Texture_Helper("lifepack_mantis_infested.png");
            Texture2D eTexture = SigilUtils.Texture_Helper("lifepack_mantis_infested_e.png");
        
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
            newCard.SetIceCube("Ringworm");
            newCard.SetExtendedProperty("LifeMoneyCost", 6);
            CardManager.Add("lifepack", newCard);
        }
    }
}

