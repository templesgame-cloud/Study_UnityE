using UnityEngine;

public class Study : MonoBehaviour
{
    public string Say = "";
    public char text = 'A';
    public int var01 = 1;
    public float var02 = 0.4f;
    public double var03 = 0.5;
    public bool var04 = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(this.Say);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

