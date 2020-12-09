using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
        public void changeScene(string sceneName){
        Application.LoadLevel(sceneName);
        Debug.Log("ChangeScene");
        //重新設定遊玩
        CheckUserInput.Instance.ResumeGame();
    }    
}
