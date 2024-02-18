using DiskCardGame;
using InscryptionAPI.Card;
using InscryptionAPI.Helpers;
using System.Collections.Generic;
using UnityEngine;
using lifeSigils.Managers;
using GracesGames.Common.Scripts;

namespace lifeSigils.Cards
{
    public static class MR_Gali
    {
        public static void AddCard()
        {
            string internalName = "lifepack_Gali";
            string displayName = "Gali";
            string description = "The mask and cloak just dance around, like a puppet on strings.";
            int attack = 0;
            int health = 2;
            int bloodCost = 0;
            int boneCost = 0;
            int energyCost = 0;
            List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
            metaCategories.Add(CardMetaCategory.ChoiceNode);
            metaCategories.Add(CardMetaCategory.TraderOffer);
            metaCategories.Add(CardMetaCategory.GBCPlayable);
            metaCategories.Add(CardMetaCategory.GBCPack);
            List<Tribe> tribes = new List<Tribe>();
            List<Ability> Abilities = new List<Ability>
            {
                Ability.GainGemBlue, Ability.BuffGems 
            };
            List<Trait> Traits = new List<Trait>();
            Traits.Add(Trait.Gem);
            Texture2D DefaultTexture = TextureHelper.GetImageAsTexture("lifepack_MR_gali.png", typeof(Plugin).Assembly, 0);
            Texture2D eTexture = TextureHelper.GetImageAsTexture("lifepack_MR_gali_e.png", typeof(Plugin).Assembly, 0);
            Texture2D pTexture = TextureHelper.GetImageAsTexture("pixelportrait_gali.png", typeof(Plugin).Assembly, 0);
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
            newCard.SetCardTemple(CardTemple.Wizard);
            newCard.SetCustomCost("LifeMoneyCost", 4);
            newCard.SetTerrain();
            newCard.AddDecal(TextureHelper.GetImageAsTexture("lifepack_MR_gali_d.png", typeof(Plugin).Assembly, 0));
            CardManager.Add("lifepack", newCard);
        }
    }
}

