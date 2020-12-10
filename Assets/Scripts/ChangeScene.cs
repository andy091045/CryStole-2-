using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeScene : MonoBehaviour
{
    public Image fadeImage;
    public void changeScene(string sceneName)
    {
        StartCoroutine(Change(sceneName));

    }

    IEnumerator Change(string sceneName)
    {
        while (fadeImage.color.a < 1)
        {
            //一開始是0
            float myAlpha = fadeImage.color.a + 0.01f;
            //R					//G					//B			  //Alpha
            fadeImage.color = new Color(fadeImage.color.r, fadeImage.color.g, fadeImage.color.b, myAlpha);

            yield return new WaitForSeconds(0.01f);

        }
        Application.LoadLevel(sceneName);
        Debug.Log("ChangeScene");
        //重新設定遊玩
        CheckUserInput.Instance.ResumeGame();
    }
}
