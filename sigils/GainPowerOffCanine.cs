using System.Collections;
using System.Collections.Generic;
using System.Linq;
using InscryptionAPI.Card;
using DiskCardGame;
using UnityEngine;
using HarmonyLib;

namespace lifeSigils
{
	[HarmonyPatch(typeof(PlayableCard), "GetPassiveAttackBuffs")]
	public class sigil_passive_buffs
	{
		[HarmonyPostfix]
		public static void Postfix(ref int __result, ref PlayableCard __instance)
		{
			if (__instance.OnBoard && __instance.Info.IsOfTribe(Tribe.Canine))
			{
				foreach (CardSlot slotState in Singleton<BoardManager>.Instance.AllSlots)
				{
					if (slotState.Card != null && slotState.Card.Info.name == "lifepack_Blood_Fea")
					{
						__result -= 2;
					}
				}
			}
		}
	}
}