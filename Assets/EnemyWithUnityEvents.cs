using UnityEngine;
using UnityEngine.Events; //UnityEvent vaatii

public class EnemyWithUnityEvents : MonoBehaviour
{
    public UnityEvent OnEnemyKilled; // eventit määritellään inspectorissa

    private void OnMouseDown()
    {      
        OnEnemyKilled?.Invoke(); // ? = null check 
    }

   

}
