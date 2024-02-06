using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System;
using InscryptionAPI.Card;
using InscryptionAPI.Ascension;
using InscryptionAPI.Helpers;
using DiskCardGame;
using UnityEngine;
using Resources = lifeSigils.Artwork.Artwork;
namespace lifeSigils
{
	[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
	[BepInDependency(APIGUID, BepInDependency.DependencyFlags.HardDependency)]
	[BepInDependency(SigilGUID, BepInDependency.DependencyFlags.SoftDependency)]
	[BepInDependency(StarterdeckGUID, BepInDependency.DependencyFlags.SoftDependency)]
	public partial class Plugin : BaseUnityPlugin
    {
		public const string APIGUID = "cyantist.inscryption.api";
		public const string SigilGUID = "extraVoid.inscryption.voidSigils";
		public const string StarterdeckGUID = "zorro.inscryption.infiniscryption.sidedecks";
		public const string PluginGuid = "extraVoid.inscryption.void_life_pack";
		private const string PluginName = "Void Life and Foil Costing Pack";
		private const string PluginVersion = "3.0.0";

		public static string Directory;
		internal static ManualLogSource Log;

		private void Awake()
		{

			Log = base.Logger;
			Directory = this.Info.Location.Replace("lifeSigils.dll", "");

			Harmony harmony = new(PluginGuid);
			harmony.PatchAll();


			CureAllNegativeSpecialAbility.specialAbility =  SpecialTriggeredAbilityManager.Add(Plugin.PluginGuid, "Illness cure", typeof(CureAllNegativeSpecialAbility)).Id;
			GainAllstrikeOnDraw.specialAbility = SpecialTriggeredAbilityManager.Add(Plugin.PluginGuid, "Gain Moon Strike on Draw", typeof(GainAllstrikeOnDraw)).Id;
			AddFungalInfection();
			AddBloodBoost();

			///Albino familiar
			///black dog
			///bone
			///bone worm
			cards.Caladrius.AddCard();
			cards.Calyptra.AddCard();
			cards.Candiru_Fish.AddCard();
			///Cabra
			cards.Coin_Crow.AddCard();
			cards.DiceMouse.AddCard();
			///Disease Cow
			///Finch
			///Salamander
			cards.Blood_Flea.AddCard();
			cards.fungal_ant.AddCard();
			cards.Greedy_Lizard.AddCard();
			///Cotten Tail
			///mantis
			///snail
			///lampray
			///neko
			///misquito
			cards.mutilated_sow.AddCard();
			cards.plague_bird.AddCard();
			///Rabbid dog
			///shitting cow
			///sick lion
			cards.Snallygaster.AddCard();
			///Starving dog
			cards.Tamed_Crow.AddCard();
			///Tick
			cards.Vampire_Bat.AddCard();
			///wasting deer
		}

		private void Start()
        {
			lifeSigils.Managers.CreateCardPack.TryCreatePack();
			lifeSigils.Managers.KCM_StartingDeck_Life.AddStartingDeck();
		}
	}
}