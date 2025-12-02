using UnityEngine;
using UnityEngine.Audio;

public class settings : MonoBehaviour
{
    public AudioMixer mixer;

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
