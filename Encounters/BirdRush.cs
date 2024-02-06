using DiskCardGame;
using InscryptionAPI.Encounters;
using InscryptionAPI.Regions;
using lifeSigils.Managers;
using System;
using System.Collections.Generic;
using System.Text;

namespace lifeSigils.Encounters
{
    internal class BirdRush
    {
        public static void AddEncounter()
        {
            string name = "BirdRush";
            string regionName = "Alpine";
            List<Tribe> list = new List<Tribe>();
            list.Add(Tribe.Bird);
            List<Ability> list2 = new List<Ability>();
            list2.Add(Ability.Flying);
            bool regionLocked = true;
            List<CardInfo> randomReplacementCards = EncounterHelper.AddRandomCards("RavenEgg", "Sparrow", "Raven");
            List<List<EncounterBlueprintData.CardBlueprint>> list3 = new List<List<EncounterBlueprintData.CardBlueprint>>();
            List<EncounterBlueprintData.CardBlueprint> list4 = new List<EncounterBlueprintData.CardBlueprint>();
            list4.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("lifepack_Caladrius")
            });
            list4.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("lifepack_Caladrius"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("lifepack_finch"),
                randomReplaceChance = 10
            });
            List<EncounterBlueprintData.CardBlueprint> item = new List<EncounterBlueprintData.CardBlueprint>();
            List<EncounterBlueprintData.CardBlueprint> list5 = new List<EncounterBlueprintData.CardBlueprint>();
            list5.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("lifepack_Caladrius"),
                difficultyReplace = true,
                difficultyReq = 13,
                replacement = CardLoader.GetCardByName("lifepack_Plague_Bird"),
                randomReplaceChance = 10
            });
            list5.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("lifepack_Caladrius"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("lifepack_finch"),
                randomReplaceChance = 10
            });
            List<EncounterBlueprintData.CardBlueprint> item2 = new List<EncounterBlueprintData.CardBlueprint>();
            List<EncounterBlueprintData.CardBlueprint> list6 = new List<EncounterBlueprintData.CardBlueprint>();
            list6.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("lifepack_Caladrius")
            });
            list6.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("lifepack_Caladrius"),
                difficultyReplace = true,
                difficultyReq = 13,
                replacement = CardLoader.GetCardByName("lifepack_finch"),
                randomReplaceChance = 10
            });
            List<EncounterBlueprintData.CardBlueprint> item3 = new List<EncounterBlueprintData.CardBlueprint>();
            List<EncounterBlueprintData.CardBlueprint> list7 = new List<EncounterBlueprintData.CardBlueprint>();
            list7.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("lifepack_Caladrius"),
                difficultyReplace = true,
                difficultyReq = 18,
                replacement = CardLoader.GetCardByName("lifepack_finch"),
                randomReplaceChance = 10
            });
            list7.Add(new EncounterBlueprintData.CardBlueprint
            {
                card = CardLoader.GetCardByName("lifepack_Caladrius"),
                difficultyReplace = true,
                difficultyReq = 13,
                replacement = CardLoader.GetCardByName("lifepack_Plague_Bird"),
                randomReplaceChance = 10
            });
            list3.Add(list4);
            list3.Add(item);
            list3.Add(list5);
            list3.Add(item2);
            list3.Add(list6);
            list3.Add(item3);
            list3.Add(list7);
            EncounterBlueprintData encounterBlueprintData = EncounterHelper.BuildBlueprint(name, list, list2, regionLocked, 0, 30, randomReplacementCards, list3);
            EncounterManager.Add(encounterBlueprintData);
            RegionExtensions.AddEncounters(EncounterHelper.GetRegionData(regionName), new EncounterBlueprintData[]
            {
                encounterBlueprintData
            });
        }
    }
}
