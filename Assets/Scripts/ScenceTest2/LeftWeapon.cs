﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class LeftWeapon : MonoBehaviour
{
    public static LeftWeapon Instance; //設定全域變數
     public Vector3 PrePosition;
    public PlayerType playerType;
    public GameObject SwordHeadL;
    public GameObject Sword;
    public GameObject NextSword;
    public GameObject changeSword;
int ChangeCountL=0;
float timer = 0;
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
        //左手武器只能攻擊左手屬性敵人
        if (playerType == PlayerType.LeftType)
        {
            if (other.gameObject.CompareTag("LeftEnemy"))
            {if(ChangeCountL%2==0){
                if(SwordHeadL.transform.position.z>=other.gameObject.transform.position.z){ Destroy(other.gameObject);}
            }else{
                Destroy(other.gameObject);
            }
               
            }
        }
       
    }
    // Update is called once per frame
    public void SwitchLeftEvent(bool n)
    {
        if (n == true)
        {
            ChangeCountL++;
        if(ChangeCountL%2==1){
            SwordHeadL.SetActive(false);
        }else{
             SwordHeadL.SetActive(true);
        } 
            Debug.Log("switch");
            Sword.SetActive(false);
            NextSword.SetActive(true);
            changeSword = Sword;
            Sword = NextSword;
            NextSword = changeSword;
            n = true;
            Debug.Log(ChangeCountL);
            // audiosource.PlayOneShot(impact);
        }

    }
    public void SwitchRightEvent(bool n)
    {
        if (playerType == PlayerType.RightType)
        {
            Debug.Log("switch");
            if (n == true)
            {
                     
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
                timer = timer + Time.deltaTime;
        if(timer>=2f){
             ChangePosition();             
            timer=0f;           
        } 
    }
    public void ChangePosition(){
        PrePosition=SwordHeadL.transform.position;
        Debug.Log(PrePosition);
    }
    public enum PlayerType
    {
        LeftType, RightType
    }
}
