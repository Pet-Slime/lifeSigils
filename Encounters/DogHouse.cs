using DiskCardGame;
using InscryptionAPI.Encounters;
using InscryptionAPI.Regions;
using lifeSigils.Managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace lifeSigils.Encounters
{
    internal class DogHouse
    {
        public static void AddEncounter()
        {
            string name = "DogHouse";
            string regionName = "Forest";
            List<Tribe> tribe = new List<Tribe>();
            tribe.Add(Tribe.Canine);
            List<Ability> redundant = new List<Ability>();
            bool regionLocked = true;
            List<CardInfo> randomReplacementCards = EncounterHelper.AddRandomCards("lifepack_dog_familiar", "Bloodhound", "lifepack_dog_black", "lifepack_dog_rabid");
            List<List<EncounterBlueprintData.CardBlueprint>> cardBlueprint = new List<List<EncounterBlueprintData.CardBlueprint>>();
            List<EncounterBlueprintData.CardBlueprint> turn1 = new List<EncounterBlueprintData.CardBlueprint>();
            turn1.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("lifepack_dog_starving")
            });
            turn1.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("lifepack_dog_starving")
            });
            List<EncounterBlueprintData.CardBlueprint> turn2 = new List<EncounterBlueprintData.CardBlueprint>();
            turn2.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("lifepack_dog_starving"),
                randomReplaceChance = 25
            });
            List<EncounterBlueprintData.CardBlueprint> turn3 = new List<EncounterBlueprintData.CardBlueprint>();
            turn3.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("lifepack_dog_starving"),
                randomReplaceChance = 25
            });
            List<EncounterBlueprintData.CardBlueprint> turn4 = new List<EncounterBlueprintData.CardBlueprint>();
            turn4.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("lifepack_dog_starving"),
                randomReplaceChance = 50
            });
            turn4.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("lifepack_dog_starving"),
                randomReplaceChance = 50
            });
            List<EncounterBlueprintData.CardBlueprint> turn5 = new List<EncounterBlueprintData.CardBlueprint>();
            turn5.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("lifepack_dog_starving"),
                randomReplaceChance = 50
            });
            turn5.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("lifepack_dog_starving"),
                randomReplaceChance = 50
            });
            List<EncounterBlueprintData.CardBlueprint> turn6 = new List<EncounterBlueprintData.CardBlueprint>();
            turn6.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("lifepack_dog_starving"),
                randomReplaceChance = 50
            });

            List<EncounterBlueprintData.CardBlueprint> turn7 = new List<EncounterBlueprintData.CardBlueprint>();
            turn7.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("lifepack_dog_starving"),
                randomReplaceChance = 50
            });
            turn7.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("lifepack_dog_starving"),
                randomReplaceChance = 50
            });
            List<EncounterBlueprintData.CardBlueprint> turn8 = new List<EncounterBlueprintData.CardBlueprint>();
            turn8.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("lifepack_dog_starving"),
                randomReplaceChance = 50
            });
            List<EncounterBlueprintData.CardBlueprint> turn9 = new List<EncounterBlueprintData.CardBlueprint>();
            turn9.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("lifepack_dog_starving"),
                randomReplaceChance = 75
            });
            cardBlueprint.Add(turn1);
            cardBlueprint.Add(turn2);
            cardBlueprint.Add(turn3);
            cardBlueprint.Add(turn4);
            cardBlueprint.Add(turn5);
            cardBlueprint.Add(turn6);
            cardBlueprint.Add(turn7);
            cardBlueprint.Add(turn8);
            cardBlueprint.Add(turn9);
            EncounterBlueprintData encounterBlueprintData = EncounterHelper.BuildBlueprint(name, tribe, redundant, regionLocked, 0, 30, randomReplacementCards, cardBlueprint);
            EncounterManager.Add(encounterBlueprintData);
            RegionExtensions.AddEncounters(EncounterHelper.GetRegionData(regionName), new EncounterBlueprintData[]
            {
                encounterBlueprintData
            });
        }
    }
}