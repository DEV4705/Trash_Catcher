using UnityEngine;

public class MainMenuSoundController : MonoBehaviour
{
    public AudioSource music;
    public AudioSource sfx;

    public AudioClip background;

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
