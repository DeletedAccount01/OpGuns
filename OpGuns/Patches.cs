// Decompiled with JetBrains decompiler
// Type: AnxietyAtNight.Patches
// Assembly: AnxietyAtNight, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 84D7F874-26C7-4DBB-83B7-F81F26BF6D91
// Assembly location: F:\games\The Long Dark\Mods\AnxietyAtNight.dll

using HarmonyLib;
using Il2CppSystem;
using UnityEngine;
using MelonLoader;

[HarmonyPatch(typeof(GunItem), "Update")]
class Patch
{
    static void Postfix()
    {
        GameManager.GetPlayerManagerComponent().m_ItemInHands.m_GunItem.m_MultiplierFire = 1000000;
        GameManager.GetPlayerManagerComponent().m_ItemInHands.m_GunItem.m_MuzzleFlash_FlashDelay = 0;
        GameManager.GetPlayerManagerComponent().m_ItemInHands.m_GunItem.m_MuzzleFlash_SmokeDelay = 0;
        GameManager.GetPlayerManagerComponent().m_ItemInHands.m_GunItem.m_FiringRateSeconds = 0.000001f;
        GameManager.GetPlayerManagerComponent().m_ItemInHands.m_GunItem.m_IsJammed = false;
        GameManager.GetPlayerManagerComponent().m_ItemInHands.m_GunItem.m_PitchRecoilMax = 0;
        GameManager.GetPlayerManagerComponent().m_ItemInHands.m_GunItem.m_PitchRecoilMin = 0;
        GameManager.GetPlayerManagerComponent().m_ItemInHands.m_GunItem.AddRoundsToClip(1, 100);
        GameManager.GetPlayerManagerComponent().m_ItemInHands.m_GunItem.m_YawRecoilMax = 0;
        GameManager.GetPlayerManagerComponent().m_ItemInHands.m_GunItem.m_YawRecoilMin = 0;
        GameManager.GetPlayerManagerComponent().m_ItemInHands.m_GunItem.m_AllowHipFire = true;
        GameManager.GetPlayerManagerComponent().m_ItemInHands.m_GunItem.m_RoundsInClip = 6;
    }
}