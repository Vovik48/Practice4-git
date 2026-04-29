using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerStats : MonoBehaviour
{
    public float maxMana = 100f;
    public float currentMana;
    public Image manaBarFill;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentMana = maxMana;
    }

    public void spendMana(float mana)
    {
        currentMana -= mana;

        //manaBarFill.rectTransform.sizeDelta = new Vector2(manaBarFill.sprite.rect.width * currentMana / maxMana, manaBarFill.rectTransform.sizeDelta.y);
        //Debug.Log(manaBarFill.rectTransform.sizeDelta);

        manaBarFill.fillAmount = currentMana / maxMana;
        Debug.Log(manaBarFill.fillAmount);

        if (currentMana <= 0)
        {
            Desiccation();
        }
    }

    void Desiccation()
    {
        Debug.Log(string.Format("Desiccation"));
        SceneManager.LoadScene("Menu");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
