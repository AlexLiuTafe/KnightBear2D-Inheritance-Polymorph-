﻿using UnityEngine.Audio;
using UnityEngine;

[System.Serializable]
public class EnemySound 
{
    public string name;

    public AudioClip clip;
    [Range(0f,1f)]
    public float volume;
    [Range(.1f,2f)]
    public float pitch;

    [HideInInspector]
    public AudioSource source;
}
