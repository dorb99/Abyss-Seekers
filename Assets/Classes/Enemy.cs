﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets
{
    public class Enemy 
    { 
        public string Name { get; set; }
        public int Worth {  get; set; }
        public int MaxHealth { get; set; }
        public int Damage { get; set; }
        public int HealthRegeneration { get; set; }
        public int HitRate { get; set; }
        public int EvadeRate { get; set; }
        public int Armour { get; set; }
        public int MovementSpeed { get; set; }
        public int CriticalChance { get; set; }
        public int ArmourPenetration { get; set; }
        public string[] SpecialAbility { get; set; }
        public Enemy(string name, int worth, int maxHealth, int damage, int healthRegeneration,
                         int hitRate, int evadeRate, int armour, int movementSpeed,
                         int criticalChance, int armourPenetration)
            {
                Name = name;
                Worth = worth;
                MaxHealth = maxHealth;
                Damage = damage;
                HealthRegeneration = healthRegeneration;
                HitRate = hitRate;
                EvadeRate = evadeRate;
                Armour = armour;
                MovementSpeed = movementSpeed;
                CriticalChance = criticalChance;
                ArmourPenetration = armourPenetration;
            }

        public static explicit operator Enemy(List<Enemy> v)
        {
            throw new NotImplementedException();
        }
    }
}