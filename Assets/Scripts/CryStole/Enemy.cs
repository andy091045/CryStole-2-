using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Pool;

public class Enemy : MonoBehaviour
{
    public GameObject FloatingTextPrefab;
    public AudioClip impact;
    AudioSource audiosource;
    public Renderer[] render;
    public int MostRenderNumbers;
    bool hide = true;
    public ParticleSystem deathParticles;
    public ParticleSystem PerfectParticles;
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
                    if (FloatingTextPrefab)
                    {
                        ShowFloatingText("PERFECT");
                    }
                    HP.Instance.CountHP(1);
                    ShockController.Instance.Shock(0.3f, 1);
                    Debug.Log("PERFECT" + "該被打到時間:" + time + "實際打到時間: " +  RightWeapon.Instance.timer );
                    // audiosource.PlayOneShot(impact);
                    Destroy();
                }
                else if ((RightWeapon.Instance.timer >= time - 2 * rangetime && RightWeapon.Instance.timer < time - rangetime) || (RightWeapon.Instance.timer > time - rangetime && RightWeapon.Instance.timer <= time - 2 * rangetime))
                {
                    if (FloatingTextPrefab)
                    {
                        ShowFloatingText("GOOD");
                    }
                    HP.Instance.CountHP(2);
                    ShockController.Instance.Shock(0.1f, 1);
                    // audiosource.PlayOneShot(impact);
                    Debug.Log("GOOD" + "該被打到時間:" + time + "實際打到時間: " +  RightWeapon.Instance.timer );
                    Destroy();
                }
                else
                {
                    if (FloatingTextPrefab)
                    {
                        ShowFloatingText("BAD");
                    }                    
                    Debug.Log("miss" + "該被打到時間:" + time + "實際打到時間: " +  RightWeapon.Instance.timer );
                }
            }
            if (other.gameObject.CompareTag("Wall"))
            {
                HP.Instance.CountHP(3);
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
                    if (FloatingTextPrefab)
                    {
                        ShowFloatingText("PERFECT");
                    }
                    HP.Instance.CountHP(1);
                    ShockController.Instance.Shock(0.3f, 1);
                    // audiosource.PlayOneShot(impact);
                    Debug.Log("PERFECT" + "該被打到時間:" + time + "實際打到時間: " +  RightWeapon.Instance.timer );
                    Destroy();
                }
                else if ((RightWeapon.Instance.timer >= time - 2 * rangetime && RightWeapon.Instance.timer < time - rangetime) || (RightWeapon.Instance.timer > time - rangetime && RightWeapon.Instance.timer <= time - 2 * rangetime))
                {
                    if (FloatingTextPrefab)
                    {
                        ShowFloatingText("GOOD");
                    }
                    HP.Instance.CountHP(2);
                    ShockController.Instance.Shock(0.1f, 1);
                    // audiosource.PlayOneShot(impact);
                    Debug.Log("GOOD" + "該被打到時間:" + time + "實際打到時間: " +  RightWeapon.Instance.timer );
                    Destroy();
                }
                else
                {
                    if (FloatingTextPrefab)
                    {
                        ShowFloatingText("BAD");
                    }
                     Debug.Log("miss" + "該被打到時間:" + time + "實際打到時間: " +  RightWeapon.Instance.timer );
                }
            }
            if (other.gameObject.CompareTag("Wall"))
            {
                HP.Instance.CountHP(3);
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
                    if (FloatingTextPrefab)
                    {
                        ShowFloatingText("PERFECT");
                    }
                    HP.Instance.CountHP(1);
                    ShockController.Instance.Shock(0.3f, 2);
                    // audiosource.PlayOneShot(impact);
                    Debug.Log("PERFECT" + "該被打到時間:" + time + "實際打到時間: " +  LeftWeapon.Instance.timer );
                    Destroy();
                }
                else if ((LeftWeapon.Instance.timer >= time - 2 * rangetime && LeftWeapon.Instance.timer < time - rangetime) || (RightWeapon.Instance.timer > time - rangetime && RightWeapon.Instance.timer <= time - 2 * rangetime))
                {
                    if (FloatingTextPrefab)
                    {
                        ShowFloatingText("GOOD");
                    }
                    HP.Instance.CountHP(2);
                    ShockController.Instance.Shock(0.1f, 2);
                    // audiosource.PlayOneShot(impact);
                    Debug.Log("GOOD" + "該被打到時間:" + time + "實際打到時間: " +  LeftWeapon.Instance.timer );
                    Destroy();
                }
                else
                {
                    if (FloatingTextPrefab)
                    {
                        ShowFloatingText("BAD");
                    }
                    Debug.Log("MISS" + "該被打到時間:" + time + "實際打到時間: " +  LeftWeapon.Instance.timer );
                }
            }
            if (other.gameObject.CompareTag("Wall"))
            {
                HP.Instance.CountHP(3);
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
                    if (FloatingTextPrefab)
                    {
                        ShowFloatingText("PERFECT");
                    }
                    HP.Instance.CountHP(1);
                    ShockController.Instance.Shock(0.3f, 2);
                    // audiosource.PlayOneShot(impact);
                    Debug.Log("PERFECT" + "該被打到時間:" + time + "實際打到時間: " +  LeftWeapon.Instance.timer );
                    Destroy();
                }
                else if ((LeftWeapon.Instance.timer >= time - 2 * rangetime && LeftWeapon.Instance.timer < time - rangetime) || (RightWeapon.Instance.timer > time - rangetime && RightWeapon.Instance.timer <= time - 2 * rangetime))
                {
                    if (FloatingTextPrefab)
                    {
                        ShowFloatingText("GOOD");
                    }
                    HP.Instance.CountHP(2);
                    ShockController.Instance.Shock(0.1f, 2);
                    // audiosource.PlayOneShot(impact);
                    Debug.Log("GOOD" + "該被打到時間:" + time + "實際打到時間: " +  LeftWeapon.Instance.timer );
                    Destroy();
                }
                else
                {
                    if (FloatingTextPrefab)
                    {
                        ShowFloatingText("BAD");
                    }
                    Debug.Log("MISS" + "PERFECT" + "該被打到時間:" + time + "實際打到時間: " +  LeftWeapon.Instance.timer );
                }
            }
            if (other.gameObject.CompareTag("Wall"))
            {
                HP.Instance.CountHP(3);
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

    void ShowFloatingText(string status)
    {
        // var go = LeanPool.Spawn(FloatingTextPrefab, transform.position, Quaternion.identity, transform);
        // go.GetComponent<TextMesh>().text = status.ToString();
    }

    public void Destroy()
    {
        Instantiate(PerfectParticles, transform.position, Quaternion.identity);
        Instantiate(deathParticles, transform.position, Quaternion.identity);
        Lean.Pool.LeanPool.Despawn(gameObject);
    }
    public enum EnemyType
    {
        YellowType, RedType, BlueType, PurpleType
    }

}
