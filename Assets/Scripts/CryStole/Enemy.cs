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

    int id;
    float time; //個別敵人該被打到的時間

    public float rangetime = 0.5f; //判定時間範圍
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
                if (RightWeapon.Instance.timer >= time - rangetime && RightWeapon.Instance.timer <= time + rangetime)
                {
                    Debug.Log("成功打到");
                    HP.Instance.CountHP(1);
                    ShockController.Instance.Shock(0.3f, 1);
                    // audiosource.PlayOneShot(impact);
                    Destroy();
                }
                else
                {
                    Debug.Log("miss");
                }
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
                if (RightWeapon.Instance.timer >= time - rangetime && RightWeapon.Instance.timer <= time + rangetime)
                {
                    HP.Instance.CountHP(1);
                    ShockController.Instance.Shock(0.3f, 1);
                    // audiosource.PlayOneShot(impact);
                    Destroy();
                }
                else
                {
                    Debug.Log("miss");
                }
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
                if (LeftWeapon.Instance.timer >= time - rangetime && LeftWeapon.Instance.timer <= time + rangetime)
                {
                    HP.Instance.CountHP(1);
                    ShockController.Instance.Shock(0.3f, 1);
                    // audiosource.PlayOneShot(impact);
                    Destroy();
                }
                else
                {
                    Debug.Log("miss");
                }
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
                if (LeftWeapon.Instance.timer >= time - rangetime && LeftWeapon.Instance.timer <= time + rangetime)
                {
                    HP.Instance.CountHP(1);
                    ShockController.Instance.Shock(0.3f, 1);
                    // audiosource.PlayOneShot(impact);
                    Destroy();
                }
                else
                {
                    Debug.Log("miss");
                }
            }
            if (other.gameObject.CompareTag("Wall"))
            {
                HP.Instance.CountHP(2);
                GetHurt.Instance.HurtStarting = true;
                Lean.Pool.LeanPool.Despawn(gameObject);
            }
        }
    }
    private void Update()
    {
        timer += Time.deltaTime;
    }

    public void Init(int id, float time)
    {
        this.id = id;
        this.time = time;
        // Debug.Log("第" + id + "個敵人出現");
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
