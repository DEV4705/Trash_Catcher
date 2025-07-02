using UnityEngine;

public class GameSoundController : MonoBehaviour
{
    public AudioSource music;
    public AudioSource sfx;

    public AudioClip background;
    public AudioClip dash;

    private void Start()
    {
        music.clip = background;
        music.loop = true;
        music.Play();
    }

    public void playSfx(AudioClip sfxClip)
    {
        sfx.PlayOneShot(sfxClip);
    }
}
