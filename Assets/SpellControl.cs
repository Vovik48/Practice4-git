using UnityEngine;
using UnityEngine.InputSystem;

public class SpellControl : MonoBehaviour
{
    public PlayerStats playerStats;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mana = 0;
        if (Keyboard.current != null)
        {
            if (Keyboard.current.digit1Key.isPressed)
            {
                Debug.Log(string.Format("digit1Key.isPressed"));
                mana += 1;
            }
        }
        if (mana != 0)
        {
            playerStats.spendMana(mana);
        }
    }
}
