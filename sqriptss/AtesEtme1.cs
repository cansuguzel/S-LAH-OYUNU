using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtesEtme : MonoBehaviour
{
    RaycastHit hit;
    public GameObject MermiCikisNoktasi;
    public bool AtesEdebilir;
    float GunTimer;
    public float TaramaHizi;
    public ParticleSystem MuzzleFlash;
    AudioSource SesKaynak;
    public AudioClip AtesSesi;
    public float Menzil;
    public float damageEnemy;
    public GameObject kanefekti;
    public GameObject mermiefekti;
    public GeriTepme recoil;

    void Start()
    {
        SesKaynak = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && AtesEdebilir == true && Time.time > GunTimer)
        {
            if (Fire())
            {
                if (hit.transform.tag == "Enemy")
                {
                    EnemyHealth enemyHealthScript = hit.transform.GetComponent<EnemyHealth>();

                    if (enemyHealthScript != null)
                    {
                        enemyHealthScript.DeductHealth(damageEnemy);

                        GameObject kanEfektiObjesi = Instantiate(kanefekti, hit.point, Quaternion.LookRotation(hit.normal));
                        Destroy(kanEfektiObjesi, 1.0f);
                    }
                    else
                    {
                        Instantiate(mermiefekti, hit.point, Quaternion.LookRotation(hit.normal));
                    }
                }

                Debug.Log(hit.transform.name);
            }

            GunTimer = Time.time + TaramaHizi;
            recoil.Fire();

        }
    }

    bool Fire()
    {
        if (Physics.Raycast(MermiCikisNoktasi.transform.position, MermiCikisNoktasi.transform.forward, out hit, Menzil))
        {
            SesKaynak.clip = AtesSesi;
            SesKaynak.Play();

            
            MuzzleFlash.transform.position = MermiCikisNoktasi.transform.position;
            MuzzleFlash.Stop();
            MuzzleFlash.Play();

            Debug.Log(hit.transform.name);

            return true;
        }

        return false;
    }
}
