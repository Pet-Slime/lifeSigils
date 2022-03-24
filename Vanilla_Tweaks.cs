using Infiniscryption.PackManagement;

namespace lifeSigils
{
	public static class Vanilla_Tweaks
	{

		public static void CreatePack()
		{
			PackInfo incrediPack = PackManager.GetPackInfo("lifepack");
			incrediPack.Title = "Life and Foils Booster Pack";
			incrediPack.SetTexture(SigilUtils.GetTextureFromPath("Artwork/life_pack.png"));
			incrediPack.Description = "A 30 card expansion that adds cards that cost life, foils, or both. The beasts in this pack are themed after those who are diseased, hemovores, or mythical beasts that deal with blood.";
			incrediPack.ValidFor.Add((PackInfo.PackMetacategory)CardTemple.Nature);
		}
	}
}
