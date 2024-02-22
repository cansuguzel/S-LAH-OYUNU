using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    private Interface interfaceScript;

    private Animator playerAnimator;
    public float playerHealth = 50f;
    public Text saglik;

    public void HesaplananHealth(float hesaplananHealth)
    {
        playerHealth -= hesaplananHealth;
        if (playerHealth <= 0)
        {
            PlayerDead();
        }
    }

    void PlayerDead()
    {
        playerAnimator.SetBool("playerdead", true);
        Destroy(gameObject, 10f);
       

    }

    // Start is called before the first frame update
    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        saglik.text = "%" + playerHealth.ToString("0");
        
    }
}
