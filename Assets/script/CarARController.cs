using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class CarARController : MonoBehaviour
{
    [Header("Audio Sources")]
    public AudioSource descriptiveVoice; // main narration
    public AudioSource carSound;         // engine/background sound

    [Header("Rotation")]
    public float rotationSpeed = 10f; // degrees per second

    [Header("Audio Settings")]
    [Range(0f, 1f)]
    public float carSoundVolume = 0.3f; // quieter than descriptive voice

    private ObserverBehaviour observer;

    void Awake()
    {
        // Get the ObserverBehaviour from the ImageTarget
        observer = GetComponent<ObserverBehaviour>();
        if (observer != null)
            observer.OnTargetStatusChanged += OnTargetStatusChanged;

        // Set engine sound volume low
        if (carSound != null)
            carSound.volume = carSoundVolume;
    }

    void OnDestroy()
    {
        if (observer != null)
            observer.OnTargetStatusChanged -= OnTargetStatusChanged;
    }

    void Update()
    {
        // Rotate the car slowly
        transform.Rotate(Vector3.up * rotationSpeed * Time.deltaTime);
    }

    private void OnTargetStatusChanged(ObserverBehaviour behaviour, TargetStatus status)
    {
        bool isTracked =
            status.Status == Status.TRACKED ||
            status.Status == Status.EXTENDED_TRACKED ||
            status.Status == Status.LIMITED;

        if (isTracked)
            PlaySounds();
        else
            StopSounds();
    }

    private void PlaySounds()
    {
        if (descriptiveVoice != null && !descriptiveVoice.isPlaying)
            descriptiveVoice.Play();

        if (carSound != null && !carSound.isPlaying)
            carSound.Play();
    }

    private void StopSounds()
    {
        if (descriptiveVoice != null && descriptiveVoice.isPlaying)
            descriptiveVoice.Stop();

        if (carSound != null && carSound.isPlaying)
            carSound.Stop();
    }
}