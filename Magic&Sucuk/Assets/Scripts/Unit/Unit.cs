﻿using UnityEngine;

namespace Unit
{
    public class Unit : MonoBehaviour
    {
        public string unitName;

        public int damage;
        public int magicDamage;
        
        public int strikeCoefficient;
        public int waterCoefficient;
        public int streamCoefficient;
        public int windCoefficient;
        
        public int maxHP;
        public int currentHP;

        public GameObject backUI;

        public int critPercentage;
        public int critDamage = 3;

        public bool TakeDamage(int dmg)
        {
            currentHP -= dmg;

            if (currentHP <= 0)
            {
                Destroy(this.gameObject);
                return true;
            }
            else
                return false;
        }

        public void Heal(int amount)
        {
            currentHP += amount;
            if (currentHP >= maxHP)
            {
                currentHP = maxHP;
            }
        }

        public bool ProcessDeath(Unit unit)
        {
            if (unit.currentHP <= 0){
                //Destroy(unit.gameObject);
                return true;
            }
            else
                return false;
        }

        public void SetUnit(string name, int dmg, int magicDmg, int maxHp, int currHp,int strikec, int waterc, int streamc, int windc, int critP)
        {
            unitName = name;
            damage = dmg;
            magicDamage = magicDmg;
        
            strikeCoefficient = strikec;
            waterCoefficient = waterc;
            streamCoefficient = streamc;
            windCoefficient = windc;
        
            maxHP = maxHp;
            currentHP = currHp;

            critPercentage = critP;
        }

        public void CoefficientBuff()
        {
            // for one round
            strikeCoefficient--;
            waterCoefficient--;
            streamCoefficient--;
            windCoefficient--;
        }

        public void CoefficientNerf()
        {
            strikeCoefficient++;
            waterCoefficient++;
            streamCoefficient++;
            windCoefficient++;
        }

        public void SetCrit()
        {
            // for two rounds
            critPercentage *= 3;
        }

        public void IncreaseAttackDmg()
        { // for two rounds
            damage += 5;
            magicDamage += 5;
        }
        
    }
}
