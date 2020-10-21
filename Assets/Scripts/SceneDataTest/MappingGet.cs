using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class MappingGet : MonoBehaviour
{
    public TextAsset mapping;
    Music data;
    // Start is called before the first frame update
    void Start()
    {
        data = JsonUtility.FromJson<Music>(mapping.text);
        Debug.Log(data._events[0]._time);
    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.L))
        {
            data._events[0]._time += 1;
            string path = Application.persistentDataPath + "/data.json";
            FileStream fs = new FileStream(path, FileMode.Create);
            string fileContext = JsonUtility.ToJson(data);
            StreamWriter file = new StreamWriter(fs);
            file.Write(fileContext);
            file.Close();
        }
    }

    // Update is called once per frame
}
[System.Serializable]
public class Events
{
    public double _time;
    public int _type;
    public int _value;
}

[System.Serializable]
public class Music
{
    public Events[] _events;
}