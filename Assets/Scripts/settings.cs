using UnityEngine;
using UnityEngine.Audio;

public class settings : MonoBehaviour
{
    public AudioMixer mixer;

    [Tooltip("will change overall audio input including music and SFX")]
    public void mastervolume(float volume)
    {
        mixer.SetFloat("master", volume);
    }
    public void musicvolume(float volume)
    {
        mixer.SetFloat("music", volume);
    }
    public void SFXvolume(float volume)
    {
        mixer.SetFloat("SFX", volume);
    }
}
