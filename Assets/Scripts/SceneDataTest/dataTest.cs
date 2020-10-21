using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;



public class dataTest : MonoBehaviour
{
    [SerializeField]
    Text ui_text;
    [SerializeField]
    PlayerData data;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            FileStream fs = new FileStream(Application.dataPath + "/Save.txt", FileMode.Create);
            // StreamWriter sw = new StreamWriter(fs);
            // sw.WriteLine(data.name);
            // sw.WriteLine(data.level);
            // sw.Close();
            // fs.Close();
            PlayerPrefs.SetString("jsondata", JsonUtility.ToJson(data));
            ui_text.text = "儲存完成";
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            // FileStream fs = new FileStream(Application.dataPath + "/Save.txt", FileMode.Open);
            // StreamReader sr = new StreamReader(fs);
            // data.name = sr.ReadLine();
            // data.level =int.Parse(sr)
            data = JsonUtility.FromJson<PlayerData>(PlayerPrefs.GetString("json"));
        }
    }

    [System.Serializable]
    public class PlayerData
    {
        public string name;
        public int level;
    }
}
