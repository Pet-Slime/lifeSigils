using System.Collections;
using DiskCardGame;
using lifeSigils.Managers;
using UnityEngine;

namespace lifeSigils
{
    public partial class Plugin
	{
		private void AddFungalInfection()
		{
			// setup ability
			const string rulebookName = "Fungal Infection (Ants)";
			const string rulebookDescription = "[creature] will cause ants to become fungal ants during the endphase.";
            const string LearnDialogue = "The infection will spread.";
            Texture2D tex_a1 = SigilUtils.Texture_Helper("void_antSpread.png");
            Texture2D tex_a2 = SigilUtils.Texture_Helper("void_antSpread_pixel.png");
            int powerlevel = 0;
            bool LeshyUsable = false;
            bool part1Shops = false;
            bool canStack = false;

            // set ability to behaviour class
            ability_FungalInfection.ability = SigilUtils.CreateAbilityWithDefaultSettingsKCM(rulebookName, rulebookDescription, typeof(ability_FungalInfection), tex_a1, tex_a2, LearnDialogue,
                                                                                    true, powerlevel, LeshyUsable, part1Shops, canStack).ability;
        }
	}

	public class ability_FungalInfection : AbilityBehaviour
	{
		public override Ability Ability => ability;

		public static Ability ability;

        public override bool RespondsToTurnEnd(bool playerTurnEnd)
        {
            return true;
        }

        public override IEnumerator OnTurnEnd(bool playerTurnEnd)
        {
            Singleton<ViewManager>.Instance.SwitchToView(View.Board, false, true);

            PlayableCard crows = (PlayableCard)base.Card;
            var OPCards = Singleton<BoardManager>.Instance.GetSlots(false);
            var PLCards = Singleton<BoardManager>.Instance.GetSlots(true);

            crows.Anim.StrongNegationEffect();
            crows.Anim.PlaySacrificeParticles();

            for (int i = 0; i < OPCards.Count; i++)
            {
                if (OPCards[i].Card != null)
                {
                    PlayableCard target = OPCards[i].Card;
                    if (target.Info.name != "lifecost_fungal_ant" && target.Info.HasTrait(Trait.Ant))
                    {
                        target.Anim.LightNegationEffect();
                        crows.Anim.PlaySacrificeParticles();
                        target.Anim.PlaySacrificeParticles();
                        yield return new WaitForSeconds(0.2f);
                        yield return target.Die(false, target, true);
                        yield return new WaitForSeconds(0.3f);
                        if (OPCards[i].Card == null)
                        {
                            PlayableCard murdered = CardSpawner.SpawnPlayableCard(CardLoader.GetCardByName("lifecost_fungal_ant"));
                            yield return Singleton<BoardManager>.Instance.ResolveCardOnBoard(murdered, OPCards[i]);
                        }
                    }
                }
            }

            for (int i = 0; i < PLCards.Count; i++)
            {
                if (PLCards[i].Card != null)
                {
                    PlayableCard target = PLCards[i].Card;
                    if (target.Info.name != "lifecost_fungal_ant" && target.Info.HasTrait(Trait.Ant))
                    {
                        target.Anim.LightNegationEffect();
                        crows.Anim.PlaySacrificeParticles();
                        target.Anim.PlaySacrificeParticles();
                        yield return new WaitForSeconds(0.2f);
                        yield return target.Die(false, target, true);
                        yield return new WaitForSeconds(0.3f);
                        if (PLCards[i].Card == null)
                        {
                            PlayableCard murdered = CardSpawner.SpawnPlayableCard(CardLoader.GetCardByName("lifecost_fungal_ant"));
                            yield return Singleton<BoardManager>.Instance.ResolveCardOnBoard(murdered, PLCards[i]);
                        }
                        
                    }
                }
            }
            yield return new WaitForSeconds(0.2f);
            Singleton<ViewManager>.Instance.Controller.LockState = ViewLockState.Unlocked;
        }
    }
}