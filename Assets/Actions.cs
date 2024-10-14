using System; //täältä löytyy Action (sis. rakennettu C#)

public static class Actions //Huom. Ei peritä MonoBehavioria, vaan luodaan staattinen luokka, johon päästään käsiksi mistä tahansa koodista suoraan luokan nimellä.
                            // Staattisista luokista ei pysty tekemään olioita, vaan static-sana kertoo, että luokasta on olemassa vain yksi instanssi.
{        
    public static Action<int> OnEnemyHit;   // OnEnemyHit on aluksi tyhjä Action, johon voidaan liittää (ja myöhemmin poistaa) funktioita, jotka ajetaan kun Action triggeröidään (invokataan)
                                            // <int> voisi olla myös luokan nimi, esim. Enemy
}


