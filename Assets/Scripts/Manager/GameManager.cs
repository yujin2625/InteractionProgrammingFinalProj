using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
public partial class GameManager : MonoBehaviour
{
    public GameObject StoryManager;
    public GameObject GameClear;
    public AudioSource SoundEffect, BackgroundMusic;
    

    public Slider PuzzleGage, CureGage;
    private void Awake()
    {
        SoundEffect = GameObject.Find("Sound Effect").GetComponent<AudioSource>();
        BackgroundMusic = GameObject.Find("Background Music").GetComponent<AudioSource>();
        BackgroundMusic.Play();
        DontDestroyOnLoad(gameObject);
    }
    public void PuzzleClear()
    {
        GameClear = GameObject.Find("GameClear");
        GameClear.SetActive(true);
    }
    public void SetAudioSource(AudioSource _audioSource, AudioClip _audioClip)
    {
        _audioSource.clip = _audioClip;
    }
    public void PlayAudio(AudioSource _audioSource)
    {
        _audioSource.Play();
    }
    public void PlaySoundEffect(AudioClip _audioClip)
    {
        SoundEffect.clip = _audioClip;
        SoundEffect.Play();
    }
    public void PlayBackgroundMusic(AudioClip _audioClip)
    {
        BackgroundMusic.clip = _audioClip;
        BackgroundMusic.Play();
    }
    

}
