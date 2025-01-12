﻿using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets
{using UnityEngine;
    public class Weapon
    {
        private static int totalIds = 0;
        public int Id { get; set; }
        public int Damage { get; set; }
        public int Range { get; set; }
        public int CriticalDamage { get; set; }
        public int Value { get; set; }
        public string Name { get; set; }
        public int Rarity { get; set; }
        public string Url { get; set; }


        public Weapon(string name, int damage, int criticalDamage, int range, int value,  int rarity, string url)
        {
            totalIds++;
            Id = totalIds;
            Damage = damage;
            Range = range;
            CriticalDamage = criticalDamage;
            Name = name;
            Value = value;
            Rarity = rarity;
            Range = range;
            Url = url;
        }

        public string GetID()
        {
            int num = this.Id;
            return num.ToString();
        }
    }
}