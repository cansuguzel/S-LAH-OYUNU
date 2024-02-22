
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    Interface arayüz;
    private int olenDusman;
    private Animator enemyAnimator;
    public float enemyHealth = 20f;

    public void DeductHealth(float deductHealth)
    {
        enemyHealth -= deductHealth;
        if (enemyHealth <= 0)
        {
            EnemyDead();
        }
    }

    void EnemyDead()
    {

        enemyAnimator.SetBool("enemydead", true);
        Destroy(gameObject, 10f);
        olenDusman++;

    }

    // Start is called before the first frame update
    void Start()
    {
        enemyAnimator = GetComponent<Animator>();
        arayüz = GetComponent<Interface>();

    }

    // Update is called once per frame
    void Update()
    {
        if (arayüz != null && olenDusman == 10)
        {
            Debug.Log("TEBRÝKLER"); 
           arayüz.durum.text = "TEBRÝKLER";
        }
    }
}