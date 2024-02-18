using DiskCardGame;
using InscryptionAPI.Card;
using InscryptionAPI.Helpers;
using System.Collections.Generic;
using UnityEngine;
using lifeSigils.Managers;
using GracesGames.Common.Scripts;
using System.Xml.Linq;

namespace lifeSigils.Cards
{
    public static class MR_Henger
    {
        public static void AddCard()
        {
            string name = "lifepack_Henger";
            string displayName = "Henger";
            string description = "The mask and cloak just dance around, like a puppet on strings.";
            int baseAttack = 2;
            int baseHealth = 2;
            int bloodCost = 0;
            int boneCost = 0;
            int energyCost = 2;
            List<CardMetaCategory> metaCategories = new List<CardMetaCategory>();
            metaCategories.Add(CardMetaCategory.ChoiceNode);
            metaCategories.Add(CardMetaCategory.TraderOffer);
            metaCategories.Add(CardMetaCategory.GBCPlayable);
            metaCategories.Add(CardMetaCategory.GBCPack);
            List<Tribe> Tribes = new List<Tribe>();
            List<Ability> Abilities = new List<Ability>
            {
                Ability.DeathShield
            };
            List<Trait> Traits = new List<Trait>();
            Texture2D DefaultTexture = TextureHelper.GetImageAsTexture("lifepack_MR_henger.png", typeof(Plugin).Assembly, 0);
            Texture2D eTexture = TextureHelper.GetImageAsTexture("lifepack_MR_henger_e.png", typeof(Plugin).Assembly, 0);
            Texture2D pTexture = TextureHelper.GetImageAsTexture("pixelportrait_henger.png", typeof(Plugin).Assembly, 0);
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
            newCard.SetCardTemple(CardTemple.Tech);
            newCard.SetCustomCost("MoneyCost", 8);
            CardManager.Add("lifepack", newCard);
        }
    }
}

