using Infiniscryption.PackManagement;
using System;

namespace lifeSigils.Managers
{
    public static class CreateCardPack
    {
        public static void TryCreatePack()
        {

            try
            {
                CreatePack();
            }
            catch (Exception ex)
            {
                Plugin.Log.LogInfo("Could not create pack. Pack Manager API is not installed");
            }
        }


        public static void CreatePack()
        {
            PackInfo incrediPack = PackManager.GetPackInfo<PackInfo>("lifepack");
            incrediPack.Title = "Life and Foils Booster Pack";
            incrediPack.SetTexture(SigilUtils.GetTextureFromPath("Artwork/life_pack.png"));
            incrediPack.Description = "A 30 card expansion that adds cards that cost life, foils, or both. The beasts in this pack are themed after those who are diseased, hemovores, or mythical beasts that deal with blood.";
            incrediPack.ValidFor.Add(PackInfo.PackMetacategory.LeshyPack);
        }
    }
}
