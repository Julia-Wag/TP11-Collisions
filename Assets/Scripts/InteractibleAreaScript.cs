using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractibleAreaScript : MonoBehaviour
{
    public ScoreUIManager scoreUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Picable"))
        {
            Destroy(col.gameObject);
            scoreUI.AddPointAndUpdateScore();
        }
    }
}
