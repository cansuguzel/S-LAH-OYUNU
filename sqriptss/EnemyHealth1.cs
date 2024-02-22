
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    Interface aray�z;
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
        aray�z = GetComponent<Interface>();

    }

    // Update is called once per frame
    void Update()
    {
        if (aray�z != null && olenDusman == 10)
        {
            Debug.Log("TEBR�KLER"); 
           aray�z.durum.text = "TEBR�KLER";
        }
    }
}