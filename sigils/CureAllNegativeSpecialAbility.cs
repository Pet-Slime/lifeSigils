using System.Collections;
using System.Collections.Generic;
using System.Linq;
using InscryptionAPI.Card;
using DiskCardGame;
using UnityEngine;

namespace lifeSigils
{
    public class CureAllNegativeSpecialAbility : SpecialCardBehaviour
    {
        public SpecialTriggeredAbility SpecialAbility => specialAbility;
        public static SpecialTriggeredAbility specialAbility;

        public override bool RespondsToResolveOnBoard()
        {
            return true;
        }

        public override IEnumerator OnResolveOnBoard()
        {
            Singleton<ViewManager>.Instance.SwitchToView(View.Board, false, true);

            PlayableCard crows = (PlayableCard)base.Card;
            var PLCards = Singleton<BoardManager>.Instance.GetSlots(true);


            crows.Anim.StrongNegationEffect();
            crows.Anim.PlaySacrificeParticles();

            var abilities = ScriptableObjectLoader<AbilityInfo>.AllData;


            for (int i = 0; i < PLCards.Count; i++)
            {
                if (PLCards[i].Card != null)
                {
                    PlayableCard target = PLCards[i].Card;
                    target.Anim.StrongNegationEffect();
                    target.Anim.PlaySacrificeParticles();


                    for (int index = 0; index < abilities.Count; index++)
                    {
                        if (target.HasAbility(abilities[index].ability) && abilities[index].powerLevel < 0)
                        {
                            yield return new WaitForSeconds(0.2f);
                            //create new modification info
                            CardModificationInfo negateMod = new CardModificationInfo();
                            negateMod.negateAbilities.Add(abilities[index].ability);
                            CardInfo cardInfo = target.Info.Clone() as CardInfo;
                            cardInfo.Mods.Add(negateMod);
                            target.SetInfo(cardInfo);
                            target.Anim.LightNegationEffect();

                        }
                    }
                }
            }
            yield return new WaitForSeconds(0.2f);
            Singleton<ViewManager>.Instance.Controller.LockState = ViewLockState.Unlocked;

            yield break;
        }
    }
}