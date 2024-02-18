using DiskCardGame;
using InscryptionAPI.Card;
using InscryptionAPI.Helpers;
using System.Collections.Generic;
using UnityEngine;
using lifeSigils.Managers;
using GracesGames.Common.Scripts;

namespace lifeSigils.Cards
{
    public static class MR_Pixie
    {
        public static void AddCard()
        {
            string internalName = "lifepack_Pixie";
            string displayName = "Pixie";
            string description = "The mask and cloak just dance around, like a puppet on strings.";
            int attack = 1;
            int health = 4;
            int bloodCost = 0;
            int boneCost = 2;
            int energyCost = 0;
            List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
            metaCategories.Add(CardMetaCategory.ChoiceNode);
            metaCategories.Add(CardMetaCategory.TraderOffer);
            metaCategories.Add(CardMetaCategory.GBCPlayable);
            metaCategories.Add(CardMetaCategory.GBCPack);
            List<Tribe> tribes = new List<Tribe>();
            List<Ability> Abilities = new List<Ability>
            {
                Ability.ActivatedHeal
            };
            List<Trait> Traits = new List<Trait>
            {
                Trait.Undead
            };
            Texture2D DefaultTexture = TextureHelper.GetImageAsTexture("lifepack_MR_pixie.png", typeof(Plugin).Assembly, 0);
            Texture2D eTexture = TextureHelper.GetImageAsTexture("lifepack_MR_pixie_e.png", typeof(Plugin).Assembly, 0);
            Texture2D pTexture = TextureHelper.GetImageAsTexture("pixelportrait_pixie.png", typeof(Plugin).Assembly, 0);
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
            newCard.SetCardTemple(CardTemple.Undead);
            newCard.SetCustomCost("LifeCost", 3);
            CardManager.Add("lifepack", newCard);
        }
    }
}

