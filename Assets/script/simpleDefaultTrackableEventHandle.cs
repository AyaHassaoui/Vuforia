using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SimpleObserverAudioHandler : MonoBehaviour
{
    public AudioSource descriptiveVoice;
    public AudioSource carSound;

    ObserverBehaviour observer;

    void Awake()
    {
        observer = GetComponent<ObserverBehaviour>();
        if (observer != null)
            observer.OnTargetStatusChanged += OnTargetStatusChanged;
    }

    void OnDestroy()
    {
        if (observer != null)
            observer.OnTargetStatusChanged -= OnTargetStatusChanged;
    }

    void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus status)
    {
        var s = status.Status;

        bool isTracked =
            s == Status.TRACKED ||
            s == Status.EXTENDED_TRACKED ||
            s == Status.LIMITED;

        if (isTracked)
        {
            if (descriptiveVoice != null && !descriptiveVoice.isPlaying)
                descriptiveVoice.Play();
            if (carSound != null && !carSound.isPlaying)
                carSound.Play();
        }
        else
        {
            if (descriptiveVoice != null && descriptiveVoice.isPlaying)
                descriptiveVoice.Stop();
            if (carSound != null && carSound.isPlaying)
                carSound.Stop();
        }
    }
}
