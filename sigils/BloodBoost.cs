using System.Collections;
using DiskCardGame;
using lifeSigils.Managers;
using UnityEngine;

namespace lifeSigils
{
    public partial class Plugin
	{
		private void AddBloodBoost()
		{
			// setup ability
			const string rulebookName = "Blood Boost";
			const string rulebookDescription = "When played, [creature] will gain power based on the blood cost of all the opponent's cards.";
            const string LearnDialogue = "It craves their blood";
            Texture2D tex_a1 = SigilUtils.Texture_Helper("void_BloodBoost.png");
            Texture2D tex_a2 = SigilUtils.Texture_Helper("void_BloodBoost_pixel.png");
            int powerlevel = 4;
            bool LeshyUsable = false;
            bool part1Shops = true;
            bool canStack = false;

            // set ability to behaviour class
            ability_BloodBoost.ability = SigilUtils.CreateAbilityWithDefaultSettingsKCM(rulebookName, rulebookDescription, typeof(ability_BloodBoost), tex_a1, tex_a2, LearnDialogue,
                                                                                    true, powerlevel, LeshyUsable, part1Shops, canStack).ability;
        }
	}

	public class ability_BloodBoost : AbilityBehaviour
	{
		public override Ability Ability => ability;

		public static Ability ability;

        public override bool RespondsToResolveOnBoard()
        {
            return true;
        }

        public override IEnumerator OnResolveOnBoard()
        {
            Singleton<ViewManager>.Instance.SwitchToView(View.Board, false, true);

            PlayableCard crows = (PlayableCard)base.Card;
            var OPCards = Singleton<BoardManager>.Instance.GetSlots(false);

            var num = 0;

            crows.Anim.StrongNegationEffect();
            crows.Anim.PlaySacrificeParticles();

            yield return base.PreSuccessfulTriggerSequence();
            for (int i = 0; i < OPCards.Count; i++)
            {
                if (OPCards[i].Card != null)
                {
                    PlayableCard target = OPCards[i].Card;
                    target.Anim.LightNegationEffect();
                    crows.Anim.PlaySacrificeParticles();
                    target.Anim.PlaySacrificeParticles();
                    num += target.Info.BloodCost;
                }
            }
            CardModificationInfo cardModificationInfo = crows.TemporaryMods.Find((CardModificationInfo x) => x.singletonId == "void_BloodBoost");
            if (cardModificationInfo == null)
            {
                cardModificationInfo = new CardModificationInfo();
                cardModificationInfo.singletonId = "void_BloodBoost";
                crows.AddTemporaryMod(cardModificationInfo);
            }
            cardModificationInfo.attackAdjustment = num;
            crows.OnStatsChanged();

            yield return new WaitForSeconds(0.45f);
            yield return base.LearnAbility(0.1f);
            Singleton<ViewManager>.Instance.Controller.LockState = ViewLockState.Unlocked;
            yield break;
        }
    }
}