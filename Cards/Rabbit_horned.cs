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
    internal class Rabbit_horned
    { 
        public static void AddCard()
        {
            string name = "lifepack_rabbit_horned";
            string displayName = "Horned Cottentail";
            string description = "The poor thing...";
            int baseAttack = 1;
            int baseHealth = 1;
            int bloodCost = 0;
            int boneCost = 0;
            int energyCost = 0;

            List<CardMetaCategory> metaCategories = new List<CardMetaCategory>
            {
                CardMetaCategory.TraderOffer,
                CardMetaCategory.ChoiceNode,
                CardMetaCategory.GBCPlayable,
                CardMetaCategory.GBCPack
            };

            List<Tribe> Tribes = new List<Tribe>();
            if (BepInEx.Bootstrap.Chainloader.PluginInfos.ContainsKey(Plugin.TotemGUID))
            {
                Plugin.Log.LogMessage("Lily Totems found, Horned Cottentail is now rodent");
                Tribes.Add(GuidManager.GetEnumValue<Tribe>("Lily.BOT", "rodent"));
            }

            List<Ability> Abilities = new List<Ability>
            {
                GuidManager.GetEnumValue<Ability>(Plugin.SigilGUID, "Repellant")
            };

            List<Trait> Traits = new List<Trait>();
        
            Texture2D DefaultTexture = SigilUtils.Texture_Helper("lifepack_rabbit_horned.png");
            Texture2D eTexture = SigilUtils.Texture_Helper("lifepack_rabbit_horned_e.png");
            Texture2D pTexture = SigilUtils.Texture_Helper("pixelportrait_cottentail.png");

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
            newCard.SetExtendedProperty("LifeMoneyCost", 3);
            CardManager.Add("lifepack", newCard);
        }
    }
}

