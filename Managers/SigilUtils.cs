using System.Collections.Generic;
using System.IO;
using InscryptionAPI.Card;
using BepInEx;
using DiskCardGame;
using UnityEngine;
using System;
using static System.IO.File;
using InscryptionAPI.Helpers;

namespace lifeSigils.Managers
{
    public class SigilUtils
    {
        public static AbilityInfo CreateAbilityWithDefaultSettingsKCM(
            string rulebookName, string rulebookDescription, Type behavior, Texture2D text_a1, Texture2D text_a2,
            string LearnDialogue, bool withDialogue = false, int powerLevel = 0, bool leshyUsable = false, bool part1Modular = true, bool stack = false
        )
        {
            AbilityInfo createdAbilityInfo = AbilityManager.New(
                Plugin.PluginGuid,
                rulebookName,
                rulebookDescription,
                behavior,
                text_a1
            );
            createdAbilityInfo.SetPixelAbilityIcon(text_a2);
            // This sets up the learned Dialog event
            if (withDialogue) { createdAbilityInfo.abilityLearnedDialogue = SetAbilityInfoDialogue(LearnDialogue); }
            // How powerful the ability is
            createdAbilityInfo.powerLevel = powerLevel;
            // Can it show up on totems for leshy?
            createdAbilityInfo.opponentUsable = leshyUsable;
            // If true, allows in shops and in totems. If false, just the rule book
            if (part1Modular)
            { createdAbilityInfo.metaCategories = new List<AbilityMetaCategory>() { AbilityMetaCategory.Part1Modular, AbilityMetaCategory.Part1Rulebook }; }
            else
            { createdAbilityInfo.metaCategories = new List<AbilityMetaCategory>() { AbilityMetaCategory.Part1Rulebook }; }
            // Does the ability stack?
            createdAbilityInfo.canStack = stack;
            return createdAbilityInfo;
        }

        public static CardInfo CreateCardWithDefaultSettings(
            string InternalName, string DisplayName, int attack, int health, Texture2D texture_base, Texture2D texture_emission,
            List<CardMetaCategory> cardMetaCategories, List<Tribe> tribes, List<Trait> traits, List<Ability> abilities, Texture2D texture_pixel = null, int bloodCost = 0, int boneCost = 0, int energyCost = 0
        )
        {
            CardInfo cardinfo = CardManager.New(
            modPrefix: "lifepack",
            InternalName,
            DisplayName,
            attack,
            health,
            description: "A puddle that errods all that touches it."
            );
            cardinfo.SetPortrait(texture_base, texture_emission);
            if (texture_pixel == null)
            {
                texture_pixel = GetTextureFromPath("Artwork/pixelportrait_blank.png");
                cardinfo.SetPixelPortrait(texture_pixel);
            }
            else
            {
                cardinfo.SetPixelPortrait(texture_pixel);
            }
            cardinfo.SetPixelPortrait(texture_pixel);
            cardinfo.metaCategories = cardMetaCategories;
            cardinfo.tribes = tribes;
            cardinfo.traits = traits;
            for (int index = 0; index < abilities.Count; index++)
            {
                cardinfo.AddAbilities(abilities[index]);
            }
            cardinfo.temple = CardTemple.Nature;
            cardinfo.cardComplexity = CardComplexity.Intermediate;
            cardinfo.SetBloodCost(bloodCost);
            cardinfo.SetBonesCost(boneCost);
            cardinfo.SetEnergyCost(energyCost);
            return cardinfo;
        }

        public static DialogueEvent.LineSet SetAbilityInfoDialogue(string dialogue)
        {
            return new DialogueEvent.LineSet(
                new List<DialogueEvent.Line>()
                {
                    new DialogueEvent.Line()
                    {
                        text = dialogue
                    }
                }
            );
        }


        public static Texture2D GetTextureFromPath(string path)
        {
            byte[] imgBytes = ReadAllBytes(Path.Combine(Plugin.Directory, path));
            Texture2D tex = new Texture2D(2, 2);
            tex.LoadImage(imgBytes);
            return tex;
        }


        public static Texture2D Texture_Helper(string Path)
        {
            return TextureHelper.GetImageAsTexture(Path, typeof(Plugin).Assembly);
        }

        public static string GetFullPathOfFile(string fileToLookFor)
        {
            return Directory.GetFiles(Paths.PluginPath, fileToLookFor, SearchOption.AllDirectories)[0];
        }

        public static byte[] ReadArtworkFileAsBytes(string nameOfCardArt)
        {
            return ReadAllBytes(GetFullPathOfFile(nameOfCardArt));
        }
    }
}