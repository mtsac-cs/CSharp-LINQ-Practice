﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using LINQ_Practice.Lib;
//
//    var itemMaster = ItemMaster.FromJson(jsonString);

namespace LINQ_Practice.Lib
{
    using Newtonsoft.Json;

    public partial class ItemMaster
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("nameKey")]
        public string NameKey { get; set; }

        [JsonProperty("worldSpriteName")]
        public string WorldSpriteName { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("descriptionKey")]
        public string DescriptionKey { get; set; }

        [JsonProperty("goldValue")]
        public long GoldValue { get; set; }

        [JsonProperty("tier")]
        public long Tier { get; set; }

        [JsonProperty("culture")]
        public long Culture { get; set; }

        [JsonProperty("maxStack")]
        public long MaxStack { get; set; }

        [JsonProperty("canAppearInChest")]
        public bool CanAppearInChest { get; set; }

        [JsonProperty("chestWeight")]
        public long ChestWeight { get; set; }

        [JsonProperty("minChestStack")]
        public long MinChestStack { get; set; }

        [JsonProperty("maxChestStack")]
        public long MaxChestStack { get; set; }

        [JsonProperty("fixedChestStack")]
        public long FixedChestStack { get; set; }

        [JsonProperty("isDestroyedOnRunEnded")]
        public bool IsDestroyedOnRunEnded { get; set; }

        [JsonProperty("wandererWeaponGoldCost")]
        public long WandererWeaponGoldCost { get; set; }

        [JsonProperty("wandererWeaponSlimeCost")]
        public long WandererWeaponSlimeCost { get; set; }

        [JsonProperty("plusLevel")]
        public long PlusLevel { get; set; }

        [JsonProperty("inGameArtPrefabName")]
        public string InGameArtPrefabName { get; set; }

        [JsonProperty("inGameExtraPieceArtPrefabName")]
        public string InGameExtraPieceArtPrefabName { get; set; }

        [JsonProperty("extraPieceBaseColor1")]
        public ExtraPiece ExtraPieceBaseColor1 { get; set; }

        [JsonProperty("extraPieceBaseColor2")]
        public ExtraPiece ExtraPieceBaseColor2 { get; set; }

        [JsonProperty("extraPieceBaseColor3")]
        public ExtraPiece ExtraPieceBaseColor3 { get; set; }

        [JsonProperty("extraPieceFinalColor1")]
        public ExtraPiece ExtraPieceFinalColor1 { get; set; }

        [JsonProperty("extraPieceFinalColor2")]
        public ExtraPiece ExtraPieceFinalColor2 { get; set; }

        [JsonProperty("extraPieceFinalColor3")]
        public ExtraPiece ExtraPieceFinalColor3 { get; set; }

        [JsonProperty("equipmentSlot")]
        public long EquipmentSlot { get; set; }

        [JsonProperty("stats")]
        public Stats Stats { get; set; }

        [JsonProperty("amuletEffectName")]
        public string AmuletEffectName { get; set; }

        [JsonProperty("appearProbability")]
        public double AppearProbability { get; set; }

        [JsonProperty("canAppearMoreThanOnce")]
        public bool CanAppearMoreThanOnce { get; set; }

        [JsonProperty("bossDrop")]
        public bool BossDrop { get; set; }

        [JsonProperty("weaponType")]
        public long WeaponType { get; set; }

        [JsonProperty("mainAttackCooldown")]
        public long MainAttackCooldown { get; set; }

        [JsonProperty("secondaryAttackCooldown")]
        public long SecondaryAttackCooldown { get; set; }

        [JsonProperty("mainAttackPushBackwardsForce")]
        public long MainAttackPushBackwardsForce { get; set; }

        [JsonProperty("secondaryAttackPushBackwardsForce")]
        public long SecondaryAttackPushBackwardsForce { get; set; }

        [JsonProperty("secondaryAttackDamageMultiplier")]
        public long SecondaryAttackDamageMultiplier { get; set; }

        [JsonProperty("mainAttackEffectCombo1")]
        public string MainAttackEffectCombo1 { get; set; }

        [JsonProperty("mainAttackEffectCombo2")]
        public string MainAttackEffectCombo2 { get; set; }

        [JsonProperty("mainAttackEffectCombo3")]
        public string MainAttackEffectCombo3 { get; set; }

        [JsonProperty("secondaryAttackEffect")]
        public string SecondaryAttackEffect { get; set; }

        [JsonProperty("secondaryAttackChargedEffect")]
        public string SecondaryAttackChargedEffect { get; set; }

        [JsonProperty("missAttackEffect")]
        public string MissAttackEffect { get; set; }

        [JsonProperty("combatEffect")]
        public string CombatEffect { get; set; }

        [JsonProperty("trickAttackCooldown")]
        public long TrickAttackCooldown { get; set; }

        [JsonProperty("trickAttackPushBackwardsForce")]
        public long TrickAttackPushBackwardsForce { get; set; }

        [JsonProperty("trickEffect")]
        public string TrickEffect { get; set; }

        [JsonProperty("arrowPrefabName")]
        public string ArrowPrefabName { get; set; }

        [JsonProperty("minLevelToAppear")]
        public long MinLevelToAppear { get; set; }

        [JsonProperty("maxLevelToAppear")]
        public long MaxLevelToAppear { get; set; }

        [JsonProperty("mainAttackArrowReackTime")]
        public long MainAttackArrowReackTime { get; set; }

        [JsonProperty("secondaryAttackArrowReachTime")]
        public long SecondaryAttackArrowReachTime { get; set; }

        [JsonProperty("consumableEffectName")]
        public string ConsumableEffectName { get; set; }
    }


    public partial class ItemMaster
    {
        public static ItemMaster FromJson(string json) => JsonConvert.DeserializeObject<ItemMaster>(json, Converter.Settings);
    }
}
