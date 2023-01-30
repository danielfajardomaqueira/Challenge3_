using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private int moneyCoin = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moneyCoin >= 30)
        {
            Debug.Log("GAME OVER");
            Time.timeScale = 0;
        }
    }

    private void OnTriggerEter(Collider other)
    {
        if (other.gameObject.name.Contains("Money"))
        {
            moneyCoin++;

            Debug.Log($"You Win");
        }
    }
}
