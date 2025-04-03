using System;

namespace DungeonCrawler
{
    internal static class BarbarianTraits : Barbarian
    {
        protected void Rage()
        {
            resistance.Add("Bludgeoning", "Piercing", "Slashing");
            base.Resistance = _resistance;

            
        }
        void UnarmoredDefense();
        void WeaponMastery();
        void DangerSense();
        void RecklessAttack();
        void BarbarianSubclass();
        void PrimalKnowledge();
        void ExtraAttack();
        void FastMovement();
        void SubclassFeature();
        void FeralInstinct();
        void InstinctivePounce();
        void BrutalAttack();
        void RelentlessRage();
        void ImprovedBrutalAttack();
        void PersistentRage();
        void ImprovedBrutalStrike();
        void IndomitableMight();
        void EpicBoon();
        void PrimalChampion();
    }
}