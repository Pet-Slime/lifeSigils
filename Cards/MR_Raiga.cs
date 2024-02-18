using DiskCardGame;
using InscryptionAPI.Card;
using InscryptionAPI.Helpers;
using System.Collections.Generic;
using lifeSigils.Managers;
using UnityEngine;
using GracesGames.Common.Scripts;
using System.Xml.Linq;

namespace lifeSigils.Cards
{
    public static class MR_Raiga
    { 
        public static void AddCard()
        {
            string internalName = "lifepack_Raiga";
            string displayName = "Raiga";
            string description = "Some known them as, Tiger.";
            int attack = 3;
            int health = 2;
            int bloodCost = 2;
            int boneCost = 0;
            int energyCost = 0;
            List<CardMetaCategory> metaCategories = new List<CardMetaCategory>
            {
                CardMetaCategory.ChoiceNode,
                CardMetaCategory.TraderOffer,
                CardMetaCategory.GBCPlayable,
                CardMetaCategory.GBCPack
            };
            List<Tribe> tribes = new List<Tribe>
            {
                Tribe.Canine
            };
            List<Ability> Abilities = new List<Ability>
            {
                InscryptionAPI.Guid.GuidManager.GetEnumValue<Ability>(Plugin.SigilGUID, "Electric")
            };
            List<Trait> Traits = new List<Trait>();
            Texture2D DefaultTexture = TextureHelper.GetImageAsTexture("lifepack_MR_raiga.png", typeof(Plugin).Assembly, 0);
            Texture2D eTexture = TextureHelper.GetImageAsTexture("lifepack_MR_raiga_e.png", typeof(Plugin).Assembly, 0);
            Texture2D pTexture = TextureHelper.GetImageAsTexture("pixelportrait_raiga.png", typeof(Plugin).Assembly, 0);
            CardInfo newCard = SigilUtils.CreateCardWithDefaultSettings(
                InternalName: internalName,
                DisplayName: displayName,
                attack: attack,
                health: health,
                texture_base: DefaultTexture,
                texture_emission: eTexture,
                texture_pixel: pTexture,
                cardMetaCategories: metaCategories,
                tribes: tribes,
                traits: Traits,
                abilities: Abilities,
                bloodCost: bloodCost,
                boneCost: boneCost,
                energyCost: energyCost
                );
            newCard.description = description;
            newCard.SetCardTemple(CardTemple.Nature);
            newCard.SetCustomCost("LifeMoneyCost", 4);
            CardManager.Add("lifepack", newCard);
        }
    }
}

