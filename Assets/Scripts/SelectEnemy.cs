using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Pool;
public class SelectEnemy : MonoBehaviour
{
    public EnemyType enemyType;
    public GameObject PurpleEnemy;
    public GameObject BlueEnemy;
    public GameObject YellowEnemy;
    public GameObject RedEnemy;
    // Start is called before the first frame update
    void Start()
    {
        if (enemyType == EnemyType.BlueType)
        {
            GameObject cube = Lean.Pool.LeanPool.Spawn(BlueEnemy, this.transform);
        }
        else if (enemyType == EnemyType.PurpleType)
        {
            GameObject cube = Lean.Pool.LeanPool.Spawn(PurpleEnemy, this.transform);
        }
        else if (enemyType == EnemyType.RedType)
        {
            GameObject cube = Lean.Pool.LeanPool.Spawn(RedEnemy, this.transform);
        }
        else
        {
            GameObject cube = Lean.Pool.LeanPool.Spawn(YellowEnemy, this.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    public enum EnemyType
    {
        PurpleType, YellowType, BlueType, RedType
    }
}
