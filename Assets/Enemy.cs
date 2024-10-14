using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnMouseDown() //Kun hiiren vasemmalla napilla klikataan objektia //HUOM. Collider t‰ytyy olla p‰‰ll‰, jotta toimii
    {      
        Actions.OnEnemyHit(5);  // Actions-luokka on staattinen (ja public) , joten siihen p‰‰st‰‰n k‰siksi suoraan luokan nimell‰.
                                // OnEnemyHit on myˆs public static
    }
}
