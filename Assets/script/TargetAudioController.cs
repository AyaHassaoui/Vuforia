using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class TargetAudioController : MonoBehaviour
{
    public AudioSource descriptiveVoice;
    public AudioSource carSound;

    private ObserverBehaviour observer;

    void Awake()
    {
        // On récupère l'ObserverBehaviour sur le même ImageTarget
        observer = GetComponent<ObserverBehaviour>();

        if (observer != null)
        {
            // On s'abonne au changement de statut de la cible
            observer.OnTargetStatusChanged += OnTargetStatusChanged;
        }
    }

    void OnDestroy()
    {
        // On se désabonne proprement
        if (observer != null)
        {
            observer.OnTargetStatusChanged -= OnTargetStatusChanged;
        }
    }

    // Appelé à chaque changement de statut (cible trouvée / perdue)
    void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus status)
    {
        var s = status.Status;

        bool isTracked =
            s == Status.TRACKED ||
            s == Status.EXTENDED_TRACKED ||
            s == Status.LIMITED;

        if (isTracked)
        {
            PlaySounds();
        }
        else
        {
            StopSounds();
        }
    }

    void PlaySounds()
    {
        if (descriptiveVoice != null && !descriptiveVoice.isPlaying)
            descriptiveVoice.Play();

        if (carSound != null && !carSound.isPlaying)
            carSound.Play();
    }

    void StopSounds()
    {
        if (descriptiveVoice != null && descriptiveVoice.isPlaying)
            descriptiveVoice.Stop();

        if (carSound != null && carSound.isPlaying)
            carSound.Stop();
    }
}

