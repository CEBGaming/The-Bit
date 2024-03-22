using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class VideoFin : MonoBehaviour
{
    public VideoPlayer video;
    public float Finsihed;
    public float Len;

    // Start is called before the first frame update
    void Start()
    {
        video.loopPointReached += EndReached;
    }

    // Update is called once per frame
    void Update()
    {
    

    }

    void EndReached(UnityEngine.Video.VideoPlayer vp)
    {
        SceneManager.LoadScene("Exit");
    }

}
