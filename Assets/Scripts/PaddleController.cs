using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    // Start is called before the first frame update
    public float kecepatan;
	public string axis;
	public float batasAtas;
	public float batasBawah;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float gerak = Input.GetAxis(axis) * kecepatan * Time.deltaTime;
		/*transform.Translate(0, gerak, 0);*/
		float nextPos = transform.position.y + gerak;
		if (nextPos > batasAtas ) {
		    gerak = 0;
		}
		if (nextPos < batasBawah) {
		    gerak = 0;
		}
		transform.Translate(0, gerak, 0);
    }
}
