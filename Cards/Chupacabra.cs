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
    internal class Chupacabra
    { 
        public static void AddCard()
        {
            string name = "lifepack_chupacabra";
            string displayName = "Chupacabra";
            string description = "A ghostly dog of pure black, said to haunt various castles.";
            int baseAttack = 3;
            int baseHealth = 3;
            int bloodCost = 0;
            int boneCost = 0;
            int energyCost = 0;
        
            List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
        
            List<Tribe> Tribes = new List<Tribe>();
            Tribes.Add(Tribe.Reptile);
        
            List<Ability> Abilities = new List<Ability>();
            Abilities.Add(InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>("extraVoid.inscryption.voidSigils", "Consumer"));
        
            List<Trait> Traits = new List<Trait>();
        
            Texture2D DefaultTexture = SigilUtils.Texture_Helper("lifepack_chupacabra.png");
            Texture2D eTexture = SigilUtils.Texture_Helper("lifepack_chupacabra_e.png");
        
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
            newCard.SetExtendedProperty("LifeCost", 5);
            newCard.SetRare();
            CardManager.Add("lifepack", newCard);
        }
    }
}

