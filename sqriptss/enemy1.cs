using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float distance;
    public Transform target;
    Vector3 pos;
    private Animator enemyAnimator;

    public GameObject MuzzleCikisNoktasi;
    public bool AtesEdebilir;
    float GunTimer;
    public GameObject uzaklik;

    public float Menzil;
    public float damagePlayer;
    public float atisHizi = 1f; // Saniyede kaç kere ateþ edileceði
    private float sonAtisZamani = 0f;

    void Start()
    {
        enemyAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        distance = Vector3.Distance(transform.position, target.position);
        pos = new Vector3(target.position.x, transform.position.y, target.position.z);

        if (distance < 10f)
        {
            transform.LookAt(pos);
            enemyAnimator.SetBool("isWalk", true);

            if (Time.time > sonAtisZamani && AtesEdebilir)
            {
                // Oyuncuya ateþ et
                Fire();
                sonAtisZamani = Time.time + 1f / atisHizi; // Atýþ hýzýný kontrol et
            }
        }
        else
        {
            enemyAnimator.SetBool("isWalk", false);
        }
    }

    void Fire()
    {
        if (Physics.Raycast(MuzzleCikisNoktasi.transform.position, MuzzleCikisNoktasi.transform.forward, out RaycastHit hit, Menzil))
        {
            if (hit.transform.CompareTag("Player"))
            {
                PlayerHealth playerHealthScript = hit.transform.GetComponent<PlayerHealth>();

                if (playerHealthScript != null)
                {
                    playerHealthScript.HesaplananHealth(damagePlayer);
                }
            }
        }
    }
}
