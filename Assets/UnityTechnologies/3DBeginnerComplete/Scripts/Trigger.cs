using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{

    [SerializeField] UnityEvent onTriggerEnter;
    [SerializeField] UnityEvent onTriggerExit;
    public AudioClip soundEffect;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.clip = soundEffect;
    }
    void OnTriggerEnter(Collider other)
    {
        onTriggerEnter.Invoke();

        PlaySoundEffect();
    }

    void OnTriggerExit(Collider other)
    {
        onTriggerExit.Invoke();
    }

    void PlaySoundEffect()
    {
        if(soundEffect != null && audioSource != null){
            audioSource.PlayOneShot(soundEffect);
        }
    }
}
