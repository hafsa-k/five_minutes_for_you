using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance;

    [Header("Audio Mixer")]
    [SerializeField] private AudioMixer myMixer;

    [Header("Audio Source")]
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioClip backgroundMusic;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
            musicSource.clip = backgroundMusic;
            musicSource.loop = true;
            musicSource.Play();
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Méthode pour régler le volume de la musique
    public void SetMusicVolume(float volume)
    {
        myMixer.SetFloat("music", Mathf.Log10(volume) * 20);
    }
}
