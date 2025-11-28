using System.Collections;
using UnityEngine;




public class Testso : MonoBehaviour
{
    private void Awake() {
        StartCoroutine(timer(5));
    }

    private void Update()
    {
        
    }
    private void FixedUpdate() {
        
    }

    private IEnumerator timer(int x)
    {
        for (int i = 0; i < x; i++)
        {
            Debug.Log(i);
            yield return new WaitForSeconds(1);
        }
    }
}
