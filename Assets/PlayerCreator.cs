using UnityEngine;
using UnityEngine.UI;

public class PlayerCreator : MonoBehaviour
{
    private InputField playerNameInput;
    public Text displayText;

    public ButtonData[] buttonData;

    private PlayerStats currentPlayerStats;

    public Text healthText;
    public Text damageText;
    public Text armourText;
    public Text hitRateText;
    public Text armourPenetrationText;
    public Text evadeRateText;
    public Text criticalChanceText;
    public Text healAmountText;
    public Text movementSpeedText;

    public GameObject emptyObject; // Reference to the empty object with SpriteRenderer

    void Start()
    {
        playerNameInput = GetComponentInChildren<InputField>();
        currentPlayerStats = new PlayerStats();

        for (int i = 0; i < buttonData.Length; i++)
        {
            int index = i;
            buttonData[i].button.onClick.AddListener(() => OnButtonClick(index));
        }
    }

    void OnButtonClick(int index)
    {
        ClearUIText();

        currentPlayerStats.ApplyStats(buttonData[index].health, buttonData[index].damage, buttonData[index].armour, buttonData[index].hitRate, buttonData[index].armourPenetration, buttonData[index].evadeRate, buttonData[index].criticalChance, buttonData[index].healAmount, buttonData[index].movementSpeed);

        healthText.text = $"Health: {currentPlayerStats.Health}";
        damageText.text = $"Damage: {currentPlayerStats.Damage}";
        armourText.text = $"Armour: {currentPlayerStats.Armour}";
        hitRateText.text = $"Hit Rate: {currentPlayerStats.HitRate}";
        armourPenetrationText.text = $"Armour Penetration: {currentPlayerStats.ArmourPenetration}";
        evadeRateText.text = $"Evade Rate: {currentPlayerStats.EvadeRate}";
        criticalChanceText.text = $"Critical Chance: {currentPlayerStats.CriticalChance}";
        healAmountText.text = $"Heal Amount: {currentPlayerStats.HealAmount}";
        movementSpeedText.text = $"Movement Speed: {currentPlayerStats.MovementSpeed}";

        // Apply sprite to the empty object's SpriteRenderer
        if (emptyObject != null)
        {
            if (buttonData[index].buttonImage != null)
            {
                SpriteRenderer spriteRenderer = emptyObject.GetComponent<SpriteRenderer>();
                if (spriteRenderer != null)
                {
                    spriteRenderer.sprite = buttonData[index].buttonImage;
                }
                else
                {
                    Debug.LogError("SpriteRenderer component not found on the empty object.");
                }
            }
            else
            {
                Debug.LogWarning("Button image not assigned.");
            }
        }
        else
        {
            Debug.LogError("Empty object reference not assigned. Please check the references in the inspector.");
        }
    }

    void ClearUIText()
    {
        healthText.text = "Health: ";
        damageText.text = "Damage: ";
        armourText.text = "Armour: ";
        hitRateText.text = "Hit Rate: ";
        armourPenetrationText.text = "Armour Penetration: ";
        evadeRateText.text = "Evade Rate: ";
        criticalChanceText.text = "Critical Chance: ";
        healAmountText.text = "Heal Amount: ";
        movementSpeedText.text = "Movement Speed: ";
    }
}

[System.Serializable]
public class ButtonData
{
    public Button button;
    public int health;
    public int damage;
    public int armour;
    public int hitRate;
    public int armourPenetration;
    public int evadeRate;
    public int criticalChance;
    public int healAmount;
    public int movementSpeed;
    public Sprite buttonImage;
}

[System.Serializable]
public class PlayerStats
{
    public int Health;
    public int Damage;
    public int Armour;
    public int HitRate;
    public int ArmourPenetration;
    public int EvadeRate;
    public int CriticalChance;
    public int HealAmount;
    public int MovementSpeed;

    public void ApplyStats(int health, int damage, int armour, int hitRate, int armourPenetration, int evadeRate, int criticalChance, int healAmount, int movementSpeed)
    {
        Health = health;
        Damage = damage;
        Armour = armour;
        HitRate = hitRate;
        ArmourPenetration = armourPenetration;
        EvadeRate = evadeRate;
        CriticalChance = criticalChance;
        HealAmount = healAmount;
        MovementSpeed = movementSpeed;
    }
}