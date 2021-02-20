﻿using System;
using UnityEngine;
using UnityEngine.UI;

namespace Managers
{
    public class BattleHUD : MonoBehaviour
    {
        public Text nameText;
        public Text levelText;
        public Slider hpSlider;
        
        public void SetHUD(Unit.Unit unit)
        {
            nameText.text = unit.unitName;
            levelText.text = "Lvl " + unit.unitLevel;
            hpSlider.maxValue = unit.maxHP;
            hpSlider.value = unit.currentHP;
        }

        public void SetHP(int hp)
        {
            hpSlider.value = hp;
        }
    }
}
