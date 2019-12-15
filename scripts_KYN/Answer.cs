using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class Answer : MonoBehaviour
{
    public void success()
    {
        changescenes.PreviousScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("Reward");
    }

    public void fail()
    {
        changescenes.PreviousScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("Fail");
    }

    public void addAnswer()
    {
        Lab2.fireAnswer.Push(EventSystem.current.currentSelectedGameObject.name);
        Lab2.fireText += " " + Lab2.fireAnswer.Peek();
        Debug.Log(Lab2.fireAnswer.Peek());
    }

    public void deleteAnswer()
    {
        if (Lab2.fireText.Length == 7) return;
        Lab2.fireAnswer.Pop();
        int deleteIndex = Lab2.fireText.Length - 2;
        Lab2.fireText = Lab2.fireText.Remove(deleteIndex);
    }

    public void checkAnswer()
    {
        bool correct = true;
        int i = Lab2.fireAnswer.Count;
        if (i != 3) correct = false;
        else
        {
            if (!Lab2.fireAnswer.Pop().Equals("1")) correct = false;
            if (!Lab2.fireAnswer.Pop().Equals("3")) correct = false;
            if (!Lab2.fireAnswer.Pop().Equals("2")) correct = false;
        }

        Lab2.fireText = "Answer:";

        if (correct)
        {
            Lab2.noFire = true;
            Lab2.fireFailed = false;
            GameObject.Find("Main Camera").transform.GetChild(2).transform.gameObject.SetActive(true);
            Invoke("extinguishFire", 2f);
        }
        else
        {
            changescenes.PreviousScene = SceneManager.GetActiveScene().name;
            Lab2.fireFailed = true;
            SceneManager.LoadScene("Fail");
        }
    }

    void extinguishFire()
    {
        GameObject.Find("Effect").transform.GetChild(1).transform.gameObject.SetActive(false);
        GameObject.Find("Main Camera").transform.GetChild(1).transform.gameObject.SetActive(false);
        GameObject.Find("Main Camera").transform.GetChild(2).transform.gameObject.SetActive(false);
        GameObject.Find("ProblemSet").transform.GetChild(1).transform.gameObject.SetActive(false);
        GameObject.Find("Status").transform.GetChild(0).transform.gameObject.SetActive(false);
        GameObject.Find("Alert").transform.GetChild(2).transform.gameObject.SetActive(true);
        GameObject.Find("ProblemSet").transform.GetChild(0).transform.gameObject.SetActive(true);

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
