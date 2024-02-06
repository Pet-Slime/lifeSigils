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
    internal class Dog_Rabid
    { 
        public static void AddCard()
        {
            string name = "lifepack_dog_rabid";
            string displayName = "Rabid Canine";
            string description = "The canine that can spread disease to those it hits.";
            int baseAttack = 1;
            int baseHealth = 1;
            int bloodCost = 0;
            int boneCost = 0;
            int energyCost = 0;
        
            List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
            metaCategories.Add(CardMetaCategory.TraderOffer);
            metaCategories.Add(CardMetaCategory.ChoiceNode);
        
            List<Tribe> Tribes = new List<Tribe>();
            Tribes.Add(Tribe.Canine);
        
            List<Ability> Abilities = new List<Ability>();
            Abilities.Add(Ability.Brittle);
            Abilities.Add(InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Toxin (Deadly)"));
        
            List<Trait> Traits = new List<Trait>();
            Traits.Add(Trait.KillsSurvivors);
        
            Texture2D DefaultTexture = SigilUtils.Texture_Helper("lifepack_dog_rabid.png");
            Texture2D eTexture = SigilUtils.Texture_Helper("lifepack_dog_rabid_e.png");
        
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
            newCard.SetExtendedProperty("LifeCost", 1);
            CardManager.Add("lifepack", newCard);
        }
    }
}

