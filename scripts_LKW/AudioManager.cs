using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioManager : MonoBehaviour
{
    public static AudioSource bgmSource;
    public AudioSource bgm;

    void Awake()
    {

        if (bgmSource != null)
        {
            bgmSource.Stop();
        }
    }
 

        // Start is called before the first frame update
    void Start()
    {
       // bgmSource.Stop();
        DontDestroyOnLoad(transform.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        bgmSource = bgm;
    }
}
