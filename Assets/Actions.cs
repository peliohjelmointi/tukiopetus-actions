using System; //t��lt� l�ytyy Action (sis. rakennettu C#)

public static class Actions //Huom. Ei perit� MonoBehavioria, vaan luodaan staattinen luokka, johon p��st��n k�siksi mist� tahansa koodista suoraan luokan nimell�.
                            // Staattisista luokista ei pysty tekem��n olioita, vaan static-sana kertoo, ett� luokasta on olemassa vain yksi instanssi.
{        
    public static Action<int> OnEnemyHit;   // OnEnemyHit on aluksi tyhj� Action, johon voidaan liitt�� (ja my�hemmin poistaa) funktioita, jotka ajetaan kun Action trigger�id��n (invokataan)
                                            // <int> voisi olla my�s luokan nimi, esim. Enemy
}


