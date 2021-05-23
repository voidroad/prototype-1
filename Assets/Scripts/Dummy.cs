using UnityEngine;

public class Dummy : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 10.0f);
    }
    
    public int Add(int a, int b) {
	    return a + b;   
    }
}
