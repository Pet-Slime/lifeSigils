using DiskCardGame;
using InscryptionAPI.Ascension;
using InscryptionAPI.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace lifeSigils.Managers
{
    internal class KCM_StartingDeck_Life
    {
        public static void AddStartingDeck()
        {

            Texture2D tex_a1 = SigilUtils.Texture_Helper("lifepack_KCM_diseased.png");
            Texture2D tex_a2 = SigilUtils.Texture_Helper("lifepack_KCM_blooddrinkers.png");

            StarterDeckInfo Diseased = ScriptableObject.CreateInstance<StarterDeckInfo>();
            Diseased.title = "The Diseased";
            Diseased.iconSprite = TextureHelper.ConvertTexture(tex_a1, TextureHelper.SpriteType.StarterDeckIcon);
            Diseased.cards = new() { CardLoader.GetCardByName("lifepack_rabbit_horned"), CardLoader.GetCardByName("lifepack_dog_starving"), CardLoader.GetCardByName("lifepack_snail_infested") };

            StarterDeckManager.Add(Plugin.PluginGuid, Diseased);


            StarterDeckInfo Drinkers = ScriptableObject.CreateInstance<StarterDeckInfo>();
            Drinkers.title = "Blood Drinkers";
            Drinkers.iconSprite = TextureHelper.ConvertTexture(tex_a2, TextureHelper.SpriteType.StarterDeckIcon);
            Drinkers.cards = new() { CardLoader.GetCardByName("lifepack_fea_blood"), CardLoader.GetCardByName("lifepack_misquote"), CardLoader.GetCardByName("lifepack_tick") };

            StarterDeckManager.Add(Plugin.PluginGuid, Drinkers);

            StarterDeckInfo TESTER = ScriptableObject.CreateInstance<StarterDeckInfo>();
            TESTER.title = "LIFE TESTERS";
            TESTER.iconSprite = TextureHelper.ConvertTexture(tex_a2, TextureHelper.SpriteType.StarterDeckIcon);
            TESTER.cards = new() { CardLoader.GetCardByName("lifepack_Blood_Fea"), CardLoader.GetCardByName("lifepack_misquote"), CardLoader.GetCardByName("lifepack_tick") };

            StarterDeckManager.Add(Plugin.PluginGuid, Drinkers);
        }
    }
}
