using UnityEngine;

public class MusicTrigger : MonoBehaviour
{
    [SerializeField] int musicToPlay;

    void Start()
    {
        AudioManager.instance.PlayMusic(musicToPlay); 
    }
}
