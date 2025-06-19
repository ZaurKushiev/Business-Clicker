using System;
using System.Collections.Generic;
using Code.Gameplay.Business.Configs;
using Code.Gameplay.Business.Requests;

namespace Code.Gameplay.Business.Components
{
    public struct AccumulatedModifierComponent
    {
        public List<AccumulatedModifiersData> Value;
    }
    
    public struct BaseCostComponent
    {
        public int Value;
    }
    
    public struct BaseIncomeComponent
    {
        public int Value;
    }
    
    public struct BusinessComponent
    {
        public bool Value;
    }
    
    public struct BusinessIdComponent
    {
        public int Value;
    }
    
    [Serializable]
    public struct BusinessSaveComponent
    {
        public int BusinessId;
        public int Level;
        public float Progress;
        public float Cooldown;
    }
    
    public struct IncomeComponent
    {
        public int Value;
    }
    
    public struct IncomeСooldownAvailableComponent
    {
        public bool Value;
    }
    
    public struct IncomeСooldownComponent
    {
        public float Value;
    }
    
    public struct IncomeСooldownLeftComponent
    {
        public float Value;
    }
    
    public struct IncomeСooldownUpComponent
    {
        public bool Value;
    }
    
    public struct LevelUpRequestComponent
    {
        public LevelUpRequest Value;
    }
    
    public struct TotalIncomeComponent
    {
        public int Value;
    }
    
    public struct TotalModifierComponent
    {
        public float Value;
    }
    
    public struct UpdateBusinessModifiersComponent
    {
        public List<UpgradeData> Value;
    }
    
    public struct UpgradeModifierComponent
    {
        public float Value;
    }
    
    public struct UpgradeModifierIdComponent
    {
        public int Value;
    }
    
    public struct UpgradePurchasedRequestComponent
    {
        public UpgradePurchasedRequest Value;
    }
}
