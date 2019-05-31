using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public void ChangeGameScene()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void NewStart()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void EndingScene_Exit()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void EndingScene_Ranking_Registration()
    {
        SceneManager.LoadScene("RankingRegistrationScene");
    }

    public void RankingRegistrationScene_Exit()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void RankingRegistrationScene_Registration()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void RankingScene()
    {
        SceneManager.LoadScene("RankingScene");
    }
}
