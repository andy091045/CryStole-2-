using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Renderer[] render;
    public int MostRenderNumbers;
    bool hide = true;
    public ParticleSystem deathParticles;
    public EnemyType enemyType;
    float timer = 0;
    // private void Start()
    // {
    //     for (int i = 0; i < MostRenderNumbers; i++)
    //     {
    //         render[i].enabled = false;
    //     }
    // }
    // private void Update()
    // {
    //     timer = timer + Time.deltaTime;

    // }

    void OnTriggerEnter(Collider other)
    {
        if (enemyType == EnemyType.BlueType)
        {
            if (other.gameObject.CompareTag("BlueWeapon"))
            {
                HP.Instance.CountHP(1);
                ShockController.Instance.Shock(0.3f, 1);
                Destroy();
            }
            if (other.gameObject.CompareTag("Wall"))
            {
                HP.Instance.CountHP(2);
                Destroy(gameObject);
            }
        }

        if (enemyType == EnemyType.PurpleType)
        {
            if (other.gameObject.CompareTag("PurpleWeapon"))
            {
                HP.Instance.CountHP(1);
                ShockController.Instance.Shock(0.3f, 1);
                Destroy();
            }
            if (other.gameObject.CompareTag("Wall"))
            {
                HP.Instance.CountHP(2);
                Destroy(gameObject);
            }
        }

        if (enemyType == EnemyType.RedType)
        {
            if (other.gameObject.CompareTag("RedWeapon"))
            {
                HP.Instance.CountHP(1);
                ShockController.Instance.Shock(0.3f, 2);
                Destroy();
            }
            if (other.gameObject.CompareTag("Wall"))
            {
                HP.Instance.CountHP(2);
                Destroy(gameObject);
            }
        }

        if (enemyType == EnemyType.YellowType)
        {
            if (other.gameObject.CompareTag("YellowWeapon"))
            {
                HP.Instance.CountHP(1);
                ShockController.Instance.Shock(0.3f, 2);
                Destroy();
            }
            if (other.gameObject.CompareTag("Wall"))
            {
                HP.Instance.CountHP(2);
                Destroy(gameObject);
            }
        }
    }

    public void Destroy()
    {
        Instantiate(deathParticles, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
    public enum EnemyType
    {
        YellowType, RedType, BlueType, PurpleType
    }

}
