using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBGM : MonoBehaviour
{
  
    public AudioSource bgm;
    public static int count = 0;

 

    // Start is called before the first frame update
    void Start()
    {
        if (count > 0)
        {
            bgm.Stop();
            bgm = AudioManager.bgmSource;
            bgm.Play();
            count++;
            AudioManager.bgmSource = bgm;
        }
        else {
            count++;
            GameObject.Destroy(GameObject.Find("BGM"));
            DontDestroyOnLoad(transform.gameObject);
            AudioManager.bgmSource = bgm;
        }
    }

    // Update is called once per frame
    void Update()
    {
 
    }
}