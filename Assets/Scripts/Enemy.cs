using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // [Header("Unity Setup")]
    public ParticleSystem deathParticles;
    public EnemyType enemyType;
    void OnTriggerEnter(Collider other)
    {   
        if(enemyType==EnemyType.BlueType){
          if (other.gameObject.CompareTag("BlueWeapon"))
           {            
                HP.Instance.CountHP(1);
                ShockController.Instance.Shock(0.3f,1);
                Destroy();
           }
          if (other.gameObject.CompareTag("Wall"))
           {            
            HP.Instance.CountHP(2);
            Destroy(gameObject);
           }
        }

        if(enemyType==EnemyType.PurpleType){
        if (other.gameObject.CompareTag("PurpleWeapon"))
        {      
            HP.Instance.CountHP(1);
                ShockController.Instance.Shock(0.3f,1);      
            Destroy();
        }
        if (other.gameObject.CompareTag("Wall"))
        {          
            HP.Instance.CountHP(2);  
            Destroy(gameObject);
        }
        }

        if(enemyType==EnemyType.RedType){
        if (other.gameObject.CompareTag("RedWeapon"))
        {   Debug.Log("洪");
            HP.Instance.CountHP(1);
            ShockController.Instance.Shock(0.3f,2);        
            Destroy();
        }
        if (other.gameObject.CompareTag("Wall"))
        {     
            HP.Instance.CountHP(2);       
            Destroy(gameObject);
        }
        }
        
         if(enemyType==EnemyType.YellowType){
        if (other.gameObject.CompareTag("YellowWeapon"))
        {      HP.Instance.CountHP(1);
                ShockController.Instance.Shock(0.3f,2);      
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
        YellowType,RedType,BlueType,PurpleType
    }

}
