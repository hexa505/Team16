using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBGM2 : MonoBehaviour
{

    public AudioSource bgm;
    public static int countt = 0;



    // Start is called before the first frame update
    void Start()
    {
        if (countt > 0)
        {
            bgm.Stop();
            bgm = AudioManager.bgmSource;
            bgm.Play();
            countt++;
            AudioManager.bgmSource = bgm;
        }
        else {
            countt++;
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