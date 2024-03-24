using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[Serializable]
public class PokemonData
{
    public string Name;
    public int number;
    public string Type;
    public string Height;
    public string Weight;
    public string Abilities;
    public Sprite Icon;
    public string Description;
    public Stats stats;

    [Serializable]
    public struct Stats
    {
        public int pv;
        public int atk;
        public int def;
        public int atkSpe;
        public int defSpe;
        public int speed;

        public Stats(int pv, int atk, int def, int atkSpe, int defSpe, int speed)
        {
            this.pv = pv;
            this.atk = atk;
            this.def = def;
            this.atkSpe = atkSpe;
            this.defSpe = defSpe;
            this.speed = speed;
        }
    }

    public PokemonData()
    {

    }

    public PokemonData(string name, int number, string type, string height, string weight, string abilities, Sprite icon, string description, Stats stats)
    {
        this.Name = name;
        this.number = number;
        this.Type = type;
        this.Height = height;
        this.Weight = weight;
        this.Abilities = abilities;
        this.Icon = icon;
        this.Description = description;
        this.stats = stats;
    }
}


