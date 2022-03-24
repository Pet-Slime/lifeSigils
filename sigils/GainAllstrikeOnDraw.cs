using System.Collections;
using InscryptionAPI.Card;
using DiskCardGame;


namespace lifeSigils
{
    public class GainAllstrikeOnDraw : SpecialCardBehaviour
    {
        public SpecialTriggeredAbility SpecialAbility => specialAbility;
        public static SpecialTriggeredAbility specialAbility;


        public override bool RespondsToDrawn()
        {
            return true;
        }

        public override IEnumerator OnDrawn()
        {
            PlayableCard card = (PlayableCard)base.Card;

            (Singleton<PlayerHand>.Instance as PlayerHand3D).MoveCardAboveHand(card);
            yield return card.FlipInHand(new System.Action(this.AddMod));
            yield break;
        }

        private void AddMod()
        {
            PlayableCard card = (PlayableCard)base.Card;
            CardModificationInfo cardModificationInfo = new CardModificationInfo(this.ChooseAbility());
            card.AddTemporaryMod(cardModificationInfo);
        }

        private Ability ChooseAbility()
        {
            Ability ability = Ability.AllStrike;
            return ability;
        }
    }
}