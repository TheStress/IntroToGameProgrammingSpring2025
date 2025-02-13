using System.Runtime.Serialization;
using UnityEngine;

public class Week2Variables : MonoBehaviour
{
    // Declaring Variables
    int health = 10;

        

    // camelCase, usually for variables
    int numberOfDeaths;

    // snake_case, usually for variables
    int number_of_deaths;
    
    // PascalCase, usually for Functions and Classes
    int NumberOfDeaths;

    // Naming variables can only contain a-z, A-Z, 0-9, _ underscore
    // Cannot start with number and have to be unique within a given scope
    //int 12userName;
    //int use$rName;
    //int use)rName;
    //int !userName;
    //int _userName;
    //int userName12;
    //int userName12;
    // Commented out so no errors

    // Data Types //////////////////////////////////////////////////////////

    // ints, numbers without decimal points
    int numberOfPlayerInLobby = 4;
    int positionInQueue = 2;
    int numberOfKills = 30;

    // floats, numbers with decimal points
    float multiplier = 1.2f;
    float distance = 4.3f;
    float atkDebuffPercent = 0.2f;

    // char, a single character sourrounded by single quotes
    char letter = 'a';

    // strings, Words sourrounded by quotes and is really just a list of characters.
    string userName = "NelsonL112";
    string tutorialText = "Hello, to move around the world use WASD!";
    string characterName = "Mario";

    string title = "title";

    // Boolean, simply a true or false value
    bool isDead = false;
    bool isOnGround = true;
    bool gameStarted = false;

    SpriteRenderer spriteRenderer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Setting /////////////////////////////////////////////////////////
        int health = 10;
        health = 5;


        Vector3 settingPosition = new Vector3(0f, 0f, 0f);

        transform.position = settingPosition;
        transform.localScale = new Vector3(2f, 2f, 2f);

        transform.rotation = Quaternion.Euler(0, 0, 45f);


        Vector3 currentPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z);


        //health = 0.5f; // Bad data conversions
        //health = false; // Bad data conversions

        float distance = 1.5f;
        distance = 2;

        int test = 55;
        test = 'a';

        int maxHealth = 100;
        int currentHealth = 0;
        currentHealth = maxHealth;
        
        float damage = 5.0f;
        float heal = 10f;
        float healthMultiplier = 2;
        float healthDebuff = 3;
        float playerHealth = 100f;

        playerHealth = playerHealth - damage;
        playerHealth -= damage;
        playerHealth = playerHealth * healthMultiplier;
        playerHealth /= healthDebuff;
        playerHealth += heal;

        // Q1 Variables
        float scoreGain = 100;
        float multiplier = 1.25f;
        
        scoreGain = scoreGain * multiplier * multiplier;
        Debug.Log(scoreGain);

        // Q2 Variables
        float startingHealth = 100f;
        float damageDelt = 10.0f;
        float defence = 5f;

        float adjustedDamage = (damageDelt - defence);
        startingHealth = startingHealth - adjustedDamage;
        Debug.Log(startingHealth);

        // Q3 Variables
        float baseDamage = 10.0f;
        float bonusHealth = 100f;
        float bonusHealthDamageScaling = 0.1f;
        float weaponBonus = 7f;
        float stackingDebuffAmount = 0.2f;

        float totalDamage = baseDamage + weaponBonus + (bonusHealth*bonusHealthDamageScaling);
        float debuffPercentAmount = 1 - stackingDebuffAmount;

        float currentDamage = totalDamage * debuffPercentAmount * debuffPercentAmount;
        Debug.Log(currentDamage);


        float speed = 10;
        float friction = 0.1f;
    }
}
