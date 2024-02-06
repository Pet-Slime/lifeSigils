using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using InscryptionAPI.Card;
namespace lifeSigils
{
	[BepInPlugin(PluginGuid, PluginName, PluginVersion)]
	[BepInDependency(APIGUID, BepInDependency.DependencyFlags.HardDependency)]
	[BepInDependency(SigilGUID, BepInDependency.DependencyFlags.SoftDependency)]
	[BepInDependency(StarterdeckGUID, BepInDependency.DependencyFlags.SoftDependency)]
    [BepInDependency(TotemGUID, BepInDependency.DependencyFlags.SoftDependency)]
    public partial class Plugin : BaseUnityPlugin
    {
		public const string APIGUID = "cyantist.inscryption.api";
		public const string SigilGUID = "ATS";
		public const string StarterdeckGUID = "zorro.inscryption.infiniscryption.sidedecks";
		public const string PluginGuid = "extraVoid.inscryption.void_life_pack";
        public const string TotemGUID = "Lily.BOT";
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

			Cards.Ant_Fungal.AddCard();
			Cards.Bat_Vampire.AddCard();
			Cards.Bird_Caladrius.AddCard();
			Cards.Bird_Finch.AddCard();
			Cards.Bird_Plague.AddCard();
			Cards.Bone.AddCard();
			Cards.Chupacabra.AddCard();
			Cards.Cow_Diseased.AddCard();
			Cards.Cow_Mutilated.AddCard();
			Cards.Cow_Shitting.AddCard();
			Cards.Crow_Coin.AddCard();
			Cards.Crow_Tamed.AddCard();
			Cards.Deer_Wasting.AddCard();
			Cards.Dog_Black.AddCard();
			Cards.Dog_Familiar.AddCard();
			Cards.Dog_Rabid.AddCard();
			Cards.Dog_Starving.AddCard();
			Cards.Feline_Lion.AddCard();
			Cards.Feline_Maneki_Neko.AddCard();
			Cards.Fish_Candiru.AddCard();
			Cards.Fish_Lamprey.AddCard();
			Cards.Flea_Blood.AddCard();
			Cards.Lizard_Greedy.AddCard();
			Cards.Lizard_Salamander.AddCard();
			Cards.Mantis_Infested.AddCard();
			Cards.Misquito.AddCard();
			Cards.Moth_Calyptra.AddCard();
			Cards.Mouse_Dice.AddCard();
			Cards.Rabbit_horned.AddCard();
			Cards.Snail_Infested.AddCard();
			Cards.Snallygaster.AddCard();
			Cards.Tick.AddCard();
			Cards.Worm_Bone.AddCard();

			Encounters.BirdRush.AddEncounter();
			Encounters.DogHouse.AddEncounter();
		}

		private void Start()
        {
			Managers.CreateCardPack.TryCreatePack();
			Managers.KCM_StartingDeck_Life.AddStartingDeck();
		}
	}
}