using DiskCardGame;
using InscryptionAPI.Ascension;
using InscryptionAPI.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using Resources = lifeSigils.Artwork.Artwork;

namespace lifeSigils.Managers
{
    internal class KCM_StartingDeck_Life
    {
        public static void AddStartingDeck()
        {

            Texture2D tex_a1 = SigilUtils.LoadTextureFromResource(Resources.lifepack_KCM_diseased);
            Texture2D tex_a2 = SigilUtils.LoadTextureFromResource(Resources.lifepack_KCM_blooddrinkers);

            StarterDeckInfo PureBone = ScriptableObject.CreateInstance<StarterDeckInfo>();
            PureBone.title = "The Diseased";
            PureBone.iconSprite = TextureHelper.ConvertTexture(tex_a1, TextureHelper.SpriteType.StarterDeckIcon);
            PureBone.cards = new() { CardLoader.GetCardByName("lifepack_horn_cottentail"), CardLoader.GetCardByName("lifepack_starving_dog"), CardLoader.GetCardByName("lifepack_Infested_Snail") };

            StarterDeckManager.Add(Plugin.PluginGuid, PureBone);


            StarterDeckInfo TrapperToys = ScriptableObject.CreateInstance<StarterDeckInfo>();
            TrapperToys.title = "Blood Drinkers";
            TrapperToys.iconSprite = TextureHelper.ConvertTexture(tex_a2, TextureHelper.SpriteType.StarterDeckIcon);
            TrapperToys.cards = new() { CardLoader.GetCardByName("lifepack_Blood_Fea"), CardLoader.GetCardByName("lifepack_misquote"), CardLoader.GetCardByName("lifepack_tick") };

            StarterDeckManager.Add(Plugin.PluginGuid, TrapperToys);
        }
    }
}
