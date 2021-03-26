
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
//要存储为json的对象
[Serializable]
public class DayRangeMessage
{
    public int Score;//玩家最終血量
    // public string date_time;//存储当天的日期
    // public List<int> rangelist; //一天之内每次运行程序生成的随机数列表
}

public class TestJson : MonoBehaviour
{
    public static TestJson Instance;
    string JsonPath; //json文件的路径
    DayRangeMessage dayrangeMessage;//要存起来的对象
    DayRangeMessage dayrangeMessagetemp;//要读取出来的对象
    public int score;


    void Awake()
    {
        JsonPath = Application.streamingAssetsPath + "/JsonTest.json";
        InitJsonData();
        Instance = this;
        Debug.Log(123);
    }
    void Start()
    {
        //     JsonPath = Application.streamingAssetsPath + "/JsonTest.json";
        //     InitJsonData();
    }
    //json 数据初始化
    void InitJsonData()
    {
        //生成一个DayRangeMessage对象
        dayrangeMessage = new DayRangeMessage();
        dayrangeMessage.Score = 0;
        //给DayRangeMessage对象的第一个属性date_time赋值
        // dayrangeMessage.date_time = "2019年8月14号";
        //给DayRangeMessage对象的第二个属性rangelist赋值
        //第二个个属性里添加有三个子元素
        // dayrangeMessage.rangelist = new List<int>();
        // dayrangeMessage.rangelist.Add(10);
        // dayrangeMessage.rangelist.Add(22);
        // dayrangeMessage.rangelist.Add(33);
    }
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        //  dayrangeMessage.Score = HP.Instance.hpCount;
        //   Debug.Log("hpCount:"+ dayrangeMessage.Score);
    }
    //把上面初始化的数据进行保存
    public void SaveJson()
    {
        dayrangeMessage.Score = HP.Instance.hpCount;
        //如果本地没有对应的json 文件，重新创建
        if (!File.Exists(JsonPath))
        {
            File.Create(JsonPath);
        }
        string json = JsonUtility.ToJson(dayrangeMessage, true);
        File.WriteAllText(JsonPath, json);
        Debug.Log("保存成功");


    }
    //从本地读取json数据
    public void ReadJson()
    {
        if (!File.Exists(JsonPath))
        {
            Debug.LogError("读取的文件不存在！");
            return;
        }
        Debug.Log("readjson跑了");
        string json = File.ReadAllText(JsonPath);
        dayrangeMessagetemp = JsonUtility.FromJson<DayRangeMessage>(json);
        score = dayrangeMessagetemp.Score;
        Debug.LogError(score);
        //读取第一个属性:日期
        // string date = dayrangeMessagetemp.date_time;
        // Debug.LogError(date);
        //获取第二个属性：
        // for (int j = 0; j < dayrangeMessagetemp.rangelist.Count; j++)
        // {
        //     Debug.Log(dayrangeMessagetemp.rangelist[j]);
        // }
    }
}
