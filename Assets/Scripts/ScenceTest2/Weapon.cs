using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class Weapon : MonoBehaviour
{
    public static Weapon Instance; //設定全域變數
    public PlayerType playerType;
    public GameObject Sword;

    public GameObject NextSword;

    public GameObject changeSword;

    public AudioClip impact;
    AudioSource audiosource;
    // public Score andy;
    // public Numbers amy;
    // public LayerMask layer;
    // private Vector3 previousPos;
    // Start is called before the first frame update
    void Awake(){
        Instance=this;
    }
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        //左手武器只能攻擊左手屬性敵人
        if (playerType == PlayerType.LeftType)
        {
            if (other.gameObject.CompareTag("LeftEnemy"))
            {
                Destroy(other.gameObject);
            }
        }
        //右手武器只能攻擊右手屬性敵人
        if (playerType == PlayerType.RightType)
        {
            if (other.gameObject.CompareTag("RightEnemy"))
            {
                Destroy(other.gameObject);
            }
        }

        // if (other.name == "Controller (right)" || other.name == "Controller (left)")
        // {
        //     Debug.Log("Change!");
        //     Sword.SetActive(false);
        //     NextSword.SetActive(true);
        //     changeSword = Sword;
        //     Sword = NextSword;
        //     NextSword = changeSword;
        // }
    }
    // Update is called once per frame
  public void SwitchEvent(bool n){
if(n==true){
     Debug.Log("switch");
     Sword.SetActive(false);
            NextSword.SetActive(true);
            changeSword = Sword;
            Sword = NextSword;
            NextSword = changeSword;
            n=true;
            // audiosource.PlayOneShot(impact);
}
  }
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.A))
        // {
        //     Sword.SetActive(false);
        //     NextSword.SetActive(true);
        //     changeSword = Sword;
        //     Sword = NextSword;
        //     NextSword = changeSword;
        //     audiosource.PlayOneShot(impact);
        // }
        // RaycastHit hit;
        // if (Physics.Raycast(transform.position, transform.forward, out hit, 1, layer))
        // {
        //     if (Vector3.Angle(transform.position - previousPos, hit.transform.up) > 0)
        //     {
        //         audiosource.PlayOneShot(impact);
        //         Debug.Log("music");
        //         Lean.Pool.LeanPool.Despawn(hit.transform.gameObject);
        //         // andy.distroyCube();
        //         // amy.distroyCube();
        //     }
        // }
        // previousPos = transform.position;        
    }
    public enum PlayerType
    {
        LeftType, RightType
    }
}
