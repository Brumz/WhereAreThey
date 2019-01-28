
using UnityEngine;

public class CharacterStats : MonoBehaviour {

    public int maxHealth = 100;
    public int currentHealth { get; private set; }
    public Stat damage;

    void Awake()
    {
        currentHealth = maxHealth;
    }
}
