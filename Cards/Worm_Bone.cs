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
    internal class Worm_Bone
    { 
        public static void AddCard()
        {
            string name = "lifepack_worm_bone";
            string displayName = "Bone Worm";
            string description = "A worm that loves to burrow into bones at the bottom of the ocean and consume them.";
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
            Abilities.Add(InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>(Plugin.SigilGUID, "Draw Bone"));
        
            List<Trait> Traits = new List<Trait>();
            Traits.Add(Trait.KillsSurvivors);
        
            Texture2D DefaultTexture = SigilUtils.Texture_Helper("lifepack_worm_bone.png");
            Texture2D eTexture = SigilUtils.Texture_Helper("lifepack_worm_bone_e.png");
        
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
            newCard.SetTail("lifepack_bone", SigilUtils.Texture_Helper("lifepack_worm_bone_a.png"));
            newCard.SetExtendedProperty("LifeMoneyCost", 4);
            CardManager.Add("lifepack", newCard);
        }
    }
}

