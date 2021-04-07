using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Pool;

public class Enemy : MonoBehaviour
{
    public AudioClip impact;
    AudioSource audiosource;
    public Renderer[] render;
    public int MostRenderNumbers;
    bool hide = true;
    public ParticleSystem deathParticles;
    public EnemyType enemyType;
    float timer = 0;
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (enemyType == EnemyType.BlueType)
        {
            if (other.gameObject.CompareTag("BlueWeapon"))
            {
                HP.Instance.CountHP(1);
                ShockController.Instance.Shock(0.3f, 1);
                // audiosource.PlayOneShot(impact);
                Destroy();
            }
            if (other.gameObject.CompareTag("Wall"))
            {
                HP.Instance.CountHP(2);
                GetHurt.Instance.HurtStarting = true;
                Lean.Pool.LeanPool.Despawn(gameObject);
            }
        }

        if (enemyType == EnemyType.PurpleType)
        {
            if (other.gameObject.CompareTag("PurpleWeapon"))
            {
                HP.Instance.CountHP(1);
                ShockController.Instance.Shock(0.3f, 1);
                // audiosource.PlayOneShot(impact);
                Destroy();
            }
            if (other.gameObject.CompareTag("Wall"))
            {
                HP.Instance.CountHP(2);
                GetHurt.Instance.HurtStarting = true;
                Lean.Pool.LeanPool.Despawn(gameObject);
            }
        }

        if (enemyType == EnemyType.RedType)
        {
            if (other.gameObject.CompareTag("RedWeapon"))
            {
                HP.Instance.CountHP(1);
                ShockController.Instance.Shock(0.3f, 2);
                // audiosource.PlayOneShot(impact);
                // Debug.Log("123456789");
                Destroy();
            }
            if (other.gameObject.CompareTag("Wall"))
            {
                HP.Instance.CountHP(2);
                GetHurt.Instance.HurtStarting = true;
                Lean.Pool.LeanPool.Despawn(gameObject);
            }
        }

        if (enemyType == EnemyType.YellowType)
        {
            if (other.gameObject.CompareTag("YellowWeapon"))
            {
                HP.Instance.CountHP(1);
                ShockController.Instance.Shock(0.3f, 2);
                // audiosource.PlayOneShot(impact);
                Destroy();
            }
            if (other.gameObject.CompareTag("Wall"))
            {
                HP.Instance.CountHP(2);
                GetHurt.Instance.HurtStarting = true;
                Lean.Pool.LeanPool.Despawn(gameObject);
            }
        }
    }

    public void Destroy()
    {
        Instantiate(deathParticles, transform.position, Quaternion.identity);
        Lean.Pool.LeanPool.Despawn(gameObject);
    }
    public enum EnemyType
    {
        YellowType, RedType, BlueType, PurpleType
    }

}
