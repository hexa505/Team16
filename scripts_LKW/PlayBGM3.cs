using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayBGM3 : MonoBehaviour
{

    public AudioSource bgm;
    public static int counttt = 0;



    // Start is called before the first frame update
    void Start()
    {
        if (counttt > 0)
        {
            GameObject.Destroy(GameObject.Find("BGMPlay"));
            counttt++;
            AudioManager.bgmSource = bgm;
        }
        else {
            bgm.Stop();
            
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}