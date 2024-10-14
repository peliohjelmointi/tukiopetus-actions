using UnityEngine;
using UnityEngine.Events; //UnityEvent vaatii

public class EnemyWithUnityEvents : MonoBehaviour
{
    public UnityEvent OnEnemyKilled; // eventit m‰‰ritell‰‰n inspectorissa

    private void OnMouseDown()
    {      
        OnEnemyKilled?.Invoke(); // ? = null check 
    }

   

}
