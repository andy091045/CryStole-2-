using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class RightWeapon : MonoBehaviour
{
    public static RightWeapon Instance; //設定全域變數
    public Vector3 PrePosition;
    public PlayerType playerType;
    public GameObject SwordHead;
    public GameObject Sword;
    public GameObject NextSword;
    public GameObject changeSword;
    int ChangeCount = 0;
    float timer = 0;
    bool switchWeapon = true; //true左手為紅色右手藍色，false左手為黃色右手為紫色
    public AudioClip impact;
    AudioSource audiosource;
    // public Score andy;
    // public Numbers amy;
    // public LayerMask layer;
    // private Vector3 previousPos;
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
    }
    void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        //右手武器只能攻擊右手屬性敵人
        if (playerType == PlayerType.RightType)
        {
            // if (other.gameObject.CompareTag("RightEnemy"))
            // {
            //         if(ChangeCount%2==0){
            //         if((SwordHead.transform.position.x-PrePosition.x)<2&&(SwordHead.transform.position.y-PrePosition.y)<2){Destroy(other.gameObject);}
            //     }else{
            //         Destroy(other.gameObject);
            //     }                 
            // }
            if (other.gameObject.CompareTag("blueEnemy"))
            {
                if (switchWeapon) { Destroy(other.gameObject); }
            }
            if (other.gameObject.CompareTag("purpleEnemy"))
            {
                if (!switchWeapon) { Destroy(other.gameObject); }
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

    public void SwitchRightEvent(bool n)
    {
        if (playerType == PlayerType.RightType)
        {
            if (n == true)
            {
                // ChangeCount++;
                // if (ChangeCount % 2 == 1)
                // {
                //     SwordHead.SetActive(false);
                // }
                // else
                // {
                //     SwordHead.SetActive(true);
                // }
                switchWeapon = !switchWeapon;
                Sword.SetActive(false);
                NextSword.SetActive(true);
                changeSword = Sword;
                Sword = NextSword;
                NextSword = changeSword;
                n = true;
                // audiosource.PlayOneShot(impact);
            }
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
        //         timer = timer + Time.deltaTime;
        // if(timer>=2f){
        //      ChangePosition();             
        //     timer=0f;           
        // }    
    }
<<<<<<< HEAD
    public void ChangePosition()
    {
        PrePosition = SwordHead.transform.position;
        Debug.Log(PrePosition);
=======
       public void ChangePosition(){
        PrePosition=SwordHead.transform.position;        
>>>>>>> e01051fd0160585034e27e35293f8950bcd03210
    }
    public enum PlayerType
    {
        LeftType, RightType
    }
}
