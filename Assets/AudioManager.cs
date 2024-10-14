using UnityEngine;

public class AudioManager : MonoBehaviour 
{
    private void OnEnable()
    {
        Actions.OnEnemyHit += PlayHitSound;  //lis‰t‰‰n PlayHitSound-funktio OnEnemyHit-actioniin
    }

    private void OnDisable()
    {
        Actions.OnEnemyHit -= PlayHitSound;
    }


    public void PlayHitSound(int soundIndex)
    {
        //Simuloidaan audiomanagerin toimimista, t‰ss‰ soitettaisiin ouch.mp3
        Debug.Log($"OUCH! (mp3 playing from soundIndex {soundIndex}");
    }
}
