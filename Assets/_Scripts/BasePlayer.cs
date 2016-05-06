using UnityEngine;
using System.Collections;

public class BasePlayer {

    public string Name { get; set; }

    public int Health { get; set; }
    public int Energy { get; set; }
    public int Stamina { get; set; }
    public int Hunger { get; set; }
    public int Thirst { get; set; }
    public int Temperature { get; set; }

    public int MaxHealth { get; set; }
    public int MaxEnergy { get; set; }
    public int MaxStamina { get; set; }
    public int MaxHunger { get; set; }
    public int MaxThirst { get; set; }
    public int MaxTemperature { get; set; }

    public BasePlayer(string name)
    {
        this.Name = name;
        this.MaxHealth = 100;
        this.Health = MaxHealth;
        this.MaxEnergy = 100;
        this.Energy = MaxEnergy;
        this.MaxStamina = 100;
        this.Stamina = MaxStamina;
        this.MaxHunger = 100;
        this.Hunger = MaxHunger;
        this.MaxThirst = 100;
        this.Thirst = MaxThirst;
        this.MaxTemperature = 100;
        this.Temperature = MaxTemperature;
    }

}
