using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    
    public float maxHealth;
    public Image healthBar;

    private float currentHealth = 0;
    
    public static Health Instance { get; private set; }



    private void Awake()
    {
        //sety singleton value <3
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            enabled = false;
        }
    }

    // Start is called before the first frame update
    void Start()
{
    currentHealth = maxHealth;
        healthBar.fillAmount = currentHealth / maxHealth;
}

    public void TakeDamage(float amount)
    {
        if (currentHealth > 0)
        {
            currentHealth -= amount;
            Debug.Log("Current heath is now" + currentHealth);
            if (currentHealth <= 0)
            {
                currentHealth = 0;
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
                //ur ded lol
            }
            //health go bye bye
        }
        healthBar.fillAmount = currentHealth /maxHealth;
    }
}
