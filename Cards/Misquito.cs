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
    internal class Misquito
    { 
        public static void AddCard()
        {
            string name = "lifepack_misquote";
            string displayName = "Engorging Misquito";
            string description = "A ghostly dog of pure black, said to haunt various castles.";
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
            Tribes.Add(Tribe.Insect);
        
            List<Ability> Abilities = new List<Ability>();
            Abilities.Add(InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>(Plugin.SigilGUID, "Blood Growth"));
        
            List<Trait> Traits = new List<Trait>();
        
            Texture2D DefaultTexture = SigilUtils.Texture_Helper("lifepack_misquote.png");
            Texture2D eTexture = SigilUtils.Texture_Helper("lifepack_misquote_e.png");
            Texture2D pTexture = SigilUtils.Texture_Helper("pixelportrait_misquito.png");

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
            newCard.SetExtendedProperty("LifeMoneyCost", 4);
            CardManager.Add("lifepack", newCard);
        }
    }
}

