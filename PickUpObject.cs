using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpObject : MonoBehaviour
{
    GameObject Dedos;
    bool carrying;
    GameObject carriedObject;
    public float distancia;
    // Start is called before the first frame update
    void Start()
    {
        Dedos = GameObject.FindWithTag("Mano");
    }

    // Update is called once per frame
    void Update()
    {
        if(carrying){
            carry(carriedObject);
            checkDrop();
        }else{
            pickup();
        }
    }

    void carry(GameObject o){
        o.GetComponent<Rigidbody>().isKinematic = true;
        o.transform.position = Dedos.transform.position + Dedos.transform.forward * distancia;
    }

    void pickup(){
        if(Input.GetKeyDown(KeyCode.N)){
            int x = (int)Dedos.transform.position.x;
            int y = (int)Dedos.transform.position.y;

            Ray ray = Dedos.GetComponent<Camera>().ScreenPointToRay(new Vector3(x, y));
            RaycastHit hit;
            if(Physics.Raycast(ray,out hit)){
                pickupable p = hit.collider.GetComponent<pickupable>();
                    if(p != null){
                        carrying = true;
                        carriedObject = p.gameObject;
                        p.gameObject.GetComponent<Rigidbody>().useGravity = false;
                    }
            }
        }
    }

    	void checkDrop() {
		if(Input.GetKeyDown (KeyCode.N)) {
			dropObject();
		}
	}

	void dropObject() {
		carrying = false;
		carriedObject.gameObject.GetComponent<Rigidbody>().useGravity = true;
		carriedObject = null;
	}
}