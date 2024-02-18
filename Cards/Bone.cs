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
    internal class Bone
    { 
        public static void AddCard()
        {
            string name = "lifepack_bone";
            string displayName = "Random Bone";
            string description = "Just a bone.";
            int baseAttack = 0;
            int baseHealth = 1;
            int bloodCost = 0;
            int boneCost = 0;
            int energyCost = 0;
        
            List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
        
            List<Tribe> Tribes = new List<Tribe>();
        
            List<Ability> Abilities = new List<Ability>();
        
            List<Trait> Traits = new List<Trait>();
        
            Texture2D DefaultTexture = SigilUtils.Texture_Helper("lifepack_bone.png");
            Texture2D eTexture = SigilUtils.Texture_Helper("lifepack_bone_e.png");
        
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
            newCard.SetTerrain();
            CardManager.Add("lifepack", newCard);
        }
    }
}

