using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class UIController : MonoBehaviour
{
    public AudioSource SoundEffect, BackgroundMusic;
    public void OnClickStart()
    {
        DontDestroyOnLoad(SoundEffect);
        DontDestroyOnLoad(BackgroundMusic);
        SceneManager.LoadScene("GameSceneDay2");
    }
    public void SetAudioSource(AudioClip _audioClip)
    {
        SoundEffect.clip = _audioClip;
        SoundEffect.Play();
    }
    public void PlayAudio()
    {
        SoundEffect.Play();
    }
    public void SetBackgroundMusicSource(AudioClip _audioClip)
    {
        BackgroundMusic.clip = _audioClip;
    }
}
